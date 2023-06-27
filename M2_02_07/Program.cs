using System;

namespace BOOP_02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment immutable Reference Type (string) behaves like a value type
            string string_a = "text1";
            string string_b = "text2";

            string_b = string_a;  //as it is immutable, a copy of string_a is assign to string_b
            string_a = "text3";

            Console.WriteLine($"string_a: {string_a}"); // text3
            Console.WriteLine($"string_b: {string_b}"); // text1
            Console.WriteLine();
        }
    }
}
//Exercises:
//1.    Discuss in a group that you really understand the memory structure in the Theory Lesson from above code
//2.    At line 15 add a line of code that assigns string_b to "Hello".
//      - In the group, discuss and draw the change in the memory structure, following the image in the Theory Lesson
