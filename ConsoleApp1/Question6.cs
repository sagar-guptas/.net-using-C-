using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question6
    {
        public static void Run()
        {
            // 1. Input value of N
            Console.Write("Enter the value of N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n===================================");

            // 2. Print Even Numbers
            Console.WriteLine($"EVEN Numbers between 1 and {n}:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); // New line

            Console.WriteLine("-----------------------------------");

            // 3. Print Odd Numbers
            Console.WriteLine($"ODD Numbers between 1 and {n}:");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n===================================");
        }
    }
}
