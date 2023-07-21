using Microsoft.Win32;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Better_Real_ESRGAN
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SelectFileBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFile = openFileDialog.FileName;
                // 处理选择的文件
                ImagePathBox.Text = selectedFile;
            }
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

            string arguments = $"{inputArgument} {imagePath} {outputArgument} {outputPath} {modelArgument} {model}";

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

        private void UpdateBtn_Click(object sender, RoutedEventArgs e) // 启动更新程序
        {
            // 启动更新器
            // Process.Start("./Updater.exe");
            Process.Start(new ProcessStartInfo { FileName = "cmd.exe", Arguments = "/C start Updater.exe", CreateNoWindow = true, UseShellExecute = true });

            // 关闭本体
            Application.Current.Shutdown();
        }
    }
}
