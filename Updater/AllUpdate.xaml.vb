Imports System.IO
Imports System.Windows.Shell
Imports System.Windows.Input
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

    Private Sub GitHubBtnClick(sender As Object, e As RoutedEventArgs) Handles GitHubBtn.Click

        ' 创建目录
        Directory.CreateDirectory("./models")
        Directory.CreateDirectory("./License")

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

        downloader.DownloadFiles(urls, savePaths)
    End Sub

    Private Sub GiteeBtn_Click(sender As Object, e As RoutedEventArgs) Handles GiteeBtn.Click
        ' 创建目录
        Directory.CreateDirectory("./models")
        Directory.CreateDirectory("./License")

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

        downloader.DownloadFiles(urls, savePaths)
    End Sub

    Private Sub BlogBtn_Click(sender As Object, e As RoutedEventArgs) Handles BlogBtn.Click
        ' 创建目录
        Directory.CreateDirectory("./models")
        Directory.CreateDirectory("./License")

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

        downloader.DownloadFiles(urls, savePaths)
    End Sub

    Private Sub DownloadSiteBtn_Click(sender As Object, e As RoutedEventArgs) Handles DownloadSiteBtn.Click
        ' 创建目录
        Directory.CreateDirectory("./models")
        Directory.CreateDirectory("./License")

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

        downloader.DownloadFiles(urls, savePaths)
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As RoutedEventArgs) Handles CloseBtn.Click
        Close()
    End Sub
End Class
