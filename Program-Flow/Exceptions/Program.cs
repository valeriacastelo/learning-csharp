using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            int y = 1;
            int result;

            // try-catch expressions make error checking easier
            try {
                if (x > 100) {
                    throw new ArgumentOutOfRangeException("x is too big");
                }

                result = x / y;
                Console.WriteLine("The result is: {0}", result);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("divide by zero error {0}", e);
            }
            catch {
                Console.WriteLine("Error");
            }
            finally {
                Console.WriteLine("Ending");
            }
            
        }
    }
}
