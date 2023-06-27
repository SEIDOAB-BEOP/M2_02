using System;

namespace BOOP_02_05
{
    class Program
    {
        [Flags]
        public enum ButtonState : byte
        {
            Left = 1, Middle = 1<<1, Right = 1<<2,
            MiddleOrRight = Middle | Right
        }
        static void Main(string[] args)
        {
            ButtonState buttons;

            // In real world read I/O port the console is connected to
            buttons = ButtonState.Left | ButtonState.Right; 

            //Check individual buttons
            if ((buttons & ButtonState.Right) != 0) Console.WriteLine("Right button pressed");
            if ((buttons & ButtonState.Middle) != 0) Console.WriteLine("Middle button pressed");
            if ((buttons & ButtonState.Left) != 0) Console.WriteLine("Left button pressed");

            if ((buttons & ButtonState.MiddleOrRight) != 0) Console.WriteLine("Right OR Middle button pressed");
        }
    }
}
