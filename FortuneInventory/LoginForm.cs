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
    public partial class LoginForm : Form
    {
        private WindowControl? _windowControl;
        private Dashboard? _dashboard;

        public LoginForm()
        {
            InitializeComponent();
            AcceptButton = button1;
            button1.Click += Button1_Click;
            FormClosed += LoginForm_FormClosed;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (_windowControl == null || _windowControl.IsDisposed)
            {
                _windowControl = new WindowControl();
                _windowControl.Show();
                _windowControl.SendToBack();
            }

            Activate();
            BringToFront();
            Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            // Disable button to prevent multiple clicks
            button1.Enabled = false;

            // Get username and password from textboxes
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ValidateUserLabel.Text = "Invalid username or password. Please try again.";
                button1.Enabled = true;
                return;
            }

            // Create Login instance and authenticate
            Login login = new Login(username, password);
            bool isAuthenticated = login.Authenticate();

            if (!isAuthenticated)
            {
                ValidateUserLabel.Text = "Authentication Failed";
                textBox2.Clear();
                textBox1.Focus();
                button1.Enabled = true;
                return;
            }

            // Authentication successful - proceed to dashboard
            await Task.Delay(TimeSpan.FromSeconds(1)); // Brief delay for smooth transition

            if (_dashboard == null || _dashboard.IsDisposed)
            {
                _dashboard = new Dashboard();
                _dashboard.FormClosed += Dashboard_FormClosed;
            }

            // Get user's full name for display
            string userFullName = login.GetUserFullName();
            if (string.IsNullOrWhiteSpace(userFullName))
            {
                userFullName = username; // Fallback to username if full name not found
            }

            await FadeOutAsync(this);
            Hide();

            _dashboard.Opacity = 0;
            _dashboard.Show();
            await FadeInAsync(_dashboard);

            CloseWindowControl();
            button1.Enabled = true;

            // Set user label in dashboard
            _dashboard.UserLabel.Text = userFullName;
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (_dashboard != null)
            {
                _dashboard.FormClosed -= Dashboard_FormClosed;
                _dashboard = null;
            }

            Close();
        }

        private void LoginForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            CloseWindowControl();
        }

        private static async Task FadeOutAsync(Form form, double step = 0.05, int interval = 15)
        {
            while (form.Opacity > step)
            {
                form.Opacity -= step;
                await Task.Delay(interval);
            }

            form.Opacity = 0;
        }

        private static async Task FadeInAsync(Form form, double step = 0.03, int interval = 10)
        {
            form.Opacity = 0;
            while (form.Opacity < 1.0)
            {
                form.Opacity += step;
                if (form.Opacity > 1.0)
                {
                    form.Opacity = 1.0;
                }

                await Task.Delay(interval);
            }
        }

        private void CloseWindowControl()
        {
            if (_windowControl == null)
            {
                return;
            }

            if (!_windowControl.IsDisposed)
            {
                _windowControl.Close();
            }

            _windowControl = null;
        }
    }
}
