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

namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (RadioButton01.IsChecked == true)
            {
                Rigatoni.Visibility = Visibility.Visible;
                Penne.Visibility = Visibility.Hidden;
                Linguine.Visibility = Visibility.Hidden;
                Fettuccine.Visibility = Visibility.Hidden;
                Tortellini.Visibility = Visibility.Hidden;
                Button01.Visibility = Visibility.Visible;
            }
            else if (RadioButton02.IsChecked == true)
            {
                Penne.Visibility = Visibility.Visible;
                Rigatoni.Visibility = Visibility.Hidden;
                Linguine.Visibility = Visibility.Hidden;
                Fettuccine.Visibility = Visibility.Hidden;
                Tortellini.Visibility = Visibility.Hidden;
                Button01.Visibility = Visibility.Visible;
            }
            else if (RadioButton03.IsChecked == true)
            {
                Linguine.Visibility = Visibility.Visible;
                Rigatoni.Visibility = Visibility.Hidden;
                Penne.Visibility = Visibility.Hidden;
                Fettuccine.Visibility = Visibility.Hidden;
                Tortellini.Visibility = Visibility.Hidden;
                Button01.Visibility = Visibility.Visible;
            }
            else if(RadioButton04.IsChecked == true)
            {
                Fettuccine.Visibility = Visibility.Visible;
                Rigatoni.Visibility = Visibility.Hidden;
                Penne.Visibility = Visibility.Hidden;
                Linguine.Visibility = Visibility.Hidden;
                Tortellini.Visibility = Visibility.Hidden;
                Button01.Visibility = Visibility.Visible;
            }
            else if(RadioButton05.IsChecked == true)
            {
                Tortellini.Visibility = Visibility.Visible;
                Rigatoni.Visibility = Visibility.Hidden;
                Penne.Visibility = Visibility.Hidden;
                Linguine.Visibility = Visibility.Hidden;
                Fettuccine.Visibility = Visibility.Hidden;
                Button01.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sauces sauce = new Sauces();
            this.Content = sauce;
        }
    }
}
