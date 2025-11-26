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
using System.IO;

namespace FortuneInventory
{
    public partial class InventoryForm : Form
    {
		private bool _addProductOverlayInitialized;
		private Point _addProductOriginalLocation;
		private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";
		private System.Drawing.Image? _editIcon;
		private System.Drawing.Image? _deleteIcon;

        public InventoryForm()
        {
            InitializeComponent();
			// Keep the add-product panel hidden until used; its location is managed by the designer.
			AddProductPanel.Visible = false;

			// Load action icons
			LoadActionIcons();

			// Wire grid events
			InventoryGrid.CellClick += InventoryGrid_CellClick;

			// Load products when the form is first shown.
			Load += (_, _) => ReloadProducts();
        }

		private async void AddProductButton_Click(object sender, EventArgs e)
		{
			EnsureAddProductOverlay();
			var modal = new AddProductMODAL
			{
				OwnerInventory = this
			};
			loadAddProduct(modal);
			await SlideInAddProductPanelAsync();
		}

		private void SearchTextBox_TextChanged(object sender, EventArgs e)
		{
			// TODO: apply filtering when data source is connected.
		}

		public void loadAddProduct(object form)
		{ 
			if(this.AddProductPanel.Controls.Count > 0)
			{
				this.AddProductPanel.Controls.RemoveAt(0);
            }

			Form fp = form as Form;
			fp.TopLevel = false;
			fp.Dock = DockStyle.Fill;
			fp.ShowInTaskbar = false;
			this.AddProductPanel.Controls.Add(fp);
			this.AddProductPanel.Tag = fp;
			// Show and bring the panel to the front as an overlay.
			AddProductPanel.Visible = true;
			AddProductPanel.BringToFront();
			AddProductPanel.Focus();
			fp.Show();
        }

		private void EnsureAddProductOverlay()
		{
			if (_addProductOverlayInitialized)
			{
				return;
			}

			// Reparent the panel to the form while preserving its on-screen position,
			// so it can overlay the grid without changing the designer layout.
			var screenLocation = AddProductPanel.PointToScreen(Point.Empty);
			var clientLocation = this.PointToClient(screenLocation);

			AddProductPanel.Parent = this;
			AddProductPanel.Location = clientLocation;
			_addProductOriginalLocation = clientLocation;
			AddProductPanel.BackColor = Color.Transparent;

			_addProductOverlayInitialized = true;
		}

		private async Task SlideInAddProductPanelAsync(int durationMs = 220)
		{
			// Start slightly off-screen to the right and slide into the stored original location.
			const int frames = 16;
			int interval = Math.Max(8, durationMs / frames);

			var target = _addProductOriginalLocation;
			if (target == Point.Empty && AddProductPanel.Visible)
			{
				target = AddProductPanel.Location;
				_addProductOriginalLocation = target;
			}

			int startX = ClientSize.Width;
			int deltaX = target.X - startX;

			AddProductPanel.Location = new Point(startX, target.Y);
			AddProductPanel.Visible = true;
			AddProductPanel.BringToFront();

			for (int i = 1; i <= frames; i++)
			{
				double t = (double)i / frames;
				// Ease-out interpolation for smoother finish.
				double ease = 1 - Math.Pow(1 - t, 3);
				int x = startX + (int)(deltaX * ease);
				AddProductPanel.Location = new Point(x, target.Y);
				AddProductPanel.Update();
				await Task.Delay(interval);
			}

			AddProductPanel.Location = target;
		}

		public async Task SlideOutAndHideAddProductPanelAsync(int durationMs = 220)
		{
			if (!AddProductPanel.Visible)
			{
				return;
			}

			const int frames = 16;
			int interval = Math.Max(8, durationMs / frames);

			var start = AddProductPanel.Location;
			int endX = ClientSize.Width;
			int deltaX = endX - start.X;

			for (int i = 1; i <= frames; i++)
			{
				double t = (double)i / frames;
				double ease = 1 - Math.Pow(1 - t, 3);
				int x = start.X + (int)(deltaX * ease);
				AddProductPanel.Location = new Point(x, start.Y);
				AddProductPanel.Update();
				await Task.Delay(interval);
			}

			AddProductPanel.Visible = false;
		}

