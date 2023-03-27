using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Rick_Dorrs_quest_rework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ArrayList MainList = new ArrayList
        {
            new ArrayList(),
            new ArrayList(),
            new ArrayList()
        };
        Type Type = typeof(Colors);
        PropertyInfo[] Properties;
        int AmtDiscs = 26;

        public MainWindow()
        {
            InitializeComponent();
            Properties = Type.GetProperties().ToArray();
            GenerateDiscs(AmtDiscs);
        }


        private void GenerateDiscs(int amount)
        {
            ArrayList TmpList = (ArrayList)MainList[0];
            for (int i = 0; i < amount; i++)
            {
                Label Lbl = new Label();
                Lbl.Height = 10;
                Lbl.Width = 10 * i + 10;
                Lbl.Margin = new Thickness(0, 0, 0, 10 * AmtDiscs - i * 10);
                Lbl.Background = new SolidColorBrush((Color)Properties[i].GetValue(null, null));
                Lbl.VerticalAlignment = VerticalAlignment.Bottom;
                TmpList.Add(Lbl);
                row1.Children.Add(Lbl);
            }
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
