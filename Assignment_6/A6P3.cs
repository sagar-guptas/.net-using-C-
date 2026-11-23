using System;
using MySql.Data.MySqlClient;

class A6P3
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

            Console.Write("Enter Student ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter new Course: ");
            string course = Console.ReadLine();

            string query =
                "UPDATE Student SET Course = @course WHERE StudentID = @id";

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@id", id);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Student details updated successfully. ");
            }
            else
            {
                Console.WriteLine("Student ID not found.");
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