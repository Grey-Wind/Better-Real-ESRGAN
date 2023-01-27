use std::process::Command;

fn main() {
    println!("Test");
    Command::new("realesrgan-ncnn-vulkan.exe")
        .arg("-i")
        .arg("input.jpg")
        .arg("-o")
        .arg("output.png")
        .arg("-n")
        .arg("realesrgan-x4plus-anime");
}
