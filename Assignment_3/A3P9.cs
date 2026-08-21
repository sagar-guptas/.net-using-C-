using System;

static class ApplicationConfiguration
{
    public static string DatabaseServer = "localhost";
    public static string DatabaseName = "UniversityDB";
    public static string DatabaseUser = "root";
    public static string ApplicationName = "University Management System";
    public static string ApplicationVersion = "1.0";
    public static int SessionTimeout = 30;
    public static void DisplayConfiguration()
    {
        Console.WriteLine("--- Application Configuration ---");

        Console.WriteLine("Application Name: " + ApplicationName);
        Console.WriteLine("Application Version: " + ApplicationVersion);
        Console.WriteLine("Database Server: " + DatabaseServer);
        Console.WriteLine("Database Name: " + DatabaseName);
        Console.WriteLine("Database User: " + DatabaseUser);
        Console.WriteLine("Session Timeout: " + SessionTimeout + " minutes");
    }
}

class A3P9
{
    static void Main(string[] args)
    {
        ApplicationConfiguration.DisplayConfiguration();

        Console.WriteLine("\nDatabase Server: " +
                          ApplicationConfiguration.DatabaseServer);

        Console.WriteLine("Application Name: " +
                          ApplicationConfiguration.ApplicationName);
    }
}