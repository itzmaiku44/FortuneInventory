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
    public partial class OrderForm : Form
    {
        private const int Radius = 10;

        public OrderForm()
        {
            InitializeComponent();
            OrderPanel.Resize += OrderPanel_Resize;
            ApplyRoundedCorner();

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

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentForm paymentModal = new PaymentForm();
            paymentModal.ShowDialog();
        }
    }
}
