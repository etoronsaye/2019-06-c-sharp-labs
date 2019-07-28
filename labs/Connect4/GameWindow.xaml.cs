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

        public GameWindow()
        {
            InitializeComponent();
            Initialise();
        }

        private void SwapPlayer(int playerNumber)
        {
            /*if (playerNumber == 1)
            {
                Players.Fill = Brushes.BlanchedAlmond;
            }
            else if (playerNumber == 2)
            {
                Players.Fill = Brushes.LightGray;
            }*/
        }

        void Initialise()
        {
           // SwapPlayer(1);
        }


        static int counterC1 = 0;
        static int counterC2 = 0;
        static int counterC3 = 0;
        static int counterC4 = 0;
        static int counterC5 = 0;
        static int counterC6 = 0;

        private bool turn = true;
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            Button c1 = (Button)sender;

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
            }
            counterC6++;
        }
    }
}
