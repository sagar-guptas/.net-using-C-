using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question9
    {
        public static void Run()
        {
            // 1. Input number from user
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int reverseNum = 0;

            // 2. Reverse the number
            while (temp > 0)
            {
                int remainder = temp % 10;
                reverseNum = (reverseNum * 10) + remainder;
                temp /= 10; // Same as temp = temp / 10
            }

            Console.WriteLine("\n===================================");

            // 3. Negative numbers are generally not palindromes due to the minus sign
            if (num < 0)
            {
                Console.WriteLine($"{num} is NOT a Palindrome number (negative numbers cannot be palindromes).");
            }
            // 4. Compare original number with the reversed number
            else if (num == reverseNum)
            {
                Console.WriteLine($"{num} is a PALINDROME number.");
            }
            else
            {
                Console.WriteLine($"{num} is NOT a Palindrome number.");
            }

            Console.WriteLine("===================================");
        }
    }
}
