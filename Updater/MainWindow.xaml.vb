Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions

Class MainWindow

    Inherits Window

    Dim childWindows As New List(Of Window)() '用于存储子窗口引用的列表

    Public Sub New()
        InitializeComponent()
        ' Me.ResizeMode = ResizeMode.NoResize ' 禁止最小化
        Me.ResizeMode = ResizeMode.CanMinimize ' 允许最小化，但有最大化按钮
        Me.WindowStartupLocation = WindowStartupLocation.CenterScreen ' 屏幕居中显示

        ' 本地版本检测
        LocalVersion.Text = GetLocalFileVersion("./Better Real-ESRGAN.exe")

        ' 线上版本检测
        GitHubVersion.Text = OnlineVersion("https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/version.txt")
        GiteeVersion.Text = OnlineVersion("https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/version.txt")

        ' 暂时禁用线上检测
        ' GitHubVersion.Text = "功能未制作"
        ' GiteeVersion.Text = "功能未制作"
    End Sub

    Private Function GetLocalFileVersion(filePath As String) As String
        If File.Exists(filePath) Then
            Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(filePath)
            Return versionInfo?.FileVersion
        Else
            Return "N/A" ' 文件未找到时返回一个默认的版本号，例如"N/A"
        End If
    End Function

    ' OnlineVersion 方法
    Private Function OnlineVersion(ByVal onlineFileUrl As String) As String
        Dim versionInfo As String = ""

        Try
            ' 创建 WebRequest 对象
            Dim request As WebRequest = WebRequest.Create(onlineFileUrl)

            ' 发起 GET 请求
            Using response As WebResponse = request.GetResponse()
                Using stream As Stream = response.GetResponseStream()
                    ' 保存文件到本地
                    Dim filePath As String = "temp.txt"
                    Using fileStream As New FileStream(filePath, FileMode.Create)
                        stream.CopyTo(fileStream)
                    End Using

                    ' 读取文件内容
                    Using reader As New StreamReader(filePath)
                        versionInfo = reader.ReadToEnd()
                    End Using

                    ' 删除临时文件
                    File.Delete(filePath)
                End Using
            End Using
        Catch ex As Exception
            ' 处理异常情况
            MessageBox.Show("无法获取文件：" & ex.Message)
        End Try

        Return versionInfo
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

    Private Sub AppUpdateBtn_Click(sender As Object, e As RoutedEventArgs) Handles AppUpdateBtn.Click
        Dim AppUpdate As New AppUpdate()
        childWindows.Add(AppUpdate)
        AppUpdate.Show()
    End Sub
End Class
