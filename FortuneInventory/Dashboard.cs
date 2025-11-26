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
        private Button? _activeButton;
        private readonly Color _activeBackColor = Color.White;
        private readonly Color _activeForeColor = Color.FromArgb(30, 40, 52);
		private readonly Color _hoverBackColor = Color.FromArgb(85, 30, 40, 52); // rgba(30, 40, 52, 0.85)

        public Dashboard()
        {
            InitializeComponent();

			// Wire hover events for sidebar buttons
			HookSidebarButtonHover(DashboardButton);
			HookSidebarButtonHover(OrderButton);
			HookSidebarButtonHover(InventoryButton);
			HookSidebarButtonHover(UserManageButton);
        }

		private void HookSidebarButtonHover(Button button)
		{
			button.MouseEnter += SidebarButton_MouseEnter;
			button.MouseLeave += SidebarButton_MouseLeave;
		}

		private void SidebarButton_MouseEnter(object? sender, EventArgs e)
		{
			if (sender is not Button btn) return;
			if (btn == _activeButton) return; // keep active style
			btn.BackColor = _hoverBackColor;
		}

		private void SidebarButton_MouseLeave(object? sender, EventArgs e)
		{
			if (sender is not Button btn) return;
			if (btn == _activeButton) return; // keep active style
			btn.BackColor = Color.Transparent;
		}

        private void ResetAllButtons()
        {
            var buttons = new[] { DashboardButton, OrderButton, InventoryButton, UserManageButton };
            foreach (var button in buttons)
            {
                if (button != null)
                {
                    button.BackColor = Color.Transparent;
                    button.ForeColor = SystemColors.Control;
                }
            }
        }

        private void SetActiveButton(Button button)
        {
            ResetAllButtons();
            button.BackColor = _activeBackColor;
            button.ForeColor = _activeForeColor;
            _activeButton = button;
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
            SetActiveButton(DashboardButton);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            loadform(new OrderForm());
            SetActiveButton(OrderButton);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            loadform(new InventoryForm());
            SetActiveButton(InventoryButton);
        }

        private void UserManageButton_Click(object sender, EventArgs e)
        {
            loadform(new UserManageForm());
            SetActiveButton(UserManageButton);
        }

        private void UserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
