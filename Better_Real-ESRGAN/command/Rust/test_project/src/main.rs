use std::process::Command;  

fn main() {
    println!("Hello, world!");
    let _ = Command::new("cmd.exe").arg("ipconfig").status().expect("errror");
    let _ = Command::new("cmd.exe").arg("/c").arg("pause").status();
}
