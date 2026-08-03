using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question3
    {
        public static void Run()
        {
            // 1. Input a number from the user
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            Console.WriteLine("\n===================================");

            // 2. Check conditions using if-else statements
            if (number > 0)
            {
                Console.WriteLine($"{number} is a POSITIVE number.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"{number} is a NEGATIVE number.");
            }
            else
            {
                Console.WriteLine("The entered number is ZERO.");
            }

            Console.WriteLine("===================================");
        }
    }
}
