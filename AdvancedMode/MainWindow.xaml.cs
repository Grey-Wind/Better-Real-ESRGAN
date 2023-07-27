using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using AdvancedMode.explanatory_document;
using System.Collections.Generic;

namespace AdvancedMode
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Window> childWindows = new List<Window>();

        public MainWindow()
        {
            InitializeComponent();

            Closing += MainWindow_Closing; // 绑定closing事件
        }

        private void SelectInputFolderBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedFolder = dialog.FileName;
                // 处理选择的文件夹
                ImagePathBox.Text = selectedFolder;
            }
        }

        private void SelectOutputFolderBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedFolder = dialog.FileName;
                // 处理选择的文件夹
                OutputPathBox.Text = selectedFolder;
            }
        }

        private void RunBtn_Click(object sender, RoutedEventArgs e)
        {
            // 设置命令参数
            string command = "realesrgan-ncnn-vulkan.exe";
            string inputArgument = "-i";
            string imagePath = ImagePathBox.Text;
            string outputArgument = "-o";
            string outputPath = OutputPathBox.Text;
            string modelArgument = "-n";
            string model = SelectModel.Text;
            string scaleArgument = "-s";
            string scale = Scale.Text;
            string gpu_id_Argument = "-g";
            string gpu_id = GPU_ID.Text;
            string tileSizeArgument = "-t";
            string tileSize = TileSize.Text;
            string threadAllocationArgument = "-j";
            string threadAllocation = ThreadAllocation.Text;
            string outputFormatArgument = "-f";
            string outputFormat = OutputFormat.Text;

            // 拼接参数
            string arguments = $"{inputArgument} {imagePath} {outputArgument} {outputPath} {modelArgument} {model} {scaleArgument} {scale} {gpu_id_Argument} {gpu_id} {tileSizeArgument} {tileSize} {threadAllocationArgument} {threadAllocation} {outputFormatArgument} {outputFormat}";

            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.FileName = command;
            processInfo.Arguments = arguments;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            processInfo.UseShellExecute = false;
            processInfo.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = processInfo;

            // 初始化 outputBuilder
            StringBuilder outputBuilder = new StringBuilder();

            process.OutputDataReceived += (eventSender, eventArgs) =>
            {
                if (!string.IsNullOrEmpty(eventArgs.Data))
                {
                    outputBuilder.AppendLine(eventArgs.Data);

                    Dispatcher.Invoke(() =>
                    {
                        CommandOutput.Text = outputBuilder.ToString();
                    });
                }
            };

            process.ErrorDataReceived += (eventSender, eventArgs) =>
            {
                if (!string.IsNullOrEmpty(eventArgs.Data))
                {
                    outputBuilder.AppendLine(eventArgs.Data);

                    Dispatcher.Invoke(() =>
                    {
                        CommandOutput.Text = outputBuilder.ToString();
                    });
                }
            };

            // 异步执行命令
            Task.Run(() =>
            {
                // 启动进程并开始异步读取输出和错误流
                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                // 等待进程退出
                process.WaitForExit();

                // 更新 CommandOutput TextBox
                Dispatcher.Invoke(() =>
                {
                    CommandOutput.Text = outputBuilder.ToString();
                    CommandOutput.ScrollToEnd(); // 将滚动条滚动到最下方
                });
            });
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Window window in childWindows)
            {
                window.Close();
            }

            // 清空子窗口列表
            childWindows.Clear();
        }

        private void TileSizeDoc_Click(object sender, RoutedEventArgs e)
        {
            // 创建另一个窗口的实例
            TileSize tileSizeWindow = new TileSize();

            // 将子窗口添加到列表中
            childWindows.Add(tileSizeWindow);

            // 显示窗口
            tileSizeWindow.Show();

            // 或者以对话框形式展示窗口
            // tileSizeWindow.ShowDialog();
        }

        private void ThreadAllocationDoc_Click(object sender, RoutedEventArgs e)
        {
            // 创建另一个窗口的实例
            ThreadAllocation threadAllocationWindow = new ThreadAllocation();

            // 将子窗口添加到列表中
            childWindows.Add(threadAllocationWindow);

            // 显示窗口
            threadAllocationWindow.Show();;
        }
    }
}
