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
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Page
    {

        Random rnd = new Random();
        ArrayList templist = new ArrayList();
        int item1,
            item2,
            item3, 
            op;



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
        }

        readonly int difficulty_selector = Convert.ToInt16(Globals.DIFFICULTY_SELECTOR);

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

        private void Generate_Calculation()
        {
            if (difficulty_selector == 0)
            {
                op = rnd.Next(2);
                if (op == 0)
                {
                    item1 = rnd.Next(100);
                    item2 = rnd.Next(100);
                    item3 = item1 + item2;
                    txbl_question.Text = Convert.ToString(item1) + " + " + Convert.ToString(item2);
                }
                else
                {
                    item3= rnd.Next(200);
                    item2= rnd.Next(item3);
                    item1 = item3 - item2;
                    txbl_question.Text = Convert.ToString(item1) + " - " + Convert.ToString(item2);
                }


                //ArrayList arraylist2 = new ArrayList();
                //arraylist2.Add("test1");
                //arraylist2.Add("test2");
                //Globals.QUESTIONS_EASY.Add(arraylist2);
                //foreach (var item in Globals.QUESTIONS_EASY)
                //{
                //    int index = Globals.QUESTIONS_EASY.Count;
                //    for (int i = 0; i < index; i++)
                //    {
                //        ArrayList arlist = (ArrayList)item;
                //        foreach (var key in arlist)
                //        {
                //            Console.WriteLine(key);
                //        }
                //    }
                //}
            }
            else if (difficulty_selector == 1)
            {

            }
            else if (difficulty_selector == 2)
            {

            }
        }

        public static int GetValueOf(string enumName, string enumConst)
        {
            Type enumType = Type.GetType(enumName);
            if (enumType == null)
            {
                throw new ArgumentException("Specified enum type could not be found", "enumName");
            }

            object value = Enum.Parse(enumType, enumConst);
            return Convert.ToInt32(value);
        }

        private void TXBNameInput_KeyDown(object sender, KeyEventArgs e)
        {
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
                templist.Add(item1);
                templist.Add(item2);
                templist.Add(item3);
                templist.Add(op);
                Generate_Calculation();
            }
        }
    }
}
