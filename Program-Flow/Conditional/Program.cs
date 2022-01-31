using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            // if-else
            if (theVal == 40) {
                Console.WriteLine("== 40");
            } 
            else if (theVal == 50) {
                Console.WriteLine("== 50");
            }
             else if (theVal == 60) {
                Console.WriteLine("== 60");
            }
            else {
                Console.WriteLine("theVal is large");
            }

            // -----------------------
            // Using the ternary operator ?:

            // a two-case if-then
            
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }

            // can be replaced by a ternary operator ?:
            Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");

            // The switch statement
            switch (theVal) {
                case 40:
                Console.WriteLine("==40");
                break;
                case 50:
                Console.WriteLine("==50");
                break;
                case 60:
                case 70:
                Console.WriteLine("==60 or 70");
                break;
                default:
                Console.WriteLine("default");
                break;

            }

        }
    }
}
