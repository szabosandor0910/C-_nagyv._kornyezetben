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

namespace WebApi_Client
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

        private void AddBook_Click(object sender, RoutedEventArgs args)
        {
            var window = new UjKonyv(null);
            window.Show();

        }
        private void Konyvtaros_Click(object sender, RoutedEventArgs args)
        {
            var window = new KonyvtarosWindow();
            window.Show();
           
        }
        private void Kolcsonzo_Click(object sender, RoutedEventArgs args)
        {
            var window = new KolcsonzoWindow();
            window.Show();

        }

    }
}
