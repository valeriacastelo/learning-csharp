using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables to excercise the operators
            int x=10, y=5;
            string a="abcd", b="efgh";

            // Basic math operators are +, -, /, *
            Console.WriteLine("----- Basic Math -----");
            Console.WriteLine((x / y) + x);
            Console.WriteLine(a + b);

            // Increment / decrement operators
            Console.WriteLine("----- Shorthand -----");
            Console.WriteLine(x++);
            Console.WriteLine(++y);

            // Operators can be shorthand: a = a + b
            Console.WriteLine(b+=a);

            // Logical operators &&, ||
            Console.WriteLine("----- Logic Operators -----");
            string s1 = "ab";
            string s2 = "ab";
            string s3 = "ab";
            Console.WriteLine(s1 == s3 && s2 == s3);
            Console.WriteLine(x > 10 || y == 6);

            // null-coalescing operators
            string str = null;
            // the ?? operator uses left operand if not null, or right one if it is
            Console.WriteLine(str ?? "notnull");
            Console.WriteLine((str ?? null) == null);

            // the ??= operator assigns the right operand if the left one is null
            // it replaces the code:
            // if (variable is null) {
            //    variable = somevalue;
            // }
            str ??= "new value";
            Console.WriteLine(str);

            str ??= "another value";
            Console.WriteLine(str);
            
        }
    }
}
