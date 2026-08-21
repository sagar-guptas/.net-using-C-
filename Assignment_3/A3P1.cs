using System;

class StudentUtility
{
    public static double CalculatePercentage(int obtainedMarks, int totalMarks)
    {
        return (obtainedMarks * 100.0) / totalMarks;
    }

    public static char CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return 'A';
        else if (percentage >= 80)
            return 'B';
        else if (percentage >= 70)
            return 'C';
        else if (percentage >= 60)
            return 'D';
        else
            return 'F';
    }

    public static double CalculateAttendancePercentage(int attended, int total)
    {
        return (attended * 100.0) / total;
    }
}

class A3P1
{
    static void Main1(string[] args)
    {
        double percentage =
            StudentUtility.CalculatePercentage(450, 500);

        char grade =
            StudentUtility.CalculateGrade(percentage);

        double attendance =
            StudentUtility.CalculateAttendancePercentage(80, 100);

        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Attendance: " + attendance + "%");
    }
}