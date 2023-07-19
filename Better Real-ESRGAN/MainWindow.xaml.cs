using Microsoft.Win32;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Security.Cryptography;
using System;

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
            SetParameters();
        }

        private void SetParameters()
        {
            string imagePath = ImagePathBox.Text;
            string outputPath = OutputPathBox.Text;
            string model = SelectModel.Text;
        }
    }
}
