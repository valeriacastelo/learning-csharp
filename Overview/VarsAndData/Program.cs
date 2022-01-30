using System;

namespace VarsAndData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some basic value type variables
            int i = 10;
            float f = 2.1f;
            decimal d = 10.3m;
            bool b = true;
            char c = 'c';

            // Declare a string - it's a collection of characters
            string str = "a string";

            // Declare an implicit variable
            var x = 10;
            var z = "Hello!";

            // Declare an array of values
            int[] arr = new int[5];
            string[] strs = {"banana", "apple", "grapes"};

            // Print the values using a Formatting String
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", i, f, d, b, c, str, x, z, arr, strs);

            // "null" means "no value"
            object obj = null;
            Console.WriteLine("null obj [{0}]", obj);

            // Implicit conversion between types
            long longNum = i; //implicit
            Console.WriteLine("int[{0}] to long = [{1}]", i, longNum);

            // Explicit conversions
            float floatNum = (float) i; //explicit - float to int
            int newInt = (int) f; //explicit - int to float
            Console.WriteLine("int[{0}] to float = [{1}]", i, floatNum);
            Console.WriteLine("float[{0}] to int = [{1}]", f, newInt);

        }
    }
}
