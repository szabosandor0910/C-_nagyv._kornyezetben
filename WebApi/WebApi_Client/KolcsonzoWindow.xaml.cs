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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            
        }

        private void UpdateBookListBox()
        {
            var book = BookDataProvider.GetBook().ToList();
            BookListBox.ItemsSource = book;

        }

        private void Kereses_Click(object sender, RoutedEventArgs args)
        {
            if (!string.IsNullOrEmpty(NevTextBox.Text))
            {
                var book = BookDataProvider.GetBook().ToList();
                List<Book> thisBooks = new List<Book>();
                
                    foreach (var item in book)
                    {
                        if (item.WhoLoan.Equals(NevTextBox.Text))
                        {
                            thisBooks.Add(item);
                        }
                    }
              BookListBox.ItemsSource = thisBooks;
                
            }
        }

        }
   
}
