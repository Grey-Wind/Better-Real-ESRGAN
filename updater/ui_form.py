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
        updater.resize(271, 213)
        updater.setWindowTitle(u"updater")
        self.cpp = QPushButton(updater)
        self.cpp.setObjectName(u"cpp")
        self.cpp.setGeometry(QRect(10, 10, 120, 30))
        self.visual_basic = QPushButton(updater)
        self.visual_basic.setObjectName(u"visual_basic")
        self.visual_basic.setGeometry(QRect(140, 10, 120, 30))
        self.c_ = QPushButton(updater)
        self.c_.setObjectName(u"c_")
        self.c_.setGeometry(QRect(140, 90, 120, 30))
        self.c_sharp = QPushButton(updater)
        self.c_sharp.setObjectName(u"c_sharp")
        self.c_sharp.setGeometry(QRect(140, 50, 120, 30))
        self.c_sharp_net = QPushButton(updater)
        self.c_sharp_net.setObjectName(u"c_sharp_net")
        self.c_sharp_net.setGeometry(QRect(10, 50, 120, 30))
        self.rust = QPushButton(updater)
        self.rust.setObjectName(u"rust")
        self.rust.setGeometry(QRect(10, 90, 120, 30))
        self.java_maven = QPushButton(updater)
        self.java_maven.setObjectName(u"java_maven")
        self.java_maven.setGeometry(QRect(10, 130, 120, 30))
        self.java_intellij = QPushButton(updater)
        self.java_intellij.setObjectName(u"java_intellij")
        self.java_intellij.setGeometry(QRect(140, 130, 120, 30))
        self.java_gradle_groovy = QPushButton(updater)
        self.java_gradle_groovy.setObjectName(u"java_gradle_groovy")
        self.java_gradle_groovy.setGeometry(QRect(10, 170, 251, 30))

        self.retranslateUi(updater)

        QMetaObject.connectSlotsByName(updater)
    # setupUi

    def retranslateUi(self, updater):
        self.cpp.setText(QCoreApplication.translate("updater", u"C++", None))
        self.visual_basic.setText(QCoreApplication.translate("updater", u"Visual Basic", None))
        self.c_.setText(QCoreApplication.translate("updater", u"C", None))
        self.c_sharp.setText(QCoreApplication.translate("updater", u"C#", None))
        self.c_sharp_net.setText(QCoreApplication.translate("updater", u"C#.NET", None))
        self.rust.setText(QCoreApplication.translate("updater", u"Rust", None))
        self.java_maven.setText(QCoreApplication.translate("updater", u"Java-Maven", None))
        self.java_intellij.setText(QCoreApplication.translate("updater", u"Java-Intellij", None))
        self.java_gradle_groovy.setText(QCoreApplication.translate("updater", u"Java-Gradle-Groovy", None))
        pass
    # retranslateUi

