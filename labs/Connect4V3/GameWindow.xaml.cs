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
        static List<Player> Scores = new List<Player>();
        //Player player;

        public GameWindow()
        {
            InitializeComponent();
            Initialise();
            this.DataContext = new Connect4Style();

            PlayerOne.Content = selectedplayer1;
            PlayerTwo.Content = selectedplayer2;
        }
        void Initialise()
        {
            using (var db = new Connect4Entities1())
            {
                Scores = db.Players.ToList();
                PlayerOneScore.Text = Scores[0].Wins.ToString();
                PlayerTwoScore.Text = Scores[0].Wins.ToString();
            }
        }

        private bool turn = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                int column = (int)button.GetValue(Grid.ColumnProperty);
                (DataContext as Connect4Style).PlayChips.Execute(column);
                if (turn)
                {
                    P1.Visibility = Visibility.Visible; 
                    P2.Visibility = Visibility.Hidden;
                }
                else
                {
                    P1.Visibility = Visibility.Hidden;
                    P2.Visibility = Visibility.Visible;
                }
                turn = !turn;
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
                //player = (Player)PlayerOne.Content;
                using (var db = new Connect4Entities1())
                {
                    //var updatePlayer = db.Players.Find(player.Id);
                    //updatePlayer.Wins = p1Count;

                    /*var updatePlayer = from player in db.Players
                                       where player.Name == PlayerOne.Content.ToString()
                                       orderby player.Id descending
                                       let p1Count = player.Wins 
                                       select player;*/

                    //var updatePlayer = new Player();
                    var updatePlayer = db.Players.OrderByDescending(p => p.Id).Skip(1).First();
                    updatePlayer.Wins = p1Count;
                    var updatePlayer2 = db.Players.OrderByDescending(p => p.Id).First();
                    updatePlayer2.Losses++;
                    db.SaveChanges();
                    //var updatePlayer = db.Players.Select(p => { p.Wins = p1Count; return p; })
                }
            }

            if (GrayPlayerWinner.IsInitialized == true && Connect4Style.CanIncreaseGrayScore == true)
            {
                p2Count++;
                PlayerTwoScore.Text = p2Count.ToString();
                //player = (Player)PlayerTwo.Content;
                using (var db = new Connect4Entities1())
                {
                    //var updatePlayer = db.Players.Find(player.Id);
                    //updatePlayer.Wins = p2Count;

                    /*var updatePlayer = from player in db.Players
                                       where player.Name == PlayerTwo.Content.ToString()
                                       orderby player.Id descending
                                       let p2Count = player.Wins
                                       select player;*/
                    //var updatePlayer = new Player();
                    var updatePlayer = db.Players.OrderByDescending(p => p.Id).Skip(1).First();
                    updatePlayer.Losses++;
                    var updatePlayer2 = db.Players.OrderByDescending(p => p.Id).First();
                    updatePlayer2.Wins = p2Count;
                    db.SaveChanges();
                }
            }
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Connect4Style();
        }
    }
}
