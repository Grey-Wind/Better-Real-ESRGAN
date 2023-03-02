#include <QCoreApplication>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus");
    return 0;
}
