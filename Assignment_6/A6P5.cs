using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P5
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=CollegeDB;Uid=root;Pwd=1234;";

        MySqlConnection con = new MySqlConnection(connectionString);

        try
        {
            string query = "SELECT * FROM Student";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Student");

            Console.WriteLine("Student Records:");

            DataTable dt = ds.Tables["Student"];

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine(
                    "Student ID: " + row["StudentID"] +
                    ", Name: " + row["Name"] +
                    ", Age: " + row["Age"] +
                    ", Course: " + row["Course"]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}