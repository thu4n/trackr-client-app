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

namespace trackr_client_app
{
    public partial class ParcelDetails : UserControl
    {
        private Parcel parcel = new Parcel();
        public ParcelDetails()
        {
            InitializeComponent();
        }
        public ParcelDetails(Parcel newParcel)
        {
            InitializeComponent();
            this.parcel = newParcel;
        }
        private void ParcelDetails_Load(object sender, EventArgs e)
        {
            cusCodeTB.Text = UserSession.customer.CusID.ToString();
            cusAddressTB.Text = UserSession.customer.CusAddress;
            cusNameTB.Text = UserSession.customer.CusName;
            cusPhoneTB.Text = UserSession.customer.CusPhone;
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            statusTB.Text = parcel.ParStatus;
            //parcelImg.Image = Image.FromFile(@"tracker-client-app\Resources\logoSmall.png");
        }
    }
}
