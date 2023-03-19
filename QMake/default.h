#ifndef DEFAULT_H
#define DEFAULT_H

#include <QWidget>

namespace Ui {
class default;
}

class default : public QWidget
{
    Q_OBJECT

public:
    explicit default(QWidget *parent = nullptr);
    ~default();

private:
    Ui::default *ui;
};

#endif // DEFAULT_H
