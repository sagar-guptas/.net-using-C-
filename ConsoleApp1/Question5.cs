using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question5
    {
        public static void Run()
        {
            // 1. Input two numbers
            Console.Write("Enter First Number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = double.Parse(Console.ReadLine());

            // 2. Display Operation Options
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("  + : Addition");
            Console.WriteLine("  - : Subtraction");
            Console.WriteLine("  * : Multiplication");
            Console.WriteLine("  / : Division");
            Console.Write("Enter your choice (+, -, *, /): ");

            char op = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to next line

            Console.WriteLine("\n===================================");

            // 3. Switch Statement to perform selected operation
            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                    break;

                case '-':
                    Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                    break;

                case '*':
                    Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                    break;

                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1} / {num2} = {(num1 / num2):F2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operation! Please select +, -, *, or /.");
                    break;
            }

            Console.WriteLine("===================================");
        }
    }
}
