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
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Better_Real_ESRGAN
{
public:
    QWidget *centralwidget;
    QLabel *Title;
    QPushButton *AnimeJPG;
    QPushButton *AnimePNG;
    QPushButton *DefaultJPG;
    QPushButton *DefaultPNG;
    QPushButton *pushButton_5;
    QPushButton *pushButton_6;
    QPushButton *pushButton_7;
    QPushButton *pushButton_8;
    QPushButton *pushButton_9;
    QPushButton *pushButton_10;
    QPushButton *pushButton_11;
    QPushButton *pushButton_12;
    QPushButton *pushButton_13;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *Better_Real_ESRGAN)
    {
        if (Better_Real_ESRGAN->objectName().isEmpty())
            Better_Real_ESRGAN->setObjectName("Better_Real_ESRGAN");
        Better_Real_ESRGAN->resize(412, 228);
        centralwidget = new QWidget(Better_Real_ESRGAN);
        centralwidget->setObjectName("centralwidget");
        Title = new QLabel(centralwidget);
        Title->setObjectName("Title");
        Title->setGeometry(QRect(130, 0, 191, 31));
        QFont font;
        font.setPointSize(12);
        Title->setFont(font);
        AnimeJPG = new QPushButton(centralwidget);
        AnimeJPG->setObjectName("AnimeJPG");
        AnimeJPG->setGeometry(QRect(10, 30, 93, 29));
        AnimePNG = new QPushButton(centralwidget);
        AnimePNG->setObjectName("AnimePNG");
        AnimePNG->setGeometry(QRect(110, 30, 93, 29));
        DefaultJPG = new QPushButton(centralwidget);
        DefaultJPG->setObjectName("DefaultJPG");
        DefaultJPG->setGeometry(QRect(210, 30, 93, 29));
        DefaultPNG = new QPushButton(centralwidget);
        DefaultPNG->setObjectName("DefaultPNG");
        DefaultPNG->setGeometry(QRect(310, 30, 93, 29));
        pushButton_5 = new QPushButton(centralwidget);
        pushButton_5->setObjectName("pushButton_5");
        pushButton_5->setGeometry(QRect(10, 70, 120, 29));
        pushButton_6 = new QPushButton(centralwidget);
        pushButton_6->setObjectName("pushButton_6");
        pushButton_6->setGeometry(QRect(139, 70, 131, 29));
        pushButton_7 = new QPushButton(centralwidget);
        pushButton_7->setObjectName("pushButton_7");
        pushButton_7->setGeometry(QRect(280, 70, 120, 29));
        pushButton_8 = new QPushButton(centralwidget);
        pushButton_8->setObjectName("pushButton_8");
        pushButton_8->setGeometry(QRect(10, 110, 161, 29));
        pushButton_9 = new QPushButton(centralwidget);
        pushButton_9->setObjectName("pushButton_9");
        pushButton_9->setGeometry(QRect(180, 110, 111, 29));
        pushButton_10 = new QPushButton(centralwidget);
        pushButton_10->setObjectName("pushButton_10");
        pushButton_10->setGeometry(QRect(10, 150, 161, 29));
        pushButton_11 = new QPushButton(centralwidget);
        pushButton_11->setObjectName("pushButton_11");
        pushButton_11->setGeometry(QRect(180, 150, 111, 29));
        pushButton_12 = new QPushButton(centralwidget);
        pushButton_12->setObjectName("pushButton_12");
        pushButton_12->setGeometry(QRect(300, 110, 101, 31));
        pushButton_13 = new QPushButton(centralwidget);
        pushButton_13->setObjectName("pushButton_13");
        pushButton_13->setGeometry(QRect(300, 150, 101, 29));
        Better_Real_ESRGAN->setCentralWidget(centralwidget);
        menubar = new QMenuBar(Better_Real_ESRGAN);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 412, 26));
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
        AnimeJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253JPG", nullptr));
        AnimePNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253PNG", nullptr));
        DefaultJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244JPG", nullptr));
        DefaultPNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244PNG", nullptr));
        pushButton_5->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x2", nullptr));
        pushButton_6->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x3", nullptr));
        pushButton_7->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x4", nullptr));
        pushButton_8->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Real ESRGAN Github", nullptr));
        pushButton_9->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Github", nullptr));
        pushButton_10->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Real ESRGAN Gitee", nullptr));
        pushButton_11->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Gitee", nullptr));
        pushButton_12->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\270\256\345\212\251", nullptr));
        pushButton_13->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\350\265\236\345\212\251", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Better_Real_ESRGAN: public Ui_Better_Real_ESRGAN {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BETTER_REAL_ESRGAN_H
