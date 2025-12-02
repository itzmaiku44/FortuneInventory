using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.IO;

namespace FortuneInventory
{
    public partial class OrderForm : Form
    {
        private const int Radius = 10;
        private const double VatRate = 0.12; // 12% VAT
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";
        
        private List<CartItem> _cartItems = new List<CartItem>();
        private Dictionary<int, int> _productQuantities = new Dictionary<int, int>(); // productID -> available quantity

        public OrderForm()
        {
            InitializeComponent();
            OrderPanel.Resize += OrderPanel_Resize;
            ApplyRoundedCorner();
            ProductsPanel.AutoScroll = true;
            CartItemListPanel.AutoScroll = true;
            UpdateOrderNumber();
            UpdateCheckoutSummary();
        }

        private void OrderPanel_Resize(object? sender, EventArgs e)
        {
            ApplyRoundedCorner();
        }

        private void ApplyRoundedCorner()
        {
            if (OrderPanel.Width <= 0 || OrderPanel.Height <= 0)
                return;
            using var path = CreateRoundedRectanglePath(OrderPanel.ClientRectangle, Radius);
            OrderPanel.Region?.Dispose();
            OrderPanel.Region = new Region(path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cancel order - clear cart
            _cartItems.Clear();
            UpdateCartDisplay();
            UpdateCheckoutSummary();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            UpdateOrderNumber();
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
                
                OrderNumLabel.Text = nextOrderId.ToString("D7");
            }
            catch (Exception ex)
            {
                // If error, default to 1
                OrderNumLabel.Text = "0000001";
                System.Diagnostics.Debug.WriteLine($"Failed to get order number: {ex.Message}");
            }
        }