		private void LoadActionIcons()
		{
			// Use embedded resources (Project Properties -> Resources) for the icons.
			try { _editIcon = Properties.Resources.EditIcon; } catch { /* ignore */ }
			try { _deleteIcon = Properties.Resources.DeleteIcon; } catch { /* ignore */ }
		}

		public void ReloadProducts()
		{
			InventoryGrid.Rows.Clear();

			try
			{
				using var conn = new SqlConnection(_connectionString);
				conn.Open();

				string sql = @"
							SELECT p.productID,
								   p.productName,
								   c.categoryName,
								   ISNULL(p.quantity, 0)       AS quantity,
								   p.price,
								   CASE WHEN ISNULL(p.quantity, 0) > 0 THEN 'In Stock' ELSE 'Out of Stock' END AS status,
								   p.imagePath
							FROM   dbo.products_t p
							LEFT JOIN dbo.categories_t c ON p.categoryID = c.categoryID
							ORDER BY p.productID;";

				using var cmd = new SqlCommand(sql, conn);
                
				using var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					int rowIndex = InventoryGrid.Rows.Add();
					var row = InventoryGrid.Rows[rowIndex];

					row.Cells["ProductIdColumn"].Value = reader["productID"];

					// Load product image thumbnail if available, otherwise show MissingIMG.png.
					System.Drawing.Image? img = null;
					string baseDir = AppDomain.CurrentDomain.BaseDirectory;
					string? imagePathValue = reader["imagePath"] as string;

					try
					{
						string? candidate = null;
						if (!string.IsNullOrWhiteSpace(imagePathValue))
						{
							candidate = Path.IsPathRooted(imagePathValue)
								? imagePathValue
								: Path.Combine(baseDir, imagePathValue);
						}

						if (candidate == null || !File.Exists(candidate))
						{
							candidate = Path.Combine(baseDir, "images", "MissingIMG.png");
						}

						if (File.Exists(candidate))
						{
							using var fs = new FileStream(candidate, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
							img = System.Drawing.Image.FromStream(fs);
						}
					}
					catch
					{
						// ignore, leave img null
					}

					row.Cells["Image"].Value = img;

                    row.Cells["ProductNameColumn"].Value = reader["productName"];
					row.Cells["CategoryColumn"].Value = reader["categoryName"];
					row.Cells["QuantityColumn"].Value = reader["quantity"];
					row.Cells["PriceColumn"].Value = reader["price"];
					row.Cells["StatusColumn"].Value = reader["status"];

					// Color status text: green for In Stock, red otherwise.
					string statusText = reader["status"]?.ToString() ?? string.Empty;
					var statusCell = row.Cells["StatusColumn"];
					if (string.Equals(statusText, "In Stock", StringComparison.OrdinalIgnoreCase))
					{
						statusCell.Style.ForeColor = Color.Green;
					}
					else
					{
						statusCell.Style.ForeColor = Color.Red;
					}

					// Set action icons
					row.Cells["EditColumn"].Value = _editIcon;
					row.Cells["DeleteColumn"].Value = _deleteIcon;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this,
					$"Failed to load products:\n{ex.Message}",
					"Database Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void InventoryGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

			var grid = InventoryGrid;
			var columnName = grid.Columns[e.ColumnIndex].Name;

			if (columnName != "EditColumn" && columnName != "DeleteColumn")
			{
				return;
			}

			var idObj = grid.Rows[e.RowIndex].Cells["ProductIdColumn"].Value;
			if (idObj == null || !int.TryParse(idObj.ToString(), out int productId))
			{
				return;
			}

			if (columnName == "EditColumn")
			{
				OpenEditModal(productId);
			}
			else if (columnName == "DeleteColumn")
			{
				DeleteProduct(productId);
			}
		}

		private void OpenEditModal(int productId)
		{
			// Fetch product data
			string sql = @"
                        SELECT productID, categoryID, price, productName, discount, quantity, imagePath
                        FROM dbo.products_t
                        WHERE productID = @id;";

			string? name = null;
			int categoryId = 0;
			decimal price = 0;
			int quantity = 0;
			int? discount = null;
			string? imagePath = null;

			try
			{
				using var conn = new SqlConnection(_connectionString);
				conn.Open();
				using var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@id", productId);

				using var reader = cmd.ExecuteReader();
				if (!reader.Read())
				{
					MessageBox.Show(this, "Product not found.", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				name = reader["productName"]?.ToString() ?? string.Empty;
				categoryId = reader["categoryID"] is int c ? c : Convert.ToInt32(reader["categoryID"]);
				price = reader["price"] is decimal p ? p : Convert.ToDecimal(reader["price"]);
				quantity = reader["quantity"] is int q ? q : Convert.ToInt32(reader["quantity"]);
				discount = reader["discount"] == DBNull.Value ? null : (reader["discount"] as int? ?? Convert.ToInt32(reader["discount"]));
				imagePath = reader["imagePath"] as string;
			}
			catch (Exception ex)
			{
				MessageBox.Show(this,
					$"Failed to load product:\n{ex.Message}",
					"Edit Product",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			EnsureAddProductOverlay();

			var modal = new EditProductMODAL
			{
				StartPosition = FormStartPosition.CenterParent,
				OwnerInventory = this,
				ProductId = productId
			};

			// Fill fields
			modal.ProductNameTextbox.Text = name;

			modal.CategoryListBox.ClearSelected();
			int catIndex = categoryId switch
			{
				1 => 0, // Apparel
				2 => 1, // Appliances
				3 => 2, // Electronics
				_ => -1
			};
			if (catIndex >= 0 && catIndex < modal.CategoryListBox.Items.Count)
			{
				modal.CategoryListBox.SelectedIndex = catIndex;
			}

			modal.PriceInput.Text = price.ToString("0.##");
			modal.QuantityInput.Value = Math.Max(0, Math.Min(modal.QuantityInput.Maximum, quantity));
			modal.DiscountInput.Text = discount.HasValue ? discount.Value.ToString() : string.Empty;

			// Load image if exists
			try
			{
				if (!string.IsNullOrWhiteSpace(imagePath))
				{
					string baseDir = AppDomain.CurrentDomain.BaseDirectory;
					string fullPath = Path.IsPathRooted(imagePath)
						? imagePath
						: Path.Combine(baseDir, imagePath);

					if (File.Exists(fullPath))
					{
						using var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						modal.ProductPictureBox.Image = System.Drawing.Image.FromStream(fs);
						modal.ProductPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
						modal.ImageFileLabel.Text = Path.GetFileName(fullPath);
					}
				}
			}
			catch
			{
				// ignore image load failures
			}

			// Show in overlay panel
			loadAddProduct(modal);
			_ = SlideInAddProductPanelAsync();
		}

		private void DeleteProduct(int productId)
		{
			var confirm = MessageBox.Show(this,
				"Are you sure you want to delete this product?",
				"Delete Product",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (confirm != DialogResult.Yes)
			{
				return;
			}

			try
			{
				using var conn = new SqlConnection(_connectionString);
				conn.Open();
				using var cmd = new SqlCommand("DELETE FROM dbo.products_t WHERE productID = @id;", conn);
				cmd.Parameters.AddWithValue("@id", productId);
				cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(this,
					$"Failed to delete product:\n{ex.Message}",
					"Delete Product",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			ReloadProducts();
		}


    }
}
