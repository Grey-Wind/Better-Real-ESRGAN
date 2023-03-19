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

    void on_Github_clicked();

    void on_Gitee_clicked();

    void on_Sponsor_clicked();

    void on_AnimeModel_clicked();

    void on_DefaultModel_clicked();

    void on_GeneralModel_clicked();

private:
    Ui::Better_Real_ESRGAN *ui;
};
#endif // BETTER_REAL_ESRGAN_H
