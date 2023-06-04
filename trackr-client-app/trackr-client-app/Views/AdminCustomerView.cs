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

namespace trackr_client_app.Views
{
    public partial class AdminCustomerView : Form
    {
        Customer customer = new Customer();
        public AdminCustomerView()
        {
            InitializeComponent();
        }

        public AdminCustomerView(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void AdminCustomerView_Load(object sender, EventArgs e)
        {
            cusCodeTB.Text = customer.CusID.ToString();
            cusPhoneTB.Text = customer.CusPhone;
            cusNameTB.Text = customer.CusName;
            cusAddressTB.Text = customer.CusAddress;
            cusBirthTB.Text = customer.CusBirth.ToShortDateString();
            if (customer.CusImage != null)
            {
                imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imgBox.LoadAsync(customer.CusImage);
            }
            LoadParcelData();
        }

        private void LoadParcelData()
        {
            int i = 1;
            parcelGridView.Rows.Clear();
            foreach (Parcel parcel in UserSession.parcels)
            {
                if (customer.CusID == parcel.CusID)
                {
                    parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(),parcel.ParStatus);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            AdminDeleteView adminDeleteView = new AdminDeleteView(customer.CusID, "Customer");
            adminDeleteView.Show();
        }
    }
}
