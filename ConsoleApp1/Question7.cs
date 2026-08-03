using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question7
    {
        public static void Run()
        {
            // 1. Input number from user
            Console.Write("Enter a positive integer: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===================================");

            // 2. Validate for non-negative input
            if (n < 0)
            {
                Console.WriteLine("Error: Factorial is not defined for negative numbers.");
            }
            else
            {
                // Using long to prevent integer overflow for larger factorials
                long factorial = 1;

                // 3. Calculate factorial using a for loop
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i; // Same as factorial = factorial * i;
                }

                Console.WriteLine($"The Factorial of {n} ({n}!) is: {factorial}");
            }

            Console.WriteLine("===================================");
        }
    }
}
