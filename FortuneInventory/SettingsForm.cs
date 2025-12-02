using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneInventory
{
    public partial class SettingsForm : Form
    {
        private readonly Color _activeBackColor = Color.FromArgb(30, 40, 52);
        private readonly Color _activeForeColor = Color.White;
        private readonly Color _hoverBackColor = Color.FromArgb(85, 30, 40, 52); // rgba(30, 40, 52, 0.85)
        private Button? _activeButton;
        private Form? _backdrop;



        public SettingsForm()
        {
            InitializeComponent();
            Shown += SettingsForm_Shown;
            FormClosed += SettingsForm_FormClosed;
            loadform(new SettingsAccount());
            SetActiveButton(AccountPanel);
            HookSidebarButtonHover(AccountPanel);
            HookSidebarButtonHover(LoginHistoryPanel);
            HookSidebarButtonHover(SaleHistoryPanel);
            LoginHistoryPanel.Click += LoginHistoryPanel_Click;
            SaleHistoryPanel.Click += SaleHistoryPanel_Click;
            LogoutButton.Click += LogoutButton_Click;
        }


        private void HookSidebarButtonHover(Button button)
        {
            button.MouseEnter += SidebarButton_MouseEnter;
            button.MouseLeave += SidebarButton_MouseLeave;
        }

        private void SidebarButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn == _activeButton) return; // keep active style
            btn.BackColor = _hoverBackColor;
            btn.ForeColor = Color.White;
        }

        private void SidebarButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;
            if (btn == _activeButton) return; // keep active style
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Black;
        }

        private void ResetAllButtons()
        {
            var buttons = new[] { AccountPanel, LoginHistoryPanel, SaleHistoryPanel };
            foreach (var button in buttons)
            {
                if (button != null)
                {
                    button.BackColor = Color.Transparent;
                    button.ForeColor = Color.Black;
                }
            }
        }

        private void SetActiveButton(Button button)
        {
            ResetAllButtons();
            button.BackColor = _activeBackColor;
            button.ForeColor = _activeForeColor;
            _activeButton = button;
        }

        public void loadform(object form)
        {
            if (this.SettingsPanel.Controls.Count > 0)
            {
                this.SettingsPanel.Controls.RemoveAt(0);
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.ShowInTaskbar = false;
            this.SettingsPanel.Controls.Add(f);
            this.SettingsPanel.Tag = f;
            f.Show();
        }

        private void AccountPanel_Click(object sender, EventArgs e)
        {
            loadform(new SettingsAccount());
            SetActiveButton(AccountPanel);
        }

        private void LoginHistoryPanel_Click(object sender, EventArgs e)
        {
            loadform(new SettingsLoginHistory());
            SetActiveButton(LoginHistoryPanel);
        }

        private void SaleHistoryPanel_Click(object sender, EventArgs e)
        {
            loadform(new SettingsSaleHistory());
            SetActiveButton(SaleHistoryPanel);
        }

        private async void LogoutButton_Click(object sender, EventArgs e)
        {
            int? userId = UserSession.CurrentUserId;

            // Log logout time if we have a user
            if (userId.HasValue)
            {
                var history = new LoginHistoryService();
                history.LogLogout(userId.Value);
            }

            // Clear current user session
            UserSession.Clear();

            // Fade out the main dashboard if it exists
            var dashboard = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is Dashboard);
            if (dashboard != null)
            {
                await LoginForm.FadeOutAsync(dashboard);
                dashboard.Hide();
            }

            // Show a fresh login form with a smooth fade-in
            var loginForm = new LoginForm
            {
                Opacity = 0
            };
            loginForm.Show();
            await LoginForm.FadeInAsync(loginForm);

            // Close/hide all other open forms (dashboard, settings, etc.) so only LoginForm (and its WindowControl) remain
            var formsToClose = Application.OpenForms
                .Cast<Form>()
                .Where(f => f != loginForm && f is not WindowControl)
                .ToList();

            foreach (var form in formsToClose)
            {
                form.Hide();
                //form.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Create a dimmed backdrop behind the settings window to darken the rest of the UI.
        /// </summary>
        private void SettingsForm_Shown(object? sender, EventArgs e)
        {
            if (_backdrop != null)
            {
                return;
            }

            // Use the owner bounds if available; otherwise use the current screen bounds.
            Rectangle bounds = Owner != null
                ? Owner.Bounds
                : Screen.FromControl(this).Bounds;

            _backdrop = new Form
            {
                StartPosition = FormStartPosition.Manual,
                Bounds = bounds,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                BackColor = Color.Black,
                Opacity = 0.55,
                TopMost = false,
                Enabled = false // never receive input/focus
            };

            // Place backdrop between owner (e.g., Dashboard) and this SettingsForm
            if (Owner != null)
            {
                _backdrop.Owner = Owner;
            }

            _backdrop.Show();
            _backdrop.BringToFront();

            // Ensure SettingsForm stays on top of backdrop
            this.BringToFront();
            this.Activate();
        }

        private void SettingsForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (_backdrop != null)
            {
                try
                {
                    _backdrop.Hide();
                    _backdrop.Close();
                    _backdrop.Dispose();
                }
                catch
                {
                    // ignore cleanup errors
                }
                finally
                {
                    _backdrop = null;
                }
            }
        }
    }
}
