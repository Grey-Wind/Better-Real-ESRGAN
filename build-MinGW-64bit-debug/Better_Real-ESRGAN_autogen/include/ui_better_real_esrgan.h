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
#include <QtGui/QAction>
#include <QtGui/QIcon>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenu>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_Better_Real_ESRGAN
{
public:
    QAction *actionGithub_Issue;
    QAction *actionGitee_Issue;
    QWidget *centralwidget;
    QLabel *Title;
    QPushButton *AnimeJPG;
    QPushButton *AnimePNG;
    QPushButton *DefaultJPG;
    QPushButton *DefaultPNG;
    QPushButton *Video2;
    QPushButton *Video3;
    QPushButton *Video4;
    QPushButton *Real_ESRGAN_Github;
    QPushButton *Github;
    QPushButton *Real_ESRGAN_Gitee;
    QPushButton *Gitee;
    QPushButton *Help;
    QPushButton *Sponsor;
    QPushButton *GeneralX4V3;
    QPushButton *GeneralX4V3_wdn;
    QMenuBar *menubar;
    QMenu *menu;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *Better_Real_ESRGAN)
    {
        if (Better_Real_ESRGAN->objectName().isEmpty())
            Better_Real_ESRGAN->setObjectName("Better_Real_ESRGAN");
        Better_Real_ESRGAN->resize(412, 270);
        Better_Real_ESRGAN->setMinimumSize(QSize(412, 270));
        Better_Real_ESRGAN->setMaximumSize(QSize(412, 270));
        QIcon icon;
        icon.addFile(QString::fromUtf8(":/image/image/icon.png"), QSize(), QIcon::Normal, QIcon::Off);
        Better_Real_ESRGAN->setWindowIcon(icon);
        actionGithub_Issue = new QAction(Better_Real_ESRGAN);
        actionGithub_Issue->setObjectName("actionGithub_Issue");
        actionGitee_Issue = new QAction(Better_Real_ESRGAN);
        actionGitee_Issue->setObjectName("actionGitee_Issue");
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
        Video2 = new QPushButton(centralwidget);
        Video2->setObjectName("Video2");
        Video2->setGeometry(QRect(10, 70, 120, 29));
        Video3 = new QPushButton(centralwidget);
        Video3->setObjectName("Video3");
        Video3->setGeometry(QRect(139, 70, 131, 29));
        Video4 = new QPushButton(centralwidget);
        Video4->setObjectName("Video4");
        Video4->setGeometry(QRect(280, 70, 120, 29));
        Real_ESRGAN_Github = new QPushButton(centralwidget);
        Real_ESRGAN_Github->setObjectName("Real_ESRGAN_Github");
        Real_ESRGAN_Github->setGeometry(QRect(10, 150, 161, 29));
        Github = new QPushButton(centralwidget);
        Github->setObjectName("Github");
        Github->setGeometry(QRect(180, 150, 111, 29));
        Real_ESRGAN_Gitee = new QPushButton(centralwidget);
        Real_ESRGAN_Gitee->setObjectName("Real_ESRGAN_Gitee");
        Real_ESRGAN_Gitee->setGeometry(QRect(10, 190, 161, 29));
        Gitee = new QPushButton(centralwidget);
        Gitee->setObjectName("Gitee");
        Gitee->setGeometry(QRect(180, 190, 111, 29));
        Help = new QPushButton(centralwidget);
        Help->setObjectName("Help");
        Help->setGeometry(QRect(300, 150, 101, 31));
        Sponsor = new QPushButton(centralwidget);
        Sponsor->setObjectName("Sponsor");
        Sponsor->setGeometry(QRect(300, 190, 101, 29));
        GeneralX4V3 = new QPushButton(centralwidget);
        GeneralX4V3->setObjectName("GeneralX4V3");
        GeneralX4V3->setGeometry(QRect(10, 110, 191, 29));
        GeneralX4V3_wdn = new QPushButton(centralwidget);
        GeneralX4V3_wdn->setObjectName("GeneralX4V3_wdn");
        GeneralX4V3_wdn->setGeometry(QRect(210, 110, 191, 29));
        Better_Real_ESRGAN->setCentralWidget(centralwidget);
        menubar = new QMenuBar(Better_Real_ESRGAN);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 412, 26));
        menu = new QMenu(menubar);
        menu->setObjectName("menu");
        Better_Real_ESRGAN->setMenuBar(menubar);
        statusbar = new QStatusBar(Better_Real_ESRGAN);
        statusbar->setObjectName("statusbar");
        Better_Real_ESRGAN->setStatusBar(statusbar);
        QWidget::setTabOrder(AnimeJPG, AnimePNG);
        QWidget::setTabOrder(AnimePNG, DefaultJPG);
        QWidget::setTabOrder(DefaultJPG, DefaultPNG);
        QWidget::setTabOrder(DefaultPNG, Video2);
        QWidget::setTabOrder(Video2, Video3);
        QWidget::setTabOrder(Video3, Video4);
        QWidget::setTabOrder(Video4, Real_ESRGAN_Github);
        QWidget::setTabOrder(Real_ESRGAN_Github, Github);
        QWidget::setTabOrder(Github, Help);
        QWidget::setTabOrder(Help, Real_ESRGAN_Gitee);
        QWidget::setTabOrder(Real_ESRGAN_Gitee, Gitee);
        QWidget::setTabOrder(Gitee, Sponsor);

        menubar->addAction(menu->menuAction());
        menu->addAction(actionGithub_Issue);
        menu->addAction(actionGitee_Issue);

        retranslateUi(Better_Real_ESRGAN);

        QMetaObject::connectSlotsByName(Better_Real_ESRGAN);
    } // setupUi

    void retranslateUi(QMainWindow *Better_Real_ESRGAN)
    {
        Better_Real_ESRGAN->setWindowTitle(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        actionGithub_Issue->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Github Issue", nullptr));
#if QT_CONFIG(shortcut)
        actionGithub_Issue->setShortcut(QCoreApplication::translate("Better_Real_ESRGAN", "F1", nullptr));
#endif // QT_CONFIG(shortcut)
        actionGitee_Issue->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Gitee Issue", nullptr));
#if QT_CONFIG(shortcut)
        actionGitee_Issue->setShortcut(QCoreApplication::translate("Better_Real_ESRGAN", "F1", nullptr));
#endif // QT_CONFIG(shortcut)
        Title->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        AnimeJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253JPG", nullptr));
        AnimePNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253PNG", nullptr));
        DefaultJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244JPG", nullptr));
        DefaultPNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244PNG", nullptr));
        Video2->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x2", nullptr));
        Video3->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x3", nullptr));
        Video4->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253\350\247\206\351\242\221\346\224\276\345\244\247 x4", nullptr));
        Real_ESRGAN_Github->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Real ESRGAN Github", nullptr));
        Github->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Github", nullptr));
        Real_ESRGAN_Gitee->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Real ESRGAN Gitee", nullptr));
        Gitee->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\234\254\350\275\257\344\273\266Gitee", nullptr));
        Help->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\270\256\345\212\251", nullptr));
        Sponsor->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\350\265\236\345\212\251", nullptr));
        GeneralX4V3->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\231\256\351\200\232 x4 v3", nullptr));
        GeneralX4V3_wdn->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\231\256\351\200\232 wdn x4 v3", nullptr));
        menu->setTitle(QCoreApplication::translate("Better_Real_ESRGAN", "\346\212\245\345\221\212\351\227\256\351\242\230", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Better_Real_ESRGAN: public Ui_Better_Real_ESRGAN {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BETTER_REAL_ESRGAN_H
