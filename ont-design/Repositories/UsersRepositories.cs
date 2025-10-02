using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using ont_design.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ont_design.Repository
{
    public class UsersRepositories
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GrocsmartDB;Integrated Security=True";

        public List<Users> GetAllUsers()
        {
            var users = new List<Users>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT* FROM Production.Products ORDER BY productid DESC"; // SQL query to fetch all products
                                                                                             //you could also use
                                                                                             //string sql = "SELECT productid, productName, supplierid, categoryid, unitprice, discontinued FROM Products";
                    using (SqlCommand command = new SqlCommand(sql, connection)) // SQL command to execute
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) // Execute the command and get a data reader
                        {
                            while (reader.Read()) // read each record
                            {
                                Users user = new Users
                                {
                                    Id = reader.GetInt32(0),
                                    Username = reader.GetString(1),
                                    Password = reader.GetString(2),
                                    firstName = reader.GetString(3),
                                    lastName = reader.GetString(4),
                                    startDate = reader.GetDateTime(5)
                                };
                                
                                users.Add(user); // add product to the list
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return users;
        }

        public Users? GetAllUsers(int userId) // new method to get a single product by id
        {

            try
            {
                // Database connection and data retrieval logic 
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT* FROM People.UserPerson WHERE Id=@userId";

                    using (SqlCommand command = new SqlCommand(sql, connection)) // SQL command to execute
                    {
                        command.Parameters.AddWithValue("@productid", userId); // add parameter to prevent SQL injection     
                        using (SqlDataReader reader = command.ExecuteReader()) // Execute the command and get a data reader
                        {
                            if (reader.Read()) // read each record
                            {
                                Users users = new Users();
                                users.Id = reader.GetInt32(0);
                                users.Username = reader.GetString(1);
                                users.Password = reader.GetString(2);
                                users.firstName = reader.GetString(3);
                                users.lastName = reader.GetString(4);
                                users.startDate = reader.GetDateTime(5);

                                return users; // return the product object   
                            }
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                // Handle exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null;
        }

        public void CreateUser(Users users)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO People.UserPerson " +
                        "(Username, Password, firstName, lastName, startDate) VALUES" +
                        "(@username, @password, @firstname, @lastname, @startdate);";

                    using (SqlCommand command = new SqlCommand(sql, connection))// SQL command to execute to replace parameters with actual values
                    {
                        command.Parameters.AddWithValue("@username", users.Username);
                        command.Parameters.AddWithValue("@password", users.Password);
                        command.Parameters.AddWithValue("@firstname", users.firstName);
                        command.Parameters.AddWithValue("@lastname", users.lastName);
                        command.Parameters.AddWithValue("@startdate", users.startDate);
                        command.ExecuteNonQuery(); // Execute the command

                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }

        }

        public void UpdateUsers(Users users)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))//Connect to the database
                {
                    connection.Open();//Open the connection
                    string sql = "UPDATE People.UserPerson " +
                        "SET Username=@username, Password=@password, firstName=@firstname, " +
                        "lastName=@lastname, startDate=@startdate" +
                        " WHERE Id=@userId;";
                    using (SqlCommand command = new SqlCommand(sql, connection))// SQL command to execute to replace parameters with actual values
                    {
                        command.Parameters.AddWithValue("@username", users.Username);
                        command.Parameters.AddWithValue("@password", users.Password);
                        command.Parameters.AddWithValue("@firstname", users.firstName);
                        command.Parameters.AddWithValue("@lastname", users.lastName);
                        command.Parameters.AddWithValue("@startdate", users.startDate);
                        command.Parameters.AddWithValue("@userId", users.Id);
                        command.ExecuteNonQuery(); // Execute the command

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))//Connect to the database
                {
                    connection.Open();//Open the connection
                    string sql = "DELETE FROM People.UserPerson WHERE Id=@userId;";
                    using (SqlCommand command = new SqlCommand(sql, connection))// SQL command to execute to replace parameters with actual values
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        int rowsAffected = command.ExecuteNonQuery(); // Execute the command
                        Console.WriteLine($"{rowsAffected} row(s) deleted."); // Inform how many rows were deleted
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
        }





    }
}

