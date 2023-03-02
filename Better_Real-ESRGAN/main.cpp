#include "better_real_esrgan.h"

#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    Better_Real_ESRGAN w;
    w.show();
    return a.exec();
}
