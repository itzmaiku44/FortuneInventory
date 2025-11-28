using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class AddProductMODAL : Form
    {
        // Allows the modal to notify the owning InventoryForm (e.g.: to reload the grid)
        public InventoryForm? OwnerInventory { get; set; }

        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        private string? _imagePathRelative;

        public AddProductMODAL()
        {
            InitializeComponent();
            AddButton.Click += AddProductButton_Click;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }

                string sourcePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(sourcePath);

                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string imagesDir = Path.Combine(baseDir, "images");
                Directory.CreateDirectory(imagesDir);

                string destPath = Path.Combine(imagesDir, fileName);
                if (!string.Equals(sourcePath, destPath, StringComparison.OrdinalIgnoreCase))
                {
                    File.Copy(sourcePath, destPath, overwrite: true);
                }

                _imagePathRelative = Path.Combine("images", fileName);
                ImageFileLabel.Text = fileName;

                if (ProductPictureBox.Image != null)
                {
                    ProductPictureBox.Image.Dispose();
                    ProductPictureBox.Image = null;
                }

                ProductPictureBox.Image = Image.FromFile(destPath);
                ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load image:\n{ex.Message}",
                    "Image Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddProductButton_Click(object? sender, EventArgs e)
        {
            if (!TryBuildProduct(out var name, out var categoryId, out var price,
                    out var quantity, out var discount, out var imagePath))
            {
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                            INSERT INTO dbo.products_t (categoryID, price, productName, discount, quantity, imagePath)
                            VALUES (@categoryID, @price, @productName, @discount, @quantity, @imagePath);";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@categoryID", categoryId);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@productName", name);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@imagePath",
                    string.IsNullOrWhiteSpace(imagePath) ? (object)DBNull.Value : imagePath);
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
                    $"Failed to add product:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            OwnerInventory?.ReloadProducts();

            MessageBox.Show(this,
                "Product added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearInputs();
        }

        private bool TryBuildProduct(
            out string name,
            out int categoryId,
            out decimal price,
            out int quantity,
            out int? discount,
            out string imagePath)
        {
            name = ProductNameTextbox.Text.Trim();
            imagePath = _imagePathRelative ?? string.Empty;
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

        private void ClearInputs()
        {
            ProductNameTextbox.Clear();
            CategoryListBox.ClearSelected();
            PriceInput.Clear();
            QuantityInput.Value = 0;
            DiscountInput.Clear();

            ImageFileLabel.Text = "Click here to select";
            _imagePathRelative = null;

            if (ProductPictureBox.Image != null)
            {
                ProductPictureBox.Image.Dispose();
                ProductPictureBox.Image = null;
            }
        }

        private async void CancelButton_Click(object? sender, EventArgs e)
        {
            if (OwnerInventory != null)
            {
                await OwnerInventory.SlideOutAndHideAddProductPanelAsync();
            }

            Close();
        }

        private void AddProductMODAL_Load(object sender, EventArgs e)
        {

        }
    }
}
