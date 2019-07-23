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

        }

        private void C4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
