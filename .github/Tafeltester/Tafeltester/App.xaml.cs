using System;
using System.Collections;
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

    public class Globals
    {
        private static ArrayList _QUESTIONS_EASY;
        private static ArrayList _QUESTIONS_MEDIUM;
        private static ArrayList _QUESTIONS_HARD;

        public static String USER_NAME = "";
        public static float DIFFICULTY_SELECTOR = 0;
        public enum DIFFICULTY
        {
            Easy,
            Normal,
            Hard
        }
        public static ArrayList QUESTIONS_EASY
        {
            get
            {
                if (_QUESTIONS_EASY == null)
                {
                    return _QUESTIONS_EASY = new ArrayList();
                }
                else
                {
                    return _QUESTIONS_EASY;
                }
            }
            set { _QUESTIONS_EASY = value; }
        }
        public static ArrayList QUESTIONS_MEDIUM
        {
            get
            {
                if (_QUESTIONS_MEDIUM == null)
                {
                    return _QUESTIONS_MEDIUM = new ArrayList();
                }
                else
                {
                    return _QUESTIONS_MEDIUM;
                }
            }
            set { _QUESTIONS_MEDIUM = value; }
        }
        public static ArrayList QUESTIONS_HARD
        {
            get
            {
                if (_QUESTIONS_HARD == null)
                {
                    return _QUESTIONS_HARD = new ArrayList();
                }
                else
                {
                    return _QUESTIONS_HARD;
                }
            }
            set { _QUESTIONS_HARD = value; }
        }
    }
}
