using System;

namespace BOOP_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte buttons;
            byte LED;

            // In real world read I/O port the console is connected to
            buttons = 0b101;  // left and right button, but not middle button

            //Check what buttons are pressed
            if ((buttons & 0b001) != 0) Console.WriteLine("Right button pressed");
            if ((buttons & 0b010) != 0) Console.WriteLine("Middle button pressed");
            if ((buttons & 0b100) != 0) Console.WriteLine("Left button pressed");

            if ((buttons & 0b011) != 0) Console.WriteLine("Right OR Middle button pressed");

            // In real world write to the I/O port the console is connected to
            LED = 0b01;
            if ((LED & 0b01) != 0) Console.WriteLine("Right LED On");
            if ((LED & 0b10) != 0) Console.WriteLine("Left LED On");

            // toggle the LED
            LED = (byte) ~LED;
            if ((LED & 0b01) != 0) Console.WriteLine("Right LED On");
            if ((LED & 0b10) != 0) Console.WriteLine("Left LED On");
            
            // another way to toggle using XOR, (bits XOR:d with 1 are toggled, while others remain the same)
            LED = (byte) (LED ^ 0b11);
            if ((LED & 0b01) != 0) Console.WriteLine("Right LED On");
            if ((LED & 0b10) != 0) Console.WriteLine("Left LED On");
        }
    }
}
//Excerices:
//1.    Modify above program to write "Any button pressed" in case any of the simulated buttons are pressed
//2.    Modify above program to write "All button pressed" in case all of the simulated buttons are pressed
//3.    Modify above program to simulate that you switch on all LED if all buttons are pressed. I.e.,
//      the program should write "Right LED On" followed by "Left LED On"
