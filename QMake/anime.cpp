#include "anime.h"
#include "ui_anime.h"

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
