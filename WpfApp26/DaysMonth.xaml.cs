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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для DaysMonth.xaml
    /// </summary>
    public partial class DaysMonth : Window
    {
        public string Day { get; set; }
        public string IconSource { get; set; }

        public DaysMonth()
        {
            InitializeComponent();
            DataContext = this;

            Day = "Monday";
            IconSource = "Images/icon.png";
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}