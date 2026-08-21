using System;
using System.Collections.Generic;
class Repository<T>
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public List<T> GetAll()
    {
        return items;
    }
}
class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }

    public Student(int rollNumber, string name)
    {
        RollNumber = rollNumber;
        Name = name;
    }

    public override string ToString()
    {
        return "Roll Number: " + RollNumber + ", Name: " + Name;
    }
}
class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }

    public Employee(int employeeId, string name)
    {
        EmployeeId = employeeId;
        Name = name;
    }

    public override string ToString()
    {
        return "Employee ID: " + EmployeeId + ", Name: " + Name;
    }
}
class A3P7
{
    static void Main(string[] args)
    {
        Repository<Student> studentRepository = new Repository<Student>();

        studentRepository.Add(new Student(101, "sagar"));
        studentRepository.Add(new Student(102, "Rahul"));

        Console.WriteLine("Students:");

        foreach (Student student in studentRepository.GetAll())
        {
            Console.WriteLine(student);
        }
        Repository<Employee> employeeRepository = new Repository<Employee>();

        employeeRepository.Add(new Employee(501, "Sagar"));
        employeeRepository.Add(new Employee(502, "Rohit"));

        Console.WriteLine("\nEmployees:");

        foreach (Employee employee in employeeRepository.GetAll())
        {
            Console.WriteLine(employee);
        }
    }
}