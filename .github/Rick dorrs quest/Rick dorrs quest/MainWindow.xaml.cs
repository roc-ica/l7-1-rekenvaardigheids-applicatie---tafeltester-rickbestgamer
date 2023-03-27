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

namespace Rick_dorrs_quest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Btn1.Content = "Grab upper disc";
            Btn2.Visibility = Visibility.Collapsed;
            Btn3.Visibility = Visibility.Collapsed;
            Generate_discs(Colors.Red);
            Generate_discs(Colors.Orange);
            Generate_discs(Colors.Yellow);
            Generate_discs(Colors.Green);
        }

        int index = 4,
            ActiveRow = 0;
        bool moving = false;
        Label MoveableLabel = new Label();
        ArrayList List1 = new ArrayList();
        ArrayList List2 = new ArrayList();
        ArrayList List3 = new ArrayList();
        public void Generate_discs(Color Color)
        {
            Label label = new Label
            {
                Background = new SolidColorBrush(Color),
                Height = 10
            };
            int margin_bottom = 10 * index;
            label.Name = "Item" + index;
            label.Width = 100 - index * 20;
            label.Margin = new Thickness(0, 0, 0, margin_bottom);
            label.VerticalAlignment = VerticalAlignment.Bottom;
            List1.Add(label);
            row1.Children.Add(label);
            index--;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (moving == false && List1.Count > 0)
            {
                ActiveRow = 1;
                MoveableLabel = (Label)List1[0];
                moving = true;
                CheckLists(List1, Btn1, 1);
                CheckLists(List2, Btn2, 2);
                CheckLists(List3, Btn3, 3);
                List1.Remove(MoveableLabel);
                row1.Children.Remove(MoveableLabel);
            }
            else if (moving == true)
            {
                if (List1.Count > 0)
                {
                    Label biggestlabel = (Label)List1[0];
                    if (Convert.ToInt32(MoveableLabel.Name.ElementAt(4)) > Convert.ToInt32(biggestlabel.Name.ElementAt(4)))
                    {
                        ArrayList templist = new ArrayList();
                        templist.Add(MoveableLabel);
                        templist.AddRange(List1);
                        List1.Clear();
                        List1.AddRange(templist);
                        row1.Children.Add(MoveableLabel);
                        MoveableLabel = new Label();
                        moving = false;
                        ActiveRow = 0;
                    }
                }
                else
                {
                    ArrayList templist = new ArrayList();
                    templist.Add(MoveableLabel);
                    List1.Clear();
                    List1.AddRange(templist);
                    row1.Children.Add(MoveableLabel);
                    MoveableLabel = new Label();
                    moving = false;
                    ActiveRow = 0;
                }
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (moving == false && List2.Count > 0)
            {
                ActiveRow = 2;
                MoveableLabel = (Label)List2[0];
                moving = true;
                CheckLists(List1, Btn1, 1);
                CheckLists(List2, Btn2, 2);
                CheckLists(List3, Btn3, 3);
                List2.Remove(MoveableLabel);
                row2.Children.Remove(MoveableLabel);
            }
            else if (moving == true)
            {
                if (List2.Count > 0)
                {
                    Label biggestlabel = (Label)List2[0];
                    if (Convert.ToInt32(MoveableLabel.Name.ElementAt(4)) > Convert.ToInt32(biggestlabel.Name.ElementAt(4)))
                    {
                        ArrayList templist = new ArrayList();
                        templist.Add(MoveableLabel);
                        templist.AddRange(List2);
                        List2.Clear();
                        List2.AddRange(templist);
                        row2.Children.Add(MoveableLabel);
                        MoveableLabel = new Label();
                        moving = false;
                        ActiveRow = 0;
                    }
                }
                else
                {
                    ArrayList templist = new ArrayList();
                    templist.Add(MoveableLabel);
                    List2.Clear();
                    List2.AddRange(templist);
                    row2.Children.Add(MoveableLabel);
                    MoveableLabel = new Label();
                    moving = false;
                    ActiveRow = 0;
                }
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (moving == false && List3.Count > 0)
            {
                ActiveRow = 3;
                MoveableLabel = (Label)List3[0];
                moving = true;
                CheckLists(List1, Btn1, 1);
                CheckLists(List2, Btn2, 2);
                CheckLists(List3, Btn3, 3);
                List3.Remove(MoveableLabel);
                row3.Children.Remove(MoveableLabel);
            }
            else if (moving == true)
            {
                if (List3.Count > 0)
                {
                    Label biggestlabel = (Label)List3[0];
                    if (Convert.ToInt32(MoveableLabel.Name.ElementAt(4)) > Convert.ToInt32(biggestlabel.Name.ElementAt(4)))
                    {
                        ArrayList templist = new ArrayList();
                        templist.Add(MoveableLabel);
                        templist.AddRange(List3);
                        List3.Clear();
                        List3.AddRange(templist);
                        row3.Children.Add(MoveableLabel);
                        MoveableLabel = new Label();
                        moving = false;
                        ActiveRow = 0;
                    }
                }
                else
                {
                    ArrayList templist = new ArrayList();
                    templist.Add(MoveableLabel);
                    List3.Clear();
                    List3.AddRange(templist);
                    row3.Children.Add(MoveableLabel);
                    MoveableLabel = new Label();
                    moving = false;
                    ActiveRow = 0;
                }
                if (List3.Count == 4)
                {
                    MessageBox.Show("Yeeeaaahhhh you won!!!!");
                }
            }
        }

        private void CheckLists(ArrayList list, Button name, int RowSelector)
        {
            if (moving == true)
            {
                Btn1.Visibility = Visibility.Visible;
                Btn2.Visibility = Visibility.Visible;
                Btn3.Visibility = Visibility.Visible;
            }
            else if (moving == false)
            {
                if (list.Count == 0)
                {
                    name.Visibility = Visibility.Collapsed;
                }
                else
                {
                    name.Visibility = Visibility.Visible;
                }
            }

            if (ActiveRow == RowSelector)
            {
                name.Content = "Put the circle back";
            }
            else
            {
                name.Content = "Put the curcle in this stack";
            }
        }
    }
}
