using System;

namespace BOOP_02_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringVar1 = "Hello\tMartin\nHello\tWorld!";
            Console.WriteLine(stringVar1);      // Hello   Martin
                                                // Hello   World!

            // if you want to write \\ you will have to write \\\\ using the backslash for escape characters 
            stringVar1 = "\\\\user\\martin\\Documents";
            Console.WriteLine(stringVar1);      // \\user\martin\Documents

            // verbatim string literals makes it more readable
            stringVar1 = @"\\user\martin\Documents";
            Console.WriteLine(stringVar1);      // \\user\martin\Documents

            // double-quote character in a verbatim literal is written twice:
            stringVar1 = @"Lets make a ""Quote"".";
            Console.WriteLine(stringVar1);      // Lets make a "Quote".

            //String concatenations
            int intVar1 = 5;
            double doubleVar1 = 5.3;
            stringVar1 = "intVar1 = " + intVar1.ToString() + ", doubleVar1 = " + doubleVar1.ToString();
            Console.WriteLine(stringVar1);      // intVar1 = 5, doubleVar1 = 5,3

            //String Interpolation - An excellent way to include parameters in a string
            stringVar1 = $"intVar1 = {intVar1}, doubleVar1 = {doubleVar1}";
            Console.WriteLine(stringVar1);      // intVar1 = 5, doubleVar1 = 5,3

            //String Interpolation can be used in a verbatim string
            stringVar1 = @$"""intVar1"" = {intVar1} \ ""doubleVar1"" = {doubleVar1}";
            Console.WriteLine(stringVar1);      // "intVar1" = 5 \ "doubleVar1" = 5,3
        }
    }
}
//Exercises:
//1.    Create a variable of type string and assign it the text "\\Hello\\"World"\\" using Verbatim and non verbatim string
//2.    Print out "This is a strange printout" using String Concatenation of each word.
//3.    Declare two variable, var1 and var2 of type float. Assign them value and print out the varible names and the values
//      using String Interpolation.
