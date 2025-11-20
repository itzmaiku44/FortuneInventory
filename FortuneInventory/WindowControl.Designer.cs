namespace FortuneInventory
{
    partial class WindowControl
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
            SuspendLayout();
            // 
            // WindowControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 52, 68);
            ClientSize = new Size(810, 461);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WindowControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WindowControl";
            WindowState = FormWindowState.Maximized;
            Load += WindowControl_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}