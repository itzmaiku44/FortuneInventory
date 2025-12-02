namespace FortuneInventory
{
    partial class SettingsForm
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
            SettingsPanel = new Panel();
            label1 = new Label();
            LogoutButton = new Button();
            AccountPanel = new Button();
            LoginHistoryPanel = new Button();
            SaleHistoryPanel = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // SettingsPanel
            // 
            SettingsPanel.BackColor = Color.Transparent;
            SettingsPanel.Location = new Point(12, 125);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(1013, 697);
            SettingsPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(235, 54);
            label1.TabIndex = 1;
            label1.Text = "SETTINGS";
            // 
            // LogoutButton
            // 
            LogoutButton.Anchor = AnchorStyles.None;
            LogoutButton.BackColor = Color.FromArgb(30, 40, 52);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Image = Properties.Resources.Log_Out_Sharp__Streamline_Ionic_Sharp;
            LogoutButton.ImageAlign = ContentAlignment.MiddleRight;
            LogoutButton.Location = new Point(889, 70);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(136, 51);
            LogoutButton.TabIndex = 27;
            LogoutButton.Text = "  Logout";
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // AccountPanel
            // 
            AccountPanel.BackColor = Color.Transparent;
            AccountPanel.FlatAppearance.BorderSize = 0;
            AccountPanel.FlatStyle = FlatStyle.Flat;
            AccountPanel.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            AccountPanel.ForeColor = Color.Black;
            AccountPanel.ImageAlign = ContentAlignment.MiddleLeft;
            AccountPanel.Location = new Point(12, 63);
            AccountPanel.Margin = new Padding(3, 3, 0, 3);
            AccountPanel.Name = "AccountPanel";
            AccountPanel.RightToLeft = RightToLeft.No;
            AccountPanel.Size = new Size(206, 62);
            AccountPanel.TabIndex = 28;
            AccountPanel.Text = "Account";
            AccountPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            AccountPanel.UseVisualStyleBackColor = false;
            AccountPanel.Click += AccountPanel_Click;
            // 
            // LoginHistoryPanel
            // 
            LoginHistoryPanel.BackColor = Color.Transparent;
            LoginHistoryPanel.FlatAppearance.BorderSize = 0;
            LoginHistoryPanel.FlatStyle = FlatStyle.Flat;
            LoginHistoryPanel.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            LoginHistoryPanel.ForeColor = Color.Black;
            LoginHistoryPanel.ImageAlign = ContentAlignment.MiddleLeft;
            LoginHistoryPanel.Location = new Point(212, 63);
            LoginHistoryPanel.Margin = new Padding(3, 3, 0, 3);
            LoginHistoryPanel.Name = "LoginHistoryPanel";
            LoginHistoryPanel.RightToLeft = RightToLeft.No;
            LoginHistoryPanel.Size = new Size(206, 62);
            LoginHistoryPanel.TabIndex = 29;
            LoginHistoryPanel.Text = "Login History";
            LoginHistoryPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginHistoryPanel.UseVisualStyleBackColor = false;
            // 
            // SaleHistoryPanel
            // 
            SaleHistoryPanel.BackColor = Color.Transparent;
            SaleHistoryPanel.FlatAppearance.BorderSize = 0;
            SaleHistoryPanel.FlatStyle = FlatStyle.Flat;
            SaleHistoryPanel.Font = new Font("Franklin Gothic Medium Cond", 15.75F);
            SaleHistoryPanel.ForeColor = Color.Black;
            SaleHistoryPanel.ImageAlign = ContentAlignment.MiddleLeft;
            SaleHistoryPanel.Location = new Point(412, 63);
            SaleHistoryPanel.Margin = new Padding(3, 3, 0, 3);
            SaleHistoryPanel.Name = "SaleHistoryPanel";
            SaleHistoryPanel.RightToLeft = RightToLeft.No;
            SaleHistoryPanel.Size = new Size(206, 62);
            SaleHistoryPanel.TabIndex = 30;
            SaleHistoryPanel.Text = "Sale History";
            SaleHistoryPanel.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaleHistoryPanel.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.Xbox_X__Streamline_Tabler_Filled;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(1004, 3);
            button1.Name = "button1";
            button1.Size = new Size(34, 38);
            button1.TabIndex = 31;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1043, 842);
            Controls.Add(button1);
            Controls.Add(SaleHistoryPanel);
            Controls.Add(LoginHistoryPanel);
            Controls.Add(AccountPanel);
            Controls.Add(LogoutButton);
            Controls.Add(label1);
            Controls.Add(SettingsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel SettingsPanel;
        private Label label1;
        private Button LogoutButton;
        private Button AccountPanel;
        private Button LoginHistoryPanel;
        private Button SaleHistoryPanel;
        private Button button1;
    }
}