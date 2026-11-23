using System;
using System.IO;

class Read
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter("student.txt"))
        {
            writer.WriteLine(name);
        }

        Console.WriteLine("Student name saved successfully.");
    }
}