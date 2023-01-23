#include "better_real_esrgan.h"
#include "./ui_better_real_esrgan.h"
#include "sponsor.h"
#include <stdlib.h>
#include <QProcess>
#include <QDir>
#include <QString>

Better_Real_ESRGAN::Better_Real_ESRGAN(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::Better_Real_ESRGAN)
{
    ui->setupUi(this);
}

Better_Real_ESRGAN::~Better_Real_ESRGAN()
{
    delete ui;
}


void Better_Real_ESRGAN::on_AnimeJPG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime");
    system("start AnimeJpg.exe");
}


void Better_Real_ESRGAN::on_AnimePNG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime");
    system("start AnimePng.exe");
}


void Better_Real_ESRGAN::on_DefaultJPG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus");
    system("start DefaultJpg.exe");
}


void Better_Real_ESRGAN::on_DefaultPNG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus");
    system("start DefaultPng.exe");
}


void Better_Real_ESRGAN::on_Video2_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2");
}


void Better_Real_ESRGAN::on_Video3_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3");
}


void Better_Real_ESRGAN::on_Video4_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4");
}

void Better_Real_ESRGAN::on_GeneralX4V3_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-x4v3");
}

void Better_Real_ESRGAN::on_GeneralX4V3_wdn_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3");
}

void Better_Real_ESRGAN::on_Real_ESRGAN_Github_clicked(){
    system("start https://github.com/xinntao/Real-ESRGAN");
}


void Better_Real_ESRGAN::on_Github_clicked()
{
    system("start https://github.com/Grey-Wind/Better-Real-ESRGAN");
}


void Better_Real_ESRGAN::on_Help_clicked()
{
    system("start help.chm");
}


void Better_Real_ESRGAN::on_Real_ESRGAN_Gitee_clicked()
{
    system("start https://gitee.com/eeethon/Real-ESRGAN");
}


void Better_Real_ESRGAN::on_Gitee_clicked()
{
    system("start https://gitee.com/at-studio/Better-Real-ESRGAN?_from=gitee_search");
}


void Better_Real_ESRGAN::on_Sponsor_clicked()
{
    //打开赞助窗口
    sponsor *configwindow=new sponsor;
    configwindow->show();
}
