using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question8
    {
        public static void Run()
        {
            // 1. Input number from the user
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            bool isPrime = true;

            Console.WriteLine("\n===================================");

            // 2. Prime numbers are strictly greater than 1
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                // 3. Check for factors from 2 up to sqrt(num)
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break; // Stop loop immediately if a factor is found
                    }
                }
            }

            // 4. Output the result
            if (isPrime)
            {
                Console.WriteLine($"{num} is a PRIME number.");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a prime number.");
            }

            Console.WriteLine("===================================");
        }
    }
}
