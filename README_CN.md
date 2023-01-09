# 更好的Real-ESRGAN

一个Real-ESRGAN的GUI。

这个GUI支持JPG格式图片优化为PNG格式图片。

原软件需要使用Batch命令或Powershell命令来运行优化指令，而本人并不喜欢手动输入，更喜欢自动化执行，所以改为在内部调用Batch命令来运行。我会在未来尝试将输出内容移至软件内，而不是在漆黑的CMD窗口中。

## 软件语言

本软件只内置了中文。

更多语言支持请耐心等待。

## 注意事项

在使用时，请先将您想要优化的图片命名为input，后缀名为png或jpg(jpeg目前不支持)，然后选自己需要的类型进行优化。输出图片为output.png

注意：动漫视频优化是以视频优化方式优化图片，且只支持png格式。

## 优化指令

动漫JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime`

动漫PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime`

默认JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus`

默认PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus`

动漫视频放大 x2:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2`

动漫视频放大 x3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3`

动漫视频放大 x4:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4`

## 参考文档

[Qt通过点击按钮弹出新的窗口（新建弹出式窗口）](https://blog.csdn.net/jkjijijkv/article/details/119969325)

[解决Qt程序打包后无法运行并提示缺少库文件](https://blog.csdn.net/code_peak/article/details/118833667)

[C++调用CMD命令](https://www.cnblogs.com/kex1n/p/5664948.html)
