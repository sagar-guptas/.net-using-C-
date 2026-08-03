using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question10
    {
        public static void Run()
        {
            int choice;

            // Loop until user selects option 4 (Exit)
            do
            {
                // 1. Display Menu
                Console.WriteLine("\n===================================");
                Console.WriteLine("             MENU                  ");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Check Even / Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");
                Console.WriteLine("===================================");
                Console.Write("Enter your choice (1-4): ");

                // Read choice input
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number (1-4).");
                    continue;
                }

                Console.WriteLine("-----------------------------------");

                // 2. Execute selected menu option
                switch (choice)
                {
                    case 1:
                        // Check Even/Odd
                        Console.Write("Enter a number: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 2 == 0)
                            Console.WriteLine($"{num} is an EVEN number.");
                        else
                            Console.WriteLine($"{num} is an ODD number.");
                        break;

                    case 2:
                        // Find Largest of Three Numbers
                        Console.Write("Enter First number: ");
                        double n1 = double.Parse(Console.ReadLine());
                        Console.Write("Enter Second number: ");
                        double n2 = double.Parse(Console.ReadLine());
                        Console.Write("Enter Third number: ");
                        double n3 = double.Parse(Console.ReadLine());

                        double largest = Math.Max(n1, Math.Max(n2, n3));
                        Console.WriteLine($"The largest number is: {largest}");
                        break;

                    case 3:
                        // Calculate Factorial
                        Console.Write("Enter a positive integer: ");
                        int n = int.Parse(Console.ReadLine());

                        if (n < 0)
                        {
                            Console.WriteLine("Factorial is not defined for negative numbers.");
                        }
                        else
                        {
                            long factorial = 1;
                            for (int i = 1; i <= n; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine($"The Factorial of {n} ({n}!) is: {factorial}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting program... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please select an option between 1 and 4.");
                        break;
                }

            } while (choice != 4);
        }
    }
}
