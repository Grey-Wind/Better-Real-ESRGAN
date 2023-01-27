#include <QCoreApplication>
#include <stdlib.h>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime");
    return 0;
}
