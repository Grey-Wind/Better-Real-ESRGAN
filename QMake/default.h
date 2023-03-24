#ifndef DEFAULT_H
#define DEFAULT_H

#include <QWidget>

namespace Ui {
class Default;
}

class Default : public QWidget
{
    Q_OBJECT

public:
    explicit Default(QWidget *parent = nullptr);
    ~Default();

private slots:
    void on_PNG_clicked();

    void on_JPG_clicked();

    void on_JPEG_clicked();

private:
    Ui::Default *ui;
};

#endif // DEFAULT_H
