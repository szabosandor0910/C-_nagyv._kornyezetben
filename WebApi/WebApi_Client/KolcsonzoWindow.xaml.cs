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
using System.Windows.Shapes;
using WebApi_Client.DataProviders;
using WebApi_Common.Models;

namespace WebApi_Client
{
    /// <summary>
    /// Interaction logic for KolcsonzoWindow.xaml
    /// </summary>
    public partial class KolcsonzoWindow : Window
    {
        public KolcsonzoWindow()
        {
            InitializeComponent();
            UpdateBookListBox();
        }

        public KolcsonzoWindow(object value)
        {
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var selectedBook = BookListBox.SelectedItem as Book;

            if (selectedBook != null)
            {
                var window = new UjKonyv(selectedBook);
                if (window.ShowDialog() ?? false)
                {
                    UpdateBookListBox();
                }

                BookListBox.UnselectAll();
            }

        }

        private void OwnBook_Click(object sender, RoutedEventArgs args)
        {
            var window = new SajatKonyvek();
            window.Show();

        }

        private void UpdateBookListBox()
        {
            var book = BookDataProvider.GetBook().ToList();
            List<Book> Availablebooks = new List<Book>();
            foreach (var item in book)
            {
                if(!item.Loaned)
                {
                    Availablebooks.Add(item);
                }
            }
            BookListBox.ItemsSource = Availablebooks;

        }
    }
}
