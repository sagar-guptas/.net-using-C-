using System;
using System.Data;
using MySql.Data.MySqlClient;

class A6P11
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

            int choice;

            do
            {
                Console.WriteLine("DISCONNECTED CRUD : ");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. Read Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DataRow newRow = dt.NewRow();

                        Console.Write("Enter ID: ");
                        newRow["StudentID"] =
                            Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        newRow["Name"] = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        newRow["Age"] =
                            Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Course: ");
                        newRow["Course"] = Console.ReadLine();

                        dt.Rows.Add(newRow);

                        adapter.Update(ds, "Student");

                        Console.WriteLine("Record inserted successfully!");
                        break;

                    case 2:
                        Console.WriteLine("Student Records:");

                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine(
                                row["StudentID"] + " | " +
                                row["Name"] + " | " +
                                row["Age"] + " | " +
                                row["Course"]);
                        }
                        break;

                    case 3:
                        Console.Write("Enter ID to update: ");
                        int updateId =
                            Convert.ToInt32(Console.ReadLine());

                        DataRow updateRow = dt.Rows.Find(updateId);

                        if (updateRow != null)
                        {
                            Console.Write("Enter New Course: ");
                            updateRow["Course"] = Console.ReadLine();

                            adapter.Update(ds, "Student");

                            Console.WriteLine("Record updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found.");
                        }
                        break;

                    case 4:
                        Console.Write("Enter ID to delete: ");
                        int deleteId =
                            Convert.ToInt32(Console.ReadLine());

                        DataRow deleteRow = dt.Rows.Find(deleteId);

                        if (deleteRow != null)
                        {
                            deleteRow.Delete();

                            adapter.Update(ds, "Student");

                            Console.WriteLine("Record deleted successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Student ID not found.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}