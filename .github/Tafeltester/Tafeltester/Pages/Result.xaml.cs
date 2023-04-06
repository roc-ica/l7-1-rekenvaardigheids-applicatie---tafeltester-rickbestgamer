using System;
using System.Collections;
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

namespace Tafeltester.Pages
{
    /// <summary>
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        public Result()
        {
            InitializeComponent();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.NavigationService.Navigated += NavigationService_Navigated;
                    (window as MainWindow).MainFrame.Content = null;
                }
            }
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
            GetItems();
        }
        int
            item1 = 0,
            item2 = 0,
            item3 = 0,
            op = 0,
            Answer = 0,
            row = 1,
            VAlignment = 1;

        TextBlock
            TxblQuestion = new TextBlock(),
            TxblAnswer = new TextBlock();


        private void GetItems()
        {
            item1 = 0;
            item2 = 0;
            item3 = 0;
            op = 0;
            Answer = 0;
            row = 1;
            VAlignment = 1;
            TxblQuestion = new TextBlock();
            TxblAnswer = new TextBlock();

            if (Globals.DIFFICULTY_SELECTOR == 0)
            {
                foreach (var item in Globals.QUESTIONS_EASY)
                {
                    ArrayList Arlist = (ArrayList)item;

                    DisplayItems(Arlist);
                }
            }
            else if (Globals.DIFFICULTY_SELECTOR == 1)
            {
                foreach (var item in Globals.QUESTIONS_MEDIUM)
                {
                    ArrayList Arlist = (ArrayList)item;

                    DisplayItems(Arlist);
                }
            }
            else if (Globals.DIFFICULTY_SELECTOR == 2)
            {
                foreach (var item in Globals.QUESTIONS_HARD)
                {
                    ArrayList Arlist = (ArrayList)item;

                    DisplayItems(Arlist);
                }
            }
        }

        private void DisplayItems(ArrayList Arlist)
        {
            TxblQuestion = new TextBlock();
            TxblAnswer = new TextBlock();
            foreach (var key in Arlist)
            {
                int Position = Arlist.IndexOf(key),
                    ListLength = Arlist.Count;
                if (Position == 0)
                {
                    item1 = (int)key;
                }
                else if (Position % ListLength == 1)
                {
                    item2 = (int)key;

                }
                else if (Position % ListLength == 2)
                {
                    item3 = (int)key;

                }
                else if (Position % ListLength == 3)
                {
                    op = (int)key;
                }
                else if (Position % ListLength == 4 && (string)key != "")
                {
                    Answer = (int)key;
                }
            }

            if (op == 0)
            {
                TxblQuestion.Text = item1 + " + " + item2;
            }
            else if (op == 1)
            {
                TxblQuestion.Text = item1 + " - " + item2;
            }
            else if (op == 2)
            {
                TxblQuestion.Text = item1 + " X " + item2;
            }
            else if (op == 3)
            {
                TxblQuestion.Text = item1 + " : " + item2;
            }

            TxblAnswer.Text = item3 + "    " + Answer;
            if (Answer == item3)
            {
                TxblAnswer.Foreground = Brushes.Green;
            }
            else
            {
                TxblAnswer.Foreground = Brushes.Red;
            }

            Grid.SetColumn(TxblQuestion, 2);
            Grid.SetRow(TxblQuestion, row);
            Grid.SetColumn(TxblAnswer, 4);
            Grid.SetColumnSpan(TxblAnswer, 2);
            Grid.SetRow(TxblAnswer, row);
            TxblQuestion.TextAlignment = TextAlignment.Left;
            TxblAnswer.TextAlignment = TextAlignment.Left;

            if (VAlignment == 1)
            {
                TxblQuestion.VerticalAlignment = VerticalAlignment.Top;
                TxblAnswer.VerticalAlignment = VerticalAlignment.Top;
                VAlignment++;
            }
            else if (VAlignment == 2)
            {
                TxblQuestion.VerticalAlignment = VerticalAlignment.Center;
                TxblAnswer.VerticalAlignment = VerticalAlignment.Center;
                VAlignment++;
            }
            else if (VAlignment == 3)
            {
                TxblQuestion.VerticalAlignment = VerticalAlignment.Bottom;
                TxblAnswer.VerticalAlignment = VerticalAlignment.Bottom;
                row++;
                VAlignment = 1;
            }
            GrdResult.Children.Add(TxblQuestion);
            GrdResult.Children.Add(TxblAnswer);
        }

        private void ResetCurrentDifficulty(object sender, RoutedEventArgs e)
        {
            float DifficultySelector = Globals.DIFFICULTY_SELECTOR;
            if (DifficultySelector == 0)
            {
                Globals.QUESTIONS_EASY.Clear();
            }
            else if (DifficultySelector == 1)
            {
                Globals.QUESTIONS_MEDIUM.Clear();
            }
            else if (DifficultySelector == 2)
            {
                Globals.QUESTIONS_HARD.Clear();
            }
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Questions();
                }
            }
        }

        private void DifficultyPicker(object sender, RoutedEventArgs e)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Difficulty_picker();
                }
            }
        }
    }
}
