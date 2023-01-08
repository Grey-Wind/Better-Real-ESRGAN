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
    QAction *actionGithub;
    QAction *actionGitee;
    QAction *actionHelp;
    QWidget *centralwidget;
    QLabel *Title;
    QPushButton *AnimeJPG;
    QPushButton *AnimePNG;
    QPushButton *DefaultJPG;
    QPushButton *DefaultPNG;
    QMenuBar *menubar;
    QMenu *menu;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *Better_Real_ESRGAN)
    {
        if (Better_Real_ESRGAN->objectName().isEmpty())
            Better_Real_ESRGAN->setObjectName("Better_Real_ESRGAN");
        Better_Real_ESRGAN->resize(414, 300);
        Better_Real_ESRGAN->setWindowOpacity(1.000000000000000);
        actionGithub = new QAction(Better_Real_ESRGAN);
        actionGithub->setObjectName("actionGithub");
        actionGitee = new QAction(Better_Real_ESRGAN);
        actionGitee->setObjectName("actionGitee");
        actionHelp = new QAction(Better_Real_ESRGAN);
        actionHelp->setObjectName("actionHelp");
        centralwidget = new QWidget(Better_Real_ESRGAN);
        centralwidget->setObjectName("centralwidget");
        Title = new QLabel(centralwidget);
        Title->setObjectName("Title");
        Title->setGeometry(QRect(100, 0, 291, 31));
        QFont font;
        font.setPointSize(18);
        Title->setFont(font);
        AnimeJPG = new QPushButton(centralwidget);
        AnimeJPG->setObjectName("AnimeJPG");
        AnimeJPG->setGeometry(QRect(10, 40, 93, 29));
        AnimePNG = new QPushButton(centralwidget);
        AnimePNG->setObjectName("AnimePNG");
        AnimePNG->setGeometry(QRect(110, 40, 93, 29));
        DefaultJPG = new QPushButton(centralwidget);
        DefaultJPG->setObjectName("DefaultJPG");
        DefaultJPG->setGeometry(QRect(210, 40, 93, 29));
        DefaultPNG = new QPushButton(centralwidget);
        DefaultPNG->setObjectName("DefaultPNG");
        DefaultPNG->setGeometry(QRect(310, 40, 93, 29));
        Better_Real_ESRGAN->setCentralWidget(centralwidget);
        menubar = new QMenuBar(Better_Real_ESRGAN);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 414, 26));
        menu = new QMenu(menubar);
        menu->setObjectName("menu");
        Better_Real_ESRGAN->setMenuBar(menubar);
        statusbar = new QStatusBar(Better_Real_ESRGAN);
        statusbar->setObjectName("statusbar");
        Better_Real_ESRGAN->setStatusBar(statusbar);

        menubar->addAction(menu->menuAction());
        menu->addAction(actionGithub);
        menu->addAction(actionGitee);
        menu->addAction(actionHelp);

        retranslateUi(Better_Real_ESRGAN);

        QMetaObject::connectSlotsByName(Better_Real_ESRGAN);
    } // setupUi

    void retranslateUi(QMainWindow *Better_Real_ESRGAN)
    {
        Better_Real_ESRGAN->setWindowTitle(QCoreApplication::translate("Better_Real_ESRGAN", "Better Real-ESRGAN", nullptr));
        actionGithub->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Github", nullptr));
#if QT_CONFIG(shortcut)
        actionGithub->setShortcut(QCoreApplication::translate("Better_Real_ESRGAN", "Ctrl+1", nullptr));
#endif // QT_CONFIG(shortcut)
        actionGitee->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Gitee", nullptr));
#if QT_CONFIG(shortcut)
        actionGitee->setShortcut(QCoreApplication::translate("Better_Real_ESRGAN", "Ctrl+2", nullptr));
#endif // QT_CONFIG(shortcut)
        actionHelp->setText(QCoreApplication::translate("Better_Real_ESRGAN", "Help", nullptr));
#if QT_CONFIG(shortcut)
        actionHelp->setShortcut(QCoreApplication::translate("Better_Real_ESRGAN", "Ctrl+3", nullptr));
#endif // QT_CONFIG(shortcut)
        Title->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\346\233\264\345\245\275\347\232\204Real-ESRGAN", nullptr));
        AnimeJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253JPG", nullptr));
        AnimePNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\345\212\250\346\274\253PNG", nullptr));
        DefaultJPG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244JPG", nullptr));
        DefaultPNG->setText(QCoreApplication::translate("Better_Real_ESRGAN", "\351\273\230\350\256\244PNG", nullptr));
        menu->setTitle(QCoreApplication::translate("Better_Real_ESRGAN", "\350\275\257\344\273\266\344\277\241\346\201\257", nullptr));
    } // retranslateUi

};

namespace Ui {
    class Better_Real_ESRGAN: public Ui_Better_Real_ESRGAN {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BETTER_REAL_ESRGAN_H
