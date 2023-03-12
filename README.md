# Better Real-ESRGAN

A Real-ESRGAN GUI.

This GUI supports JPG images optimized to PNG images.

The original software needs to use Batch command or Powershell command to run the optimization instruction, but I prefer automatic execution rather than manual input, so I call Batch command internally to run. In the future, I will try to move the output outside the software instead of in the dark CMD window.

Now I write new optimization scripts using C++, Visual Basic, and Rust, respectively. Based on my tests, the theoretical fastest should be Rust, but since I use Rust less, I recommend using the Visual Basic version, but the core support should be biased towards Rust in the future.

View the Chinese readme:[click here](https://github.com/Adenx0/Better-Real-ESRGAN/blob/main/README_CN.md)

## Design content

* [X] Multi-model optional optimization
* [X] Independent optimization script
* [X] Script is written in multiple languages
* [ ] Optional file optimization (here refers to the freedom to select images in any location)

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

General x4 v3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-x4v3`

General x4 v3 wdn:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3`

## Use content

Icon: Han Yi Shu Hun Ti Jian; 256×256; 300px; No thickened tilt; Starry sky brush for background; Background color RGB-&gt; 001 | 164 | 233, HSV - & gt; 198 | 095 | 091 (reproduced signature, commercial need to contact my)
