use std::io;

pub fn variables(){
    let mut x=5;
    println!("The value of x is : {x}");
    x = 6;
    println!("The value of x is : {x}");
}

pub fn Shadowing(){
    let x=5;
    let x = x+1;
    let x = x*2;

    println!("The value of x is:{x}");

    let spaces = "    ";
    let spaces = spaces.len();
}