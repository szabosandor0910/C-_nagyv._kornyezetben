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
    /// Interaction logic for KonyvtarosWindow.xaml
    /// </summary>
    public partial class KonyvtarosWindow : Window
    {
        public KonyvtarosWindow()
        {
            InitializeComponent();
            UpdateBookListBox();
        }

        public KonyvtarosWindow(object value)
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

        private void Kolcsonzes_Click(object sender, RoutedEventArgs args)
        {
            var book = BookDataProvider.GetBook().ToList();
            List<Book> thisBooks = new List<Book>();
            if(!string.IsNullOrEmpty(Keres.Text))
            {
                foreach (var item in book)
                {
                    if (item.Title.Equals(Keres.Text))
                    {
                        thisBooks.Add(item);
                    }
                }
                BookListBox.ItemsSource = thisBooks;
            }else
            {
                BookListBox.ItemsSource = book;
            }
        }

        private void UpdateBookListBox()
        {
            var book = BookDataProvider.GetBook().ToList();
            foreach (var item in book)
            {
                if(item.Loaned == false)
                {
                    item.WhoLoan = "";
                    item.StartDate = DateTime.Now;
                    item.EndDate = DateTime.Now;
                }
            }
            BookListBox.ItemsSource = book;

        }
    }
}
