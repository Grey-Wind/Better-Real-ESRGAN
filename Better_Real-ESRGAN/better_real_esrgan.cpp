#include "better_real_esrgan.h"
#include "./ui_better_real_esrgan.h"

Better_Real_ESRGAN::Better_Real_ESRGAN(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::Better_Real_ESRGAN)
{
    ui->setupUi(this);
    setFixedSize(415,300);
}

Better_Real_ESRGAN::~Better_Real_ESRGAN()
{
    delete ui;
}


void Better_Real_ESRGAN::on_AnimeJPG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime");
}


void Better_Real_ESRGAN::on_AnimePNG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime");
}

