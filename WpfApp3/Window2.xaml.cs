using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();

        }

        private void close01(object sender, RoutedEventArgs e)
        {
            Window1 objWindow1 = new Window1();
            objWindow1.Show();
            this.Close();
        }

        private void ieopen(object sender, RoutedEventArgs e)
        {
            Window3 objWindow3 = new Window3();
            objWindow3.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 objWindow1 = new Window1();
            objWindow1.Show();
            Process.Start("C:/mspaintold.exe");
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 objWindow4 = new Window4();
            objWindow4.Show();
            this.Close();
        }
    }
    }

