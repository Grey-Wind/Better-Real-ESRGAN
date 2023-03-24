#ifndef GENERAL_H
#define GENERAL_H

#include <QWidget>

namespace Ui {
class General;
}

class General : public QWidget
{
    Q_OBJECT

public:
    explicit General(QWidget *parent = nullptr);
    ~General();

private slots:
    void on_DefaultPng_clicked();

    void on_DefaultJpg_clicked();

    void on_DefaultJpeg_clicked();

    void on_wdnPng_clicked();

    void on_wdnJpg_clicked();

    void on_wdnJpeg_clicked();

private:
    Ui::General *ui;
};

#endif // GENERAL_H
