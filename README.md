# Better Real-ESRGAN

A Real-ESRGAN GUI.

This GUI supports JPG images optimized to PNG images.

The original software needs to use Batch command or Powershell command to run the optimization instruction, but I prefer automatic execution rather than manual input, so I call Batch command internally to run. In the future, I will try to move the output inside the software instead of in the dark CMD window.

## Language

This software only have Chinese.

Please wait for more language support.

View the Chinese readme:[click here](https://github.com/Adenx0/Better-Real-ESRGAN/blob/main/README_CN.md)

## Precautions

To use it, name the image you want to optimize as input, with a png or jpg suffix (jpeg is not currently supported), and then choose the type you want to optimize. The output image is output.png

Note: Animation video optimization is video optimization to optimize the image, and only support png format.

## Optimize Command

Anime JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime`

Anime PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime`

Default JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus`

Default PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus`

Anime Video x2:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2`

Anime Video x3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3`

Anime Video x4:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4`

## Use content

PySide6

Icon: Han Yi Shu Hun Ti Jian; 256×256; 300px; No thickened tilt; Starry sky brush for background; Background color RGB-&gt; 001 | 164 | 233, HSV - & gt; 198 | 095 | 091 (reproduced signature, commercial need to contact my)

## Reference document

[Qt creator: create and add the resources](https://blog.csdn.net/qq_31672941/article/details/89340539)

[taught you how to convert Python code to exe](https://zhuanlan.zhihu.com/p/391464546)

[domestic famous mirror address, PIP download and install more efficient](https://www.jianshu.com/p/db33456d5d77)

[Python call CMD](https://blog.csdn.net/leviopku/article/details/90753593)

[Python call CMD](https://www.cnblogs.com/raichen/p/4930525.html)

[use pyqt QRC file error](https://blog.csdn.net/u010845208/article/details/58595355)

[written in python TXT file need to wrap, and \ r \ n](https://www.cnblogs.com/isme-zjh/p/11585462.html)

[Python the write () and writelines () : to write data file](http://c.biancheng.net/view/4758.html)

[Python code is executed before program exits](https://blog.csdn.net/lly1122334/article/details/107767433)

[how python shows a picture](https://www.py.cn/faq/python/18522.html)

[the downloaded file in python several methods summary](https://cloud.tencent.com/developer/article/1471279)

[python Basics: exsist, os.path.isfile, exsist, os.path.isfile, try-catch)](https://blog.csdn.net/NeverLate_gogogo/article/details/109333970)
