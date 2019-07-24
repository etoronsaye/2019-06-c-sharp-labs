using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Connect4
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : MetroWindow
    {
        static Point[] points =
        {
            new Point(0,0), new Point(0,1), new Point(0,2), new Point(0,3), new Point(0,4), new Point(0,5), new Point(0,6),
            new Point(1,0), new Point(1,1), new Point(1,2), new Point(1,3), new Point(1,4), new Point(1,5), new Point(1,6),
            new Point(2,0), new Point(2,1), new Point(2,2), new Point(2,3), new Point(2,4), new Point(2,5), new Point(2,6),
            new Point(0,0), new Point(3,1), new Point(3,2), new Point(3,3), new Point(3,4), new Point(3,5), new Point(3,6),
            new Point(4,0), new Point(4,1), new Point(4,2), new Point(4,3), new Point(4,4), new Point(4,5), new Point(4,6),
            new Point(5,0), new Point(5,1), new Point(5,2), new Point(5,3), new Point(5,4), new Point(5,5), new Point(5,6),
        };

        static int[][] positions = new int[][]
        {
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1, 2, 3, 4, 5, 6}
        };

        public GameWindow()
        {
            InitializeComponent();
            Initialise();
        }
     
        void Initialise()
        {
            playerSwap();
        }

        static int counterC1 = 0;
        static int counterC2 = 0;
        static int counterC3 = 0;
        static int counterC4 = 0;
        static int counterC5 = 0;
        static int counterC6 = 0;

        private bool turn = true;
        private bool winner = false;

        private void playerSwap()
        {            
                if(turn)
                {
                    Players.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    Players.Fill = Brushes.LightGray;
                }          
        }

        private void C1_Click(object sender, RoutedEventArgs e)
        {
            Button c1 = (Button)sender;
            int column = (int)c1.GetValue(Grid.ColumnProperty);
            if (counterC1 == 0)
            {
                if (turn)
                {
                    C1P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC1 == 1)
            {
                if (turn)
                {
                    C1P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC1 == 2)
            {
                if (turn)
                {
                    C1P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC1 == 3)
            {
                if (turn)
                {
                    C1P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC1 == 4)
            {
                if (turn)
                {
                    C1P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC1 == 5)
            {
                if (turn)
                {
                    C1P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C1P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC1++;
            
        }

        private void C2_Click(object sender, RoutedEventArgs e)
        {
            Button c2 = (Button)sender;

            if (counterC2 == 0)
            {
                if (turn)
                {
                    C2P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC2 == 1)
            {
                if (turn)
                {
                    C2P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC2 == 2)
            {
                if (turn)
                {
                    C2P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC2 == 3)
            {
                if (turn)
                {
                    C2P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC2 == 4)
            {
                if (turn)
                {
                    C2P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC2 == 5)
            {
                if (turn)
                {
                    C2P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C2P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC2++;
        }

        private void C3_Click(object sender, RoutedEventArgs e)
        {
            Button c3 = (Button)sender;

            if (counterC3 == 0)
            {
                if (turn)
                {
                    C3P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC3 == 1)
            {
                if (turn)
                {
                    C3P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC3 == 2)
            {
                if (turn)
                {
                    C3P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC3 == 3)
            {
                if (turn)
                {
                    C3P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC3 == 4)
            {
                if (turn)
                {
                    C3P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC3 == 5)
            {
                if (turn)
                {
                    C3P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C3P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC3++;
        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {
            Button c4 = (Button)sender;

            if (counterC4 == 0)
            {
                if (turn)
                {
                    C4P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC4 == 1)
            {
                if (turn)
                {
                    C4P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC4 == 2)
            {
                if (turn)
                {
                    C4P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC4 == 3)
            {
                if (turn)
                {
                    C4P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC4 == 4)
            {
                if (turn)
                {
                    C4P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC4 == 5)
            {
                if (turn)
                {
                    C4P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C4P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC4++;
        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {
            Button c5 = (Button)sender;

            if (counterC5 == 0)
            {
                if (turn)
                {
                    C5P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC5 == 1)
            {
                if (turn)
                {
                    C5P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC5 == 2)
            {
                if (turn)
                {
                    C5P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC5 == 3)
            {
                if (turn)
                {
                    C5P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC5 == 4)
            {
                if (turn)
                {
                    C5P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC5 == 5)
            {
                if (turn)
                {
                    C5P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C5P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC5++;
        }

        private void C6_Click(object sender, RoutedEventArgs e)
        {
            Button c6 = (Button)sender;

            if (counterC6 == 0)
            {
                if (turn)
                {
                    C6P1.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P1.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC6 == 1)
            {
                if (turn)
                {
                    C6P2.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P2.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC6 == 2)
            {
                if (turn)
                {
                    C6P3.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P3.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC6 == 3)
            {
                if (turn)
                {
                    C6P4.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P4.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC6 == 4)
            {
                if (turn)
                {
                    C6P5.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P5.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            if (counterC6 == 5)
            {
                if (turn)
                {
                    C6P6.Fill = Brushes.BlanchedAlmond;
                }
                else
                {
                    C6P6.Fill = Brushes.LightGray;
                }
                turn = !turn;
                playerSwap();
            }
            counterC6++;
        }

        /*private static UIElement GetChildren(Grid grid, int row, int column)
        {
            foreach (UIElement child in grid.Children)
            {
                if (Grid.GetRow(child) == row && Grid.GetColumn(child) == column)
                {
                    return child;
                }
            }
        }*/

        private bool HorizontalWin()
        {
 

            /*foreach(ColumnDefinition cd in GameBoardGrid.ColumnDefinitions)
            {
                column = (int)cd.GetValue(Grid.ColumnProperty);
                foreach (RowDefinition rd in GameBoardGrid.RowDefinitions)
                {
                    row = (int)rd.GetValue(Grid.RowProperty);
                    points.Cre(column, row);
                }
            }*/

            /*foreach(var point in points)
            {
                for(int i = (int)point.X; i < point.X; i++)
                {
                    for(int j = (int)point.Y; j < 2; j++)
                    {
                        if(point.Equals()
                    }
                }
            }*/
            for (int i = 0; i < positions.Length; i++)
            {
                for (int j = 0; j < positions[i].Length - 3; j++)
                {
                    //checks horizontal win
                    if (positions[i][j] != 0 && positions[i][j] == positions[i][j + 1] && positions[i][j] == positions[i][j + 2] && positions[i][j] == positions[i][j + 3])
                        return true;
                }
            }
        }

        private bool VerticalWin()
        {
            for (int i = 0; i < positions.Length - 3; i++)
            {
                for (int j = 0; j < positions.Length; j++)
                {
                    //checks vertical win
                    if (positions[i][j] != 0 && positions[i][j] == positions[i + 1][j] && positions[i][j] == positions[i + 2][j] && positions[i][j] == positions[i + 3][j])
                        return true;
                }
            }
        }
    }
}
