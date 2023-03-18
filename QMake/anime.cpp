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
    system("start AnimePng.exe");
}


void Anime::on_JPG_clicked()
{
    system("start AnimeJpg.exe");
}

void Anime::on_JPEG_clicked()
{
    //system("start AnimeJpeg.exe");
    system("@echo off&&echo unsupport&&pause");
}

