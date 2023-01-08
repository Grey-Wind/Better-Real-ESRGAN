# 更好的Real-ESRGAN

一个Real-ESRGAN的GUI

这个GUI支持jpg图片优化为png图片

原软件需要使用batch命令或powershell命令来运行优化指令，而本人并不喜欢命令框，所以改为在内部调用CMD来运行，唯一的缺点是无法实时看到进度，这一点可能会在未来的版本改进。

# 软件语言

本软件只内置了中文。

更多语言支持请耐心等待。

### Command

动漫JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime`

动漫PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime`

默认JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus`

默认PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus`
