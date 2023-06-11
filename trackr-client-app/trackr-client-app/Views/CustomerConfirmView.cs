using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app.Views
{
    public partial class CustomerConfirmView : Form
    {
        public CustomerConfirmView()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {

        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            CustomerParcelView customerParcelView = new CustomerParcelView();
            customerParcelView.Show();
        }
    }
}
