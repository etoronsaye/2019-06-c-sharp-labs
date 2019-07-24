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

namespace Connect4V3
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public string selectedplayer1 = (App.Current as App).player1;
        public string selectedplayer2 = (App.Current as App).player2;

        public GameWindow()
        {
            InitializeComponent();
            this.DataContext = new Connect4Style();

            PlayerOne.Content = selectedplayer1;
            PlayerTwo.Content = selectedplayer2;
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void C7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int column = (int)button.GetValue(Grid.ColumnProperty);
                (DataContext as Connect4Style).PlayChips.Execute(column);
            }
        }
    }
}
