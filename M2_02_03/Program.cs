using System;

namespace BOOP_02_03
{
    class Program
    {
        public enum MonthOfYear
        {
            January, February, March,
            April, May, June,
            July, August, September,
            October, November, December
        }
        static void Main(string[] args)
        {
            MonthOfYear month = MonthOfYear.January;
            Console.WriteLine(month);       // January
            Console.WriteLine((int)month);  // 0

            if (month == MonthOfYear.January) Console.WriteLine("Happy New Year");
        }
    }
}
//Excerices:
//1.    Declare a public enum type PlayingCardColor that models Spade, Club, Heart, Diamond 
//2.    Declare a public enum type PlayingCardValue that models Ace, Two..Ten, Knight, Queen, King.
///     Ace should start with constant = 1
//3.    Declare a public struct PlayingCard that models Color and Value of a playing card. Declare a variable, card1, of 
//      PlayingCard type and assign it to Queen of Heart. 
//4.    Declare a variable of int and assign it card1.Value. Check that the numeric value corresponds to the card. 
//      E.g., Ace is 1 and King is 13
