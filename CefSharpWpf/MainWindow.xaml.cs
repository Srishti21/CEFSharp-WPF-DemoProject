using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CefSharpWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void QuickScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            ChromiumWebBrowser.Address = "https://www.javatpoint.com/";
        }

        private void GoogleButton_Click(object sender, RoutedEventArgs e)
        {
            ChromiumWebBrowser2.Address = "https://google.co.in";
        }
    }
}
