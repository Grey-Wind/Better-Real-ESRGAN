ffmpeg -i input.mp4 -qscale:v 1 -qmin 1 -qmax 1 -fps_mode 0 tmp_frames/frame%08d.png
realesrgan-ncnn-vulkan.exe -i tmp_frames -o out_frames -n realesr-animevideov3 -s 2 -f jpg
ffmpeg -i input.mp4
ffmpeg -r 23.98 -i out_frames/frame%08d.jpg -c:v libx264 -r 23.98 -pix_fmt yuv420p output.mp4
pause