#include "general.h"
#include "ui_general.h"

#include <stdlib.h>

General::General(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::General)
{
    ui->setupUi(this);
}

General::~General()
{
    delete ui;
}

void General::on_DefaultPng_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-x4v3");
}


void General::on_DefaultJpg_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesr-general-x4v3");
}


void General::on_DefaultJpeg_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpeg -o output.png -n realesr-general-x4v3");
}


void General::on_wdnPng_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3");
}


void General::on_wdnJpg_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesr-general-wdn-x4v3");
}


void General::on_wdnJpeg_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpeg -o output.png -n realesr-general-wdn-x4v3");
}

