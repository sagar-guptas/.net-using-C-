using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P7
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

            Console.Write("Enter Student ID to update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DataRow row = dt.Rows.Find(id);

            if (row != null)
            {
                Console.Write("Enter New Name: ");
                row["Name"] = Console.ReadLine();

                Console.Write("Enter New Age: ");
                row["Age"] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Course: ");
                row["Course"] = Console.ReadLine();

                adapter.Update(ds, "Student");

                Console.WriteLine("Student record updated successfully.");
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