use std::process::Command;

fn main() {
    let _ = Command::new("cmd.exe")
        .arg("/c")
        .arg("realesrgan-ncnn-vulkan.exe")
        .arg("-i")
        .arg("input.jpg")
        .arg("-o")
        .arg("output.png")
        .arg("-n")
        .arg("realesrgan-x4plus")
        .status();
}
