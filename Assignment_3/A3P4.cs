using System;

sealed class EmployeePayroll
{
    private double salary;
    private double tax;
    public EmployeePayroll(double salary, double tax)
    {
        this.salary = salary;
        this.tax = tax;
    }
    public double CalculateSalary()
    {
        return salary;
    }
    public double CalculateTax()
    {
        return salary * tax / 100;
    }
    public double CalculateNetSalary()
    {
        return salary - CalculateTax();
    }
    public void DisplayPayroll()
    {
        Console.WriteLine("Salary: " + CalculateSalary());
        Console.WriteLine("Tax: " + CalculateTax());
        Console.WriteLine("Net Salary: " + CalculateNetSalary());
    }
}

class A3P4
{
    static void Main(string[] args)
    {
        EmployeePayroll employee = new EmployeePayroll(50000, 10);
        employee.DisplayPayroll();
    }
}