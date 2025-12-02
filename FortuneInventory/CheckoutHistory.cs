using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FortuneInventory
{
    public partial class CheckoutHistory : Form
    {
        private readonly SaleLedger _saleLedger = new SaleLedger();

        public CheckoutHistory()
        {
            InitializeComponent();

            if (!UserSession.IsAdmin)
            {
                MessageBox.Show(this,
                    "You do not have permission to view checkout history.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Close();
                return;
            }

            Load += CheckoutHistory_Load;
        }

        private void CheckoutHistory_Load(object? sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void LoadOrderHistory()
        {
            try
            {
                OrderHistoryGrid.Rows.Clear();

                List<SaleLedger.OrderRecord> orders = _saleLedger.GetAllOrders();

                foreach (var order in orders)
                {
                    int rowIndex = OrderHistoryGrid.Rows.Add();
                    var row = OrderHistoryGrid.Rows[rowIndex];

                    row.Cells["OrderIdColumn"].Value = order.OrderId;
                    row.Cells["DateColumn"].Value = order.Date.ToString("yyyy-MM-dd HH:mm");
                    row.Cells["CashierColumn"].Value = order.CashierName ?? $"User #{order.CashierId}";
                    row.Cells["ProductNameColumn"].Value = order.ProductName;
                    row.Cells["QuantityColumn"].Value = order.Quantity;
                    row.Cells["TotalPriceColumn"].Value = order.TotalPrice.ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load orders:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
