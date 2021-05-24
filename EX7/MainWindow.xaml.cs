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

namespace EX7
{
    public partial class MainWindow : Window
    {
        Random r;
        int n;
        Stack<string> history = new Stack<string>();
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            btnCommand1.Content = "+1";
            btnCommand2.Content = "x2";
            btnReset.Content = "Сброс";
            lblNumber.Content = "0";
            this.Title = "Удвоитель";
            r = new Random();
        }
        int count = 1;
        private void btnCommand1_Click(object sender, RoutedEventArgs e)
        {
            Counter.Content = count++;
            var t = Convert.ToInt32(lblNumber.Content);
            history.Push(t.ToString());
            if (t != n)
            {
                t += 1;  
            lblNumber.Content = t.ToString();
            }
            else
            {
                MessageBox.Show("Победа");
                Reset();
            }
        }

        private void btnCommand2_Click(object sender, RoutedEventArgs e)
        {
            Counter.Content = count++;
            var t = Convert.ToInt32(lblNumber.Content);
            history.Push(t.ToString());
            if (t != n)
            {
                t *= 2;
                lblNumber.Content = t.ToString();
            }
            else
            {
                MessageBox.Show("Победа");
                Reset();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            lblNumber.Content = "0";
            Counter.Content = 0;
            count = 1;
            GameNumber.Content = "";
        }
        private void NewGameClik(object sender, RoutedEventArgs e)
        {
            double k = 0;
            n = r.Next(50, 100);
            if ( n %2 == 0 )
            {
                k = n / 2; 
            }
            else
            {
               k = 1 + n/2;  //это не минимальное число, разобраться!!
            }
            GameNumber.Content = "Угадать число: " + n.ToString() + "\nЗа "+ k + " ходов";
        }
        private void UnDo_Click(object sender, RoutedEventArgs e)
        {
            lblNumber.Content = history.Pop();
        }
    }
}