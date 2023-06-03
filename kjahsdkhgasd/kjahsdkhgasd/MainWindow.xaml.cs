using kjahsdkhgasd.Screens;
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

namespace kjahsdkhgasd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PRINCIPAL homeScreen = new PRINCIPAL();
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.NavigationService.Navigate(homeScreen);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Screem1());
        }
    }
}
