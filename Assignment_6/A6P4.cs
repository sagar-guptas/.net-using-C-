using System;
using MySql.Data.MySqlClient;

class A6P4
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

            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            string query = "DELETE FROM Student WHERE StudentID = @id";

            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Student record deleted successfully!");
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