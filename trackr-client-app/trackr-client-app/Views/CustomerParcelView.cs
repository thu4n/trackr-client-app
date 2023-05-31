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
    public partial class CustomerParcelView : Form
    {
        Parcel parcel;
        public CustomerParcelView()
        {
            InitializeComponent();
        }

        public CustomerParcelView(Parcel parcel)
        {
            InitializeComponent();
            this.parcel = parcel;
        }

        private void CustomerParcelView_Load(object sender, EventArgs e)
        {
            cusCodeTB.Text = UserSession.customer.CusID.ToString();
            cusAddressTB.Text = UserSession.customer.CusAddress;
            cusNameTB.Text = UserSession.customer.CusName;
            cusPhoneTB.Text = UserSession.customer.CusPhone;
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            statusTB.Text = parcel.ParStatus;
            noteTB.Text = parcel.Note;
            parcelImg.ImageLocation = parcel.ParImage;
            parcelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayTrackingTree();
        }

        private void DisplayTrackingTree()
        {
            string[] locationLog = parcel.ParLocation.Split('@');
            string[] timeLog = parcel.Realtime.Split('@');
            int i = 0;
            foreach(var timeMark in timeLog) 
            {
                string locationMark = locationLog[i++];
                treeView1.Nodes.Add(timeMark + " " + locationMark);

            }
        }
    }
}
