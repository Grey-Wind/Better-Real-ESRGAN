#ifndef SPONSOR_H
#define SPONSOR_H

#include <QWidget>

namespace Ui {
class sponsor;
}

class sponsor : public QWidget
{
    Q_OBJECT

public:
    explicit sponsor(QWidget *parent = nullptr);
    ~sponsor();

private:
    Ui::sponsor *ui;
};

#endif // SPONSOR_H
