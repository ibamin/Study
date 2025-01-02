use std::io;

pub fn B1000() {
    let mut input = String::new();
    io::stdin().read_line(&mut input).unwrap();
    
    // 입력된 문자열을 공백을 기준으로 나누고, 각 부분 문자열을 정수로 변환하여 벡터에 저장합니다.
    let values:Vec<i32> = input
        .as_mut_str() // 입력된 문자열을 가변 문자열로 변환합니다.
        .split_whitespace() // 공백을 기준으로 문자열을 나눕니다.
        .map(|s| s.parse().unwrap()) // 각 부분 문자열을 정수로 변환합니다.
        .collect(); // 변환된 정수들을 벡터에 저장합니다.

    println!("{}", values[0] + values[1]);
}
