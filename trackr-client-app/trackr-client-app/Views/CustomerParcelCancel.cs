using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;
using trackr_client_app.Views;

namespace trackr_client_app.Views
{
    public partial class CustomerParcelCancel : Form
    {
        Parcel parcel = new Parcel();
        int id;
        public CustomerParcelCancel()
        {
            InitializeComponent();
            reasonCancelParcelCB.Items.Add("Không thích mua nữa");
            reasonCancelParcelCB.Items.Add("Giá ở đây quá mắc");
            reasonCancelParcelCB.Items.Add("Dịch vụ này không ship đến chỗ tôi");
        }

        public CustomerParcelCancel(int id)
        {
            InitializeComponent();
            reasonCancelParcelCB.Items.Add("Không thích mua nữa");
            reasonCancelParcelCB.Items.Add("Giá ở đây quá mắc");
            reasonCancelParcelCB.Items.Add("Dịch vụ này không ship đến chỗ tôi");
            this.id = id;
        }


        private void cancelConfirmBtn_Click(object sender, EventArgs e)
        {
            //parcel.SelectedCancelReason = reasonCancelParcelCB.SelectedItem.ToString();
            
            CustomerConfirmView customerConfirmView = new CustomerConfirmView(this.id);
            customerConfirmView.Show();
        }
    }
}
