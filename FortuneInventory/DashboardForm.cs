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

namespace FortuneInventory
{
    public partial class DashboardForm : Form
    {
        private const int CardCornerRadius = 10;
        private readonly Dictionary<Panel, ShadowPanel> _shadowLookup = new();
        private readonly Point _shadowOffset = new(6, 8);
        private readonly SaleLedger _saleLedger = new SaleLedger();

        public DashboardForm()
        {
            InitializeComponent();
            InitializeCardPanels();
            Load += DashboardForm_Load;
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            LoadDashboardMetrics();
            LoadPopularProducts();
        }

        private void InitializeCardPanels()
        {
            var cards = new[] { panel1, panel2, panel3, panel4, panel5, panel6 };
            foreach (var card in cards)
            {
                ConfigureCardPanel(card);
            }
        }

        private void ConfigureCardPanel(Panel panel)
        {
            if (panel == null)
            {
                return;
            }

            panel.Resize += CardPanel_StructureChanged;
            panel.LocationChanged += CardPanel_StructureChanged;
            panel.ParentChanged += CardPanel_ParentChanged;
            ApplyRoundedCorners(panel);
            UpdateShadow(panel);
        }

        private void CardPanel_ParentChanged(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                UpdateShadow(panel);
            }
        }

        private void CardPanel_StructureChanged(object? sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                ApplyRoundedCorners(panel);
                UpdateShadow(panel);
            }
        }

        private void ApplyRoundedCorners(Panel panel)
        {
            if (panel.Width <= 0 || panel.Height <= 0)
            {
                return;
            }

            var bounds = new Rectangle(Point.Empty, panel.Size);
            using var path = CreateRoundedRectanglePath(bounds, CardCornerRadius);
            var newRegion = new Region(path);
            var oldRegion = panel.Region;
            panel.Region = newRegion;
            oldRegion?.Dispose();
        }

        private void UpdateShadow(Panel panel)
        {
            if (panel.Parent == null)
            {
                return;
            }

            if (!_shadowLookup.TryGetValue(panel, out var shadow))
            {
                shadow = new ShadowPanel
                {
                    CornerRadius = CardCornerRadius + 2,
                    ShadowColor = Color.FromArgb(60, 0, 0, 0)
                };

                _shadowLookup[panel] = shadow;
                panel.Parent.Controls.Add(shadow);
                shadow.SendToBack();
            }

            if (shadow.Parent != panel.Parent)
            {
                shadow.Parent?.Controls.Remove(shadow);
                panel.Parent.Controls.Add(shadow);
                shadow.SendToBack();
            }

            shadow.Bounds = new Rectangle(
                panel.Left + _shadowOffset.X,
                panel.Top + _shadowOffset.Y,
                panel.Width,
                panel.Height);
            shadow.Invalidate();
            panel.BringToFront();
        }

        private static GraphicsPath CreateRoundedRectanglePath(Rectangle bounds, int radius)
        {
            var diameter = radius * 2;
            var path = new GraphicsPath();

            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            var size = new Size(diameter, diameter);
            var arc = new Rectangle(bounds.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoadDashboardMetrics()
        {
            try
            {
                // Get today's date range (start of day to end of day)
                DateTime todayStart = DateTime.Today;
                DateTime todayEnd = todayStart.AddDays(1).AddTicks(-1);

                // Today's metrics
                int todayOrders = _saleLedger.GetOrderCount(todayStart, todayEnd);
                decimal todaySales = _saleLedger.GetTotalSales(todayStart, todayEnd);

                int totalOrders;
                decimal totalSales;

                // Total metrics depend on role:
                // - Admin: all users
                // - Staff: only their own sales
                if (UserSession.IsAdmin)
                {
                    totalOrders = _saleLedger.GetOrderCount();
                    totalSales = _saleLedger.GetTotalSales();
                }
                else if (UserSession.CurrentUserId.HasValue)
                {
                    totalOrders = _saleLedger.GetOrderCountForUser(UserSession.CurrentUserId.Value);
                    totalSales = _saleLedger.GetTotalSalesForUser(UserSession.CurrentUserId.Value);
                }
                else
                {
                    totalOrders = 0;
                    totalSales = 0;
                }

                // Average Order Value (Total Sales / Total Orders)
                decimal aov = totalOrders > 0 ? totalSales / totalOrders : 0;

                // Update labels with formatted numbers
                TodayOrderLabel.Text = todayOrders.ToString("N0");
                TodaySaleLabel.Text = $"P{todaySales:N2}";
                TotalOrderLabel.Text = totalOrders.ToString("N0");
                TotalSaleLabel.Text = $"P{totalSales:N2}";
                AovLabel.Text = $"P{aov:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dashboard metrics:\n{ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set default values on error
                TodayOrderLabel.Text = "0";
                TodaySaleLabel.Text = "P 0.00";
                TotalOrderLabel.Text = "0";
                TotalSaleLabel.Text = "P 0.00";
                AovLabel.Text = "P 0.00";
            }
        }

        private void LoadPopularProducts()
        {
            try
            {
                PopularProductTable.Rows.Clear();

                var popularProducts = _saleLedger.GetPopularProducts(10);

                foreach (var product in popularProducts)
                {
                    int rowIndex = PopularProductTable.Rows.Add();
                    var row = PopularProductTable.Rows[rowIndex];

                    row.Cells["id"].Value = product.ProductId;
                    row.Cells["ProductNameColumnDashboard"].Value = product.ProductName;
                    row.Cells["ProductSale"].Value = product.TotalQuantitySold;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load popular products:\n{ex.Message}", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed class ShadowPanel : Panel
        {
            public int CornerRadius { get; set; } = 12;
            public Color ShadowColor { get; set; } = Color.FromArgb(80, 0, 0, 0);

            public ShadowPanel()
            {
                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint |
                    ControlStyles.SupportsTransparentBackColor,
                    true);

                BackColor = Color.Transparent;
                Enabled = false;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                var rect = ClientRectangle;
                rect.Inflate(-1, -1);
                if (rect.Width <= 0 || rect.Height <= 0)
                {
                    return;
                }

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using var path = CreateRoundedRectanglePath(rect, CornerRadius);
                using var brush = new SolidBrush(ShadowColor);
                e.Graphics.FillPath(brush, path);
            }
        }
    }
}
