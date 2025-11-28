namespace FortuneInventory
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            ValidateUserLabel = new Label();
            panel4 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("COMEBREAK", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(59, 107);
            label2.Name = "label2";
            label2.Size = new Size(389, 40);
            label2.TabIndex = 3;
            label2.Text = "RETAIL BUSINESS Co.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(27, 96);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.Controls.Add(ValidateUserLabel);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 266);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // ValidateUserLabel
            // 
            ValidateUserLabel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValidateUserLabel.ForeColor = Color.Red;
            ValidateUserLabel.Location = new Point(64, 234);
            ValidateUserLabel.Name = "ValidateUserLabel";
            ValidateUserLabel.Size = new Size(307, 23);
            ValidateUserLabel.TabIndex = 9;
            ValidateUserLabel.Text = " ";
            ValidateUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(64, 185);
            panel4.Name = "panel4";
            panel4.Size = new Size(307, 40);
            panel4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Dock = DockStyle.Fill;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(307, 40);
            button1.TabIndex = 0;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(39, 52, 68);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(27, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 28);
            panel3.TabIndex = 7;
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
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(39, 52, 68);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Snap ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Control;
            textBox2.Location = new Point(37, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(347, 20);
            textBox2.TabIndex = 1;
            textBox2.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 52, 68);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(27, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 28);
            panel2.TabIndex = 6;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 52, 68);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Franklin Gothic Book", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(37, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 19);
            textBox1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(195, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 74);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(500, 500);
            panel5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.LightSlateGray;
            label4.Location = new Point(131, 476);
            label4.Name = "label4";
            label4.Size = new Size(222, 15);
            label4.TabIndex = 8;
            label4.Text = "Forgot password? Contact your Manager";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(500, 500);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Button button1;
        private Panel panel3;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label4;
        private Label ValidateUserLabel;
    }
}