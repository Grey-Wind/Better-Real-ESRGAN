/********************************************************************************
** Form generated from reading UI file 'better_real_esrgan.ui'
**
** Created by: Qt User Interface Compiler version 6.4.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_BETTER_REAL_ESRGAN_H
#define UI_BETTER_REAL_ESRGAN_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Better_Real_ESRGAN
{
public:
    QWidget *centralwidget;
    QLabel *Title;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *Better_Real_ESRGAN)
    {
        if (Better_Real_ESRGAN->objectName().isEmpty())
            Better_Real_ESRGAN->setObjectName("Better_Real_ESRGAN");
        Better_Real_ESRGAN->resize(330, 228);
        centralwidget = new QWidget(Better_Real_ESRGAN);
        centralwidget->setObjectName("centralwidget");
        Title = new QLabel(centralwidget);
        Title->setObjectName("Title");
        Title->setGeometry(QRect(90, 0, 191, 31));
        QFont font;
        font.setPointSize(12);
        Title->setFont(font);
        Better_Real_ESRGAN->setCentralWidget(centralwidget);
        menubar = new QMenuBar(Better_Real_ESRGAN);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 330, 26));
        Better_Real_ESRGAN->setMenuBar(menubar);
        statusbar = new QStatusBar(Better_Real_ESRGAN);
        statusbar->setObjectName("statusbar");
        Better_Real_ESRGAN->setStatusBar(statusbar);

        retranslateUi(Better_Real_ESRGAN);

        QMetaObject::connectSlotsByName(Better_Real_ESRGAN);
    } // setupUi

    void retranslateUi(QMainWindow *Better_Real_ESRGAN)
    {
        Better_Real_ESRGAN->setWindowTitle(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        Title->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Better_Real_ESRGAN: public Ui_Better_Real_ESRGAN {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BETTER_REAL_ESRGAN_H