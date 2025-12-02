using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class SettingsSaleHistory : Form
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        public SettingsSaleHistory()
        {
            InitializeComponent();
            Load += SettingsSaleHistory_Load;
        }

        private void SettingsSaleHistory_Load(object? sender, EventArgs e)
        {
            LoadSaleHistory();
        }

        private void LoadSaleHistory()
        {
            SaleHistoryGrid.Rows.Clear();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                if (!UserSession.CurrentUserId.HasValue)
                {
                    MessageBox.Show(this,
                        "No user session found. Unable to load sale history.",
                        "Sale History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string sql = @"
                    SELECT o.orderID,
                           o.date,
                           u.firstName + ' ' + u.lastName AS cashierName,
                           p.productName,
                           o.quantity,
                           o.totalPrice
                    FROM dbo.order_t o
                    LEFT JOIN dbo.users_t    u ON o.cashierID = u.userID
                    LEFT JOIN dbo.products_t p ON o.productID = p.productID
                    WHERE o.cashierID = @userID
                    ORDER BY o.date DESC, o.orderID DESC;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", UserSession.CurrentUserId.Value);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rowIndex = SaleHistoryGrid.Rows.Add();
                    var row = SaleHistoryGrid.Rows[rowIndex];

                    row.Cells["OrderIdColumn"].Value = reader["orderID"];

                    if (reader["date"] is DateTime date)
                    {
                        row.Cells["DateColumn"].Value = date.ToString("yyyy-MM-dd HH:mm");
                    }
                    else
                    {
                        row.Cells["DateColumn"].Value = "N/A";
                    }

                    
                    row.Cells["ProductColumn"].Value = reader["productName"]?.ToString() ?? "Unknown";
                    row.Cells["QuantityColumn"].Value = reader["quantity"];

                    if (reader["totalPrice"] != DBNull.Value)
                    {
                        decimal total = reader["totalPrice"] is decimal tp ? tp : Convert.ToDecimal(reader["totalPrice"]);
                        row.Cells["TotalColumn"].Value = total.ToString("N2");
                    }
                    else
                    {
                        row.Cells["TotalColumn"].Value = "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load sale history:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}


