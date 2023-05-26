using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Text = "Trackr - Đăng nhập";
        }

        private void navigateRegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Tag = this;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = this.Location;
            registerForm.Show();
            Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Tag = this;
            customerDashboard.StartPosition = FormStartPosition.Manual;
            customerDashboard.Location = this.Location;
            customerDashboard.Show();
            Hide();
        }
    }
}
