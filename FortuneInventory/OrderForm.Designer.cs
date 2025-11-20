namespace FortuneInventory
{
    partial class OrderForm
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
            OrderPanel = new Panel();
            label18 = new Label();
            label7 = new Label();
            CheckOutPanel = new Panel();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            button2 = new Button();
            button1 = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            CartItemListPanel = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            AvailableProductsPanel = new Panel();
            ProductsPanel = new Panel();
            label2 = new Label();
            OrderPanel.SuspendLayout();
            CheckOutPanel.SuspendLayout();
            AvailableProductsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // OrderPanel
            // 
            OrderPanel.BackColor = Color.White;
            OrderPanel.Controls.Add(label18);
            OrderPanel.Controls.Add(label7);
            OrderPanel.Controls.Add(CheckOutPanel);
            OrderPanel.Controls.Add(CartItemListPanel);
            OrderPanel.Controls.Add(label6);
            OrderPanel.Controls.Add(label5);
            OrderPanel.Controls.Add(label4);
            OrderPanel.Controls.Add(label3);
            OrderPanel.Controls.Add(label1);
            OrderPanel.Location = new Point(1054, 23);
            OrderPanel.Name = "OrderPanel";
            OrderPanel.Size = new Size(529, 1030);
            OrderPanel.TabIndex = 0;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(33, 699);
            label18.Name = "label18";
            label18.Size = new Size(462, 15);
            label18.TabIndex = 8;
            label18.Text = "___________________________________________________________________________________________";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(368, 30);
            label7.Name = "label7";
            label7.Size = new Size(127, 36);
            label7.TabIndex = 7;
            label7.Text = "0000000";
            // 
            // CheckOutPanel
            // 
            CheckOutPanel.Controls.Add(label17);
            CheckOutPanel.Controls.Add(label16);
            CheckOutPanel.Controls.Add(label15);
            CheckOutPanel.Controls.Add(label14);
            CheckOutPanel.Controls.Add(label13);
            CheckOutPanel.Controls.Add(button2);
            CheckOutPanel.Controls.Add(button1);
            CheckOutPanel.Controls.Add(label12);
            CheckOutPanel.Controls.Add(label11);
            CheckOutPanel.Controls.Add(label10);
            CheckOutPanel.Controls.Add(label9);
            CheckOutPanel.Controls.Add(label8);
            CheckOutPanel.Location = new Point(33, 717);
            CheckOutPanel.Name = "CheckOutPanel";
            CheckOutPanel.Size = new Size(462, 297);
            CheckOutPanel.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(320, 155);
            label17.Name = "label17";
            label17.Size = new Size(59, 23);
            label17.TabIndex = 11;
            label17.Text = "0.00";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(320, 107);
            label16.Name = "label16";
            label16.Size = new Size(53, 23);
            label16.TabIndex = 10;
            label16.Text = "0.00";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(320, 67);
            label15.Name = "label15";
            label15.Size = new Size(53, 23);
            label15.TabIndex = 9;
            label15.Text = "0.00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(299, 107);
            label14.Name = "label14";
            label14.Size = new Size(21, 23);
            label14.TabIndex = 8;
            label14.Text = "P";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(299, 67);
            label13.Name = "label13";
            label13.Size = new Size(21, 23);
            label13.TabIndex = 7;
            label13.Text = "P";
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Noto Sans SC Medium", 15.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(10, 224);
            button2.Margin = new Padding(10, 3, 10, 10);
            button2.Name = "button2";
            button2.Size = new Size(207, 63);
            button2.TabIndex = 6;
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
            button1.Location = new Point(232, 224);
            button1.Margin = new Padding(5, 3, 10, 10);
            button1.Name = "button1";
            button1.Size = new Size(220, 63);
            button1.TabIndex = 5;
            button1.Text = "PLACE ORDER";
            button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(299, 155);
            label12.Name = "label12";
            label12.Size = new Size(24, 23);
            label12.TabIndex = 4;
            label12.Text = "P";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(38, 155);
            label11.Name = "label11";
            label11.Size = new Size(157, 23);
            label11.TabIndex = 3;
            label11.Text = "Total Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(38, 107);
            label10.Name = "label10";
            label10.Size = new Size(46, 23);
            label10.TabIndex = 2;
            label10.Text = "VAT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(38, 67);
            label9.Name = "label9";
            label9.Size = new Size(90, 23);
            label9.TabIndex = 1;
            label9.Text = "Subtotal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 24);
            label8.Name = "label8";
            label8.Size = new Size(189, 23);
            label8.TabIndex = 0;
            label8.Text = "Payment Summary";
            // 
            // CartItemListPanel
            // 
            CartItemListPanel.Location = new Point(33, 125);
            CartItemListPanel.Name = "CartItemListPanel";
            CartItemListPanel.Size = new Size(462, 573);
            CartItemListPanel.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(364, 97);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 4;
            label6.Text = "PRICE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(298, 97);
            label5.Name = "label5";
            label5.Size = new Size(48, 25);
            label5.TabIndex = 3;
            label5.Text = "QTY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(61, 97);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 2;
            label4.Text = "ITEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 67);
            label3.Name = "label3";
            label3.Size = new Size(462, 15);
            label3.TabIndex = 1;
            label3.Text = "___________________________________________________________________________________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(33, 30);
            label1.Name = "label1";
            label1.Size = new Size(128, 36);
            label1.TabIndex = 0;
            label1.Text = "ORDER #";
            // 
            // AvailableProductsPanel
            // 
            AvailableProductsPanel.BackColor = Color.White;
            AvailableProductsPanel.Controls.Add(ProductsPanel);
            AvailableProductsPanel.Controls.Add(label2);
            AvailableProductsPanel.Dock = DockStyle.Left;
            AvailableProductsPanel.Location = new Point(0, 0);
            AvailableProductsPanel.Margin = new Padding(10, 3, 3, 3);
            AvailableProductsPanel.Name = "AvailableProductsPanel";
            AvailableProductsPanel.Size = new Size(1019, 1080);
            AvailableProductsPanel.TabIndex = 1;
            // 
            // ProductsPanel
            // 
            ProductsPanel.Location = new Point(3, 80);
            ProductsPanel.Name = "ProductsPanel";
            ProductsPanel.Size = new Size(1013, 1000);
            ProductsPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 23);
            label2.Name = "label2";
            label2.Size = new Size(306, 37);
            label2.TabIndex = 1;
            label2.Text = "AVAILABLE PRODUCTS";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1607, 1080);
            Controls.Add(AvailableProductsPanel);
            Controls.Add(OrderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            OrderPanel.ResumeLayout(false);
            OrderPanel.PerformLayout();
            CheckOutPanel.ResumeLayout(false);
            CheckOutPanel.PerformLayout();
            AvailableProductsPanel.ResumeLayout(false);
            AvailableProductsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel OrderPanel;
        private Label label1;
        private Panel AvailableProductsPanel;
        private Label label2;
        private Panel CartItemListPanel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel CheckOutPanel;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button2;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label18;
        private Panel ProductsPanel;
    }
}