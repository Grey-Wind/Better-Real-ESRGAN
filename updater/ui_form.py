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
        self.cpp = QPushButton(updater)
        self.cpp.setObjectName(u"cpp")
        self.cpp.setGeometry(QRect(10, 10, 120, 30))
        self.visual_basic = QPushButton(updater)
        self.visual_basic.setObjectName(u"visual_basic")
        self.visual_basic.setGeometry(QRect(140, 10, 120, 30))

        self.retranslateUi(updater)

        QMetaObject.connectSlotsByName(updater)
    # setupUi

    def retranslateUi(self, updater):
        updater.setWindowTitle(QCoreApplication.translate("updater", u"updater", None))
        self.cpp.setText(QCoreApplication.translate("updater", u"C++", None))
        self.visual_basic.setText(QCoreApplication.translate("updater", u"Visual Basic", None))
    # retranslateUi

