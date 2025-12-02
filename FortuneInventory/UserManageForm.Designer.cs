namespace FortuneInventory
{
    partial class UserManageForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            topPanel = new Panel();
            AddUserButton = new Button();
            titleLabel = new Label();
            SearchBarPanel = new Panel();
            searchPictureBox = new PictureBox();
            SearchTextBox = new TextBox();
            UsersGrid = new DataGridView();
            CheckboxColumn = new DataGridViewCheckBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            DateCreatedColumn = new DataGridViewTextBoxColumn();
            ActiveColumn = new DataGridViewTextBoxColumn();
            RoleColumn = new DataGridViewImageColumn();
            EditUserColumn = new DataGridViewImageColumn();
            DeleteUserColumn = new DataGridViewImageColumn();
            topPanel.SuspendLayout();
            SearchBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).BeginInit();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.Controls.Add(AddUserButton);
            topPanel.Controls.Add(titleLabel);
            topPanel.Controls.Add(SearchBarPanel);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Margin = new Padding(0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(32, 24, 32, 24);
            topPanel.Size = new Size(1607, 140);
            topPanel.TabIndex = 0;
            // 
            // AddUserButton
            // 
            AddUserButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddUserButton.BackColor = Color.FromArgb(52, 120, 246);
            AddUserButton.FlatAppearance.BorderSize = 0;
            AddUserButton.FlatStyle = FlatStyle.Flat;
            AddUserButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddUserButton.ForeColor = Color.White;
            AddUserButton.Location = new Point(1395, 74);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(180, 44);
            AddUserButton.TabIndex = 2;
            AddUserButton.Text = "Add User";
            AddUserButton.UseVisualStyleBackColor = false;
            AddUserButton.Click += AddUserButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(30, 40, 52);
            titleLabel.Location = new Point(32, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(339, 51);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "User Management";
            // 
            // SearchBarPanel
            // 
            SearchBarPanel.BackColor = Color.White;
            SearchBarPanel.Controls.Add(searchPictureBox);
            SearchBarPanel.Controls.Add(SearchTextBox);
            SearchBarPanel.Location = new Point(1045, 86);
            SearchBarPanel.Name = "SearchBarPanel";
            SearchBarPanel.Size = new Size(322, 32);
            SearchBarPanel.TabIndex = 3;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Image = Properties.Resources.Search__Streamline_Block_Free;
            searchPictureBox.Location = new Point(0, 3);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(25, 28);
            searchPictureBox.TabIndex = 2;
            searchPictureBox.TabStop = false;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchTextBox.BackColor = Color.White;
            SearchTextBox.BorderStyle = BorderStyle.None;
            SearchTextBox.Font = new Font("Segoe UI", 11.25F);
            SearchTextBox.Location = new Point(28, 5);
            SearchTextBox.Margin = new Padding(0);
            SearchTextBox.MaxLength = 120;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search user...";
            SearchTextBox.Size = new Size(294, 20);
            SearchTextBox.TabIndex = 1;
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            // 
            // UsersGrid
            // 
            UsersGrid.AllowUserToAddRows = false;
            UsersGrid.AllowUserToDeleteRows = false;
            UsersGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            UsersGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            UsersGrid.BackgroundColor = Color.WhiteSmoke;
            UsersGrid.BorderStyle = BorderStyle.None;
            UsersGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UsersGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            UsersGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UsersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UsersGrid.ColumnHeadersHeight = 52;
            UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            UsersGrid.Columns.AddRange(new DataGridViewColumn[] { CheckboxColumn, FullNameColumn, DateCreatedColumn, ActiveColumn, RoleColumn, EditUserColumn, DeleteUserColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle3.Padding = new Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 242, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 40, 52);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UsersGrid.DefaultCellStyle = dataGridViewCellStyle3;
            UsersGrid.Dock = DockStyle.Fill;
            UsersGrid.EnableHeadersVisualStyles = false;
            UsersGrid.GridColor = Color.FromArgb(235, 238, 245);
            UsersGrid.Location = new Point(0, 140);
            UsersGrid.MultiSelect = false;
            UsersGrid.Name = "UsersGrid";
            UsersGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            UsersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            UsersGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            UsersGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            UsersGrid.RowTemplate.Height = 72;
            UsersGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGrid.Size = new Size(1607, 940);
            UsersGrid.TabIndex = 1;
            // 
            // CheckboxColumn
            // 
            CheckboxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            CheckboxColumn.FillWeight = 4F;
            CheckboxColumn.HeaderText = "";
            CheckboxColumn.Name = "CheckboxColumn";
            CheckboxColumn.ReadOnly = true;
            CheckboxColumn.Width = 21;
            // 
            // FullNameColumn
            // 
            FullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullNameColumn.FillWeight = 40F;
            FullNameColumn.HeaderText = "Full Name";
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.ReadOnly = true;
            // 
            // DateCreatedColumn
            // 
            DateCreatedColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateCreatedColumn.FillWeight = 30F;
            DateCreatedColumn.HeaderText = "Date Created";
            DateCreatedColumn.Name = "DateCreatedColumn";
            DateCreatedColumn.ReadOnly = true;
            // 
            // ActiveColumn
            // 
            ActiveColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ActiveColumn.FillWeight = 15F;
            ActiveColumn.HeaderText = "Active";
            ActiveColumn.Name = "ActiveColumn";
            ActiveColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            RoleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RoleColumn.FillWeight = 25F;
            RoleColumn.HeaderText = "Role";
            RoleColumn.Name = "RoleColumn";
            RoleColumn.ReadOnly = true;
            RoleColumn.Resizable = DataGridViewTriState.False;
            // 
            // EditUserColumn
            // 
            EditUserColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditUserColumn.HeaderText = "";
            EditUserColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            EditUserColumn.Name = "EditUserColumn";
            EditUserColumn.ReadOnly = true;
            EditUserColumn.Width = 21;
            // 
            // DeleteUserColumn
            // 
            DeleteUserColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteUserColumn.HeaderText = "";
            DeleteUserColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DeleteUserColumn.Name = "DeleteUserColumn";
            DeleteUserColumn.ReadOnly = true;
            DeleteUserColumn.Width = 21;
            // 
            // UserManageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1607, 1080);
            Controls.Add(UsersGrid);
            Controls.Add(topPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManageForm";
            Text = "UserManageForm";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            SearchBarPanel.ResumeLayout(false);
            SearchBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Button AddUserButton;
        private Label titleLabel;
        private Panel SearchBarPanel;
        private PictureBox searchPictureBox;
        private TextBox SearchTextBox;
        private DataGridView UsersGrid;
        private DataGridViewCheckBoxColumn CheckboxColumn;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn DateCreatedColumn;
        private DataGridViewTextBoxColumn ActiveColumn;
        private DataGridViewImageColumn RoleColumn;
        private DataGridViewImageColumn EditUserColumn;
        private DataGridViewImageColumn DeleteUserColumn;
    }
}
