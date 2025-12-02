using System.Drawing;
using System.Windows.Forms;

namespace FortuneInventory
{
    partial class SettingsLoginHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            titleLabel = new Label();
            LoginHistoryGrid = new DataGridView();
            LogIdColumn = new DataGridViewTextBoxColumn();
            TimeInColumn = new DataGridViewTextBoxColumn();
            TimeOutColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)LoginHistoryGrid).BeginInit();
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
            titleLabel.Text = "Login History";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LoginHistoryGrid
            // 
            LoginHistoryGrid.AllowUserToAddRows = false;
            LoginHistoryGrid.AllowUserToDeleteRows = false;
            LoginHistoryGrid.AllowUserToResizeRows = false;
            LoginHistoryGrid.BackgroundColor = Color.WhiteSmoke;
            LoginHistoryGrid.BorderStyle = BorderStyle.None;
            LoginHistoryGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LoginHistoryGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(30, 40, 52);
            headerStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(30, 40, 52);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;
            LoginHistoryGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            LoginHistoryGrid.ColumnHeadersHeight = 48;
            LoginHistoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            LoginHistoryGrid.Columns.AddRange(new DataGridViewColumn[] { LogIdColumn, TimeInColumn, TimeOutColumn });
            defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            defaultCellStyle.BackColor = Color.White;
            defaultCellStyle.Font = new Font("Segoe UI", 11F);
            defaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51);
            defaultCellStyle.SelectionBackColor = Color.FromArgb(230, 242, 255);
            defaultCellStyle.SelectionForeColor = Color.FromArgb(30, 40, 52);
            defaultCellStyle.WrapMode = DataGridViewTriState.False;
            LoginHistoryGrid.DefaultCellStyle = defaultCellStyle;
            LoginHistoryGrid.Dock = DockStyle.Fill;
            LoginHistoryGrid.EnableHeadersVisualStyles = false;
            LoginHistoryGrid.GridColor = Color.FromArgb(235, 238, 245);
            LoginHistoryGrid.Location = new Point(0, 64);
            LoginHistoryGrid.MultiSelect = false;
            LoginHistoryGrid.Name = "LoginHistoryGrid";
            LoginHistoryGrid.ReadOnly = true;
            rowHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowHeaderStyle.BackColor = SystemColors.Control;
            rowHeaderStyle.Font = new Font("Segoe UI", 9F);
            rowHeaderStyle.ForeColor = SystemColors.WindowText;
            rowHeaderStyle.SelectionBackColor = SystemColors.Highlight;
            rowHeaderStyle.SelectionForeColor = SystemColors.HighlightText;
            rowHeaderStyle.WrapMode = DataGridViewTriState.True;
            LoginHistoryGrid.RowHeadersDefaultCellStyle = rowHeaderStyle;
            LoginHistoryGrid.RowHeadersVisible = false;
            altStyle.BackColor = Color.White;
            LoginHistoryGrid.RowsDefaultCellStyle = altStyle;
            LoginHistoryGrid.RowTemplate.Height = 40;
            LoginHistoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoginHistoryGrid.TabIndex = 1;
            // 
            // LogIdColumn
            // 
            LogIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LogIdColumn.FillWeight = 10F;
            LogIdColumn.HeaderText = "Log #";
            LogIdColumn.Name = "LogIdColumn";
            LogIdColumn.ReadOnly = true;
            // 
            // TimeInColumn
            // 
            TimeInColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeInColumn.FillWeight = 30F;
            TimeInColumn.HeaderText = "Time In";
            TimeInColumn.Name = "TimeInColumn";
            TimeInColumn.ReadOnly = true;
            // 
            // TimeOutColumn
            // 
            TimeOutColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TimeOutColumn.FillWeight = 30F;
            TimeOutColumn.HeaderText = "Time Out";
            TimeOutColumn.Name = "TimeOutColumn";
            TimeOutColumn.ReadOnly = true;
            // 
            // SettingsLoginHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(1013, 697);
            Controls.Add(LoginHistoryGrid);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsLoginHistory";
            Text = "SettingsLoginHistory";
            ((System.ComponentModel.ISupportInitialize)LoginHistoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private DataGridView LoginHistoryGrid;
        private DataGridViewTextBoxColumn LogIdColumn;
        private DataGridViewTextBoxColumn TimeInColumn;
        private DataGridViewTextBoxColumn TimeOutColumn;
    }
}


