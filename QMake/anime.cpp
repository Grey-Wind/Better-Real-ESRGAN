#include "anime.h"
#include "ui_anime.h"

#include <stdlib.h>

Anime::Anime(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Anime)
{
    ui->setupUi(this);
}

Anime::~Anime()
{
    delete ui;
}

void Anime::on_PNG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime");
}


void Anime::on_JPG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime");
}

void Anime::on_JPEG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.jpeg -o output.png -n realesrgan-x4plus-anime");
}

