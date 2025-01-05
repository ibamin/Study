use aes_gcm::aead::generic_array::GenericArray;
use aes_gcm::Aes256Gcm;
use aes_gcm::aead::{Aead, KeyInit, OsRng};
use aes_gcm::aead::rand_core::RngCore;
use std::env;
use std::fs;
use hex;
use chrono::Utc;
use std::io::{self, Write};

fn get_content(file_path: &str) -> Result<Vec<u8>, io::Error> {
    fs::read(file_path) // 바이너리 데이터를 Vec<u8>로 읽음
}

fn folder_check(folder_path: &str) -> Result<Vec<String>, io::Error> {
    let mut file_list = Vec::new();

    for entry in fs::read_dir(folder_path)? {
        let entry = entry?;
        let path = entry.path();

        if path.is_dir() {
            let sub_files = folder_check(path.to_str().unwrap())?;
            file_list.extend(sub_files);
        } else {
            file_list.push(path.display().to_string());
        }
    }

    Ok(file_list)
}

pub fn encrypt(path: String) -> Result<(), io::Error> {
    let mut key_bytes = [0u8; 32];
    OsRng.fill_bytes(&mut key_bytes);
    let key = GenericArray::clone_from_slice(&key_bytes);

    let cipher = Aes256Gcm::new(&key);

    let mut nonce_bytes = [0u8; 12];

    let file_list = folder_check(&path)?;

    for file_path in file_list {
        let file_content = get_content(&file_path)?; // 바이너리 데이터를 읽음

        // 파일마다 새로운 Nonce 생성
        OsRng.fill_bytes(&mut nonce_bytes);
        let nonce = GenericArray::clone_from_slice(&nonce_bytes);

        // 파일 내용 암호화
        let encrypted_data = cipher.encrypt(&nonce, file_content.as_slice()) // 슬라이스로 변환
            .expect("Encryption failed");

        // 암호화된 데이터 저장 (기존 파일 덮어쓰기)
        let mut encrypted_file = fs::File::create(&file_path)?; // 같은 파일 이름 사용
        encrypted_file.write_all(nonce.as_slice())?; // Nonce를 파일 맨 앞에 저장
        encrypted_file.write_all(&encrypted_data)?; // 암호화된 데이터 저장
    }

    // Readme.txt에 암호화 정보를 저장
    let user_profile = env::var("userprofile").map_err(|e| {
        io::Error::new(io::ErrorKind::NotFound, format!("Failed to read userprofile: {}", e))
    })?;
    let readme_path = format!("{}\\Desktop\\Readme.txt", user_profile);

    let mut file = fs::File::create(&readme_path)?;
    let encryption_info = format!(
        "Encryption Information:\n\
         Algorithm: AES-256-GCM\n\
         Key: {}\n\
         Date: {}\n",
        hex::encode(&key_bytes),       // 키를 16진수 문자열로 저장
        Utc::now().to_rfc3339()        // 현재 UTC 시간을 ISO 8601 형식으로 저장
    );
    file.write_all(encryption_info.as_bytes())?;

    Ok(())
}

pub fn decryption(path: String, key: Option<String>) -> Result<(), io::Error> {
    // 사용자 프로필 경로에서 Readme.txt의 위치 결정
    let user_profile = env::var("userprofile").map_err(|e| {
        io::Error::new(io::ErrorKind::NotFound, format!("Failed to read userprofile: {}", e))
    })?;
    let readme_path = format!("{}\\Desktop\\Readme.txt", user_profile);

    // 키 읽기: 옵션으로 제공된 키 사용, 없으면 Readme.txt에서 읽기
    let key = if let Some(k) = key {
        k // 사용자 제공 키
    } else {
        // Readme.txt에서 키 읽기
        let key_from_file = get_content(&readme_path)?;
        let key_lines = String::from_utf8_lossy(&key_from_file);
        key_lines
            .lines()
            .find(|line| line.starts_with("Key: ")) // "Key: "로 시작하는 줄 찾기
            .ok_or_else(|| io::Error::new(io::ErrorKind::InvalidData, "Key not found in file"))?
            .trim_start_matches("Key: ") // "Key: " 제거
            .to_string()
    };

    // 키 디코딩
    let decoded_key = hex::decode(&key).map_err(|e| {
        io::Error::new(io::ErrorKind::InvalidInput, format!("Failed to decode key: {}", e))
    })?;
    if decoded_key.len() != 32 {
        return Err(io::Error::new(io::ErrorKind::InvalidInput, "Invalid key length"));
    }
    let key = GenericArray::clone_from_slice(&decoded_key); // GenericArray로 변환

    // AES-GCM 복호화 객체 초기화
    let cipher = Aes256Gcm::new(&key);

    // 폴더 내 파일 목록 가져오기
    let file_list = folder_check(&path)?;

    // 각 파일 복호화
    for file_path in file_list {
        let encrypted_content = get_content(&file_path)?; // 바이너리 데이터를 읽음

        // Nonce 추출
        if encrypted_content.len() < 12 {
            return Err(io::Error::new(io::ErrorKind::InvalidData, "Invalid encrypted file format"));
        }
        let nonce = GenericArray::from_slice(&encrypted_content[..12]); // 첫 12바이트는 Nonce
        let encrypted_data = &encrypted_content[12..]; // 나머지는 암호화된 데이터

        // 파일 내용 복호화
        let decrypted_data = cipher.decrypt(nonce, encrypted_data)
            .map_err(|_| io::Error::new(io::ErrorKind::InvalidData, "Decryption failed"))?;

        // 복호화된 데이터 저장 (기존 파일 덮어쓰기)
        let mut decrypted_file = fs::File::create(&file_path)?; // 같은 파일 이름 사용
        decrypted_file.write_all(&decrypted_data)?; // 복호화된 데이터 저장
    }

    Ok(())
}