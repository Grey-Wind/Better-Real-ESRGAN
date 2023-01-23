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

## 使用内容

PySide6

图标：汉仪书魂体简；256×256；300px；无加粗倾斜；背景使用星空(密)笔刷；背景颜色RGB->001|164|233，HSV->198|095|091（转载署名，商用需联系本人）

## 参考文档

[Qt creator：创建和添加资源resource](https://blog.csdn.net/qq_31672941/article/details/89340539)

[手把手教你把Python代码转成exe](https://zhuanlan.zhihu.com/p/391464546)

[国内知名镜像地址，PIP下载安装更高效](https://www.jianshu.com/p/db33456d5d77)

[Python调用cmd](https://blog.csdn.net/leviopku/article/details/90753593)

[python中调用cmd](https://www.cnblogs.com/raichen/p/4930525.html)

[pyqt使用qrc文件报错](https://blog.csdn.net/u010845208/article/details/58595355)

[python中写入txt文件需要换行,以及\r 和\n](https://www.cnblogs.com/isme-zjh/p/11585462.html)

[Python write()和writelines()：向文件中写入数据](http://c.biancheng.net/view/4758.html)

[Python在程序退出前执行代码](https://blog.csdn.net/lly1122334/article/details/107767433)

[python如何显示出一张图片](https://www.py.cn/faq/python/18522.html)

[用python下载文件的若干种方法汇总](https://cloud.tencent.com/developer/article/1471279)

[python基础：Python判断文件是否存在的三种方法(os.path.exsist, os.path.isfile, try-catch)](https://blog.csdn.net/NeverLate_gogogo/article/details/109333970)
