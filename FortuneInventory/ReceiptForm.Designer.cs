namespace FortuneInventory
{
    partial class ReceiptForm
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
            ReceiptTextBox = new TextBox();
            PrintButton = new Button();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // ReceiptTextBox
            // 
            ReceiptTextBox.Font = new Font("Courier New", 9F);
            ReceiptTextBox.Location = new Point(12, 12);
            ReceiptTextBox.Multiline = true;
            ReceiptTextBox.Name = "ReceiptTextBox";
            ReceiptTextBox.ReadOnly = true;
            ReceiptTextBox.Size = new Size(400, 500);
            ReceiptTextBox.TabIndex = 0;
            ReceiptTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PrintButton
            // 
            PrintButton.Location = new Point(12, 530);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(190, 35);
            PrintButton.TabIndex = 1;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(222, 530);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(190, 35);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 577);
            Controls.Add(CloseButton);
            Controls.Add(PrintButton);
            Controls.Add(ReceiptTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Receipt";
            Load += ReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ReceiptTextBox;
        private Button PrintButton;
        private Button CloseButton;
    }
}

