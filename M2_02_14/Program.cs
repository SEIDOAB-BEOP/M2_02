using System;

namespace BOOP_02_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int iScope1 = 500;
            
            
            {
                int iScope2 = ++iScope1;
 
                
                {
                    int iScope3 = ++iScope2;
                    {
                        //int iScope3 = 0;        // Compiler error - iScope3 already defined in outer scope
                        Console.WriteLine(iScope1 + iScope2 + iScope3); // 1505
                    }

                    Console.WriteLine(iScope1 + iScope2 + iScope3); // 1505
                }

                //Console.WriteLine(iScope1 + iScope2 + iScope3); // Compiler error - iScope3 out of scope
                Console.WriteLine(iScope1 + iScope2); // 1003
            }
            //Console.WriteLine(iScope1 + iScope2); // // Compiler error - iScope2 out of scope
            Console.WriteLine(iScope1); // 501



        }
    }
}
//Exercises:
//1.    On row 11 try to add code to access iScope2 and iScope3. What happens? Explain
//2.    On row 15 try to add code to access iScope2 and iScope3. What happens? Explain
//3.    On row 32 add a new scope and declare variable iScope4 and assign it to iScope1 + iScope2. What happens? Explain

