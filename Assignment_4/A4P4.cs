using System;

class A4P4
{
    delegate int Calculator(int a, int b);
    static int Addition(int a, int b)
    {
        return a + b;
    }

    static int Subtraction(int a, int b)
    {
        return a - b;
    }

    static int Multiplication(int a, int b)
    {
        return a * b;
    }

    static int Division(int a, int b)
    {
        return a / b;
    }

    static void Main()
    {
        Calculator calculate = Addition;

        calculate += Subtraction;
        calculate += Multiplication;
        calculate += Division;

        Delegate[] methods = calculate.GetInvocationList();

        foreach (Delegate method in methods)
        {
            Calculator calculatorMethod = (Calculator)method;

            int result = calculatorMethod(20, 5);

            Console.WriteLine(
                method.Method.Name + " = " + result
            );
        }
    }
}