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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace lab_24_gaming_interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
        }

        void Initialise()
        {
           // StackPanel01.Visibility = Visibility.Visible;
           // StackPanel02.Visibility = Visibility.Visible;
            //Panel.SetZIndex(StackPanel01, 1);
            //Panel.SetZIndex(StackPanel02, -1);
        }

        // When the key up event takes place, object will be item which caused the event 
        // ie the key we pressed eg letter 'h'
        // EventArgs is an array of strings which contains any relevant data for that event
        private void KeyUp_ChangeTitle(object sender, EventArgs e)
        {
            WelcomeLabel.Content = "Welcome to the party," + InputName.Text;
            // add a line to save to file
            File.WriteAllText("Title.txt", InputName.Text);
        }
        private void MouseEnter_ChangeColour(object sender, EventArgs e)
        {
            //InputName.UseVisualStyleBackColor = false;
            //button1.BackColor = Color.GhostWhite;
            Color MouseEnter = Color.FromRgb(50,50,50);
            //InputName.Background = new Color(); / MouseEnter="MouseEnter_ChangeColor" />
        }

        private void ChangeEditMode(object sender, RoutedEventArgs e)
        {
            if (EditMode.IsChecked==true)
            {
                InputName.IsReadOnly = false;
            }
            else
            {
                InputName.IsReadOnly = true;
            }
        }

        private void ButtonClickChange(object sender, EventArgs e)
        {
              //starts at 0 so first click means first rabbit is 1 
        }

        int counter = 0;
        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show(); 

            counter++;

            if(counter == 0)
            {
                Image01.Visibility = Visibility.Hidden;
                Image02.Visibility = Visibility.Hidden;
                Image03.Visibility = Visibility.Hidden;
            }

            if (counter == 1)
            {
                Image01.Visibility = Visibility.Hidden;
            }
            if (counter == 2)
            {
                Image01.Visibility = Visibility.Hidden;
                Image02.Visibility = Visibility.Hidden;
            }
            if (counter == 3)
            {
                Image01.Visibility = Visibility.Hidden;
                Image02.Visibility = Visibility.Hidden;
                Image03.Visibility = Visibility.Hidden;
            }



        }

        private void Button02_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TogglePanel(object sender, RoutedEventArgs e)
        {
            //Panel.SetZIndex(Stackpanel01, Canvas.GetZIndex(Stackpanel01) * -1);
            //Panel.SetZIndex(Stackpanel02, Canvas.GetZIndex(Stackpanel02) * -1);
        }

        /// Grid Backgorund
        /// <Grid.Background>
        /// <ImageBrush / ImageSource = "/lab_52_wpf_grid;component/Images/" />
        /// <ImageBrush / ImageSource="pack://application:,,,/Images/snakes-and-ladders.jpg" />
        /// </Grid.Background>
    }
}
