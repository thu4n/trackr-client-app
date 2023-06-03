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
            //cusAddressTB.Text = UserSession.customer.CusAddress.Replace('*',',');
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
            string[] routeLog = parcel.ParRouteLocation.Split('@');
            string[] timeLog = parcel.Realtime.Split('@');
            string[] locationLog = parcel.ParLocation.Split('@');
            int mark = locationLog.Length - 2;
            int distance = int.Parse(routeLog[0]);
            distanceLabel.Text = $"Tổng khoảng cách ước tính: {distance} km";
            for (int i = 1; i < routeLog.Length; i++)
            {
                treeView1.Nodes.Add("done", routeLog[i], 0);
            }
            for(int i=0; i < timeLog.Length; i++)
            {
                treeView1.Nodes[i].Nodes.Add(Name, timeLog[i], 0);
            }
            if (mark >= 0)
            {
                treeView1.Nodes[mark].ImageIndex = 1;
                treeView1.Nodes[mark].SelectedImageIndex = 1;
                for (int i = 0; i < mark; i++)
                {
                    treeView1.Nodes[i].ImageIndex = 2;
                    treeView1.Nodes[i].SelectedImageIndex = 2;
                }

            }
        }
    }
}
