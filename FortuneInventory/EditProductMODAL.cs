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
    public partial class EditProductMODAL : Form
    {
        public InventoryForm? OwnerInventory { get; set; }
        public int ProductId { get; set; }

        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        public EditProductMODAL()
        {
            InitializeComponent();
        }

        private async void CancelAddButton_Click(object? sender, EventArgs e)
        {
            if (OwnerInventory != null)
            {
                await OwnerInventory.SlideOutAndHideAddProductPanelAsync();
            }

            Close();
        }

        private async void EditProductButton_Click(object? sender, EventArgs e)
        {
            if (!TryBuildProduct(out var name, out var categoryId, out var price,
                    out var quantity, out var discount))
            {
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
UPDATE dbo.products_t
SET categoryID = @categoryID,
    price      = @price,
    productName= @productName,
    discount   = @discount,
    quantity   = @quantity
WHERE productID = @id;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", ProductId);
                cmd.Parameters.AddWithValue("@categoryID", categoryId);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@productName", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                if (discount.HasValue)
                {
                    cmd.Parameters.AddWithValue("@discount", discount.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@discount", DBNull.Value);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to update product:\n{ex.Message}",
                    "Edit Product",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            OwnerInventory?.ReloadProducts();

            if (OwnerInventory != null)
            {
                await OwnerInventory.SlideOutAndHideAddProductPanelAsync();
            }

            Close();
        }

        private bool TryBuildProduct(
            out string name,
            out int categoryId,
            out decimal price,
            out int quantity,
            out int? discount)
        {
            name = ProductNameTextbox.Text.Trim();
            discount = null;
            categoryId = 0;
            price = 0;
            quantity = 0;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(this, "Product name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProductNameTextbox.Focus();
                return false;
            }

            if (CategoryListBox.SelectedIndex < 0)
            {
                MessageBox.Show(this, "Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CategoryListBox.Focus();
                return false;
            }

            categoryId = CategoryListBox.SelectedIndex switch
            {
                0 => 1, // Apparel
                1 => 2, // Appliances
                2 => 3, // Electronics
                _ => 0
            };

            if (categoryId == 0)
            {
                MessageBox.Show(this, "Invalid category selection.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(PriceInput.Text, out price) || price < 0)
            {
                MessageBox.Show(this, "Please enter a valid, non-negative price.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PriceInput.Focus();
                return false;
            }

            quantity = (int)QuantityInput.Value;
            if (quantity < 0)
            {
                MessageBox.Show(this, "Quantity cannot be negative.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                QuantityInput.Focus();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(DiscountInput.Text))
            {
                if (!int.TryParse(DiscountInput.Text, out var d) || d < 0)
                {
                    MessageBox.Show(this, "Please enter a valid, non-negative discount.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DiscountInput.Focus();
                    return false;
                }

                discount = d;
            }

            return true;
        }
    }
}
