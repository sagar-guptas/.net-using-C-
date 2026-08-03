using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question1
    {
        public static void Run()
        {
            // 1. Input Student Details
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Roll Number: ");
            int rollNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            double marks = double.Parse(Console.ReadLine());

            // 2. Display Details in Formatted Manner
            Console.WriteLine("\n===================================");
            Console.WriteLine("          STUDENT DETAILS          ");
            Console.WriteLine("===================================");
            Console.WriteLine($"Name        : {name}");
            Console.WriteLine($"Roll Number : {rollNumber}");
            Console.WriteLine($"Marks       : {marks:F2}");
            Console.WriteLine("===================================");
        }
    }
}
