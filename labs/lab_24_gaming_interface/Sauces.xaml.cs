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

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for Sauces.xaml
    /// </summary>
    public partial class Sauces : Page
    {
        public Sauces()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton01.IsChecked == true)
            {
                
            }
            else if (RadioButton02.IsChecked == true)
            {
                
            }
            else if (RadioButton03.IsChecked == true)
            {
                
            }
            else if (RadioButton04.IsChecked == true)
            {
                
            }
            else if (RadioButton05.IsChecked == true)
            {
                
            }
        }
    }
}
