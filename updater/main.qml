import QtQuick 2.12
import QtQuick.Window 2.12
import QtQuick.Controls 6.3

Window {
    width: 640
    height: 480
    visible: true
    title: qsTr("Update/Download")

    Text {
        id: text1
        x: 114
        y: 70
        text: qsTr("Text")
        font.pixelSize: 12
    }
}
