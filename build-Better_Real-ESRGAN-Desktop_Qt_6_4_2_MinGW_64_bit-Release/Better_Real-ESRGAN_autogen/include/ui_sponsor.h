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
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_sponsor
{
public:

    void setupUi(QWidget *sponsor)
    {
        if (sponsor->objectName().isEmpty())
            sponsor->setObjectName("sponsor");
        sponsor->resize(400, 300);

        retranslateUi(sponsor);

        QMetaObject::connectSlotsByName(sponsor);
    } // setupUi

    void retranslateUi(QWidget *sponsor)
    {
        sponsor->setWindowTitle(QCoreApplication::translate("sponsor", "Form", nullptr));
    } // retranslateUi

};

namespace Ui {
    class sponsor: public Ui_sponsor {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_SPONSOR_H
