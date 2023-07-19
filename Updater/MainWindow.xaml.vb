Imports System.ComponentModel

Class MainWindow

    Dim childWindows As New List(Of Window)() '用于存储子窗口引用的列表

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) ' 用于加载新窗口
        Dim Allupdate As New AllUpdate()
        childWindows.Add(Allupdate)
        Allupdate.Show()
    End Sub

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing ' 主窗口关闭事件，循环遍历子窗口列表并关闭每个子窗口
        For Each childWindow As Window In childWindows
            childWindow.Close()
        Next
    End Sub

End Class
