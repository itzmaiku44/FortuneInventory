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
    public partial class Dashboard : Form
    {
        private const int Panel3CornerRadius = 10;

        public Dashboard()
        {
            InitializeComponent();

        }


        public void loadform(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();


        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadform(new DashboardForm());
            if (DashboardButton.Focused)
            {
                DashboardButton.BackColor = Color.FromArgb(13, 20, 28);
            }
            else if (!DashboardButton.Focused)
            {
                DashboardButton.BackColor = Color.Transparent;
            }

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            loadform(new OrderForm());
            if (OrderButton.Focused)
            {
                OrderButton.BackColor = Color.FromArgb(13, 20, 28);
            }
            else
            {
                OrderButton.BackColor = Color.Transparent;
            }
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            loadform(new InventoryForm());
            if (InventoryButton.Focused)
            {
                InventoryButton.BackColor = Color.FromArgb(13, 20, 28);
            }
            else
            {
                InventoryButton.BackColor = Color.Transparent;
            }
        }

        private void UserManageButton_Click(object sender, EventArgs e)
        {
            loadform(new UserManageForm());
            if (UserManageButton.Focused)
            {
                UserManageButton.BackColor = Color.FromArgb(13, 20, 28);
            }
            else
            {
                UserManageButton.BackColor = Color.Transparent;
            }
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
