Imports System.ComponentModel
Imports System.IO

Class MainWindow

    Inherits Window

    Dim childWindows As New List(Of Window)() '用于存储子窗口引用的列表

    Public Sub New()
        InitializeComponent()
        ' Me.ResizeMode = ResizeMode.NoResize ' 禁止最小化
        Me.ResizeMode = ResizeMode.CanMinimize ' 允许最小化，但有最大化按钮
        Me.WindowStartupLocation = WindowStartupLocation.CenterScreen ' 屏幕居中显示

        ' 版本检测
        LocalVersion.Text = GetLocalFileVersion("./Better Real-ESRGAN.exe")

        ' 暂时禁用检测
        GitHubVersion.Text = "功能未制作"
        GiteeVersion.Text = "功能未制作"
    End Sub

    Private Function GetLocalFileVersion(filePath As String) As String
        If File.Exists(filePath) Then
            Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(filePath)
            Return versionInfo?.FileVersion
        Else
            Return "N/A" ' 文件未找到时返回一个默认的版本号，例如"N/A"
        End If
    End Function

    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing ' 主窗口关闭事件，循环遍历子窗口列表并关闭每个子窗口
        For Each childWindow As Window In childWindows
            childWindow.Close()
        Next
    End Sub

    Private Sub AllUpdateBtn_Click(sender As Object, e As RoutedEventArgs) Handles AllUpdateBtn.Click
        Dim Allupdate As New AllUpdate()
        childWindows.Add(Allupdate)
        Allupdate.Show()
    End Sub
End Class
