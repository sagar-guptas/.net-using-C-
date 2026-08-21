using System;

class University
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public string HODName { get; set; }
        public int FacultyMembers { get; set; }

        public Department(string departmentName, string hodName, int facultyMembers)        {
            DepartmentName = departmentName;
            HODName = hodName;
            FacultyMembers = facultyMembers;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("HOD Name: " + HODName);
            Console.WriteLine("Number of Faculty Members: " + FacultyMembers);
        }
    }
}

class A3P8
{
    static void Main(string[] args)
    {
        University.Department department =
            new University.Department(
                "Computer Applications",
                "Dr. Sharma",
                15
            );
        department.DisplayDetails();
    }
}