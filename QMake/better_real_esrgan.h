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
    void animeJPG_clicked();

    void animePNG_clicked();

    void defaultJPG_clicked();

    void defaultPNG_clicked();

    void video2_clicked();

    void video3_clicked();

    void video4_clicked();

    void github_clicked();

    void help_clicked();

    void gitee_clicked();

    void sponsor_clicked();

    void generalX4V3_clicked();

    void generalX4V3_wdn_clicked();

private:
    Ui::Better_Real_ESRGAN *ui;
};
#endif // BETTER_REAL_ESRGAN_H
