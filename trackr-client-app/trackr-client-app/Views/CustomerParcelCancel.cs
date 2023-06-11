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
        Parcel selectedParcel = new Parcel();
        public string SelectedCancellationReason { get; set; }
        public CustomerParcelCancel()
        {
            InitializeComponent();
            reasonCancelParcelCB.Items.Add("Không thích mua nữa");
            reasonCancelParcelCB.Items.Add("Giá ở đây quá mắc");
            reasonCancelParcelCB.Items.Add("Dịch vụ này không ship đến chỗ tôi");
        }

        private void reasonCancelParcelCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCancellationReason = reasonCancelParcelCB.SelectedItem.ToString();
        }

        private void cancelConfirmBtn_Click(object sender, EventArgs e)
        {
            
            CustomerConfirmView customerConfirmView = new CustomerConfirmView(selectedParcel);
            customerConfirmView.Show();
        }
    }
}
