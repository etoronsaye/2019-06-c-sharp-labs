using System;
using System.Collections.Generic;
using System.IO;
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

namespace game_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int SquareSize = 20;
        const int ManSize = 10;
        const int Boxes = 15;
        string username = "";

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
            if (File.Exists("Title.txt"))
            {
                WelcomeLabel.Content = "Welcome back " + File.ReadAllText("Title.txt");
                // InputName.Text = WelcomeLabel.Content.ToString();
            }
            else
            {
                File.Create("Title.txt");
            }
            //username = File.ReadAllText("Title.txt");
        }

        void Initialise()
        {

        }

        /* <TabControl x:Name="MainTab" Background="Beige" Grid.Row="1" Grid.Column="1" Grid.RowSpan="7" Grid.ColumnSpan="9"></TabControl>
         * TabItem _tabUserPage;
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            MainTab.Items.Clear(); //Clear previous Items in the user controls which is my tabItems    
            var userGameBoard = new GameBoard();
            _tabUserPage = new TabItem { Content = userGameBoard };
            MainTab.Items.Add(_tabUserPage); // Add User Controls    
            MainTab.Items.Refresh();
        }*/

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GameBoard gameBoard = new GameBoard();
            this.Content = gameBoard; 
        }


        private void DrawSquare()
        {
            Rectangle rect = new Rectangle();
        }

        private void InputName_KeyUp(object sender, KeyEventArgs e)
        {
            WelcomeLabel.Content = InputName.Text;
            // add a line to save to file
            File.WriteAllText("Title.txt", InputName.Text);
        }

        /*private void DrawGameArea()
        {
            bool doneDrawingWarehouse = false;
            int nextX = 0, nextY = 0;
            int rowCounter = 0;
            bool nextIsOdd = false;
            while(doneDrawingWarehouse == false)
            {
                Rectangle rect = new Rectangle
                {
                    Width = SquareSize,
                    Height = SquareSize,
                    Fill = nextIsOdd ? Brushes.BlanchedAlmond : Brushes.White
                };
            }
        }*/
    }

    public class Sokoban
    {

       
    }
}
