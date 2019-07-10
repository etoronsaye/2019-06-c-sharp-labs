using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace lab_38_WPF_stack_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<string> questions = new List<string>();
        public List<QuestionBank> questionAnswers = new List<QuestionBank>();
        public string answer { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        public void Initialise()
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;

            questions.Add("What is the capital of Italy?");
            questions.Add("What is the capital of Mongolia?");
            questions.Add("How do you spell Llanfair....?");
            questions.Add("What is 1/0 * 3?");
            questions.Add("Who is the president of Singapore?");

            var qanda01 = new QuestionBank("What is the capital of Italy ?", "Rome", 100 );
            var qanda02 = new QuestionBank("What is the capital of Mongolia ?", "Who knows", 2000);
            var qanda03 = new QuestionBank("How do you spell Llanfair.... ?", "Llanfairpwllgwyngyllgogerychwyrndrobwllllantysiliogogogoch", 5000);
            var qanda04 = new QuestionBank("What is 1/0 * 3?", "Undefined", 100);
            var qanda05 = new QuestionBank("Who is the president of Singapore?", "Halimah ", 5000);

            questionAnswers.Add(qanda01);
            questionAnswers.Add(qanda02);
            questionAnswers.Add(qanda03);
            questionAnswers.Add(qanda04);
            questionAnswers.Add(qanda05);

            int ran = RandomNumberGenerator(0, 6);
            if (ran == (0))
            {
                Label01.Content = qanda01.Question;
            }
            else if (ran == 1)
            {
                Label01.Content = qanda02.Question;
            }
            else if (ran == 2)
            {
                Label01.Content = qanda03.Question;
            }
            else if (ran == 3)
            {
                Label01.Content = qanda04.Question;
            }
            else if (ran == 4)
            {
                Label01.Content = qanda05.Question;
            } 
            Thread.Sleep(25);
            // Create a game to randomly show one of the questions
            // Have a text box to recieve the answer
            // If its right display appropriate message and add total prize
            // If wrong zero points and appropriate message
            // Create a winning condition
            // Add some imagery as well

        }

        private int RandomNumberGenerator(int start, int end)
        {
            Random random = new Random();
            int num = random.Next(start, end);
            return num;
        }

        private void ShowPanel01(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Visible;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel02(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Visible;
            StackPanel03.Visibility = Visibility.Hidden;
        }

        private void ShowPanel03(object sender, EventArgs e)
        {
            StackPanel01.Visibility = Visibility.Hidden;
            StackPanel02.Visibility = Visibility.Hidden;
            StackPanel03.Visibility = Visibility.Visible;
        }

        private void Input01_TextChanged(object sender, TextChangedEventArgs e)
        {
            answer = Input01.Text;
        }

    }

    public class QuestionBank
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public int Points { get; set; }

        public QuestionBank(string q, string a, int p)
        {
            this.Question = q;
            this.Answer = a;
            this.Points = p;
        }
 
    }
}
