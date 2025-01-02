mod problem {
    pub mod Calculator;
}

fn main() {
    fn main() {
        let multiplier = 3;
        let multiply = |x: i32| x * multiplier; // 외부 변수 multiplier를 캡처
        let result = multiply(4);
        println!("4 * {} = {}", multiplier, result); // 출력: 4 * 3 = 12
    }
}