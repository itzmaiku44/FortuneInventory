namespace FortuneInventory
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            TodayOrderLabel = new Label();
            label2 = new Label();
            panel2 = new Panel();
            TotalOrderLabel = new Label();
            label4 = new Label();
            TodaySaleLabel = new Label();
            panel3 = new Panel();
            label10 = new Label();
            panel4 = new Panel();
            TotalSaleLabel = new Label();
            TotalSaletext = new Label();
            panel5 = new Panel();
            TotalVatLabel = new Label();
            label12 = new Label();
            panel6 = new Panel();
            AovLabel = new Label();
            label13 = new Label();
            PopularProductTable = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            ProductNameColumnDashboard = new DataGridViewTextBoxColumn();
            ProductSale = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PopularProductTable).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(414, 47);
            label1.TabIndex = 0;
            label1.Text = "DASHBOARD OVERVIEW";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(TodayOrderLabel);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(140, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 274);
            panel1.TabIndex = 1;
            // 
            // TodayOrderLabel
            // 
            TodayOrderLabel.BackColor = Color.Transparent;
            TodayOrderLabel.Dock = DockStyle.Fill;
            TodayOrderLabel.Font = new Font("Segoe UI", 44.25F, FontStyle.Bold);
            TodayOrderLabel.Location = new Point(0, 56);
            TodayOrderLabel.Name = "TodayOrderLabel";
            TodayOrderLabel.Size = new Size(362, 218);
            TodayOrderLabel.TabIndex = 1;
            TodayOrderLabel.Text = "99,999";
            TodayOrderLabel.TextAlign = ContentAlignment.MiddleCenter;
            TodayOrderLabel.Click += label8_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(362, 56);
            label2.TabIndex = 0;
            label2.Text = "Today's # of Order";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(TotalOrderLabel);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(620, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 274);
            panel2.TabIndex = 5;
            // 
            // TotalOrderLabel
            // 
            TotalOrderLabel.BackColor = Color.Transparent;
            TotalOrderLabel.Dock = DockStyle.Fill;
            TotalOrderLabel.Font = new Font("Segoe UI", 44.25F, FontStyle.Bold);
            TotalOrderLabel.Location = new Point(0, 56);
            TotalOrderLabel.Name = "TotalOrderLabel";
            TotalOrderLabel.Size = new Size(323, 218);
            TotalOrderLabel.TabIndex = 1;
            TotalOrderLabel.Text = "99,999";
            TotalOrderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(323, 56);
            label4.TabIndex = 0;
            label4.Text = "Total Order";
            // 
            // TodaySaleLabel
            // 
            TodaySaleLabel.BackColor = Color.Transparent;
            TodaySaleLabel.Dock = DockStyle.Fill;
            TodaySaleLabel.Font = new Font("Segoe UI", 40.25F, FontStyle.Bold);
            TodaySaleLabel.Location = new Point(0, 56);
            TodaySaleLabel.Name = "TodaySaleLabel";
            TodaySaleLabel.Size = new Size(362, 218);
            TodaySaleLabel.TabIndex = 1;
            TodaySaleLabel.Text = "P99,999.99";
            TodaySaleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TodaySaleLabel);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(1085, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(362, 274);
            panel3.TabIndex = 6;
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label10.ForeColor = Color.DimGray;
            label10.Location = new Point(0, 0);
            label10.Margin = new Padding(10);
            label10.Name = "label10";
            label10.Padding = new Padding(10);
            label10.Size = new Size(362, 56);
            label10.TabIndex = 0;
            label10.Text = "Today's Sales";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(TotalSaleLabel);
            panel4.Controls.Add(TotalSaletext);
            panel4.Location = new Point(140, 454);
            panel4.Name = "panel4";
            panel4.Size = new Size(362, 274);
            panel4.TabIndex = 2;
            // 
            // TotalSaleLabel
            // 
            TotalSaleLabel.BackColor = Color.Transparent;
            TotalSaleLabel.Dock = DockStyle.Fill;
            TotalSaleLabel.Font = new Font("Segoe UI", 40.25F, FontStyle.Bold);
            TotalSaleLabel.Location = new Point(0, 56);
            TotalSaleLabel.Name = "TotalSaleLabel";
            TotalSaleLabel.Size = new Size(362, 218);
            TotalSaleLabel.TabIndex = 1;
            TotalSaleLabel.Text = "P99,999.99";
            TotalSaleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TotalSaletext
            // 
            TotalSaletext.BackColor = Color.Transparent;
            TotalSaletext.Dock = DockStyle.Top;
            TotalSaletext.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            TotalSaletext.ForeColor = Color.DimGray;
            TotalSaletext.Location = new Point(0, 0);
            TotalSaletext.Margin = new Padding(10);
            TotalSaletext.Name = "TotalSaletext";
            TotalSaletext.Padding = new Padding(10);
            TotalSaletext.Size = new Size(362, 56);
            TotalSaletext.TabIndex = 0;
            TotalSaletext.Text = "Total Sales";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(TotalVatLabel);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(620, 454);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 274);
            panel5.TabIndex = 2;
            // 
            // TotalVatLabel
            // 
            TotalVatLabel.BackColor = Color.Transparent;
            TotalVatLabel.Dock = DockStyle.Fill;
            TotalVatLabel.Font = new Font("Segoe UI", 46.25F, FontStyle.Bold);
            TotalVatLabel.Location = new Point(0, 56);
            TotalVatLabel.Name = "TotalVatLabel";
            TotalVatLabel.Size = new Size(323, 218);
            TotalVatLabel.TabIndex = 1;
            TotalVatLabel.Text = "12";
            TotalVatLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.Transparent;
            label12.Dock = DockStyle.Top;
            label12.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label12.ForeColor = Color.DimGray;
            label12.Location = new Point(0, 0);
            label12.Margin = new Padding(10);
            label12.Name = "label12";
            label12.Padding = new Padding(10);
            label12.Size = new Size(323, 56);
            label12.TabIndex = 0;
            label12.Text = "VAT %";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(AovLabel);
            panel6.Controls.Add(label13);
            panel6.Location = new Point(1085, 454);
            panel6.Name = "panel6";
            panel6.Size = new Size(362, 274);
            panel6.TabIndex = 7;
            // 
            // AovLabel
            // 
            AovLabel.BackColor = Color.Transparent;
            AovLabel.Dock = DockStyle.Fill;
            AovLabel.Font = new Font("Segoe UI", 40.25F, FontStyle.Bold);
            AovLabel.Location = new Point(0, 56);
            AovLabel.Name = "AovLabel";
            AovLabel.Size = new Size(362, 218);
            AovLabel.TabIndex = 1;
            AovLabel.Text = "P99,999.99";
            AovLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = Color.Transparent;
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold);
            label13.ForeColor = Color.DimGray;
            label13.Location = new Point(0, 0);
            label13.Margin = new Padding(10);
            label13.Name = "label13";
            label13.Padding = new Padding(10);
            label13.Size = new Size(362, 56);
            label13.TabIndex = 0;
            label13.Text = "Avg. Order Value";
            // 
            // PopularProductTable
            // 
            PopularProductTable.AllowUserToAddRows = false;
            PopularProductTable.AllowUserToDeleteRows = false;
            PopularProductTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            PopularProductTable.BackgroundColor = Color.White;
            PopularProductTable.BorderStyle = BorderStyle.None;
            PopularProductTable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PopularProductTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PopularProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PopularProductTable.Columns.AddRange(new DataGridViewColumn[] { id, ProductNameColumnDashboard, ProductSale });
            PopularProductTable.Dock = DockStyle.Fill;
            PopularProductTable.GridColor = Color.Silver;
            PopularProductTable.Location = new Point(0, 0);
            PopularProductTable.Name = "PopularProductTable";
            PopularProductTable.ReadOnly = true;
            PopularProductTable.Size = new Size(1307, 221);
            PopularProductTable.TabIndex = 8;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 10;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 49;
            // 
            // ProductNameColumnDashboard
            // 
            ProductNameColumnDashboard.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductNameColumnDashboard.HeaderText = "Product Name";
            ProductNameColumnDashboard.Name = "ProductNameColumnDashboard";
            ProductNameColumnDashboard.ReadOnly = true;
            // 
            // ProductSale
            // 
            ProductSale.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductSale.FillWeight = 50F;
            ProductSale.HeaderText = "Total Order";
            ProductSale.Name = "ProductSale";
            ProductSale.ReadOnly = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(PopularProductTable);
            panel7.Location = new Point(140, 840);
            panel7.Name = "panel7";
            panel7.Size = new Size(1307, 221);
            panel7.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(141, 786);
            label14.Name = "label14";
            label14.Size = new Size(292, 45);
            label14.TabIndex = 10;
            label14.Text = "Popular Product(s)";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1607, 1100);
            Controls.Add(label14);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PopularProductTable).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label TodayOrderLabel;
        private Panel panel2;
        private Label TodaySaleLabel;
        private Label label4;
        private Panel panel3;
        private Label TotalOrderLabel;
        private Label label10;
        private Panel panel4;
        private Label TotalSaleLabel;
        private Label TotalSaletext;
        private Panel panel5;
        private Label TotalVatLabel;
        private Label label12;
        private Panel panel6;
        private Label AovLabel;
        private Label label13;
        public DataGridView PopularProductTable;
        private Panel panel7;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ProductNameColumnDashboard;
        private DataGridViewTextBoxColumn ProductSale;
        private Label label14;
    }
}