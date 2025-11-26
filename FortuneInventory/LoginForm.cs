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
            button1.Enabled = false;
            await Task.Delay(TimeSpan.FromSeconds(2));
            if (_dashboard == null || _dashboard.IsDisposed)
            {
                _dashboard = new Dashboard();
                _dashboard.FormClosed += Dashboard_FormClosed;
            }

            await FadeOutAsync(this);
            await FadeOutAsync(this);
            Hide();

            _dashboard.Opacity = 0;
            _dashboard.Show();
            await FadeInAsync(_dashboard);

            CloseWindowControl();
            button1.Enabled = true;

            _dashboard.UserLabel.Text = textBox1.Text;
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
