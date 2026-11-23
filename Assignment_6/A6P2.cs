using System;
using MySql.Data.MySqlClient;

class A6P2
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=CollegeDB;Uid=root;Pwd=1234;";

        MySqlConnection con = new MySqlConnection(connectionString);

        try
        {
            con.Open();

            Console.WriteLine("Database connected successfully!");

            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Course: ");
            string course = Console.ReadLine();

            string query =
                "INSERT INTO Student (StudentID, Name, Age, Course) " +
                "VALUES (@id, @name, @age, @course)";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@course", course);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Student record inserted successfully. ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            con.Close();

            Console.WriteLine("Database connection closed.");
        }
    }
}