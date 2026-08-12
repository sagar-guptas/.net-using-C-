using System;
using StudentLibrary;

namespace StudentClient
{
    class ResearchStudent : Student
    {
        public void ShowData()
        {
            // Through inheritance

            Name = "Mukund";
            Department = "Computer Science";
            College = "ABC College";

            Console.WriteLine("Through inheritance:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("College: " + College);


            // Through a Student object

            Student student = new Student();

            student.Name = "Another Student";

            // student.Department = "IT";
            // student.College = "XYZ College";
            // student.CGPA = 9.0;
            // student.Address = "Mumbai";
            // student.Age = 25;
        }
    }
}