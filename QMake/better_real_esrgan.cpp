#include <stdlib.h>
#include <QProcess>
#include <QDir>
#include <QString>
#include <QDebug>

#include "better_real_esrgan.h"
#include "./ui_better_real_esrgan.h"
#include "sponsor.h"
#include "anime.h"
#include "default.h"

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

void Better_Real_ESRGAN::on_Github_clicked()
{
    system("start https://github.com/Grey-Wind/Better-Real-ESRGAN");
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

void Better_Real_ESRGAN::on_AnimeModel_clicked()
{
    //打开动漫模型优化窗口
    Anime *animewindow=new Anime;
    setAttribute(Qt::WA_DeleteOnClose, true);
    setAttribute(Qt::WA_QuitOnClose,false);
    animewindow->show();
}

//这两行可以让打开的子窗口在主窗口关闭后一同关闭
//setAttribute(Qt::WA_DeleteOnClose, true);
//setAttribute(Qt::WA_QuitOnClose,false);

void Better_Real_ESRGAN::on_DefaultModel_clicked()
{
    Default *defaultwindow=new Default;
    setAttribute(Qt::WA_DeleteOnClose, true);
    setAttribute(Qt::WA_QuitOnClose,false);
    defaultwindow->show();
}


void Better_Real_ESRGAN::on_GeneralModel_clicked()
{
    printf("info:start general model optimize form");
}

