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

namespace Tafeltester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == typeof(MainWindow))
                {
                    (window as MainWindow).MainFrame.NavigationService.Navigated += NavigationService_Navigated;
                    (window as MainWindow).MainFrame.Content = new Pages.Landing();
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

        private void BtnClickP1(object sender, RoutedEventArgs e)
        {
        }

        private void BtnClickP2(object sender, RoutedEventArgs e)
        {
        }
    }
}
