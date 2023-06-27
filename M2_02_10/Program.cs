using System;

namespace BOOP_02_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Format using Composite Format String
            decimal price = 582.5555M;

            //Format as Currency
            Console.WriteLine("Product A costs: {0:C}", price);
            Console.WriteLine("Product B costs: {0:C}", price * 5);

            // Format the price right adjusted in a column 20 characters wide and 4 decimals
            Console.WriteLine();
            Console.WriteLine("Product A costs: {0,20:C4}", price);
            Console.WriteLine("Product B costs: {0,20:C4}", price * 5);

            // Format a byte and int in hex
            byte data = 0xAF;
            Console.WriteLine();
            Console.WriteLine(@"""data"" in decimal: {0}", data);
            Console.WriteLine("{0} in hexdecimal 2digits: 0x{1:X2}", data, data);
            Console.WriteLine("{0} in hexdecimal 4digits: 0x{1:X4}", data, data);


            string book1 = "Robinson Cruisoe";
            string author1 = "Daniel Defoe";
            decimal price1 = 125.50M;
            string book2 = "Count of Monte Christo";
            string author2 = "Alexandre Dumas";
            decimal price2 = 119.75M;

            // Format in a table
            Console.WriteLine();
            Console.WriteLine("{0,-7} {1,-30} {2,-30} {3,20}", "Article", "Title", "Author", "Price");
            Console.WriteLine("{0,-7} {1,-30} {2,-30} {3,20:C2}", "1:", book1, author1, price1);
            Console.WriteLine("{0,-7} {1,-30} {2,-30} {3,20:C2}", "1:", book2, author2, price2);
        }
    }
}
//Exercises:
//1.    Change the program in BOOP_02_09.4 to print the Mathematical Constant table using composite format strings.
