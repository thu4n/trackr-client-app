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
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                parcelGridView.Rows.Add("i","thuan","ok","alo");
            }
        }

        private void CustomerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }
    }
}
