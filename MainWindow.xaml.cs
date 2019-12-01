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

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 290;
            this.Height= 170;
        }
       
        public void border1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
              if (e.ClickCount == 2)
       MessageBox.Show("Double Click");
        }
        public void button_Click1 (object sender, RoutedEventArgs past)
        {
             MessageBox.Show("Mein Tischchen Nummer 123");
        }
        
        public void button_Click2 (object sender, RoutedEventArgs past)
        {
             MessageBox.Show("Mein Tischchen Nummer 456");
        }
        public void button_Click3 (object sender, RoutedEventArgs past)
        {
            MessageBox.Show("Mein Tischchen Nummer 789");
        }
    }
}
