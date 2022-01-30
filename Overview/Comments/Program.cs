using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is a simple main method
        /// </summary>
        /// <param name='args'>An array</param>
        /// <returns>
        /// no values
        /// </returns>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Single line
            /* Multiple lines
               another line */
        }
    }
}
