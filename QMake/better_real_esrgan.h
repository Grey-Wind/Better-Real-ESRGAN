#ifndef BETTER_REAL_ESRGAN_H
#define BETTER_REAL_ESRGAN_H

#include <QMainWindow>
#include <QPushButton>
#include <QWidget>
#include "sponsor.h"

QT_BEGIN_NAMESPACE
namespace Ui { class Better_Real_ESRGAN; }
QT_END_NAMESPACE

class Better_Real_ESRGAN : public QMainWindow
{
    Q_OBJECT

public:
    Better_Real_ESRGAN(QWidget *parent = nullptr);
    ~Better_Real_ESRGAN();

private slots:

    void on_animePNG_clicked();

    void on_defaultJPG_clicked();

    void on_defaultPNG_clicked();

    void on_video2_clicked();

    void on_video3_clicked();

    void on_video4_clicked();

    void on_github_clicked();

    void on_help_clicked();

    void on_gitee_clicked();

    void on_sponsor_clicked();

    void on_generalX4V3_clicked();

    void on_generalX4V3_wdn_clicked();

    void on_animeJPG_clicked();

private:
    Ui::Better_Real_ESRGAN *ui;
};
#endif // BETTER_REAL_ESRGAN_H
