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
using System.Threading;

namespace lab_39_button_grid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        List<Button> buttons = new List<Button>();
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            
            for (int i = 0; i < 100; i++)
            {
                var b = new Button();
                //int buttonNumber = i + 1;
                b.Name = "Button" + (i + 1).ToString();
                b.Content = (i+1);
                b.Click += new RoutedEventHandler(button_click);
                buttons.Add(b);
                Grid.SetColumn(b, i % 10);
                Grid.SetRow(b, i / 10);
                // generate a random number between 1 and 6
                Thread.Sleep(25);
                int ran = RandomNumberGenerator(0, 6);
                // match number with enum number (use casting)
                if (ran == (int)colours.blue)
                {
                    b.Background = Brushes.Azure ;
                }
                else if (ran == (int)colours.red)
                {
                    b.Background = Brushes.Red;
                }
                else if (ran == (int)colours.green)
                {
                    b.Background = Brushes.Green;
                }
                else if (ran == (int)colours.yellow)
                {
                    b.Background = Brushes.Yellow;
                }
                else if (ran == (int)colours.purple)
                {
                    b.Background = Brushes.Purple;
                }
                else if (ran == (int)colours.pink)
                {
                    b.Background = Brushes.Pink;
                }
                MainGrid.Children.Add(b);
                // set colour of button to be chosen colour
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            var b = (Button)sender;
            MessageBox.Show($"{b.Name} is at row {Grid.GetRow(b)} and column {Grid.GetColumn(b)}.");
            int ran = RandomNumberGenerator(0, 6);
            // can we tell the colour
            if (ran == (int)colours.blue)
            {
                b.Background = Brushes.Azure;
            }
            else if (ran == (int)colours.red)
            {
                b.Background = Brushes.Red;
            }
            else if (ran == (int)colours.green)
            {
                b.Background = Brushes.Green;
            }
            else if (ran == (int)colours.yellow)
            {
                b.Background = Brushes.Yellow;
            }
            else if (ran == (int)colours.purple)
            {
                b.Background = Brushes.Purple;
            }
            else if (ran == (int)colours.pink)
            {
                b.Background = Brushes.Pink;
            }
        }

        private int RandomNumberGenerator(int start, int end)
        {
            Random random = new Random();
            int num = random.Next(start, end);
            return num;
        }
    }

    enum colours
    {
        blue, red, green, yellow, purple, pink
    }
}
