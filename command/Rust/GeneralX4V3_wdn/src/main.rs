use std::process::Command;

fn main() {
    let _ = Command::new("cmd.exe")
        .arg("/c")
        .arg("realesrgan-ncnn-vulkan.exe")
        .arg("-i")
        .arg("input.png")
        .arg("-o")
        .arg("output.png")
        .arg("-n")
        .arg("realesr-general-wdn-x4v3")
        .status();
}
