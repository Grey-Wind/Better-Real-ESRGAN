# -*- coding: utf-8 -*-

################################################################################
## Form generated from reading UI file 'form.ui'
##
## Created by: Qt User Interface Compiler version 6.4.2
##
## WARNING! All changes made in this file will be lost when recompiling UI file!
################################################################################

from PySide6.QtCore import (QCoreApplication, QDate, QDateTime, QLocale,
    QMetaObject, QObject, QPoint, QRect,
    QSize, QTime, QUrl, Qt)
from PySide6.QtGui import (QBrush, QColor, QConicalGradient, QCursor,
    QFont, QFontDatabase, QGradient, QIcon,
    QImage, QKeySequence, QLinearGradient, QPainter,
    QPalette, QPixmap, QRadialGradient, QTransform)
from PySide6.QtWidgets import (QApplication, QPushButton, QSizePolicy, QWidget)

class Ui_updater(object):
    def setupUi(self, updater):
        if not updater.objectName():
            updater.setObjectName(u"updater")
        updater.resize(800, 600)
        self.pushButton = QPushButton(updater)
        self.pushButton.setObjectName(u"pushButton")
        self.pushButton.setGeometry(QRect(80, 70, 93, 29))

        self.retranslateUi(updater)

        QMetaObject.connectSlotsByName(updater)
    # setupUi

    def retranslateUi(self, updater):
        updater.setWindowTitle(QCoreApplication.translate("updater", u"updater", None))
        self.pushButton.setText(QCoreApplication.translate("updater", u"PushButton", None))
    # retranslateUi

