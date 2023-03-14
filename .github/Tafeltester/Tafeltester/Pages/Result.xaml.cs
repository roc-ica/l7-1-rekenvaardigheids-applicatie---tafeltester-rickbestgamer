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
            row = 1,
            VAlignment = 1;

        TextBlock
            Question = new TextBlock(),
            Answer = new TextBlock();


        private void GetItems()
        {
            item1 = 0;
            item2 = 0;
            item3 = 0;
            op = 0;
            row = 1;
            VAlignment = 1;
            Question = new TextBlock();
            Answer = new TextBlock();

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
            Question = new TextBlock();
            Answer = new TextBlock();
            foreach (var key in Arlist)
            {
                int Position = Arlist.IndexOf(key);
                if (Position == 0)
                {
                    item1 = (int)key;
                }
                else if (Position % 3 == 1)
                {
                    item2 = (int)key;

                }
                else if (Position % 3 == 2)
                {
                    item3 = (int)key;

                }
                else if (Position % 3 == 0)
                {
                    op = (int)key;
                }
            }

            if (op == 0)
            {
                Question.Text = item1 + " + " + item2;
            }
            else if (op == 1)
            {
                Question.Text = item1 + " - " + item2;
            }
            else if (op == 2)
            {
                Question.Text = item1 + " X " + item2;
            }
            else if (op == 3)
            {
                Question.Text = item1 + " : " + item2;
            }

            Answer.Text = Convert.ToString(item3);

            Grid.SetColumn(Question, 2);
            Grid.SetRow(Question, row);
            Grid.SetColumn(Answer, 4);
            Grid.SetColumnSpan(Answer, 2);
            Grid.SetRow(Answer, row);
            Question.TextAlignment = TextAlignment.Left;
            Answer.TextAlignment = TextAlignment.Left;

            if (VAlignment == 1)
            {
                Question.VerticalAlignment = VerticalAlignment.Top;
                Answer.VerticalAlignment = VerticalAlignment.Top;
                VAlignment++;
            }
            else if (VAlignment == 2)
            {
                Question.VerticalAlignment = VerticalAlignment.Center;
                Answer.VerticalAlignment = VerticalAlignment.Center;
                VAlignment++;
            }
            else if (VAlignment == 3)
            {
                Question.VerticalAlignment = VerticalAlignment.Bottom;
                Answer.VerticalAlignment = VerticalAlignment.Bottom;
                row++;
                VAlignment = 1;
            }
            GrdResult.Children.Add(Question);
            GrdResult.Children.Add(Answer);
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
