/********************************************************************************
** Form generated from reading UI file 'sponsor.ui'
**
** Created by: Qt User Interface Compiler version 6.4.2
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_SPONSOR_H
#define UI_SPONSOR_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QLabel>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_sponsor
{
public:
    QLabel *label;

    void setupUi(QWidget *sponsor)
    {
        if (sponsor->objectName().isEmpty())
            sponsor->setObjectName("sponsor");
        sponsor->resize(922, 451);
        label = new QLabel(sponsor);
        label->setObjectName("label");
        label->setGeometry(QRect(0, 0, 921, 461));

        retranslateUi(sponsor);

        QMetaObject::connectSlotsByName(sponsor);
    } // setupUi

    void retranslateUi(QWidget *sponsor)
    {
        sponsor->setWindowTitle(QCoreApplication::translate("sponsor", "\350\265\236\345\212\251\344\275\234\350\200\205", nullptr));
        label->setText(QCoreApplication::translate("sponsor", "<html><head/><body><p><img src=\":/image/image/sponsor.png\"/></p></body></html>", nullptr));
    } // retranslateUi

};

namespace Ui {
    class sponsor: public Ui_sponsor {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SPONSOR_H
