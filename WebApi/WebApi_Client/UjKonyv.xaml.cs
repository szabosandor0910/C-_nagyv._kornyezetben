﻿using System;
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
    /// Interaction logic for UjKonyv.xaml
    /// </summary>
    public partial class UjKonyv : Window
    {
        private readonly Book _book;
        public UjKonyv(Book book)
        {
            InitializeComponent();

            if (book != null)
            {
                _book = book;

                CimTextBox.Text = _book.Title;
                CheckBox.IsChecked = _book.Loaned;
                KolcsonozteTextBox.Text = _book.WhoLoan;
                KezdoDatePicker.SelectedDate = _book.StartDate;
                VegeDatePicker.SelectedDate = _book.EndDate;

                CreateButton.Visibility = Visibility.Collapsed;
                UpdateButton.Visibility = Visibility.Visible;
                DeleteButton.Visibility = Visibility.Visible;
            }
            else 
            {
                _book = new Book();

                CreateButton.Visibility = Visibility.Visible;
                UpdateButton.Visibility = Visibility.Collapsed;
                DeleteButton.Visibility = Visibility.Collapsed;
            }

           
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {

            if (ValidateBook())
            {
                _book.Title = CimTextBox.Text;
                _book.Loaned = (bool)CheckBox.IsChecked;
                _book.WhoLoan = KolcsonozteTextBox.Text;
                _book.StartDate = KezdoDatePicker.SelectedDate.Value;
                _book.EndDate = VegeDatePicker.SelectedDate.Value;

                BookDataProvider.CreateBook(_book);

                DialogResult = true;
                Close();
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateBook())
            {
                _book.Title = CimTextBox.Text;
                _book.Loaned = (bool)CheckBox.IsChecked;
                _book.WhoLoan = KolcsonozteTextBox.Text;
                _book.StartDate = KezdoDatePicker.SelectedDate.Value;
                _book.EndDate = VegeDatePicker.SelectedDate.Value;

                BookDataProvider.UpdateBook(_book);

                DialogResult = true;
                Close();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete?", "Question", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                BookDataProvider.DeleteBook(_book.Id);

                DialogResult = true;
                Close();
            }
        }
        private bool ValidateBook()
        {
            if (string.IsNullOrEmpty(CimTextBox.Text))
            {
                MessageBox.Show("A cím nem lehet üres!");
                return false;
            }

            if (string.IsNullOrEmpty(KolcsonozteTextBox.Text))
            {
                MessageBox.Show("A kölcsönző nem lehet üres!");
                return false;
            }

            if (!KezdoDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("A kezdő dátum nem lehet üres!");
                return false;
            }

            if (!VegeDatePicker.SelectedDate.HasValue)
            {
                MessageBox.Show("A vége dátum nem lehet üres!");
                return false;
            }

            return true;
        }



    }
}
