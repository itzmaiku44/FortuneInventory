namespace FortuneInventory
{
    partial class Dashboard
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
            label2 = new Label();
            SidebarPanel = new Panel();
            CheckoutHistoryButton = new Button();
            panel1 = new Panel();
            UserLabel = new TextBox();
            SettingButton = new Button();
            pictureBox1 = new PictureBox();
            UserManageButton = new Button();
            InventoryButton = new Button();
            OrderButton = new Button();
            DashboardButton = new Button();
            MainPanel = new Panel();
            SidebarPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("COMEBREAK", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(285, 29);
            label2.TabIndex = 4;
            label2.Text = "RETAIL BUSINESS Co.";
            // 
            // SidebarPanel
            // 
            SidebarPanel.BackColor = Color.FromArgb(30, 40, 52);
            SidebarPanel.Controls.Add(CheckoutHistoryButton);
            SidebarPanel.Controls.Add(panel1);
            SidebarPanel.Controls.Add(SettingButton);
            SidebarPanel.Controls.Add(pictureBox1);
            SidebarPanel.Controls.Add(label2);
            SidebarPanel.Controls.Add(UserManageButton);
            SidebarPanel.Controls.Add(InventoryButton);
            SidebarPanel.Controls.Add(OrderButton);
            SidebarPanel.Controls.Add(DashboardButton);
            SidebarPanel.Dock = DockStyle.Left;
            SidebarPanel.Location = new Point(0, 0);
            SidebarPanel.Name = "SidebarPanel";
            SidebarPanel.Size = new Size(313, 1080);
            SidebarPanel.TabIndex = 9;
            // 
            // CheckoutHistoryButton
            // 
            CheckoutHistoryButton.BackColor = Color.Transparent;
            CheckoutHistoryButton.FlatAppearance.BorderSize = 0;
            CheckoutHistoryButton.FlatStyle = FlatStyle.Flat;
            CheckoutHistoryButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            CheckoutHistoryButton.ForeColor = SystemColors.Control;
            CheckoutHistoryButton.Image = Properties.Resources.History__Streamline_Unicons;
            CheckoutHistoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            CheckoutHistoryButton.Location = new Point(12, 507);
            CheckoutHistoryButton.Name = "CheckoutHistoryButton";
            CheckoutHistoryButton.Size = new Size(285, 62);
            CheckoutHistoryButton.TabIndex = 9;
            CheckoutHistoryButton.Text = "Checkout History";
            CheckoutHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            CheckoutHistoryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CheckoutHistoryButton.UseVisualStyleBackColor = false;
            CheckoutHistoryButton.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(UserLabel);
            panel1.Location = new Point(50, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 24);
            panel1.TabIndex = 8;
            // 
            // UserLabel
            // 
            UserLabel.BackColor = Color.FromArgb(30, 40, 52);
            UserLabel.BorderStyle = BorderStyle.None;
            UserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLabel.ForeColor = Color.White;
            UserLabel.Location = new Point(13, 3);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(174, 22);
            UserLabel.TabIndex = 0;
            UserLabel.TextAlign = HorizontalAlignment.Center;
            // 
            // SettingButton
            // 
            SettingButton.BackColor = Color.Transparent;
            SettingButton.FlatAppearance.BorderSize = 0;
            SettingButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            SettingButton.FlatStyle = FlatStyle.Flat;
            SettingButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            SettingButton.ForeColor = SystemColors.Control;
            SettingButton.Image = Properties.Resources.Settings__Streamline_Block_Free;
            SettingButton.ImageAlign = ContentAlignment.MiddleLeft;
            SettingButton.Location = new Point(12, 1006);
            SettingButton.Name = "SettingButton";
            SettingButton.RightToLeft = RightToLeft.No;
            SettingButton.Size = new Size(285, 62);
            SettingButton.TabIndex = 7;
            SettingButton.Text = "Settings";
            SettingButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SettingButton.UseVisualStyleBackColor = false;
            SettingButton.Click += SettingButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.User__Streamline_Block_Free__1_;
            pictureBox1.Location = new Point(50, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UserManageButton
            // 
            UserManageButton.BackColor = Color.Transparent;
            UserManageButton.FlatAppearance.BorderSize = 0;
            UserManageButton.FlatStyle = FlatStyle.Flat;
            UserManageButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            UserManageButton.ForeColor = SystemColors.Control;
            UserManageButton.Image = Properties.Resources.User_Identifier_Card__Streamline_Core_Neon;
            UserManageButton.ImageAlign = ContentAlignment.MiddleLeft;
            UserManageButton.Location = new Point(12, 439);
            UserManageButton.Name = "UserManageButton";
            UserManageButton.Size = new Size(285, 62);
            UserManageButton.TabIndex = 3;
            UserManageButton.Text = "User Management";
            UserManageButton.TextAlign = ContentAlignment.MiddleLeft;
            UserManageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            UserManageButton.UseVisualStyleBackColor = false;
            UserManageButton.Click += UserManageButton_Click;
            // 
            // InventoryButton
            // 
            InventoryButton.BackColor = Color.Transparent;
            InventoryButton.FlatAppearance.BorderSize = 0;
            InventoryButton.FlatStyle = FlatStyle.Flat;
            InventoryButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            InventoryButton.ForeColor = SystemColors.Control;
            InventoryButton.Image = Properties.Resources.Warehouse_1__Streamline_Core_Neon;
            InventoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            InventoryButton.Location = new Point(12, 371);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(285, 62);
            InventoryButton.TabIndex = 2;
            InventoryButton.Text = "Inventory";
            InventoryButton.TextAlign = ContentAlignment.MiddleLeft;
            InventoryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            InventoryButton.UseVisualStyleBackColor = false;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.BackColor = Color.Transparent;
            OrderButton.FlatAppearance.BorderSize = 0;
            OrderButton.FlatStyle = FlatStyle.Flat;
            OrderButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            OrderButton.ForeColor = SystemColors.Control;
            OrderButton.Image = Properties.Resources.Shopping_Cart_Add__Streamline_Core_Neon;
            OrderButton.ImageAlign = ContentAlignment.MiddleLeft;
            OrderButton.Location = new Point(12, 303);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(285, 62);
            OrderButton.TabIndex = 1;
            OrderButton.Text = "Order         ";
            OrderButton.TextAlign = ContentAlignment.MiddleLeft;
            OrderButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            OrderButton.UseVisualStyleBackColor = false;
            OrderButton.Click += OrderButton_Click;
            // 
            // DashboardButton
            // 
            DashboardButton.BackColor = Color.Transparent;
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            DashboardButton.ForeColor = SystemColors.Control;
            DashboardButton.Image = Properties.Resources.Dashboard_3__Streamline_Core_Neon__1_;
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(12, 235);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.RightToLeft = RightToLeft.No;
            DashboardButton.Size = new Size(285, 62);
            DashboardButton.TabIndex = 0;
            DashboardButton.Text = "Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(313, 0);
            MainPanel.Margin = new Padding(0, 3, 3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1607, 1080);
            MainPanel.TabIndex = 10;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1920, 1080);
            Controls.Add(MainPanel);
            Controls.Add(SidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Dashboard  ";
            WindowState = FormWindowState.Maximized;
            SidebarPanel.ResumeLayout(false);
            SidebarPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel SidebarPanel;
        private Panel MainPanel;
        private Button DashboardButton;
        private Button InventoryButton;
        private Button OrderButton;
        private Button UserManageButton;
        private PictureBox pictureBox1;
        private Button SettingButton;
        private Panel panel1;
        public TextBox UserLabel;
        public Label UserWelcome;
        public Label DateLabel;
        private Button CheckoutHistoryButton;
    }
}