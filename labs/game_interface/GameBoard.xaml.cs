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
    /// Interaction logic for GameBoard.xaml
    /// </summary>
    public partial class GameBoard : UserControl
    {
        const int SquareSize = 50;
        const int ManSize = 40;
        const int Boxes = 30;

        public GameBoard()
        {
            InitializeComponent();
            Initialise();
            //User.Content = MainWindow.User;
        }

        void Initialise()
        {
            DrawGameArea();
            //DrawSquare();
        }

        private void DrawGameArea()
        {
            /*Tile newTile;
            switch (tilesListBox.SelectedItem.ToString())
            {
                case "Sokoban.Wall":
                    newTile = new Wall();
                    break;
                case "Sokoban.Target":
                    newTile = new Target();
                    break;
                case "Sokoban.Box":
                    newTile = new Box();
                    break;
                case "Sokoban.Forklift":
                    newTile = new Forklift();
                    break;
                default:
                    newTile = new Floor();
                    break;
            }*/
            //bool doneDrawingWarehouse = false;
            //int nextX = 0, nextY = 0;
            //int rowCounter = 0;
            //bool nextIsOdd = false;
            Rectangle hedge = new Rectangle()
            {
                Width = SquareSize,
                Height = SquareSize,
                Stroke = Brushes.ForestGreen,
                Fill = Brushes.ForestGreen,
            };
            Rectangle square = new Rectangle()
            {
                Width = SquareSize,
                Height = SquareSize,
                Stroke = Brushes.Tan,
                Fill = Brushes.Tan,
            };
            Rectangle storage = new Rectangle()
            {
                Width = SquareSize,
                Height = SquareSize,
                Stroke = Brushes.BlanchedAlmond,
                Fill = Brushes.BlanchedAlmond,
            };
            Rectangle man = new Rectangle()
            {
                Width = ManSize,
                Height = ManSize,
                Stroke = Brushes.Chocolate,
                Fill = Brushes.Chocolate,
            };
            Rectangle box = new Rectangle()
            {
                Width = Boxes,
                Height = Boxes,
                Stroke = Brushes.DarkSlateGray,
                Fill = Brushes.DarkSlateGray,
            };
            GameArea.Children.Add(hedge);
            GameArea.Children.Add(square);
            GameArea.Children.Add(storage);
            GameArea.Children.Add(man);
            GameArea.Children.Add(box);
            Canvas.SetTop(hedge, 150);
            Canvas.SetTop(man, 300);
            Canvas.SetLeft(square, 150);
            Canvas.SetLeft(storage, 300);

        }
    }
}
