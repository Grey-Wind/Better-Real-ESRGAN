﻿Imports System.IO
Imports System.Windows.Shell
Imports System.Net.Http
Imports FileDownloader

Public Class AdvancedMode

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

    Private Sub CloseBtn_Click(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

    Private Sub GitHubBtnClick(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://github.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
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

    Private Sub GiteeBtn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://gitee.com/sunrise-studio/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
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

    Private Sub BlogBtn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://grey-wind.github.io/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
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

    Private Sub DownloadSiteBtn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://sunrise-studio.gitee.io/file/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
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

    Private Sub Mirror1Btn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://hub.ggo.icu/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
        }

        Dim url As String = "https://hub.ggo.icu/"

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
                Dim result As MessageBoxResult = MessageBox.Show("无法访问hub.ggo.icu，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

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

    Private Sub Mirror2Btn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://hub.njuu.cf/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
        }

        Dim url As String = "https://hub.njuu.cf/"

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
                Dim result As MessageBoxResult = MessageBox.Show("无法访问hub.njuu.cf，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

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

    Private Sub Mirror3Btn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://hub.yzuu.cf/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
        }

        Dim url As String = "https://hub.yzuu.cf/"

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
                Dim result As MessageBoxResult = MessageBox.Show("无法访问hub.yzuu.cf，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

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

    Private Sub Mirror4Btn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://hub.nuaa.cf/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
        }

        Dim url As String = "https://hub.nuaa.cf/"

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
                Dim result As MessageBoxResult = MessageBox.Show("无法访问hub.nuaa.cf，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

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

    Private Sub Mirror5Btn_Click(sender As Object, e As RoutedEventArgs)
        ' 下载
        Dim downloader As New Downloader()

        Dim urls As String() = {
            "https://kgithub.com/Grey-Wind/File/raw/main/Better.Real-ESRGAN/AdvancedMode.exe" ' 软件本体
        }

        Dim savePaths As String() = {
            "./AdvancedMode.exe" ' 软件本体
        }

        Dim url As String = "https://kgithub.com/"

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
                Dim result As MessageBoxResult = MessageBox.Show("无法访问kgithub.com，请更换下载方式或启动加速器" & vbCrLf & "点击是将继续下载，但是不保证正常运行" & vbCrLf & "点击否将取消下载", "警告", MessageBoxButton.YesNo)

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