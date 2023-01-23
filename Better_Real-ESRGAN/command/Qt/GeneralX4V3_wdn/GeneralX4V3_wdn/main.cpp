#include <QCoreApplication>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3");
    return 0;
}
