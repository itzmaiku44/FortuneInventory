using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FortuneInventory
{
    public partial class SettingsAccount : Form
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";

        private System.Drawing.Image? _showPass;
        private System.Drawing.Image? _hidePass;

        public SettingsAccount()
        {
            InitializeComponent();
            Load += SettingsAccount_Load;
            SaveButton.Click += SaveButton_Click;
            LoadPassIcons();
        }

        private void SettingsAccount_Load(object? sender, EventArgs e)
        {
            LoadCurrentUser();
        }

        private void LoadCurrentUser()
        {
            if (!UserSession.CurrentUserId.HasValue)
            {
                MessageBox.Show(this,
                    "No user session found.",
                    "Account Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT firstName, lastName, password
                    FROM dbo.users_t
                    WHERE userID = @id;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", UserSession.CurrentUserId.Value);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FirstnameTextbox.Text = reader["firstName"]?.ToString() ?? string.Empty;
                    LastnameTextbox.Text = reader["lastName"]?.ToString() ?? string.Empty;
                    PasswordTextbox.Text = reader["password"]?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load account:\n{ex.Message}",
                    "Account Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            if (!UserSession.CurrentUserId.HasValue)
            {
                MessageBox.Show(this,
                    "No user session found.",
                    "Account Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstnameTextbox.Text) ||
                string.IsNullOrWhiteSpace(LastnameTextbox.Text) ||
                string.IsNullOrWhiteSpace(PasswordTextbox.Text))
            {
                MessageBox.Show(this,
                    "Please fill in all fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    UPDATE dbo.users_t
                    SET firstName = @firstName,
                        lastName  = @lastName,
                        password  = @password
                    WHERE userID = @id;";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@firstName", FirstnameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@lastName", LastnameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@password", PasswordTextbox.Text);
                cmd.Parameters.AddWithValue("@id", UserSession.CurrentUserId.Value);

                cmd.ExecuteNonQuery();

                // Update session display name
                UserSession.CurrentUserName = $"{FirstnameTextbox.Text.Trim()} {LastnameTextbox.Text.Trim()}";

                MessageBox.Show(this,
                    "Account updated successfully.",
                    "Account Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to update account:\n{ex.Message}",
                    "Account Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadPassIcons()
        {
            try
            {
                _showPass = Properties.Resources.showPassBLACK;
            }
            catch { /* ignore */ }
            try
            {
                _hidePass = Properties.Resources.hidePassBLACK;
            }
            catch { /* ignore */ }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == _showPass)
            {
                pictureBox1.Image = _hidePass;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                PasswordTextbox.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox1.Image = _showPass;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                PasswordTextbox.UseSystemPasswordChar = true;
            }
        }
    }
}
