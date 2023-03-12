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
            ONE_ONE = 0,
            ONE_TWO = 0,
            ONE_THREE = 0,
            ONE_OPERATOR = 0,
            TWO_ONE = 0,
            TWO_TWO = 0,
            TWO_THREE = 0,
            TWO_OPERATOR = 0,
            THREE_ONE = 0,
            THREE_TWO = 0,
            THREE_THREE = 0,
            THREE_OPERATOR = 0,
            FOUR_ONE = 0,
            FOUR_TWO = 0,
            FOUR_THREE = 0,
            FOUR_OPERATOR = 0,
            FIVE_ONE = 0,
            FIVE_TWO = 0,
            FIVE_THREE = 0,
            FIVE_OPERATOR = 0,
            SIX_ONE = 0,
            SIX_TWO = 0,
            SIX_THREE = 0,
            SIX_OPERATOR = 0,
            SEVEN_ONE = 0,
            SEVEN_TWO = 0,
            SEVEN_THREE = 0,
            SEVEN_OPERATOR = 0,
            EIGHT_ONE = 0,
            EIGHT_TWO = 0,
            EIGHT_THREE = 0,
            EIGHT_OPERATOR = 0,
            NINE_ONE = 0,
            NINE_TWO = 0,
            NINE_THREE = 0,
            NINE_OPERATOR = 0,
            TEN_ONE = 0,
            TEN_TWO = 0,
            TEN_THREE = 0,
            TEN_OPERATOR = 0
        }
        public enum QUESTIONIS_MEDIUM
        {
            ONE_ONE = 0,
            ONE_TWO = 0,
            ONE_THREE = 0,
            ONE_OPERATOR = 0,
            TWO_ONE = 0,
            TWO_TWO = 0,
            TWO_THREE = 0,
            TWO_OPERATOR = 0,
            THREE_ONE = 0,
            THREE_TWO = 0,
            THREE_THREE = 0,
            THREE_OPERATOR = 0,
            FOUR_ONE = 0,
            FOUR_TWO = 0,
            FOUR_THREE = 0,
            FOUR_OPERATOR = 0,
            FIVE_ONE = 0,
            FIVE_TWO = 0,
            FIVE_THREE = 0,
            FIVE_OPERATOR = 0,
            SIX_ONE = 0,
            SIX_TWO = 0,
            SIX_THREE = 0,
            SIX_OPERATOR = 0,
            SEVEN_ONE = 0,
            SEVEN_TWO = 0,
            SEVEN_THREE = 0,
            SEVEN_OPERATOR = 0,
            EIGHT_ONE = 0,
            EIGHT_TWO = 0,
            EIGHT_THREE = 0,
            EIGHT_OPERATOR = 0,
            NINE_ONE = 0,
            NINE_TWO = 0,
            NINE_THREE = 0,
            NINE_OPERATOR = 0,
            TEN_ONE = 0,
            TEN_TWO = 0,
            TEN_THREE = 0,
            TEN_OPERATOR = 0
        }
        public enum QUESTIONS_HARD
        {
            ONE_ONE = 0,
            ONE_TWO = 0,
            ONE_THREE = 0,
            ONE_OPERATOR = 0,
            TWO_ONE = 0,
            TWO_TWO = 0,
            TWO_THREE = 0,
            TWO_OPERATOR = 0,
            THREE_ONE = 0,
            THREE_TWO = 0,
            THREE_THREE = 0,
            THREE_OPERATOR = 0,
            FOUR_ONE = 0,
            FOUR_TWO = 0,
            FOUR_THREE = 0,
            FOUR_OPERATOR = 0,
            FIVE_ONE = 0,
            FIVE_TWO = 0,
            FIVE_THREE = 0,
            FIVE_OPERATOR = 0,
            SIX_ONE = 0,
            SIX_TWO = 0,
            SIX_THREE = 0,
            SIX_OPERATOR = 0,
            SEVEN_ONE = 0,
            SEVEN_TWO = 0,
            SEVEN_THREE = 0,
            SEVEN_OPERATOR = 0,
            EIGHT_ONE = 0,
            EIGHT_TWO = 0,
            EIGHT_THREE = 0,
            EIGHT_OPERATOR = 0,
            NINE_ONE = 0,
            NINE_TWO = 0,
            NINE_THREE = 0,
            NINE_OPERATOR = 0,
            TEN_ONE = 0,
            TEN_TWO = 0,
            TEN_THREE = 0,
            TEN_OPERATOR = 0
        }
    }
}
