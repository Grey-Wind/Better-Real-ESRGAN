#include "sponsor.h"
#include "ui_sponsor.h"

sponsor::sponsor(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::sponsor)
{
    ui->setupUi(this);
}

sponsor::~sponsor()
{
    delete ui;
}
