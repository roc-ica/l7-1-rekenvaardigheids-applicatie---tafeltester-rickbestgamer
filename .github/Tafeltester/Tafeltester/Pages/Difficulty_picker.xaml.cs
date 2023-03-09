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
    /// Interaction logic for Difficulty_picker.xaml
    /// </summary>
    public partial class Difficulty_picker : Page
    {
        public Difficulty_picker()
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

        private void Dif_easy(object sender, RoutedEventArgs e)
        {
            Globals.DIFFICULTY_SELECTOR = 0;
            foreach(Window window in Application.Current.Windows)
            {
                if(window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Questions();
                }
            }
        }

        private void Dif_medium(object sender, RoutedEventArgs e)
        {
            Globals.DIFFICULTY_SELECTOR = 1;
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Questions();
                }
            }
        }

        private void Dif_hard(object sender, RoutedEventArgs e)
        {
            Globals.DIFFICULTY_SELECTOR = 2;
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.Content = new Questions();
                }
            }
        }
    }
}
