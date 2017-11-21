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

namespace FirstWPF
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvwMyList.Items.Add("5");
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lvwMyList.Items.Add("10");
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lvwMyList.Items.Add("15");
        }
        private void lblResetButton_Click(object sender, RoutedEventArgs e)
        {
            lvwMyList.Items.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int total = 0;
            foreach (string Li in lvwMyList.Items) 

            {
                total += Convert.ToInt16(Li);
            }
            lvwTotaal.Items.Add(total);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lvwTotaal.Items.Clear();
        }
    }
}
