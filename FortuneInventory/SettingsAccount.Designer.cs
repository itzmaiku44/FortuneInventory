namespace FortuneInventory
{
    partial class SettingsAccount
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
        private Label titleLabel;
        private Label firstNameLabel;
        private TextBox FirstnameTextbox;
        private Label lastNameLabel;
        private TextBox LastnameTextbox;
        private Label passwordLabel;
        private TextBox PasswordTextbox;
        private Button SaveButton;

        private void InitializeComponent()
        {
            titleLabel = new Label();
            firstNameLabel = new Label();
            FirstnameTextbox = new TextBox();
            lastNameLabel = new Label();
            LastnameTextbox = new TextBox();
            passwordLabel = new Label();
            PasswordTextbox = new TextBox();
            SaveButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            titleLabel.Text = "Account Settings";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 11F);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(64, 96);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // FirstnameTextbox
            // 
            FirstnameTextbox.Font = new Font("Segoe UI", 11F);
            FirstnameTextbox.Location = new Point(64, 119);
            FirstnameTextbox.Name = "FirstnameTextbox";
            FirstnameTextbox.Size = new Size(320, 27);
            FirstnameTextbox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 11F);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(64, 168);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name";
            // 
            // LastnameTextbox
            // 
            LastnameTextbox.Font = new Font("Segoe UI", 11F);
            LastnameTextbox.Location = new Point(64, 191);
            LastnameTextbox.Name = "LastnameTextbox";
            LastnameTextbox.Size = new Size(320, 27);
            LastnameTextbox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 11F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(64, 240);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Font = new Font("Segoe UI", 11F);
            PasswordTextbox.Location = new Point(64, 263);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(320, 27);
            PasswordTextbox.TabIndex = 6;
            PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(52, 120, 246);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(64, 320);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 40);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save Changes";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.showPassBLACK;
            pictureBox1.Location = new Point(359, 265);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SettingsAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(1013, 697);
            Controls.Add(pictureBox1);
            Controls.Add(SaveButton);
            Controls.Add(PasswordTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(LastnameTextbox);
            Controls.Add(lastNameLabel);
            Controls.Add(FirstnameTextbox);
            Controls.Add(firstNameLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsAccount";
            Text = "SettingsAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
    }
}