using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P6
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

            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Student");

            DataTable dt = ds.Tables["Student"];

            DataRow newRow = dt.NewRow();

            Console.Write("Enter Student ID: ");
            newRow["StudentID"] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            newRow["Name"] = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            newRow["Age"] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Course: ");
            newRow["Course"] = Console.ReadLine();

            dt.Rows.Add(newRow);

            adapter.Update(ds, "Student");

            Console.WriteLine("Student record inserted successfully. ");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}