using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question4
    {
        public static void Run()
        {
            // 1. Input marks from the user
            Console.Write("Enter student marks (0-100): ");
            double marks = double.Parse(Console.ReadLine());

            Console.WriteLine("\n===================================");

            // 2. Validate input and check grade criteria
            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid Input! Marks should be between 0 and 100.");
            }
            else if (marks >= 91)
            {
                Console.WriteLine($"Marks: {marks} | Grade: O (Outstanding)");
            }
            else if (marks >= 81)
            {
                Console.WriteLine($"Marks: {marks} | Grade: A+");
            }
            else if (marks >= 71)
            {
                Console.WriteLine($"Marks: {marks} | Grade: A");
            }
            else if (marks >= 61)
            {
                Console.WriteLine($"Marks: {marks} | Grade: B+");
            }
            else if (marks >= 51)
            {
                Console.WriteLine($"Marks: {marks} | Grade: B");
            }
            else
            {
                Console.WriteLine($"Marks: {marks} | Result: Fail");
            }

            Console.WriteLine("===================================");
        }
    }
}
