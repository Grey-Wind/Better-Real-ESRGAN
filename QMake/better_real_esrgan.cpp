#include "better_real_esrgan.h"
#include "./ui_better_real_esrgan.h"
#include "sponsor.h"
#include <stdlib.h>
#include <QProcess>
#include <QDir>
#include <QString>
#include <stdio.h>

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

void Better_Real_ESRGAN::animeJPG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime");
    system("start AnimeJpg.exe");
}


void Better_Real_ESRGAN::animePNG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime");
    system("start AnimePng.exe");
}


void Better_Real_ESRGAN::defaultJPG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus");
    system("start DefaultJpg.exe");
}


void Better_Real_ESRGAN::defaultPNG_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus");
    system("start DefaultPng.exe");
}


void Better_Real_ESRGAN::video2_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x2");
    system("start Video2.exe");
}


void Better_Real_ESRGAN::video3_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x3");
    system("start Video3.exe");
}


void Better_Real_ESRGAN::video4_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-animevideov3-x4");
    system("start Video4.exe");
}

void Better_Real_ESRGAN::generalX4V3_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-x4v3");
    system("start GeneralX4V3.exe");
}

void Better_Real_ESRGAN::generalX4V3_wdn_clicked()
{
    //system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesr-general-wdn-x4v3");
    system("start GeneralX4V3_wdn.exe");
}

void Better_Real_ESRGAN::github_clicked()
{
    system("start https://github.com/Grey-Wind/Better-Real-ESRGAN");
}


void Better_Real_ESRGAN::help_clicked()
{
    system("start help.chm");
}

void Better_Real_ESRGAN::gitee_clicked()
{
    system("start https://gitee.com/at-studio/Better-Real-ESRGAN");
}


void Better_Real_ESRGAN::sponsor_clicked()
{
    //打开赞助窗口
    sponsor *configwindow=new sponsor;
    configwindow->show();
}

