using System;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public class LoginHistoryService
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        public void LogLogin(int userId)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // Check if there is already an open login record (TimeOut IS NULL)
                string checkSql = @"
                    SELECT TOP (1) logID
                    FROM dbo.loginhistory_t
                    WHERE UserID = @userID AND TimeOut IS NULL
                    ORDER BY TimeIn DESC, logID DESC;";

                using var checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@userID", userId);
                var existingIdObj = checkCmd.ExecuteScalar();

                if (existingIdObj != null && existingIdObj != DBNull.Value)
                {
                    // Update the existing open record's TimeIn to the latest login time
                    int existingId = Convert.ToInt32(existingIdObj);
                    string updateSql = "UPDATE dbo.loginhistory_t SET TimeIn = @timeIn WHERE logID = @logID;";
                    using var updateCmd = new SqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@timeIn", DateTime.Now);
                    updateCmd.Parameters.AddWithValue("@logID", existingId);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // Insert a new login record
                    string insertSql = @"
                        INSERT INTO dbo.loginhistory_t (TimeIn, TimeOut, UserID)
                        VALUES (@timeIn, NULL, @userID);";

                    using var insertCmd = new SqlCommand(insertSql, conn);
                    insertCmd.Parameters.AddWithValue("@timeIn", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@userID", userId);
                    insertCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to log login: {ex.Message}");
            }
        }

        public void LogLogout(int userId)
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    UPDATE dbo.loginhistory_t
                    SET TimeOut = @timeOut
                    WHERE logID = (
                        SELECT TOP (1) logID
                        FROM dbo.loginhistory_t
                        WHERE UserID = @userID AND TimeOut IS NULL
                        ORDER BY TimeIn DESC, logID DESC
                    );";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@timeOut", DateTime.Now);
                cmd.Parameters.AddWithValue("@userID", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Failed to log logout: {ex.Message}");
            }
        }
    }
}


