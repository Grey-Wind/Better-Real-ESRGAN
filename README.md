# Better Real-ESRGAN

![Alt](https://repobeats.axiom.co/api/embed/d3293db1f256b1bdb064a1e0f704fc622434e173.svg "Repobeats analytics image")

A Real-ESRGAN GUI.

This GUI supports JPG(JPEG) format images optimized to PNG format images.

The original software needs to call Batch command or Powershell command to run the optimization instruction, but I don't like to manually input every time, prefer to automate the execution, so I made this software to save time.

I've abandoned script splitting for now, but it's still supported for multiple languages.

View the Chinese readme:[click here](https://github.com/Adenx0/Better-Real-ESRGAN/blob/main/README_CN.md)

---

This software takes into account multiple programming languages, so there is no core code in the main branch, the code of each language is in the corresponding branch, Qt6 has been improved, I will not bother to update, the follow-up will first support WPF, C# and Visual Basic, the other languages temporarily wait for me to continue learning.

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
