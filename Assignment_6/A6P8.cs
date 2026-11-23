using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P8
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

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Student");

            DataTable dt = ds.Tables["Student"];

            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow row = dt.Rows.Find(id);

            if (row != null)
            {
                row.Delete();

                adapter.Update(ds, "Student");

                Console.WriteLine("Student record deleted successfully. ");
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
    }
}