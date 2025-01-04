pub mod module;

use std::io;
use clap::{Arg, Command};
use std::process;

use module::crypto::{encrypt, decryption};

fn main() -> Result<(), io::Error> {
    let matches = Command::new("MyBinary")
        .version("1.0")
        .author("Your Name <your_email@example.com>")
        .about("Encrypt or Decrypt files")
        .arg(
            Arg::new("mod")
                .short('m')
                .long("mod")
                .value_name("MODE")
                .help("Mode of operation: 'e' for encrypt, 'd' for decrypt")
                .required(true),
        )
        .arg(
            Arg::new("path")
                .short('p')
                .long("path")
                .value_name("PATH")
                .help("Path to the target folder")
                .required(true),
        )
        .arg(
            Arg::new("key")
                .short('k')
                .long("key")
                .value_name("KEY")
                .help("Decryption Key")
                .required(false),
        )
        .get_matches();

    let mode: &String = matches
        .get_one("mod")
        .expect("Mode argument is required");
    let path: &String = matches
        .get_one("path")
        .expect("Path argument is required");
    let key: Option<&String> = matches.get_one("key"); // 선택적 인자로 처리

    match mode.as_str() {
        "e" => {
            encrypt(path.clone())?; // `encrypt` 함수 호출
        }
        "d" => {
            // `decryption` 함수 호출, `key`는 `Option<String>`으로 전달
            decryption(path.clone(), key.map(|k| k.clone()))?;
        }
        _ => {
            eprintln!("Invalid mode. Use 'e' for encrypt or 'd' for decrypt.");
            process::exit(1);
        }
    }

    Ok(())
}
