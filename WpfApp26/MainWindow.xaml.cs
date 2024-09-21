using System.Windows.Controls;
using System.Windows;
using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            previous_btn.Click += Previous_btn_Click;
            next_btn.Click += Next_btn_Click;
            datePicker_btn.Click += DatePicker_btn_Click;

            datePicker.SelectedDateChanged += DatePicker_SelectedDateChanged;
        }

        private void Previous_btn_Click(object sender, RoutedEventArgs e)
        {
            if (text1.IsVisible)
            {
                text1.Text = "<";
            }
        }

        private void Next_btn_Click(object sender, RoutedEventArgs e)
        {
            if (text1.IsVisible)
            {
                text1.Text = ">";
            }
        }

        private void DatePicker_btn_Click(object sender, RoutedEventArgs e)
        {
            if (datePicker.Visibility == Visibility.Visible)
            {
                datePicker.Visibility = Visibility.Hidden;
                text1.Visibility = Visibility.Visible;
                text2.Visibility = Visibility.Collapsed;
            }
            else
            {
                datePicker.Visibility = Visibility.Visible;
                text1.Visibility = Visibility.Collapsed;
                text2.Visibility = Visibility.Visible;
            }
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (text1.IsVisible)
            {
                text1.Text = datePicker.SelectedDate?.ToString("dddd");
            }
        }
    }
}
