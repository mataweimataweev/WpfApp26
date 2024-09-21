using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp7
{
    public partial class ChoisePAge : Page
    {
        public ChoisePAge()
        {
            InitializeComponent();
            save_btn.Click += SaveButton_Click;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> selectedItems = new List<string>();

            foreach (var item in ListBox.SelectedItems)
            {
                selectedItems.Add(item.ToString());
            }
            string message = "Выбранные данные: ";
            foreach (var selectedItem in selectedItems)
            {
                message += selectedItem + ", ";
            }
            MessageBox.Show(message.TrimEnd(' ', ','));
        }
    }
}
