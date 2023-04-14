using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Better_Real_ESRGAN
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void AnimeJPG_Click(object sender, RoutedEventArgs e)
        {
            Process app = new Process();
            app.StartInfo.FileName = "realesrgan-ncnn-vulkan.exe";
            app.StartInfo.Arguments = "-i input.jpg -o output.png -n realesrgan-x4plus-anime";
            app.Start();
        }

    }
}
