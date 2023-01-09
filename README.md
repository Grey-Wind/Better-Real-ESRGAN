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

## Reference document

[Qt by clicking on the button pop-up window (the new pop-up window)](https://blog.csdn.net/jkjijijkv/article/details/119969325)

[solve Qt program won't run after packaging and prompt the lack of libraries](https://blog.csdn.net/code_peak/article/details/118833667)

[C++ call CMD command](https://www.cnblogs.com/kex1n/p/5664948.html)
