using System;

class A4P3
{
    delegate void Calculator(int a, int b);
    static void Addition(int a, int b)
    {
        Console.WriteLine("Addition = " + (a + b));
    }

    static void Subtraction(int a, int b)
    {
        Console.WriteLine("Subtraction = " + (a - b));
    }

    static void Multiplication(int a, int b)
    {
        Console.WriteLine("Multiplication = " + (a * b));
    }

    static void Division(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Division = " + ((double)a / b));
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }

    static void Main()
    {
        
        Calculator calculate = Addition;
        calculate += Subtraction;
        calculate += Multiplication;
        calculate += Division;

        calculate(20, 5);
    }
}