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


        static int counter = 0;
        private bool turn = true;
        private void C1_Click(object sender, RoutedEventArgs e)
        {
            Button c1 = (Button)sender;
            

            if (counter == 0)
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
            if (counter == 1)
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
            if (counter == 2)
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
            if (counter == 3)
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
            if (counter == 4)
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
            if (counter == 5)
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
            counter++;

        }
    }
}
