﻿using System;
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
    /// Interaction logic for Landing.xaml
    /// </summary>
    public partial class Landing : Page
    {
        public Landing()
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
