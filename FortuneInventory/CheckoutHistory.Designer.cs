using System.Drawing;
using System.Windows.Forms;

namespace FortuneInventory
{
    partial class CheckoutHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel topPanel;
        private Label titleLabel;
        private DataGridView OrderHistoryGrid;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            topPanel = new Panel();
            titleLabel = new Label();
            OrderHistoryGrid = new DataGridView();
            OrderIdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            CashierColumn = new DataGridViewTextBoxColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            TotalPriceColumn = new DataGridViewTextBoxColumn();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderHistoryGrid).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.Controls.Add(titleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(32, 24, 32, 24);
            topPanel.Size = new Size(1591, 120);
            topPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 52);
            titleLabel.Location = new Point(32, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(258, 51);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Order History";
            // 
            // OrderHistoryGrid
            // 
            OrderHistoryGrid.AllowUserToAddRows = false;
            OrderHistoryGrid.AllowUserToDeleteRows = false;
            OrderHistoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            OrderHistoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            OrderHistoryGrid.BackgroundColor = Color.WhiteSmoke;
            OrderHistoryGrid.BorderStyle = BorderStyle.None;
            OrderHistoryGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            OrderHistoryGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            OrderHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            OrderHistoryGrid.ColumnHeadersHeight = 48;
            OrderHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            OrderHistoryGrid.Columns.AddRange(new DataGridViewColumn[] { OrderIdColumn, DateColumn, CashierColumn, ProductNameColumn, QuantityColumn, TotalPriceColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            OrderHistoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            OrderHistoryGrid.Dock = DockStyle.Fill;
            OrderHistoryGrid.EnableHeadersVisualStyles = false;
            OrderHistoryGrid.GridColor = Color.FromArgb(235, 238, 245);
            OrderHistoryGrid.Location = new Point(0, 120);
            OrderHistoryGrid.Margin = new Padding(10);
            OrderHistoryGrid.MultiSelect = false;
            OrderHistoryGrid.Name = "OrderHistoryGrid";
            OrderHistoryGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            OrderHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            OrderHistoryGrid.RowHeadersVisible = false;
            OrderHistoryGrid.RowTemplate.Height = 56;
            OrderHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderHistoryGrid.Size = new Size(1591, 941);
            OrderHistoryGrid.TabIndex = 1;
            // 
            // OrderIdColumn
            // 
            OrderIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderIdColumn.FillWeight = 15F;
            OrderIdColumn.HeaderText = "Order #";
            OrderIdColumn.Name = "OrderIdColumn";
            OrderIdColumn.ReadOnly = true;
            OrderIdColumn.Resizable = DataGridViewTriState.False;
            // 
            // DateColumn
            // 
            DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateColumn.FillWeight = 20F;
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            DateColumn.Resizable = DataGridViewTriState.False;
            // 
            // CashierColumn
            // 
            CashierColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CashierColumn.FillWeight = 25F;
            CashierColumn.HeaderText = "Cashier";
            CashierColumn.Name = "CashierColumn";
            CashierColumn.ReadOnly = true;
            CashierColumn.Resizable = DataGridViewTriState.False;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductNameColumn.FillWeight = 50F;
            ProductNameColumn.HeaderText = "Product Name";
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.ReadOnly = true;
            ProductNameColumn.Resizable = DataGridViewTriState.False;
            // 
            // QuantityColumn
            // 
            QuantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityColumn.FillWeight = 15F;
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            QuantityColumn.Resizable = DataGridViewTriState.False;
            // 
            // TotalPriceColumn
            // 
            TotalPriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPriceColumn.FillWeight = 20F;
            TotalPriceColumn.HeaderText = "Total Amount";
            TotalPriceColumn.Name = "TotalPriceColumn";
            TotalPriceColumn.ReadOnly = true;
            TotalPriceColumn.Resizable = DataGridViewTriState.False;
            // 
            // CheckoutHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1591, 1061);
            Controls.Add(OrderHistoryGrid);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CheckoutHistory";
            Text = "CheckoutHistory";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrderHistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewTextBoxColumn OrderIdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn CashierColumn;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn TotalPriceColumn;
    }
}