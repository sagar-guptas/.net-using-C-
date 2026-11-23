using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P9
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

            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
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

                    Console.WriteLine("Student inserted successfully.");
                    break;

                case 2:
                    Console.Write("Enter Student ID to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    DataRow updateRow = dt.Rows.Find(updateId);

                    if (updateRow != null)
                    {
                        Console.Write("Enter New Name: ");
                        updateRow["Name"] = Console.ReadLine();

                        Console.Write("Enter New Age: ");
                        updateRow["Age"] = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New Course: ");
                        updateRow["Course"] = Console.ReadLine();

                        adapter.Update(ds, "Student");

                        Console.WriteLine("Student updated successfully");
                    }
                    else
                    {
                        Console.WriteLine("Student ID not found.");
                    }
                    break;

                case 3:
                    Console.Write("Enter Student ID to delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    DataRow deleteRow = dt.Rows.Find(deleteId);

                    if (deleteRow != null)
                    {
                        deleteRow.Delete();

                        adapter.Update(ds, "Student");

                        Console.WriteLine("Student deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Student ID not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}