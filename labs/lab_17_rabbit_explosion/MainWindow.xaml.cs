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

namespace lab_17_rabbit_explosion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button01_Click(object sender, RoutedEventArgs e)
        {
            counter++;    //starts at 0 so first click means first rabbit is 1
            Rabbit newRabbit = new Rabbit(counter);
            rabbits.Add(newRabbit);
            //display rabbits but first clear display
            ListBox01.Items.Clear();
            foreach (var rabbit in rabbits)
            {
                rabbit.Age++;
                ListBox01.Items.Add($"{rabbit.Name,-20} Age {rabbit.Age}");
            }
           
        }
    }

}
