using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;

namespace AdvancedMode.explanatory_document
{
    /// <summary>
    /// ThreadAllocation.xaml 的交互逻辑
    /// </summary>
    public partial class ThreadAllocation : Window
    {
        public ThreadAllocation()
        {
            InitializeComponent();

            // 在窗口加载时加载嵌入的HTML资源
            Loaded += ThreadAllocation_Loaded;
        }

        private void ThreadAllocation_Loaded(object sender, RoutedEventArgs e)
        {
            string currentDirectory = Environment.CurrentDirectory; // 获取当前目录
            string htmlFilePath = Path.Combine(currentDirectory, "docs", "ThreadAllocation.html"); // 拼接路径
            webBrowser.Navigate(new Uri(htmlFilePath)); // 加载HTML内容
        }
    }
}
