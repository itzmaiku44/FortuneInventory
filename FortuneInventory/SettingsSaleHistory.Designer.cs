using System.Drawing;
using System.Windows.Forms;

namespace FortuneInventory
{
    partial class SettingsSaleHistory
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            titleLabel = new Label();
            SaleHistoryGrid = new DataGridView();
            OrderIdColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            ProductColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            TotalColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SaleHistoryGrid).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(16, 16, 16, 8);
            titleLabel.Size = new Size(1013, 64);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Sale History";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SaleHistoryGrid
            // 
            SaleHistoryGrid.AllowUserToAddRows = false;
            SaleHistoryGrid.AllowUserToDeleteRows = false;
            SaleHistoryGrid.AllowUserToResizeRows = false;
            SaleHistoryGrid.BackgroundColor = Color.WhiteSmoke;
            SaleHistoryGrid.BorderStyle = BorderStyle.None;
            SaleHistoryGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SaleHistoryGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SaleHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SaleHistoryGrid.ColumnHeadersHeight = 48;
            SaleHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            SaleHistoryGrid.Columns.AddRange(new DataGridViewColumn[] { OrderIdColumn, DateColumn, ProductColumn, QuantityColumn, TotalColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SaleHistoryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            SaleHistoryGrid.Dock = DockStyle.Fill;
            SaleHistoryGrid.EnableHeadersVisualStyles = false;
            SaleHistoryGrid.GridColor = Color.FromArgb(235, 238, 245);
            SaleHistoryGrid.Location = new Point(0, 64);
            SaleHistoryGrid.MultiSelect = false;
            SaleHistoryGrid.Name = "SaleHistoryGrid";
            SaleHistoryGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            SaleHistoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            SaleHistoryGrid.RowHeadersVisible = false;
            SaleHistoryGrid.RowTemplate.Height = 40;
            SaleHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SaleHistoryGrid.Size = new Size(1013, 633);
            SaleHistoryGrid.TabIndex = 1;
            // 
            // OrderIdColumn
            // 
            OrderIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OrderIdColumn.FillWeight = 10F;
            OrderIdColumn.HeaderText = "Order #";
            OrderIdColumn.Name = "OrderIdColumn";
            OrderIdColumn.ReadOnly = true;
            // 
            // DateColumn
            // 
            DateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateColumn.FillWeight = 20F;
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            DateColumn.ReadOnly = true;
            // 
            // ProductColumn
            // 
            ProductColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductColumn.FillWeight = 30F;
            ProductColumn.HeaderText = "Product";
            ProductColumn.Name = "ProductColumn";
            ProductColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            QuantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityColumn.FillWeight = 10F;
            QuantityColumn.HeaderText = "Qty";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // TotalColumn
            // 
            TotalColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalColumn.FillWeight = 10F;
            TotalColumn.HeaderText = "Total";
            TotalColumn.Name = "TotalColumn";
            TotalColumn.ReadOnly = true;
            // 
            // SettingsSaleHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(1013, 697);
            Controls.Add(SaleHistoryGrid);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsSaleHistory";
            Text = "SettingsSaleHistory";
            ((System.ComponentModel.ISupportInitialize)SaleHistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private DataGridView SaleHistoryGrid;
        private DataGridViewTextBoxColumn OrderIdColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn ProductColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn TotalColumn;
    }
}


