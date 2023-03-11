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
#include <QtGui/QIcon>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Better_Real_ESRGAN
{
public:
    QWidget *centralwidget;
    QLabel *title;
    QPushButton *animeJPG;
    QPushButton *animePNG;
    QPushButton *defaultJPG;
    QPushButton *defaultPNG;
    QPushButton *video2;
    QPushButton *video3;
    QPushButton *video4;
    QPushButton *github;
    QPushButton *gitee;
    QPushButton *help;
    QPushButton *sponsor;
    QPushButton *generalX4V3;
    QPushButton *generalX4V3_wdn;

    void setupUi(QMainWindow *Better_Real_ESRGAN)
    {
        if (Better_Real_ESRGAN->objectName().isEmpty())
            Better_Real_ESRGAN->setObjectName("Better_Real_ESRGAN");
        Better_Real_ESRGAN->resize(412, 189);
        Better_Real_ESRGAN->setMinimumSize(QSize(412, 189));
        Better_Real_ESRGAN->setMaximumSize(QSize(412, 189));
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/image/image/icon.png"), QSize(), QIcon::Normal, QIcon::Off);
        Better_Real_ESRGAN->setWindowIcon(icon);
        centralwidget = new QWidget(Better_Real_ESRGAN);
        centralwidget->setObjectName("centralwidget");
        title = new QLabel(centralwidget);
        title->setObjectName("title");
        title->setGeometry(QRect(130, 0, 191, 31));
        QFont font;
        font.setPointSize(12);
        title->setFont(font);
        animeJPG = new QPushButton(centralwidget);
        animeJPG->setObjectName("animeJPG");
        animeJPG->setGeometry(QRect(10, 30, 93, 29));
        animePNG = new QPushButton(centralwidget);
        animePNG->setObjectName("animePNG");
        animePNG->setGeometry(QRect(110, 30, 93, 29));
        defaultJPG = new QPushButton(centralwidget);
        defaultJPG->setObjectName("defaultJPG");
        defaultJPG->setGeometry(QRect(210, 30, 93, 29));
        defaultPNG = new QPushButton(centralwidget);
        defaultPNG->setObjectName("defaultPNG");
        defaultPNG->setGeometry(QRect(310, 30, 93, 29));
        video2 = new QPushButton(centralwidget);
        video2->setObjectName("video2");
        video2->setGeometry(QRect(10, 70, 120, 29));
        video3 = new QPushButton(centralwidget);
        video3->setObjectName("video3");
        video3->setGeometry(QRect(139, 70, 131, 29));
        video4 = new QPushButton(centralwidget);
        video4->setObjectName("video4");
        video4->setGeometry(QRect(280, 70, 120, 29));
        github = new QPushButton(centralwidget);
        github->setObjectName("github");
        github->setGeometry(QRect(10, 150, 100, 29));
        gitee = new QPushButton(centralwidget);
        gitee->setObjectName("gitee");
        gitee->setGeometry(QRect(120, 150, 100, 29));
        help = new QPushButton(centralwidget);
        help->setObjectName("help");
        help->setGeometry(QRect(320, 150, 81, 29));
        sponsor = new QPushButton(centralwidget);
        sponsor->setObjectName("sponsor");
        sponsor->setGeometry(QRect(230, 150, 81, 29));
        generalX4V3 = new QPushButton(centralwidget);
        generalX4V3->setObjectName("generalX4V3");
        generalX4V3->setGeometry(QRect(10, 110, 191, 29));
        generalX4V3_wdn = new QPushButton(centralwidget);
        generalX4V3_wdn->setObjectName("generalX4V3_wdn");
        generalX4V3_wdn->setGeometry(QRect(210, 110, 191, 29));
        Better_Real_ESRGAN->setCentralWidget(centralwidget);
        QWidget::setTabOrder(animeJPG, animePNG);
        QWidget::setTabOrder(animePNG, defaultJPG);
        QWidget::setTabOrder(defaultJPG, defaultPNG);
        QWidget::setTabOrder(defaultPNG, video2);
        QWidget::setTabOrder(video2, video3);
        QWidget::setTabOrder(video3, video4);
        QWidget::setTabOrder(video4, github);
        QWidget::setTabOrder(github, help);
        QWidget::setTabOrder(help, gitee);
        QWidget::setTabOrder(gitee, sponsor);

        retranslateUi(Better_Real_ESRGAN);
        QObject::connect(animeJPG, &QPushButton::clicked, animeJPG, qOverload<>(&QPushButton::click));

        QMetaObject::connectSlotsByName(Better_Real_ESRGAN);
    } // setupUi

    void retranslateUi(QMainWindow *Better_Real_ESRGAN)
    {
        Better_Real_ESRGAN->setWindowTitle(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        title->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        animeJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253JPG", nullptr));
        animePNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253PNG", nullptr));
        defaultJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244JPG", nullptr));
        defaultPNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244PNG", nullptr));
        video2->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x2", nullptr));
        video3->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x3", nullptr));
        video4->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x4", nullptr));
        github->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Github", nullptr));
        gitee->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Gitee", nullptr));
        help->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\270\256\345\212\251", nullptr));
        sponsor->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\350\265\236\345\212\251", nullptr));
        generalX4V3->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\231\256\351\200\232 x4 v3", nullptr));
        generalX4V3_wdn->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\231\256\351\200\232 wdn x4 v3", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Better_Real_ESRGAN: public Ui_Better_Real_ESRGAN {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BETTER_REAL_ESRGAN_H
