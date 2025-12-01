using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    internal class Login
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";
        private readonly string _password;
        private readonly string _username;
        
        public Login(string username, string password)
        {
            _username = username?.Trim() ?? string.Empty;
            _password = password ?? string.Empty;
        }

        public bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(_username) || string.IsNullOrWhiteSpace(_password))
            {
                return false;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    // Get userID along with authentication check
                    string query = @"SELECT userID, firstName + ' ' + lastName AS FullName
                                    FROM users_t 
                                    WHERE password = @password 
                                    AND (
                                        (firstName + ' ' + lastName) = @username
                                    )";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", _username);
                        command.Parameters.AddWithValue("@password", _password);
                        
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Store user ID and name in session
                                UserSession.CurrentUserId = reader["userID"] is int id ? id : Convert.ToInt32(reader["userID"]);
                                UserSession.CurrentUserName = reader["FullName"]?.ToString();
                                return true;
                            }
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Log error or handle database connection issues
                System.Diagnostics.Debug.WriteLine($"Authentication failed: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                System.Diagnostics.Debug.WriteLine($"Error during authentication: {ex.Message}");
                return false;
            }
        }

        public string GetUserFullName()
        {
            if (string.IsNullOrWhiteSpace(_username) || string.IsNullOrWhiteSpace(_password))
            {
                return string.Empty;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = @"SELECT firstName + ' ' + lastName AS FullName 
                                    FROM users_t 
                                    WHERE password = @password 
                                    AND (
                                        firstName = @username 
                                        OR lastName = @username 
                                        OR (firstName + ' ' + lastName) = @username
                                    )";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", _username);
                        command.Parameters.AddWithValue("@password", _password);
                        
                        object result = command.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
