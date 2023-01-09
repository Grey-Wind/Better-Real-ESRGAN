# Better Real-ESRGAN

A Real-ESRGAN GUI

This GUI supports JPG images optimized to PNG images

The original software needs to use Batch command or Powershell command to run the optimization instruction, but I prefer automatic execution rather than manual input, so I call Batch command internally to run. In the future, I will try to move the output inside the software instead of in the dark CMD window.

# Language

This software only have Chinese.

Please wait for more language support.

View the Chinese readme:[click here](https://github.com/Adenx0/Better-Real-ESRGAN/blob/main/README_CN.md)

# Optimize Command

Anime JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime`

Anime PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime`

Default JPG:`realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus`

Default PNG:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus`

Anime Video x2:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2`

Anime Video x3:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3`

Anime Video x4:`realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4`
