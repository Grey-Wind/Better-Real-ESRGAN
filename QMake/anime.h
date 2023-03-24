#ifndef ANIME_H
#define ANIME_H

#include <QWidget>

namespace Ui {
class Anime;
}

class Anime : public QWidget
{
    Q_OBJECT

public:
    explicit Anime(QWidget *parent = nullptr);
    ~Anime();

private slots:
    void on_PNG_clicked();

    void on_JPG_clicked();

    void on_JPEG_clicked();

private:
    Ui::Anime *ui;
};

#endif // ANIME_H
