using System;

namespace BOOP_02_12
{
    class Program
    {
        // Value type
        public struct mutableStructPoint
        {
            public int X, Y;            
        }
        public readonly struct immutableStructPoint
        {
            public readonly int X, Y;  
            public immutableStructPoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        // Reference type
        public class mutableClassPoint
        {
            public int X, Y;        
        }
        public class immutableClassPoint
        {
            public readonly int X, Y; 
            public immutableClassPoint(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        static void Main(string[] args)
        {
            var msp = new mutableStructPoint { X = 10, Y = 10 };    // variable is an instance of the type
            msp.Y = 100;                                            // Mutable means change is ok

            var imsp = new immutableStructPoint(10, 10);            // variable is an instance of the type
            //imsp.X = 100;                                         // Compiler error, immutable type means instance cannot change

            var mcp = new mutableClassPoint { X = 10, Y = 10};      // variable is an instance of the type
            mcp.X = 100;                                            // Mutable means change is ok

            var imcp = new immutableClassPoint(10, 10);             // variable is an instance of the type
            //imcp.X = 100;                                         // Compiler error, immutable type means instance cannot change
        }
    }
}
//Exercises:
//1.    In Excercise BOOP_02_03 and BOOP_02_04 you made struct PlayingCard. Is that type mutable or immutable?
//2.    Create a new type struct PlayingCardXX with opposite mutability. Create a variable of type PlayingCardXX and 
//      demonstrate the mutability or immutability
