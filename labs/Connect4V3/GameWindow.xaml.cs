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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                int column = (int)button.GetValue(Grid.ColumnProperty);
                (DataContext as Connect4Style).PlayChips.Execute(column);
                UpdateScores();
            }
        }

        int p1Count = 0;
        int p2Count = 0;
        
        public void UpdateScores()
        {
            if (BurlyPlayerWinner.IsEnabled == true && Connect4Style.CanIncreaseBurlyScore == true)
            {
                p1Count++;
                PlayerOneScore.Text = p1Count.ToString();
            }

            if (GrayPlayerWinner.IsInitialized == true && Connect4Style.CanIncreaseGrayScore == true)
            {
                p2Count++;
                PlayerTwoScore.Text = p2Count.ToString();
            }
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Connect4Style();
        }
    }
}
