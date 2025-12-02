using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class SettingsLoginHistory : Form
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        public SettingsLoginHistory()
        {
            InitializeComponent();
            Load += SettingsLoginHistory_Load;
        }

        private void SettingsLoginHistory_Load(object? sender, EventArgs e)
        {
            LoadLoginHistory();
        }

        private void LoadLoginHistory()
        {
            LoginHistoryGrid.Rows.Clear();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT l.logID,
                           l.TimeIn,
                           l.TimeOut
                    FROM dbo.loginhistory_t l
                    ORDER BY l.TimeIn DESC, l.logID DESC;";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rowIndex = LoginHistoryGrid.Rows.Add();
                    var row = LoginHistoryGrid.Rows[rowIndex];

                    row.Cells["LogIdColumn"].Value = reader["logID"];

                    if (reader["TimeIn"] is DateTime timeIn)
                    {
                        row.Cells["TimeInColumn"].Value = timeIn.ToString("yyyy-MM-dd HH:mm");
                    }
                    else
                    {
                        row.Cells["TimeInColumn"].Value = "N/A";
                    }

                    if (reader["TimeOut"] is DateTime timeOut)
                    {
                        row.Cells["TimeOutColumn"].Value = timeOut.ToString("yyyy-MM-dd HH:mm");
                    }
                    else
                    {
                        row.Cells["TimeOutColumn"].Value = "N/A";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load login history:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


