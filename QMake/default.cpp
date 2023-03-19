#include "default.h"
#include "ui_default.h"

default::default(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::default)
{
    ui->setupUi(this);
}

default::~default()
{
    delete ui;
}
