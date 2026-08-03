using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n===================================");
            Console.WriteLine("Assignment 1 All 10 Question ");
            Console.WriteLine("Devloped By Sagar");
            Console.WriteLine("All CopyRight Reserved By Sagar");

            int choice;

            do
            {
                Console.WriteLine("\n===================================");
                Console.WriteLine(" Assignment 1: All 10 Questions    ");
                Console.WriteLine(" Developed By Sagar                ");
                Console.WriteLine("===================================");
                Console.WriteLine("1.  Student Details");
                Console.WriteLine("2.  Arithmetic Operations");
                Console.WriteLine("3.  Positive / Negative / Zero");
                Console.WriteLine("4.  Grade Calculation");
                Console.WriteLine("5.  Simple Calculator");
                Console.WriteLine("6.  Even & Odd Numbers (1 to N)");
                Console.WriteLine("7.  Factorial of a Number");
                Console.WriteLine("8.  Prime Number Check");
                Console.WriteLine("9.  Palindrome Number Check");
                Console.WriteLine("10. Menu Driven Program");
                Console.WriteLine("0.  Exit");
                Console.WriteLine("===================================");
                Console.Write("Enter Question Number to Run (0-10): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                Console.WriteLine("\n-----------------------------------");

                switch (choice)
                {
                    case 1:
                        Question1.Run(); // Calls Question1 file
                        break;
                    case 2:
                        Question2.Run();
                        break;
                    case 3:
                        Question3.Run();
                        break;
                    case 4:
                        Question4.Run();
                        break;
                    case 5:
                        Question5.Run();
                        break;
                    case 6:
                        Question6.Run();
                        break;
                    case 7:
                        Question7.Run();
                        break;
                    case 8:
                        Question8.Run();
                        break;
                    case 9:
                        Question9.Run();
                        break;
                    case 10:
                        Question10.Run();
                        break;
                    case 0:
                        Console.WriteLine("Exiting program... Good Luck!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Please enter 0 to 10.");
                        break;
                }

            } while (choice != 0);


        }
    }
}
