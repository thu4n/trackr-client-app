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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            var loginForm = (LoginForm) Tag;
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
            Close();
        }
    }
}