        private void LoadProducts()
        {
            ProductsPanel.Controls.Clear();
            _productQuantities.Clear(); // Clear previous quantities

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT p.productID,
                           p.productName,
                           ISNULL(p.quantity, 0) AS quantity,
                           p.price,
                           p.imagePath
                    FROM dbo.products_t p
                    WHERE ISNULL(p.quantity, 0) > 0
                      AND ISNULL(p.isActive, 1) = 1
                    ORDER BY p.productID;";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                // Calculate grid dimensions for 4x4 layout
                const int columns = 4;
                const int rows = 4;
                const int margin = 10;
                const int spacing = 15;
                
                // Calculate card size based on panel dimensions
                int availableWidth = ProductsPanel.Width - (margin * 2) - (spacing * (columns - 1));
                int availableHeight = ProductsPanel.Height - (margin * 2) - (spacing * (rows - 1));
                int cardWidth = availableWidth / columns;
                int cardHeight = availableHeight / rows;

                int row = 0;
                int col = 0;

                while (reader.Read())
                {
                    int productId = reader["productID"] is int id ? id : Convert.ToInt32(reader["productID"]);
                    string productName = reader["productName"]?.ToString() ?? "Unknown";
                    int quantity = reader["quantity"] is int q ? q : Convert.ToInt32(reader["quantity"]);
                    decimal price = reader["price"] is decimal p ? p : Convert.ToDecimal(reader["price"]);
                    string? imagePath = reader["imagePath"] as string;

                    // Store product quantity for inventory tracking
                    _productQuantities[productId] = quantity;

                    // Calculate position in grid
                    int x = margin + (col * (cardWidth + spacing));
                    int y = margin + (row * (cardHeight + spacing));

                    // Create product card with calculated dimensions
                    Panel card = CreateProductCard(productId, productName, quantity, price, imagePath, cardWidth, cardHeight);
                    card.Location = new Point(x, y);
                    card.Size = new Size(cardWidth, cardHeight);
                    ProductsPanel.Controls.Add(card);

                    // Move to next position in grid
                    col++;
                    if (col >= columns)
                    {
                        col = 0;
                        row++;
                        // If we exceed 4 rows, continue but allow scrolling
                        if (row >= rows)
                        {
                            // Continue adding rows for scrolling
                        }
                    }
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

        private Panel CreateProductCard(int productId, string productName, int quantity, decimal price, string? imagePath, int cardWidth, int cardHeight)
        {
            Panel card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None,
                Size = new Size(cardWidth, cardHeight)
            };

            // Apply rounded corners (8px radius)
            ApplyRoundedCornersToPanel(card, 8);

            // Calculate proportional sizes based on card dimensions
            int padding = Math.Max(6, cardWidth / 20); // 6px minimum padding
            int gap = 3; // Gap between elements
            int imageHeight = (int)(cardHeight * 0.50); // 50% of card height for image
            int imageWidth = cardWidth - (padding * 2);
            int textAreaStart = imageHeight + padding + gap;
            int textAreaHeight = cardHeight - imageHeight - padding - (padding * 2) - gap;

            // Product Image
            PictureBox pictureBox = new PictureBox
            {
                Location = new Point(padding, padding),
                Size = new Size(imageWidth, imageHeight),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(255, 255, 255) // rgba(255, 255, 255, 1)
            };

            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string? candidate = null;
                if (!string.IsNullOrWhiteSpace(imagePath))
                {
                    candidate = Path.IsPathRooted(imagePath)
                        ? imagePath
                        : Path.Combine(baseDir, imagePath);
                }

                if (candidate == null || !File.Exists(candidate))
                {
                    candidate = Path.Combine(baseDir, "images", "MissingIMG.png");
                }

                if (File.Exists(candidate))
                {
                    using var fs = new FileStream(candidate, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    pictureBox.Image = Image.FromStream(fs);
                }
            }
            catch
            {
                // Use default image or leave empty
            }

            // Product Name
            int nameLabelHeight = textAreaHeight / 4;
            Label nameLabel = new Label
            {
                Text = productName,
                Location = new Point(padding, textAreaStart),
                Size = new Size(imageWidth, nameLabelHeight),
                Font = new Font("Segoe UI", Math.Max(8, cardWidth / 25), FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true,
                BackColor = Color.Transparent
            };

            // Quantity Label
            int qtyLabelHeight = textAreaHeight / 5;
            Label qtyLabel = new Label
            {
                Text = $"Qty: {quantity}",
                Location = new Point(padding, textAreaStart + nameLabelHeight + gap),
                Size = new Size(imageWidth, qtyLabelHeight),
                Font = new Font("Segoe UI", Math.Max(7, cardWidth / 28)),
                ForeColor = Color.Gray,
                BackColor = Color.Transparent
            };

            // Price Label
            int priceLabelHeight = textAreaHeight / 5;
            Label priceLabel = new Label
            {
                Text = $"P {price:F2}",
                Location = new Point(padding, textAreaStart + nameLabelHeight + qtyLabelHeight + (gap * 2)),
                Size = new Size(imageWidth, priceLabelHeight),
                Font = new Font("Segoe UI", Math.Max(9, cardWidth / 22), FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 215),
                BackColor = Color.Transparent
            };

            // Add Button with clean modern design
            int buttonHeight = textAreaHeight - nameLabelHeight - qtyLabelHeight - priceLabelHeight - (gap * 3);
            Button addButton = new Button
            {
                Text = "Add to Cart",
                Location = new Point(padding, textAreaStart + nameLabelHeight + qtyLabelHeight + priceLabelHeight + (gap * 4)),
                Size = new Size(imageWidth, buttonHeight),
                BackColor = Color.FromArgb(76, 175, 80), // Material Design Green
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", Math.Max(8, cardWidth / 24), FontStyle.Regular),
                Cursor = Cursors.Hand,
                TextAlign = ContentAlignment.MiddleCenter
            };
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(69, 160, 73); // Slightly darker green on hover
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 142, 60); // Darker green on click
            ApplyRoundedCornersToButton(addButton, 6);
            addButton.Click += (s, e) => AddToCart(productId, productName, price, pictureBox.Image);

            card.Controls.Add(pictureBox);
            card.Controls.Add(nameLabel);
            card.Controls.Add(qtyLabel);
            card.Controls.Add(priceLabel);
            card.Controls.Add(addButton);

            return card;
        }

        private void AddToCart(int productId, string productName, decimal price, Image? productImage)
        {
            // Get available quantity for this product
            if (!_productQuantities.ContainsKey(productId))
            {
                MessageBox.Show("Product quantity not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int availableQuantity = _productQuantities[productId];
            
            // Check how much is already in cart
            var existingItem = _cartItems.FirstOrDefault(x => x.ProductId == productId);
            int currentCartQuantity = existingItem?.Quantity ?? 0;

            // Check if adding one more would exceed available quantity
            if (currentCartQuantity + 1 > availableQuantity)
            {
                MessageBox.Show($"Cannot add more. Only {availableQuantity} available in stock.", 
                    "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = 1,
                    ProductImage = productImage != null ? new Bitmap(productImage) : null
                });
            }

            UpdateCartDisplay();
            UpdateCheckoutSummary();
        }

        private void UpdateCartDisplay()
        {
            CartItemListPanel.Controls.Clear();

            int yPos = 5;
            const int itemHeight = 80;
            const int spacing = 5;

            foreach (var item in _cartItems)
            {
                Panel cartItemPanel = CreateCartItemPanel(item);
                cartItemPanel.Location = new Point(5, yPos);
                cartItemPanel.Size = new Size(CartItemListPanel.Width - 10, itemHeight);
                CartItemListPanel.Controls.Add(cartItemPanel);

                yPos += itemHeight + spacing;
            }
        }

        private Panel CreateCartItemPanel(CartItem item)
        {
            Panel panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Product Image (small) - no border
            PictureBox imgBox = new PictureBox
            {
                Location = new Point(5, 5),
                Size = new Size(70, 70),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(245, 245, 245)
            };

            if (item.ProductImage != null)
            {
                imgBox.Image = item.ProductImage;
            }

            // Product Name
            Label nameLabel = new Label
            {
                Text = item.ProductName,
                Location = new Point(80, 10),
                Size = new Size(150, 20),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            // Quantity Controls with rounded corners
            Button decreaseBtn = new Button
            {
                Text = "-",
                Location = new Point(80, 35),
                Size = new Size(30, 25),
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            decreaseBtn.FlatAppearance.BorderSize = 0;
            ApplyRoundedCornersToButton(decreaseBtn, 5);

            Label qtyLabel = new Label
            {
                Text = item.Quantity.ToString(),
                Location = new Point(115, 35),
                Size = new Size(40, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(250, 250, 250)
            };

            Button increaseBtn = new Button
            {
                Text = "+",
                Location = new Point(160, 35),
                Size = new Size(30, 25),
                BackColor = Color.FromArgb(240, 240, 240),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            increaseBtn.FlatAppearance.BorderSize = 0;
            ApplyRoundedCornersToButton(increaseBtn, 5);

            decreaseBtn.Click += (s, e) =>
            {
                if (item.Quantity > 1)
                {
                    item.Quantity--;
                    qtyLabel.Text = item.Quantity.ToString();
                    UpdateCartDisplay();
                    UpdateCheckoutSummary();
                }
                else
                {
                    _cartItems.Remove(item);
                    UpdateCartDisplay();
                    UpdateCheckoutSummary();
                }
            };

            increaseBtn.Click += (s, e) =>
            {
                // Check available quantity
                if (!_productQuantities.ContainsKey(item.ProductId))
                {
                    MessageBox.Show("Product quantity not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int availableQuantity = _productQuantities[item.ProductId];
                // Check if increasing by 1 would exceed available quantity
                if (item.Quantity + 1 > availableQuantity)
                {
                    MessageBox.Show($"Cannot add more. Only {availableQuantity} available in stock.", 
                        "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                item.Quantity++;
                qtyLabel.Text = item.Quantity.ToString();
                UpdateCartDisplay();
                UpdateCheckoutSummary();
            };

            // Price (total)
            Label priceLabel = new Label
            {
                Text = $"P {item.TotalPrice:F2}",
                Location = new Point(350, 25),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 215)
            };

            panel.Controls.Add(imgBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(decreaseBtn);
            panel.Controls.Add(qtyLabel);
            panel.Controls.Add(increaseBtn);
            panel.Controls.Add(priceLabel);

            return panel;
        }

        private void UpdateCheckoutSummary()
        {
            decimal subtotal = _cartItems.Sum(x => x.TotalPrice);
            decimal vat = subtotal * (decimal)VatRate;
            decimal total = subtotal + vat;

            SubtotalLabel.Text = subtotal.ToString("F2");
            VatLabel.Text = vat.ToString("F2");
            TotalAmountLabel.Text = total.ToString("F2");
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            // top left
            path.AddArc(arc, 180, 90);

            // top right
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void ApplyRoundedCornersToPanel(Panel panel, int radius)
        {
            panel.Paint += (sender, e) =>
            {
                var path = CreateRoundedRectanglePath(panel.ClientRectangle, radius);
                panel.Region?.Dispose();
                panel.Region = new Region(path);
            };
        }

        private void ApplyRoundedCornersToButton(Button button, int radius)
        {
            // Action to apply rounded corners
            Action applyRoundedCorners = () =>
            {
                if (button.Width > 0 && button.Height > 0 && button.IsHandleCreated)
                {
                    try
                    {
                        var path = CreateRoundedRectanglePath(button.ClientRectangle, radius);
                        button.Region?.Dispose();
                        button.Region = new Region(path);
                    }
                    catch
                    {
                        // Ignore errors if handle is not ready
                    }
                }
            };

            // Apply when handle is created
            button.HandleCreated += (sender, e) => applyRoundedCorners();
            
            // Apply on resize
            button.Resize += (sender, e) =>
            {
                if (button.IsHandleCreated)
                {
                    applyRoundedCorners();
                }
            };
            
            // Apply after button is added to parent (only if handle is created)
            button.ParentChanged += (sender, e) =>
            {
                if (button.Parent != null && button.IsHandleCreated)
                {
                    try
                    {
                        button.BeginInvoke(new Action(() =>
                        {
                            if (button.IsHandleCreated)
                            {
                                applyRoundedCorners();
                            }
                        }));
                    }
                    catch
                    {
                        // If BeginInvoke fails, try direct call when handle is ready
                        if (button.IsHandleCreated)
                        {
                            applyRoundedCorners();
                        }
                    }
                }
            };

            // Apply immediately if handle is already created
            if (button.IsHandleCreated)
            {
                applyRoundedCorners();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items to cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = _cartItems.Sum(x => x.TotalPrice) * (1 + (decimal)VatRate);
            
            // Create a copy of cart items for the payment form
            var orderItemsCopy = _cartItems.Select(x => new CartItem
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Price = x.Price,
                Quantity = x.Quantity,
                ProductImage = x.ProductImage != null ? new Bitmap(x.ProductImage) : null
            }).ToList();

            PaymentForm paymentModal = new PaymentForm
            {
                TotalAmountValue = total,
                OrderItems = orderItemsCopy
            };
            
            if (paymentModal.ShowDialog() == DialogResult.OK)
            {
                // Payment successful - record order and clear cart
                RecordOrder();
                _cartItems.Clear();
                UpdateCartDisplay();
                UpdateCheckoutSummary();
                UpdateOrderNumber(); // Update to show next order number
            }
        }

        private void RecordOrder()
        {
            if (!UserSession.CurrentUserId.HasValue)
            {
                MessageBox.Show("User session not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // Use transaction to ensure both order recording and inventory update succeed or fail together
                using var transaction = conn.BeginTransaction();

                try
                {
                    // Record order items
                    foreach (var item in _cartItems)
                    {
                        string insertOrderSql = @"
                            INSERT INTO dbo.order_t (cashierID, date, productID, quantity, totalPrice)
                            VALUES (@cashierID, @date, @productID, @quantity, @totalPrice);";

                        using var cmd = new SqlCommand(insertOrderSql, conn, transaction);
                        cmd.Parameters.AddWithValue("@cashierID", UserSession.CurrentUserId.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@productID", item.ProductId);
                        cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@totalPrice", item.TotalPrice);
                        cmd.ExecuteNonQuery();

                        // Update product quantity in inventory
                        string updateInventorySql = @"
                            UPDATE dbo.products_t 
                            SET quantity = quantity - @quantity
                            WHERE productID = @productID;";

                        using var updateCmd = new SqlCommand(updateInventorySql, conn, transaction);
                        updateCmd.Parameters.AddWithValue("@productID", item.ProductId);
                        updateCmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        updateCmd.ExecuteNonQuery();

                        // Update local quantity tracking
                        if (_productQuantities.ContainsKey(item.ProductId))
                        {
                            _productQuantities[item.ProductId] -= item.Quantity;
                        }
                    }

                    // Commit transaction if all operations succeeded
                    transaction.Commit();

                    // Reload products to reflect updated quantities
                    LoadProducts();
                }
                catch
                {
                    // Rollback transaction on error
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to record order:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
