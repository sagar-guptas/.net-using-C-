using System;

class A4P1
{
    
    delegate void CalculateSum(int a, int b);

    
    static void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Sum = " + result);
    }

    static void Main1()
    {
       
        CalculateSum calculate = Sum;

       
        calculate(10, 20);
    }
}