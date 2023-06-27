using System;

namespace BOOP_02_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empty vs uninitialized string
            string s1 = "";                         // empty string
            Console.WriteLine(s1.Length);           // 0
            Console.WriteLine(s1 == string.Empty);  // True

            string s2 = null;                       // variable with no instance reference
            //Console.WriteLine(s2.Length);         // Compiler exception as s2 is null
            Console.WriteLine(s2== string.Empty);   // False

            string s3 = "abcd";
            char ch = s3[2];
            Console.WriteLine(ch);                    // c

            string s4 = s3.Replace('c', '!');
            Console.WriteLine($"s3: {s3}, s4: {s4}"); // s3: abcd, s4: ab!d

            s3 = "The quick brown fox";
            s4 = s3.Replace("fox", "cat");
            int i = s4.IndexOf("brown");
            string s5 = s4.Substring(i);
            Console.WriteLine($"s3: {s3}, s4: {s4}, s5: {s5}"); // s3: The quick brown fox, s4: The quick brown cat, s5: brown cat

            string[] words = s4.Split(' ');
            Console.WriteLine($"words[2]: {words[2]}"); // words[2]: brown
        }
    }
}
//Exercises:
//1.    Make a program that
//      - assigns a variable, aLimerick1,  of type string the value "There was a young belle of old Natchez".
//      - use appropriate string manipulation functions on aLimerick1 to assign another string variable, aLimerick2,
//        the value "There was a old belle of new Natchez"
//2.    Use appropriate string function to print out the length of aLimerick.
//3.    Print out aLimeric1 in all lower and all upper characters
//4.    In Excercise BOOP_02_03 and BOOP_02_04 you made struct PlayingCard. Create a variable of type PlayingCard and assign the
//      members Color and Value values. For example Color = Diamonds and Value = Ace.
//      - Declare a string variable and assign it using String interpolation a description of the card. For example
//      - Ace of Diamonds
//      - Five of Clubs
