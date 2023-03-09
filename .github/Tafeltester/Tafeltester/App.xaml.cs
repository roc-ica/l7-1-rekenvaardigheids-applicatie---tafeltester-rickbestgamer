using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Tafeltester
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

    }

    public static class Globals
    {
        public static String USER_NAME = "";
        public static float DIFFICULTY_SELECTOR = 0;
        public enum DIFFICULTY
        {
            Easy,
            Normal,
            Hard
        }
        public enum QUESTIONIS_EASY
        {

        }
        public enum QUESTIONIS_MEDIUM
        {

        }
        public enum QUESTIONS_HARD
        {

        }
    }
}
