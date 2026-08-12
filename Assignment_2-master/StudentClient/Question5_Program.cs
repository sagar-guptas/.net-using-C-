using System;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchStudent researchStudent = new ResearchStudent();

            researchStudent.ShowData();

            Console.ReadLine();
        }
    }
}