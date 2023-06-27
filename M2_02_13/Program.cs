using System;

namespace BOOP_02_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname == string.Empty);

            Console.WriteLine($"{firstname}, please press a key. (Q or q to quit)");

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                Console.WriteLine();
                Console.Write($"You pressed the key {key.Key}");
                if (key.Modifiers != 0) 
                    Console.WriteLine($" with the modifiers {key.Modifiers}");
                else 
                    Console.WriteLine();

                Console.WriteLine($"The character {key.KeyChar} hexadecimal value is 0x{(ushort)key.KeyChar:x4}.");

            } while (key.Key != ConsoleKey.Q);

            Console.WriteLine();
            Console.WriteLine("Thanks for playing");
        }
    }
}
//Exercises:
//1.    Write a program that ask for firstname, lastname and age and responds year of birth.
//      After entering the details a printout could be for John Smith 25:
//      "Hello John Smith! You were born 1996.
//      If age is not an integer (remember int.TryParse()) the output should be
//      "Hello John Smith! I cannot determine your birth year.
//2.    If firstname or lastname is empty "" it should be replaced with Unknown. Use string.Empty to
//      determine and empty string, e.g., if (firstname == string.Empty) ....

