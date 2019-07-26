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

namespace Connect4V3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string playerOne = "";
        string playerTwo = "";
        List<Player> players;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            using (var db = new Connect4Entities1())
            {
                 players = db.Players.ToList();
            }
            Leaderboard.DisplayMemberPath = "Name";
            //Leaderboard.DisplayMemberPath = "Wins";
            //ListBoxCustomers.ItemsSource = customers;
            Leaderboard.ItemsSource = players;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            playerOne = P1.Text;
            playerTwo = P2.Text;

            if(playerOne == "" || playerTwo == "")
            {
                MessageBox.Show("Please enter names!");
            }
            else
            {
                (App.Current as App).player1 = P1.Text.ToString();
                (App.Current as App).player2 = P2.Text.ToString();
                using(var db = new Connect4Entities1())
                {
                    Player newPlayer = new Player();
                    Player newPlayer2 = new Player();
                    newPlayer.Name = playerOne;
                    newPlayer.Wins = 0;
                    newPlayer.Losses = 0;
                    newPlayer2.Name = playerTwo;
                    newPlayer2.Wins = 0;
                    newPlayer2.Losses = 0;
                    db.Players.Add(newPlayer);
                    db.Players.Add(newPlayer2);
                    db.SaveChanges();
                }
            }
            GameWindow gameWindow = new GameWindow();
            this.Close();
            gameWindow.Show();
        }

        private void Leaderboard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
