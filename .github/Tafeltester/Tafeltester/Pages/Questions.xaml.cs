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

namespace Tafeltester.Pages
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Page
    {
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

        int difficulty_selector = Convert.ToInt16(Globals.DIFFICULTY_SELECTOR);

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

            }
            else if (difficulty_selector == 1)
            {

            }
            else if (difficulty_selector == 2)
            {

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

        }
    }
}
