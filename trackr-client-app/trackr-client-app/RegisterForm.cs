using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app
{
    public partial class RegisterForm : Form
    {
        private bool returnToLogin = false;
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
            returnToLogin = true;
            Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!returnToLogin)
            {
                var loginForm = (LoginForm)Tag;
                loginForm.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        public static bool CheckEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch(FormatException)
            { 
                return false; 
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmail(accountTB.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
            }
        }
    }
}
