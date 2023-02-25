#include <QCoreApplication>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4");
    return 0;
}
