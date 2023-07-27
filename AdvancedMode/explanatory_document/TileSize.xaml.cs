using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows;

namespace AdvancedMode.explanatory_document
{
    /// <summary>
    /// TileSize.xaml 的交互逻辑
    /// </summary>
    public partial class TileSize : Window
    {
        public TileSize()
        {
            InitializeComponent();

            // 在窗口加载时加载嵌入的HTML资源
            Loaded += TileSize_Loaded;
        }

        private void TileSize_Loaded(object sender, RoutedEventArgs e)
        {
            // 从嵌入资源中读取HTML内容
            //string htmlContent;
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //using (StreamReader streamReader = new StreamReader(assembly.GetManifestResourceStream("AdvancedMode.TileSize.html")))
            //{
            //    htmlContent = streamReader.ReadToEnd();
            //}
            // 加载HTML内容
            //webBrowser.NavigateToString(htmlContent);

            string currentDirectory = Environment.CurrentDirectory;
            string htmlFilePath = Path.Combine(currentDirectory, "docs", "TileSize.html");
            webBrowser.Navigate(new Uri(htmlFilePath));
        }
    }
}
