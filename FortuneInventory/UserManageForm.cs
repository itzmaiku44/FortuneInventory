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
    public partial class UserManageForm : Form
    {
        private readonly string _connectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\OneDrive\\Documents\\inv.mdf;Integrated Security=True;Connect Timeout=30";
        private System.Drawing.Image? _adminIcon;
        private System.Drawing.Image? _staffIcon;
        private System.Drawing.Image? _editIcon;
        private System.Drawing.Image? _deleteIcon;

        public UserManageForm()
        {
            InitializeComponent();

            if (!UserSession.IsAdmin)
            {
                MessageBox.Show(this,
                    "You do not have permission to access user management.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Close();
                return;
            }

            LoadRoleIcons();
            UsersGrid.CellClick += UsersGrid_CellClick;
            Load += UserManageForm_Load;
        }

        private void UserManageForm_Load(object? sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadRoleIcons()
        {
            try
            {
                _adminIcon = Properties.Resources.adminLabel;
            }
            catch { /* ignore */ }
            try
            {
                _staffIcon = Properties.Resources.staffLabel;
            }
            catch { /* ignore */ }

            try
            {
                _editIcon = Properties.Resources.EditIcon;
            }
            catch { /* ignore */ }

            try
            {
                _deleteIcon = Properties.Resources.DeleteIcon;
            }
            catch { /* ignore */ }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var addUserForm = new AddUserFORM
            {
                OwnerUserManage = this
            };
            
            if (addUserForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers(); // Reload users after adding
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filter users based on search text
            string searchText = SearchTextBox.Text.ToLower();
            
            foreach (DataGridViewRow row in UsersGrid.Rows)
            {
                string fullName = row.Cells["FullNameColumn"].Value?.ToString()?.ToLower() ?? "";
                bool visible = string.IsNullOrWhiteSpace(searchText) || fullName.Contains(searchText);
                row.Visible = visible;
            }
        }

        public void LoadUsers()
        {
            UsersGrid.Rows.Clear();

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                string sql = @"
                    SELECT u.userID,
                           u.firstName,
                           u.lastName,
                           u.roleID,
                           r.roleName,
                           u.timeIn,
                           ISNULL(u.isActive, 1) AS isActive
                    FROM dbo.users_t u
                    LEFT JOIN dbo.roles_t r ON u.roleID = r.roleID
                    WHERE ISNULL(u.isActive, 1) = 1   -- only active users
                    ORDER BY u.userID DESC;";

                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int rowIndex = UsersGrid.Rows.Add();
                    var row = UsersGrid.Rows[rowIndex];

                    // Checkbox (unchecked by default, make it editable)
                    var checkboxCell = row.Cells["CheckboxColumn"];
                    checkboxCell.Value = false;
                    checkboxCell.ReadOnly = false; // Make checkbox editable

                    // Full Name
                    string firstName = reader["firstName"]?.ToString() ?? "";
                    string lastName = reader["lastName"]?.ToString() ?? "";
                    row.Cells["FullNameColumn"].Value = $"{firstName} {lastName}".Trim();
                    row.Cells["FullNameColumn"].ReadOnly = true;

                    // Date Created (use timeIn if available, otherwise show N/A)
                    DateTime? timeIn = reader["timeIn"] as DateTime?;
                    if (timeIn.HasValue)
                    {
                        row.Cells["DateCreatedColumn"].Value = timeIn.Value.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        row.Cells["DateCreatedColumn"].Value = "N/A";
                    }
                    row.Cells["DateCreatedColumn"].ReadOnly = true;

                    // Role Image
                    int roleId = reader["roleID"] is int rid ? rid : Convert.ToInt32(reader["roleID"]);
                    System.Drawing.Image? roleImage = roleId == 1 ? _adminIcon : _staffIcon;
                    row.Cells["RoleColumn"].Value = roleImage;
                    row.Cells["RoleColumn"].ReadOnly = true;

                    // Active status
                    bool isActive = reader["isActive"] is bool b && b || Convert.ToInt32(reader["isActive"]) != 0;
                    row.Cells["ActiveColumn"].Value = isActive ? "Active" : "Inactive";
                    row.Cells["ActiveColumn"].ReadOnly = true;

                    // Action icons
                    row.Cells["EditUserColumn"].Value = _editIcon;
                    row.Cells["DeleteUserColumn"].Value = _deleteIcon;

                    // Store userID in row tag for reference
                    row.Tag = reader["userID"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load users:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void UsersGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var grid = UsersGrid;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            if (columnName != "EditUserColumn" && columnName != "DeleteUserColumn")
            {
                return;
            }

            var row = grid.Rows[e.RowIndex];
            if (row.Tag == null || !int.TryParse(row.Tag.ToString(), out int userId))
            {
                return;
            }

            if (columnName == "EditUserColumn")
            {
                OpenEditUserForm(userId);
            }
            else if (columnName == "DeleteUserColumn")
            {
                DeleteUser(userId);
            }
        }

        private void OpenEditUserForm(int userId)
        {
            // Fetch user data
            string sql = @"
                SELECT userID, roleID, firstName, lastName, password
                FROM dbo.users_t
                WHERE userID = @id;";

            int roleId = 2;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string password = string.Empty;

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                using var reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show(this, "User not found.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                firstName = reader["firstName"]?.ToString() ?? string.Empty;
                lastName = reader["lastName"]?.ToString() ?? string.Empty;
                password = reader["password"]?.ToString() ?? string.Empty;
                roleId = reader["roleID"] is int rid ? rid : Convert.ToInt32(reader["roleID"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to load user:\n{ex.Message}",
                    "Edit User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var editForm = new EditUserFORM
            {
                UserId = userId
            };

            // Fill fields
            editForm.SetUserFields(firstName, lastName, password, roleId);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }
        }

        private void DeleteUser(int userId)
        {
            var confirm = MessageBox.Show(this,
                "Are you sure you want to deactivate this user?\n\nExisting history will be kept, but the user will no longer be active.",
                "Deactivate User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();

                // Soft delete: mark user as inactive so relations remain intact
                using var cmd = new SqlCommand("UPDATE dbo.users_t SET isActive = 0 WHERE userID = @id;", conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    $"Failed to delete user:\n{ex.Message}",
                    "Delete User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            LoadUsers();
        }
    }
}
