using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {3, 14, 15, 92, 6};
            string str = "The quick brown fox jumps over the lazy dog";

            // the basic for loop
            Console.WriteLine("The basic for loop:");
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine();

            // the foreach-in loop can be used to iterate over sequences
            Console.WriteLine("The foreach loop:");
            foreach(int n in nums) {
                Console.WriteLine(n);
            }

            Console.WriteLine();

            // count the number of o's in the string
            var count = 0;
            foreach (char c in str) {
                if (c == 'o') {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.WriteLine();

            string inputStr = "";

            // basic while loop executes while the gate condition is true
            Console.WriteLine("Basic while() loop:");

            while (inputStr != "exit") {
                inputStr = Console.ReadLine();
                Console.WriteLine("inputStr = {0}", inputStr);
            }

            Console.WriteLine();

            // the do-while loop always executes at least one time
            Console.WriteLine("The  do-while() loop:");
            do {
                inputStr = Console.ReadLine();
                Console.WriteLine("inputStr = {0}", inputStr);
            } while (inputStr != "exit");

            Console.WriteLine();

            // continue and break
            int[] values = {15, 7, 12, 23, 41, 28, 9, 17, 36};

            Console.WriteLine("Using break and continue :");
            foreach (int val in values)
            {
                // The continue statement skips the rest of the loop entirely
                // and jumps to the next iteration (if there is one)

                if (val == 12 || val == 23) {
                    continue;
                }
                
                // print the value
                Console.WriteLine($"val is currently {val}");

                // The break statement stops the loop and exits
                if (val == 41) {
                    break;
                }

            }

        }
    }
}
