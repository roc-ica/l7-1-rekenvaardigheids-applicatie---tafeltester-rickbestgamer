using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
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

namespace Tafeltester.Pages
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Page
    {

        Random rnd = new Random();
        ArrayList list;
        int item1,
            item2,
            item3,
            op,
            QuestionsLenght = 10,
            QuestionsCurrent;

        public Questions()
        {
            InitializeComponent();
            Generate_Calculation();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.NavigationService.Navigated += NavigationService_Navigated;
                    (window as MainWindow).MainFrame.Content = null;
                }
            }
            difficulty_header.Text = Convert.ToString((Globals.DIFFICULTY)Globals.DIFFICULTY_SELECTOR);

            void NavigationService_Navigated(object sender, NavigationEventArgs e)
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.GetType() == typeof(MainWindow))
                    {
                        (window as MainWindow).MainFrame.NavigationService.RemoveBackEntry();
                        (window as MainWindow).MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
                        (window as MainWindow).MainFrame.NavigationService.Navigated -= NavigationService_Navigated;
                    }
                }
            }
        }

        readonly int difficulty_selector = Convert.ToInt16(Globals.DIFFICULTY_SELECTOR);

        private void Generate_Calculation()
        {
            if (difficulty_selector == 0)
            {
                list = Globals.QUESTIONS_EASY;
                QuestionsCurrent = list.Count + 1;
                TxBlProgress.Text = QuestionsCurrent + "/" + QuestionsLenght;
                op = rnd.Next(2);

                if (op == 0)
                {
                    item1 = rnd.Next(1, 25);
                    item2 = rnd.Next(1, 25);
                    item3 = item1 + item2;
                    txbl_question.Text = Convert.ToString(item1) + " + " + Convert.ToString(item2);
                }
                else
                {
                    item1 = rnd.Next(20, 40);
                    item3 = rnd.Next(10, item1 - 5);
                    item2 = item1 - item3;
                    txbl_question.Text = Convert.ToString(item1) + " - " + Convert.ToString(item2);
                }
            }
            else if (difficulty_selector == 1)
            {
                list = Globals.QUESTIONS_MEDIUM;
                QuestionsCurrent = list.Count + 1;
                TxBlProgress.Text = QuestionsCurrent + "/" + QuestionsLenght;
                op = rnd.Next(2);

                if (op == 0)
                {
                    item1 = rnd.Next(1, 100);
                    item2 = rnd.Next(1, 100);
                    item3 = item1 + item2;
                    txbl_question.Text = Convert.ToString(item1) + " + " + Convert.ToString(item2);
                }
                else
                {
                    item1 = rnd.Next(40, 120);
                    item3 = rnd.Next(10, item1 - 10);
                    item2 = item1 - item3;
                    txbl_question.Text = Convert.ToString(item1) + " - " + Convert.ToString(item2);
                }
            }
            else if (difficulty_selector == 2)
            {
                list = Globals.QUESTIONS_HARD;
                QuestionsCurrent = list.Count + 1;
                TxBlProgress.Text = QuestionsCurrent + "/" + QuestionsLenght;
                op = rnd.Next(4);
                op = 3;
                if (op == 0)
                {
                    item1 = rnd.Next(10, 1000);
                    item2 = rnd.Next(10, 1000);
                    item3 = item1 + item2;
                    txbl_question.Text = Convert.ToString(item1) + " + " + Convert.ToString(item2);
                }
                else if (op == 1)
                {
                    item1 = rnd.Next(80, 240);
                    item3 = rnd.Next(20, item1 - 10);
                    item2 = item1 - item3;
                    txbl_question.Text = Convert.ToString(item1) + " - " + Convert.ToString(item2);
                }
                else if (op == 2)
                {
                    item1 = rnd.Next(1, 25);
                    item2 = rnd.Next(1, 25);
                    item3 = item1 * item2;
                    txbl_question.Text = Convert.ToString(item1) + " X " + Convert.ToString(item2);
                }
                else if (op == 3)
                {
                    item2 = rnd.Next(3, 10);
                    item1 = item2 * rnd.Next(3, item2);
                    item3 = item1 / item2;
                    txbl_question.Text = Convert.ToString(item1) + " : " + Convert.ToString(item2);
                }
            }
        }

        private void CheckQuestions(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Result();
                }
            }
        }

        private void TXBNameInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.D1 || e.Key != Key.D2 || e.Key != Key.D3 || e.Key != Key.D4 || e.Key != Key.D5 || e.Key != Key.D6 || e.Key != Key.D7 || e.Key != Key.D8 || e.Key != Key.D9 || e.Key != Key.D0)
            {
                Console.WriteLine(e.Key);
                e.Handled = true;
            }

            if (e.Key == Key.Enter)
            {
                NextQuestion(sender, e);
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Difficulty_picker();
                }
            }
        }

        private void NextQuestion(object sender, RoutedEventArgs e)
        {
            if (txb_questioin_input.Text == Convert.ToString(item3))
            {
                SoundPlayer player = new SoundPlayer(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Media\correct.wav"));
                player.Play();
                ArrayList tmplist = new ArrayList();
                tmplist.Add(item1);
                tmplist.Add(item2);
                tmplist.Add(item3);
                tmplist.Add(op);
                tmplist.Add(txb_questioin_input.Text);
                list.Add(tmplist);

                txb_questioin_input.Text = "";
                if (list.Count < 10)
                {
                    Generate_Calculation();
                }
                else
                {
                    CheckQuestions(sender, e);
                }
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Media\wrong.wav"));
                player.Play();
                ArrayList tmplist = new ArrayList();
                tmplist.Add(item1);
                tmplist.Add(item2);
                tmplist.Add(item3);
                tmplist.Add(op);
                tmplist.Add(txb_questioin_input.Text);
                list.Add(tmplist);

                txb_questioin_input.Text = "";
                if (list.Count < 10)
                {
                    Generate_Calculation();
                }
                else
                {
                    CheckQuestions(sender, e);
                }
            }
        }
    }
}
