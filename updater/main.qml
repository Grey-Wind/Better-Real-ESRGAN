import QtQuick 2.12
import QtQuick.Window 2.12
import QtQuick.Controls 6.3

Window {
    width: 640
    height: 480
    visible: true
    title: qsTr("Update/Download")

    Button {
        id: cpp
        x: 6
        y: 7
        width: 214
        height: 39
        text: qsTr("C++子程序")
        font.pointSize: 17
        display: AbstractButton.TextOnly
    }
}
