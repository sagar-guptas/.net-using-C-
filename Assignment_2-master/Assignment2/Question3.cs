using System;

namespace Assignment2
{
    class GraduateStudent : Student
    {
        public void ShowData()
        {
            // Through inheritance

            Name = "sagar";
            Department = "Computer Science";
            CGPA = 8.5;
            College = "ABC College";
            Address = "Delhi";

            Console.WriteLine("Through inheritance:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);


            // Through a Student object

            Student student = new Student();

            student.Name = "Another Student";
            student.CGPA = 9.0;
            student.College = "XYZ College";

            // student.Age = 23;
            // student.Department = "IT";
            // student.Address = "Mumbai";
        }
    }
}