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

namespace EX_7._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random r = new Random();
        int t = r.Next(0, 100);
       // int PC;
        public MainWindow()
        {
            InitializeComponent();
         
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            var d = Convert.ToInt32(UserTry.Text);
            int PC = r.Next(t-10, t+10);
            Chek(d);
            ChekPC(PC);
        }

        private void Chek(int d)
        {
            if (d == t)
            {
                UserStep.Content = "Угадал!";
            }
            else if (d > t)
            {
                UserStep.Content = "Слишком большое";
            }
            else
            {
                UserStep.Content = "Слишком маленькое";
            }
        }
        private void ChekPC(int PC)
        {
            if (PC == t)
            {
                PCstep.Content = "Угадал!";
                MessageBox.Show("Компьютер выйграл ха-ха");
            }
            else if (PC > t)
            {
                PCstep.Content = "Слишком большое";
            }
            else
            {
                PCstep.Content = "Слишком маленькое";
            }
        }
    }
}
