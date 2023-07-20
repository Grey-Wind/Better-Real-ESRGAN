Imports System.IO
Imports System.Windows.Shell
Imports System.Net.Http
Imports FileDownloader

Public Class AllUpdate

    Inherits Window

    Public Sub New()
        InitializeComponent()
        SetWindowStyle()
        EnableWindowDrag()
    End Sub

    Private Sub SetWindowStyle() ' 禁用窗口标题栏
        Dim chrome As New WindowChrome With {
            .CaptionHeight = 0,
            .ResizeBorderThickness = New Thickness(1),
            .UseAeroCaptionButtons = False
        }
        WindowChrome.SetWindowChrome(Me, chrome)
        WindowChrome.SetIsHitTestVisibleInChrome(Me, True)
    End Sub

    Private Sub EnableWindowDrag() ' 允许窗口拖动
        AddHandler MouseLeftButtonDown, Sub(sender, e)
                                            If e.ButtonState = MouseButtonState.Pressed Then
                                                DragMove()
                                            End If
                                        End Sub
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As RoutedEventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub GitHubBtnClick(sender As Object, e As RoutedEventArgs) Handles GitHubBtn.Click

        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Better%20Real-ESRGAN.exe", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/realesrgan-ncnn-vulkan.exe", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/vcomp140.dll", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/vcomp140d.dll", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/LICENSE", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_EN.txt", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_CN.txt", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/" ' 模型文件
        }

        Dim savePaths As String() = {
            "./Better.Real-ESRGAN.exe", ' 软件本体
            "./Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "./Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "./realesrgan-ncnn-vulkan.exe", ' 启动器
            "./vcomp140.dll", ' 启动器
            "./vcomp140d.dll", ' 启动器
            "./License/LICENSE", ' 版权信息
            "./License/Better.Real-ESRGAN_EN.txt", ' 版权信息
            "./License/Better.Real-ESRGAN_CN.txt", ' 版权信息 
            "./models/realesr-animevideov3-x2.bin", ' 模型文件
            "./models/realesr-animevideov3-x2.param", ' 模型文件
            "./models/realesr-animevideov3-x3.bin", ' 模型文件
            "./models/realesr-animevideov3-x3.param", ' 模型文件
            "./models/realesr-animevideov3-x4.bin", ' 模型文件
            "./models/realesr-animevideov3-x4.param", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "./models/realesrgan-x4plus.bin", ' 模型文件
            "./models/realesrgan-x4plus.param", ' 模型文件
            "./models/realesrgan-x4plus-anime.bin", ' 模型文件
            "./models/realesrgan-x4plus-anime.param", ' 模型文件
            "./models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "./models/realesr-general-x4v3.pth" ' 模型文件
        }

        Dim url As String = "https://github.com/"

        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(url).Result

            If response.IsSuccessStatusCode Then ' 正常访问代码
                ' 创建目录
                Directory.CreateDirectory("./models")
                Directory.CreateDirectory("./License")

                ' 开始下载
                downloader.DownloadFiles(urls, savePaths)
            Else
                ' 弹出提示框等待响应
                Dim result As MessageBoxResult = MessageBox.Show("无法访问GitHub，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

                If result = MessageBoxResult.Yes Then
                    ' 创建目录
                    Directory.CreateDirectory("./models")
                    Directory.CreateDirectory("./License")

                    ' 开始下载
                    downloader.DownloadFiles(urls, savePaths)
                Else
                    ' 点击No后的代码
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GiteeBtn_Click(sender As Object, e As RoutedEventArgs) Handles GiteeBtn.Click

        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/Better%20Real-ESRGAN.exe", ' 软件本体
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/realesrgan-ncnn-vulkan.exe", ' 启动器
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/vcomp140.dll", ' 启动器
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/vcomp140d.dll", ' 启动器
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/License/LICENSE", ' 版权信息
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_EN.txt", ' 版权信息
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_CN.txt", ' 版权信息
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.bin", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.param", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.bin", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.param", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.bin", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.param", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.bin", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.param", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.bin", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.param", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/models/" ' 模型文件
        }

        Dim savePaths As String() = {
            "./Better.Real-ESRGAN.exe", ' 软件本体
            "./Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "./Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "./realesrgan-ncnn-vulkan.exe", ' 启动器
            "./vcomp140.dll", ' 启动器
            "./vcomp140d.dll", ' 启动器
            "./License/LICENSE", ' 版权信息
            "./License/Better.Real-ESRGAN_EN.txt", ' 版权信息
            "./License/Better.Real-ESRGAN_CN.txt", ' 版权信息 
            "./models/realesr-animevideov3-x2.bin", ' 模型文件
            "./models/realesr-animevideov3-x2.param", ' 模型文件
            "./models/realesr-animevideov3-x3.bin", ' 模型文件
            "./models/realesr-animevideov3-x3.param", ' 模型文件
            "./models/realesr-animevideov3-x4.bin", ' 模型文件
            "./models/realesr-animevideov3-x4.param", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "./models/realesrgan-x4plus.bin", ' 模型文件
            "./models/realesrgan-x4plus.param", ' 模型文件
            "./models/realesrgan-x4plus-anime.bin", ' 模型文件
            "./models/realesrgan-x4plus-anime.param", ' 模型文件
            "./models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "./models/realesr-general-x4v3.pth" ' 模型文件
        }

        Dim url As String = "https://gitee.com/"

        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(url).Result

            If response.IsSuccessStatusCode Then ' 正常访问代码
                ' 创建目录
                Directory.CreateDirectory("./models")
                Directory.CreateDirectory("./License")

                ' 开始下载
                downloader.DownloadFiles(urls, savePaths)
            Else
                ' 弹出提示框等待响应
                Dim result As MessageBoxResult = MessageBox.Show("无法访问Gitee，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

                If result = MessageBoxResult.Yes Then
                    ' 创建目录
                    Directory.CreateDirectory("./models")
                    Directory.CreateDirectory("./License")

                    ' 开始下载
                    downloader.DownloadFiles(urls, savePaths)
                Else
                    ' 点击No后的代码
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BlogBtn_Click(sender As Object, e As RoutedEventArgs) Handles BlogBtn.Click

        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/Better%20Real-ESRGAN.exe", ' 软件本体
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/realesrgan-ncnn-vulkan.exe", ' 启动器
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/vcomp140.dll", ' 启动器
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/vcomp140d.dll", ' 启动器
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/License/LICENSE", ' 版权信息
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_EN.txt", ' 版权信息
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_CN.txt", ' 版权信息
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.bin", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.param", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.bin", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.param", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.bin", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.param", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.bin", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.param", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.bin", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.param", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/models/" ' 模型文件
        }

        Dim savePaths As String() = {
            "./Better.Real-ESRGAN.exe", ' 软件本体
            "./Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "./Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "./realesrgan-ncnn-vulkan.exe", ' 启动器
            "./vcomp140.dll", ' 启动器
            "./vcomp140d.dll", ' 启动器
            "./License/LICENSE", ' 版权信息
            "./License/Better.Real-ESRGAN_EN.txt", ' 版权信息
            "./License/Better.Real-ESRGAN_CN.txt", ' 版权信息 
            "./models/realesr-animevideov3-x2.bin", ' 模型文件
            "./models/realesr-animevideov3-x2.param", ' 模型文件
            "./models/realesr-animevideov3-x3.bin", ' 模型文件
            "./models/realesr-animevideov3-x3.param", ' 模型文件
            "./models/realesr-animevideov3-x4.bin", ' 模型文件
            "./models/realesr-animevideov3-x4.param", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "./models/realesrgan-x4plus.bin", ' 模型文件
            "./models/realesrgan-x4plus.param", ' 模型文件
            "./models/realesrgan-x4plus-anime.bin", ' 模型文件
            "./models/realesrgan-x4plus-anime.param", ' 模型文件
            "./models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "./models/realesr-general-x4v3.pth" ' 模型文件
        }

        Dim url As String = "https://grey-wind.github.io/"

        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(url).Result

            If response.IsSuccessStatusCode Then ' 正常访问代码
                ' 创建目录
                Directory.CreateDirectory("./models")
                Directory.CreateDirectory("./License")

                ' 开始下载
                downloader.DownloadFiles(urls, savePaths)
            Else
                ' 弹出提示框等待响应
                Dim result As MessageBoxResult = MessageBox.Show("无法访问作者的博客，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

                If result = MessageBoxResult.Yes Then
                    ' 创建目录
                    Directory.CreateDirectory("./models")
                    Directory.CreateDirectory("./License")

                    ' 开始下载
                    downloader.DownloadFiles(urls, savePaths)
                Else
                    ' 点击No后的代码
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DownloadSiteBtn_Click(sender As Object, e As RoutedEventArgs) Handles DownloadSiteBtn.Click

        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Better%20Real-ESRGAN.exe", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/realesrgan-ncnn-vulkan.exe", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/vcomp140.dll", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/vcomp140d.dll", ' 启动器
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/LICENSE", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_EN.txt", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/License/Better%20Real-ESRGAN_CN.txt", ' 版权信息
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x2.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x3.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-animevideov3-x4.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.bin", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesrgan-x4plus-anime.param", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/models/" ' 模型文件
        }

        Dim savePaths As String() = {
            "./Better.Real-ESRGAN.exe", ' 软件本体
            "./Microsoft.WindowsAPICodePack.Shell.dll", ' 软件本体
            "./Microsoft.WindowsAPICodePack.dll", ' 软件本体
            "./realesrgan-ncnn-vulkan.exe", ' 启动器
            "./vcomp140.dll", ' 启动器
            "./vcomp140d.dll", ' 启动器
            "./License/LICENSE", ' 版权信息
            "./License/Better.Real-ESRGAN_EN.txt", ' 版权信息
            "./License/Better.Real-ESRGAN_CN.txt", ' 版权信息 
            "./models/realesr-animevideov3-x2.bin", ' 模型文件
            "./models/realesr-animevideov3-x2.param", ' 模型文件
            "./models/realesr-animevideov3-x3.bin", ' 模型文件
            "./models/realesr-animevideov3-x3.param", ' 模型文件
            "./models/realesr-animevideov3-x4.bin", ' 模型文件
            "./models/realesr-animevideov3-x4.param", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx2.pth", ' 模型文件
            "./models/RealESRGANv2-animevideo-xsx4.pth", ' 模型文件
            "./models/realesrgan-x4plus.bin", ' 模型文件
            "./models/realesrgan-x4plus.param", ' 模型文件
            "./models/realesrgan-x4plus-anime.bin", ' 模型文件
            "./models/realesrgan-x4plus-anime.param", ' 模型文件
            "./models/realesr-general-wdn-x4v3.pth", ' 模型文件
            "./models/realesr-general-x4v3.pth" ' 模型文件
        }

        Dim url As String = "https://sunrise-studio.gitee.io/"

        Try
            Dim client As New HttpClient()
            Dim response As HttpResponseMessage = client.GetAsync(url).Result

            If response.IsSuccessStatusCode Then ' 正常访问代码
                ' 创建目录
                Directory.CreateDirectory("./models")
                Directory.CreateDirectory("./License")

                ' 开始下载
                downloader.DownloadFiles(urls, savePaths)
            Else
                ' 弹出提示框等待响应
                Dim result As MessageBoxResult = MessageBox.Show("无法访问官方下载站，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

                If result = MessageBoxResult.Yes Then
                    ' 创建目录
                    Directory.CreateDirectory("./models")
                    Directory.CreateDirectory("./License")

                    ' 开始下载
                    downloader.DownloadFiles(urls, savePaths)
                Else
                    ' 点击No后的代码
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class