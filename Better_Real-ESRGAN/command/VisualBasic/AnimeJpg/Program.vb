Imports System

Module Program
    Sub Main(args As String())
        Shell("cmd.exe /c realesrgan-ncnn-vulkan.exe -i input.jpg -o output.png -n realesrgan-x4plus-anime")
    End Sub
End Module
