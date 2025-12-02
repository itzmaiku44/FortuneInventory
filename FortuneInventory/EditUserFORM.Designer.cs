namespace FortuneInventory
{
    partial class EditUserFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserFORM));
            AddButton = new Button();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            RoleDropdown = new ComboBox();
            pictureBox3 = new PictureBox();
            LastnameTextbox = new TextBox();
            CancelButton = new Button();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            PasswordTextbox = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            FirstnameTextbox = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddButton.BackColor = Color.FromArgb(52, 120, 246);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            AddButton.ForeColor = Color.White;
            AddButton.Image = Properties.Resources.Add__Streamline_Block_Free;
            AddButton.ImageAlign = ContentAlignment.MiddleRight;
            AddButton.Location = new Point(334, 345);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(193, 60);
            AddButton.TabIndex = 26;
            AddButton.Text = "  Save Changes";
            AddButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(463, 227);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 22;
            label5.Text = "User Role";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.User_Identifier_Card__Streamline_Core_Neon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 20);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 52, 68);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(RoleDropdown);
            panel4.Location = new Point(463, 251);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 28);
            panel4.TabIndex = 24;
            // 
            // RoleDropdown
            // 
            RoleDropdown.BackColor = Color.FromArgb(39, 52, 68);
            RoleDropdown.FlatStyle = FlatStyle.Flat;
            RoleDropdown.Font = new Font("Franklin Gothic Book", 12F);
            RoleDropdown.ForeColor = Color.White;
            RoleDropdown.FormattingEnabled = true;
            RoleDropdown.Items.AddRange(new object[] { "Staff", "Admin" });
            RoleDropdown.Location = new Point(37, 1);
            RoleDropdown.Name = "RoleDropdown";
            RoleDropdown.Size = new Size(256, 29);
            RoleDropdown.TabIndex = 12;
            RoleDropdown.Text = "Select a role";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 20);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // LastnameTextbox
            // 
            LastnameTextbox.BackColor = Color.FromArgb(39, 52, 68);
            LastnameTextbox.BorderStyle = BorderStyle.None;
            LastnameTextbox.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastnameTextbox.ForeColor = SystemColors.Control;
            LastnameTextbox.Location = new Point(37, 4);
            LastnameTextbox.Name = "LastnameTextbox";
            LastnameTextbox.Size = new Size(256, 19);
            LastnameTextbox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Crimson;
            CancelButton.FlatStyle = FlatStyle.Popup;
            CancelButton.Font = new Font("Noto Sans SC Medium", 12.75F, FontStyle.Bold);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(758, 25);
            CancelButton.Margin = new Padding(5, 3, 10, 10);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(121, 40);
            CancelButton.TabIndex = 25;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 52, 68);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(LastnameTextbox);
            panel1.Location = new Point(463, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 28);
            panel1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(109, 227);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 20);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.FromArgb(39, 52, 68);
            PasswordTextbox.BorderStyle = BorderStyle.None;
            PasswordTextbox.Font = new Font("Franklin Gothic Book", 12F);
            PasswordTextbox.ForeColor = SystemColors.Control;
            PasswordTextbox.Location = new Point(37, 4);
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(256, 19);
            PasswordTextbox.TabIndex = 1;
            PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(463, 139);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 19;
            label4.Text = "Last Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 52, 68);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(PasswordTextbox);
            panel3.Location = new Point(106, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 28);
            panel3.TabIndex = 21;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = Properties.Resources.showPass;
            pictureBox5.Location = new Point(285, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(109, 139);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 20);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FirstnameTextbox
            // 
            FirstnameTextbox.BackColor = Color.FromArgb(39, 52, 68);
            FirstnameTextbox.BorderStyle = BorderStyle.None;
            FirstnameTextbox.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstnameTextbox.ForeColor = SystemColors.Control;
            FirstnameTextbox.Location = new Point(37, 4);
            FirstnameTextbox.Name = "FirstnameTextbox";
            FirstnameTextbox.Size = new Size(256, 19);
            FirstnameTextbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 22);
            label2.Name = "label2";
            label2.Size = new Size(863, 56);
            label2.TabIndex = 23;
            label2.Text = "EDIT USER";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 52, 68);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(FirstnameTextbox);
            panel2.Location = new Point(106, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 28);
            panel2.TabIndex = 17;
            // 
            // EditUserFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(894, 426);
            Controls.Add(AddButton);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(CancelButton);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditUserFORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditUserFORM";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label5;
        private PictureBox pictureBox4;
        private Panel panel4;
        private ComboBox RoleDropdown;
        private PictureBox pictureBox3;
        private TextBox LastnameTextbox;
        private Button CancelButton;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
        private TextBox PasswordTextbox;
        private Label label4;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox FirstnameTextbox;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox5;
    }
}