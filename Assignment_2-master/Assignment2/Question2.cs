using System;

namespace Assignment2
{
    class TestStudent
    {
        public void TestAccess()
        {
            Student student = new Student();

            student.Name = "sagar";          // public
            student.CGPA = 8.5;               // internal
            student.College = "ABC College";  // protected internal

            // student.Age = 23;              // private 
            // student.Department = "CS";     // protected 
            // student.Address = "Delhi";     // private protected 

            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("CGPA: " + student.CGPA);
            Console.WriteLine("College: " + student.College);
        }
    }
}