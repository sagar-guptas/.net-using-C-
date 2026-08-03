using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question2
    {
        public static void Run()
        {
            // 1. Input two numbers from the user
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine());

            // 2. Perform Arithmetic Operations
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;

            Console.WriteLine("\n===================================");
            Console.WriteLine("          CALCULATED RESULTS       ");
            Console.WriteLine("===================================");
            Console.WriteLine($"Sum (+)        : {sum}");
            Console.WriteLine($"Difference (-) : {difference}");
            Console.WriteLine($"Product (*)    : {product}");

            // 3. Handle Division and Remainder safely (check for division by zero)
            if (num2 != 0)
            {
                double quotient = num1 / num2;
                double remainder = num1 % num2;

                Console.WriteLine($"Quotient (/)   : {quotient:F2}");
                Console.WriteLine($"Remainder (%)   : {remainder}");
            }
            else
            {
                Console.WriteLine("Quotient (/)   : Cannot divide by zero!");
                Console.WriteLine("Remainder (%)  : Cannot divide by zero!");
            }

            Console.WriteLine("===================================");
        }
    }
}
