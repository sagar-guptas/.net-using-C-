using System;
using System.IO;

class Programm
{
    static void Main()
    {
        string name = "Ramendra Singh Sengar";
        string course = "MCA";
        int marks = 83;

       
        using (StringWriter writer = new StringWriter())
        {
          
            writer.WriteLine("Student Details");
            writer.WriteLine("------------------------");
            writer.WriteLine("Name   : " + name);
            writer.WriteLine("Course : " + course);
            writer.WriteLine("Marks  : " + marks);

            string studentData = writer.ToString();

            File.WriteAllText("student.txt", studentData);
        }

        Console.WriteLine("Student details successfully written to student.txt");
    }
}