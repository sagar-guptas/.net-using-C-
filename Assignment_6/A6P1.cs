using System;
using MySql.Data.MySqlClient;

class A6P1
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=CollegeDB;Uid=root;Pwd=1234;";

        MySqlConnection con = new MySqlConnection(connectionString);

        try
        {

            con.Open();

            Console.WriteLine("Database connected successfully.");
            Console.WriteLine("Student Records:");

            string query = "SELECT * FROM Student";

            MySqlCommand cmd = new MySqlCommand(query, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    "Student ID: " + reader["StudentID"] +
                    ", Name: " + reader["Name"] +
                    ", Age: " + reader["Age"] +
                    ", Course: " + reader["Course"]);
            }

            reader.Close();
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