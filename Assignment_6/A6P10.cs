using System;
using MySql.Data.MySqlClient;

class A6P10
{
    static void Main()
    {
        string connectionString =
            "Server=localhost;Port=3306;Database=CollegeDB;Uid=root;Pwd=1234;";

        MySqlConnection con = new MySqlConnection(connectionString);

        try
        {
            con.Open();

            int choice;

            do
            {
                Console.WriteLine("CONNECTED CRUD");
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
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Course: ");
                        string course = Console.ReadLine();

                        string insertQuery =
                            "INSERT INTO Student VALUES (@id, @name, @age, @course)";

                        MySqlCommand insertCmd =
                            new MySqlCommand(insertQuery, con);

                        insertCmd.Parameters.AddWithValue("@id", id);
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@age", age);
                        insertCmd.Parameters.AddWithValue("@course", course);

                        insertCmd.ExecuteNonQuery();

                        Console.WriteLine("Record inserted successfully!");
                        break;

                    case 2:
                        string selectQuery = "SELECT * FROM Student";

                        MySqlCommand selectCmd =
                            new MySqlCommand(selectQuery, con);

                        MySqlDataReader reader = selectCmd.ExecuteReader();

                        Console.WriteLine("Student Records:");

                        while (reader.Read())
                        {
                            Console.WriteLine(
                                reader["StudentID"] + "," +
                                reader["Name"] + "," +
                                reader["Age"] + "," +
                                reader["Course"]);
                        }

                        reader.Close();
                        break;

                    case 3:
                        Console.Write("Enter ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter New Course: ");
                        string newCourse = Console.ReadLine();

                        string updateQuery =
                            "UPDATE Student SET Course = @course WHERE StudentID = @id";

                        MySqlCommand updateCmd =
                            new MySqlCommand(updateQuery, con);

                        updateCmd.Parameters.AddWithValue("@course", newCourse);
                        updateCmd.Parameters.AddWithValue("@id", updateId);

                        int updated = updateCmd.ExecuteNonQuery();

                        if (updated > 0)
                            Console.WriteLine("Record updated successfully!");
                        else
                            Console.WriteLine("Student ID not found.");
                        break;

                    case 4:
                        Console.Write("Enter ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());

                        string deleteQuery =
                            "DELETE FROM Student WHERE StudentID = @id";

                        MySqlCommand deleteCmd =
                            new MySqlCommand(deleteQuery, con);

                        deleteCmd.Parameters.AddWithValue("@id", deleteId);

                        int deleted = deleteCmd.ExecuteNonQuery();

                        if (deleted > 0)
                            Console.WriteLine("Record deleted successfully!");
                        else
                            Console.WriteLine("Student ID not found.");
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
        finally
        {
            con.Close();
            Console.WriteLine("Database connection closed.");
        }
    }
}