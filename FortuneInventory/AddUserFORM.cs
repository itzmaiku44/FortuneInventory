using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class AddUserFORM : Form
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        private System.Drawing.Image? _showPass;
        private System.Drawing.Image? _hidePass;

        public UserManageForm? OwnerUserManage { get; set; }

        public AddUserFORM()
        {
            InitializeComponent();
            LoadPassIcons();
            CancelButton.Click += CancelButton_Click;
            AddButton.Click += AddButton_Click;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(FirstnameTextbox.Text))
            {
                MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstnameTextbox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(LastnameTextbox.Text))
            {
                MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastnameTextbox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextbox.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                PasswordTextbox.Focus();
                return;
            }

            if (RoleDropdown.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RoleDropdown.Focus();
                return;
            }

            // Get roleID (1 = Admin, 2 = Staff)
            int roleId = RoleDropdown.SelectedIndex == 0 ? 2 : 1; // "Staff" is first item (index 0) = roleID 2, "Admin" is second (index 1) = roleID 1

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    INSERT INTO dbo.users_t (roleID, firstName, lastName, password, timeIn)
                    VALUES (@roleID, @firstName, @lastName, @password, @timeIn);";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@roleID", roleId);
                cmd.Parameters.AddWithValue("@firstName", FirstnameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@lastName", LastnameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", PasswordTextbox.Text);
                cmd.Parameters.AddWithValue("@timeIn", DateTime.Now); // Set current date as dateCreated

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add user:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPassIcons()
        {
            try
            {
                _showPass = Properties.Resources.showPass;
            }
            catch { /* ignore */ }
            try
            {
                _hidePass = Properties.Resources.hidePass;
            }
            catch { /* ignore */ }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == _showPass)
            {
                pictureBox5.Image = _hidePass;
                pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
                PasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox5.Image = _showPass;
                pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
