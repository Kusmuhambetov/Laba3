using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        Random rnd = new Random();
        private void Dopusk_Click(object sender, RoutedEventArgs e)
        {

            int y = rnd.Next(0, 2);
            if (y == 0)
            {
                Class1 usr = new Class1();
                DateTime selectedDate = Calendar.SelectedDate ?? DateTime.MinValue;
                usr.User(Name.Text, SubName.Text, selectedDate);
                MessageBox.Show(usr.Show());
            }
            else
            {
                MessageBox.Show("ОТЧИСЛЕН!!!!");
            }
        }
    }
}
