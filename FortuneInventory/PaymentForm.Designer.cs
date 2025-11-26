namespace FortuneInventory
{
    partial class PaymentForm
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
            label1 = new Label();
            panel1 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label6 = new Label();
            TotalChangeLabel = new Label();
            label4 = new Label();
            panel4 = new Panel();
            TotalAmount = new TextBox();
            panel3 = new Panel();
            PaymentAmount = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono SemiBold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 85);
            label1.TabIndex = 0;
            label1.Text = "PAYMENT";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TotalChangeLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 97);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 348);
            panel1.TabIndex = 1;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.FlatStyle = FlatStyle.Popup;
            radioButton2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(461, 267);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(164, 39);
            radioButton2.TabIndex = 14;
            radioButton2.Text = "DEBIT CARD";
            radioButton2.UseCompatibleTextRendering = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(332, 267);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 36);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "CASH";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(83, 271);
            label6.Name = "label6";
            label6.Size = new Size(226, 32);
            label6.TabIndex = 12;
            label6.Text = "PAYMENT METHOD";
            // 
            // TotalChangeLabel
            // 
            TotalChangeLabel.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalChangeLabel.ForeColor = Color.White;
            TotalChangeLabel.Location = new Point(332, 197);
            TotalChangeLabel.Name = "TotalChangeLabel";
            TotalChangeLabel.Size = new Size(389, 32);
            TotalChangeLabel.TabIndex = 11;
            TotalChangeLabel.Text = "P 0.00";
            TotalChangeLabel.TextAlign = ContentAlignment.MiddleCenter;
            TotalChangeLabel.Click += TotalChangeLabel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(124, 197);
            label4.Name = "label4";
            label4.Size = new Size(185, 32);
            label4.TabIndex = 10;
            label4.Text = "TOTAL CHANGE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Controls.Add(TotalAmount);
            panel4.Location = new Point(332, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(389, 28);
            panel4.TabIndex = 9;
            // 
            // TotalAmount
            // 
            TotalAmount.BackColor = Color.FromArgb(224, 224, 224);
            TotalAmount.BorderStyle = BorderStyle.None;
            TotalAmount.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalAmount.ForeColor = Color.Black;
            TotalAmount.Location = new Point(21, 4);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            TotalAmount.Size = new Size(347, 22);
            TotalAmount.TabIndex = 1;
            TotalAmount.Text = "1234";
            TotalAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(PaymentAmount);
            panel3.Location = new Point(332, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(389, 28);
            panel3.TabIndex = 8;
            // 
            // PaymentAmount
            // 
            PaymentAmount.BackColor = Color.FromArgb(224, 224, 224);
            PaymentAmount.BorderStyle = BorderStyle.None;
            PaymentAmount.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PaymentAmount.ForeColor = Color.Black;
            PaymentAmount.Location = new Point(21, 3);
            PaymentAmount.Name = "PaymentAmount";
            PaymentAmount.Size = new Size(347, 22);
            PaymentAmount.TabIndex = 2;
            PaymentAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 126);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 1;
            label3.Text = "PAYMENT AMOUNT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 55);
            label2.Name = "label2";
            label2.Size = new Size(193, 32);
            label2.TabIndex = 0;
            label2.Text = "TOTAL AMOUNT";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(894, 99);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Noto Sans SC Medium", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(233, 9);
            button2.Margin = new Padding(10, 3, 10, 10);
            button2.Name = "button2";
            button2.Size = new Size(207, 63);
            button2.TabIndex = 8;
            button2.Text = "CANCEL";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Noto Sans SC Medium", 15.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(455, 9);
            button1.Margin = new Padding(5, 3, 10, 10);
            button1.Name = "button1";
            button1.Size = new Size(220, 63);
            button1.TabIndex = 7;
            button1.Text = "CHECKOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 40, 52);
            ClientSize = new Size(894, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PaymentForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "PaymentForm";
            TransparencyKey = Color.Transparent;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel3;
        private Label label4;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        public TextBox TotalAmount;
        public Label TotalChangeLabel;
        public TextBox PaymentAmount;
    }
}