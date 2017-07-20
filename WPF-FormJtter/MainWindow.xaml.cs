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

namespace WPF_FormJtter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int i, j, k;
            for (i = 1; i <= 3; i++)
            {
                for (j = 1; j <= 10; j++)
                {
                    this.Top += 1;
                    this.Left += 1;
                    System.Threading.Thread.Sleep(3);
                }
                for (k = 1; k <= 10; k++)
                {
                    this.Top -= 1;
                    this.Left -= 1;
                    System.Threading.Thread.Sleep(3);
                }
            }
        }
    }
}
