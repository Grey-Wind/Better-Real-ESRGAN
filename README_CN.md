# 更好的Real-ESRGAN

一个Real-ESRGAN的GUI。

这个GUI支持JPG格式图片优化为PNG格式图片。

原软件需要使用Batch命令或Powershell命令来运行优化指令，而本人并不喜欢手动输入，更喜欢自动化执行，所以改为在外部调用Batch命令来运行。我会在未来尝试将输出内容移至软件内，而不是在漆黑的CMD窗口中。

现在我分别使用C++、Visual Basic与Rust编写了新的优化脚本，根据我的测试，理论最快的应该是Rust，但由于我较少使用Rust，故建议使用Visual Basic版本，但未来核心支持应该会偏向于Rust。

## 设计内容

* [X] 多模型自选优化
* [X] 独立优化脚本
* [X] 脚本多语言编写
* [ ] 自选文件优化（此处指自由在任何位置选择图片）

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

普通 x4 v3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-x4v3`

普通 x4 v3 wdn:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3`

## 使用内容

图标：汉仪书魂体简；256×256；300px；无加粗倾斜；背景使用星空(密)笔刷；背景颜色RGB->001|164|233，HSV->198|095|091（转载署名，商用需联系本人）
