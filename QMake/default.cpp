#include "default.h"
#include "ui_default.h"

#include <stdlib.h>

Default::Default(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Default)
{
    ui->setupUi(this);
}

Default::~Default()
{
    delete ui;
}

void Default::on_PNG_clicked()
{
    system("realesrgan-ncnn-vulkan.exe -i input.png -o output.png -n realesrgan-x4plus-anime");
}

