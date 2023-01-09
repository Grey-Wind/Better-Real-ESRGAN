# 更好的Real-ESRGAN

一个Real-ESRGAN的GUI

这个GUI支持JPG图片优化为PNG图片

原软件需要使用Batch命令或Powershell命令来运行优化指令，而本人并不喜欢手动输入，更喜欢自动化执行，所以改为在内部调用Batch命令来运行。我会在未来尝试将输出内容移至软件内，而不是在漆黑的CMD窗口中。

# 软件语言

本软件只内置了中文。

更多语言支持请耐心等待。

### 优化指令

动漫JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime`

动漫PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime`

默认JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus`

默认PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus`

动漫视频放大 x2:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2`

动漫视频放大 x3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3`

动漫视频放大 x4:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4`
