using System;

namespace BOOP_02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple characters
            char charVar1 = 'A';    
            char charVar2 = '!';
            Console.WriteLine(charVar1);
            Console.WriteLine((int)charVar1);
            Console.WriteLine(charVar2);
            Console.WriteLine((int)charVar2);

            // Escape sequences characters using backslash
            char backSlash = '\\';
            char singleQuote = '\'';
            Console.WriteLine(backSlash);
            Console.WriteLine(singleQuote);

            char charVar3 = '\x0041';
            Console.WriteLine(charVar3);
            char charVar4 = '\x00A9';
            Console.WriteLine(charVar4);
        }
    }
}
//Excercise:
//1.    Set a variable of type char to 'þ' (UniCode value 00FE)
//2.    Explore the Unicode list from the link in the Theory material, select a character from the Latin part, and assign to 
//      a variable of type char
