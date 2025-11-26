namespace FortuneInventory
{
    partial class InventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            topPanel = new Panel();
            AddProductButton = new Button();
            titleLabel = new Label();
            AddProductPanel = new Panel();
            SearchBarPanel = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            InventoryGrid = new DataGridView();
            ProductIdColumn = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            ProductNameColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            EditColumn = new DataGridViewImageColumn();
            DeleteColumn = new DataGridViewImageColumn();
            topPanel.SuspendLayout();
            AddProductPanel.SuspendLayout();
            SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.Controls.Add(AddProductButton);
            topPanel.Controls.Add(titleLabel);
            topPanel.Controls.Add(AddProductPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(32, 24, 32, 24);
            topPanel.Size = new Size(1607, 140);
            topPanel.TabIndex = 0;
            // 
            // AddProductButton
            // 
            AddProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddProductButton.BackColor = Color.FromArgb(52, 120, 246);
            AddProductButton.FlatAppearance.BorderSize = 0;
            AddProductButton.FlatStyle = FlatStyle.Flat;
            AddProductButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddProductButton.ForeColor = Color.White;
            AddProductButton.Location = new Point(1395, 74);
            AddProductButton.Name = "AddProductButton";
            AddProductButton.Size = new Size(180, 44);
            AddProductButton.TabIndex = 2;
            AddProductButton.Text = "Add Product";
            AddProductButton.UseVisualStyleBackColor = false;
            AddProductButton.Click += AddProductButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 52);
            titleLabel.Location = new Point(32, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(188, 51);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Inventory";
            // 
            // AddProductPanel
            // 
            AddProductPanel.BackColor = Color.Transparent;
            AddProductPanel.Controls.Add(SearchBarPanel);
            AddProductPanel.Location = new Point(591, 74);
            AddProductPanel.Name = "AddProductPanel";
            AddProductPanel.Size = new Size(1016, 940);
            AddProductPanel.TabIndex = 4;
            // 
            // SearchBarPanel
            // 
            SearchBarPanel.BackColor = Color.White;
            SearchBarPanel.Controls.Add(pictureBox1);
            SearchBarPanel.Controls.Add(textBox1);
            SearchBarPanel.Location = new Point(463, 7);
            SearchBarPanel.Name = "SearchBarPanel";
            SearchBarPanel.Size = new Size(322, 32);
            SearchBarPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Search__Streamline_Block_Free;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 28);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(28, 5);
            textBox1.Margin = new Padding(0);
            textBox1.MaxLength = 120;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search product...";
            textBox1.Size = new Size(294, 20);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += SearchTextBox_TextChanged;
            // 
            // InventoryGrid
            // 
            InventoryGrid.AllowUserToAddRows = false;
            InventoryGrid.AllowUserToDeleteRows = false;
            InventoryGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            InventoryGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            InventoryGrid.BackgroundColor = Color.WhiteSmoke;
            InventoryGrid.BorderStyle = BorderStyle.None;
            InventoryGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            InventoryGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            InventoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            InventoryGrid.ColumnHeadersHeight = 52;
            InventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            InventoryGrid.Columns.AddRange(new DataGridViewColumn[] { ProductIdColumn, Image, ProductNameColumn, CategoryColumn, QuantityColumn, PriceColumn, StatusColumn, EditColumn, DeleteColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            InventoryGrid.DefaultCellStyle = dataGridViewCellStyle3;
            InventoryGrid.Dock = DockStyle.Fill;
            InventoryGrid.EnableHeadersVisualStyles = false;
            InventoryGrid.GridColor = Color.FromArgb(235, 238, 245);
            InventoryGrid.Location = new Point(0, 140);
            InventoryGrid.MultiSelect = false;
            InventoryGrid.Name = "InventoryGrid";
            InventoryGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            InventoryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            InventoryGrid.RowHeadersVisible = false;
            InventoryGrid.RowTemplate.Height = 72;
            InventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InventoryGrid.Size = new Size(1607, 940);
            InventoryGrid.TabIndex = 1;
            // 
            // ProductIdColumn
            // 
            ProductIdColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductIdColumn.FillWeight = 15F;
            ProductIdColumn.HeaderText = "ID";
            ProductIdColumn.MinimumWidth = 10;
            ProductIdColumn.Name = "ProductIdColumn";
            ProductIdColumn.ReadOnly = true;
            // 
            // Image
            // 
            Image.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Image.FillWeight = 30F;
            Image.HeaderText = "";
            Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            ProductNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductNameColumn.FillWeight = 80F;
            ProductNameColumn.HeaderText = "Product Name";
            ProductNameColumn.Name = "ProductNameColumn";
            ProductNameColumn.ReadOnly = true;
            ProductNameColumn.ToolTipText = "Name of the product.";
            // 
            // CategoryColumn
            // 
            CategoryColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CategoryColumn.FillWeight = 68.07374F;
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            QuantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityColumn.FillWeight = 29.1744614F;
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // PriceColumn
            // 
            PriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PriceColumn.FillWeight = 30F;
            PriceColumn.HeaderText = "Unit Price";
            PriceColumn.Name = "PriceColumn";
            PriceColumn.ReadOnly = true;
            // 
            // StatusColumn
            // 
            StatusColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StatusColumn.FillWeight = 30F;
            StatusColumn.HeaderText = "Status";
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            EditColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditColumn.HeaderText = "";
            EditColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditColumn.Name = "EditColumn";
            EditColumn.ReadOnly = true;
            EditColumn.Width = 21;
            // 
            // DeleteColumn
            // 
            DeleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteColumn.HeaderText = "";
            DeleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteColumn.Name = "DeleteColumn";
            DeleteColumn.ReadOnly = true;
            DeleteColumn.Width = 21;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1607, 1080);
            Controls.Add(InventoryGrid);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventoryForm";
            Text = "InventoryForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            AddProductPanel.ResumeLayout(false);
            SearchBarPanel.ResumeLayout(false);
            SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)InventoryGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
		private Button AddProductButton;
		private Label titleLabel;
		private DataGridView InventoryGrid;
        private Panel SearchBarPanel;
        private TextBox textBox1;
        private Panel AddProductPanel;
        private DataGridViewTextBoxColumn ProductIdColumn;
        private DataGridViewImageColumn Image;
        private DataGridViewTextBoxColumn ProductNameColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewImageColumn EditColumn;
        private DataGridViewImageColumn DeleteColumn;
        private PictureBox pictureBox1;
    }
}