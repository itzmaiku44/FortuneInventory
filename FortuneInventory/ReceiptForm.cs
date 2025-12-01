using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class ReceiptForm : Form
    {
        public List<CartItem> OrderItems { get; set; } = new List<CartItem>();
        public decimal TotalAmount { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal ChangeAmount { get; set; }
        private string orderNumber;
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";
        
        public ReceiptForm()
        {
            InitializeComponent();
            UpdateOrderNumber();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            LoadReceiptData();
        }

        private void UpdateOrderNumber()
        {
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = "SELECT ISNULL(MAX(orderID), 0) + 1 AS nextOrderID FROM dbo.order_t;";
                using var cmd = new SqlCommand(sql, conn);
                object result = cmd.ExecuteScalar();
                
                int nextOrderId = result != null && result != DBNull.Value 
                    ? Convert.ToInt32(result) 
                    : 1;
                
                orderNumber = nextOrderId.ToString("D7");
            }
            catch (Exception ex)
            {
                // If error, default to 1
                orderNumber = "0000001";
                System.Diagnostics.Debug.WriteLine($"Failed to get order number: {ex.Message}");
            }
        }

        private void LoadReceiptData()
        {
            if (OrderItems == null || OrderItems.Count == 0)
            {
                return;
            }

            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("========================================");
            receiptText.AppendLine("RETAIL BUSINESS Co.");
            receiptText.AppendLine("RECEIPT");
            receiptText.AppendLine("========================================");
            receiptText.AppendLine($"Order Number: {orderNumber}");
            receiptText.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            receiptText.AppendLine($"Cashier: {UserSession.CurrentUserName ?? "Unknown"}");
            receiptText.AppendLine("----------------------------------------");
            receiptText.AppendLine();

            decimal subtotal = OrderItems.Sum(x => x.TotalPrice);
            decimal vat = subtotal * 0.12m;

            foreach (var item in OrderItems)
            {
                receiptText.AppendLine($"{item.ProductName}");
                receiptText.AppendLine($"  {item.Quantity} x P {item.Price:F2} = P {item.TotalPrice:F2}");
                receiptText.AppendLine();
            }

            receiptText.AppendLine("----------------------------------------");
            receiptText.AppendLine($"Subtotal:        P {subtotal:F2}");
            receiptText.AppendLine($"VAT (12%):       P {vat:F2}");
            receiptText.AppendLine($"Total Amount:    P {TotalAmount:F2}");
            receiptText.AppendLine($"Payment:         P {PaymentAmount:F2}");
            receiptText.AppendLine($"Change:          P {ChangeAmount:F2}");
            receiptText.AppendLine("========================================");
            receiptText.AppendLine();
            receiptText.AppendLine("Thank you for your purchase!");
            receiptText.AppendLine("========================================");

            if (ReceiptTextBox != null)
            {
                ReceiptTextBox.Text = receiptText.ToString();
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Print functionality can be added here
            MessageBox.Show("Printed!.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

