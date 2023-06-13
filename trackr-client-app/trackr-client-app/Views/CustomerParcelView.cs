using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;
using trackr_client_app.Views;

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
            GetCancelStatus();
            cusCodeTB.Text = UserSession.customer.CusID.ToString();
            cusAddressTB.Text = UserSession.customer.CusAddress.Replace('*',',');
            cusNameTB.Text = UserSession.customer.CusName;
            cusPhoneTB.Text = UserSession.customer.CusPhone;
            priceTB.Text = parcel.Price.ToString();
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            statusTB.Text = parcel.ParStatus;
            noteTB.Text = parcel.Note;
            orderDateTB.Text = parcel.ParDeliveryDate.ToString("dd-MM-yyyy");
            estimateDateTB.Text = parcel.ParDeliveryDate.AddDays(3).ToString("dd-MM-yyyy");
            parcelImg.ImageLocation = parcel.ParImage;
            parcelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            GetReivewStatus();
            DisplayTrackingTree();
        }

        private void GetCancelStatus()
        {
            if(parcel.ParStatus.Contains('@'))
            {
                cancelBtn.Enabled = false;
                cancelBtn.Text = "Đã gửi yêu cầu hủy đơn";
                statusTB.Text = "IN_CANCEL";
            }
            else if(parcel.ParStatus == "CANCELLED")
            {
                cancelBtn.Enabled = false;
                cancelBtn.Text = "Đơn hàng đã bị hủy";
            }
        }
        private async void GetReivewStatus()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(UserSession.apiUrl + $"review/parcel?id={parcel.ParID}");
            var responseString = await response.Content.ReadAsStringAsync();
            var reviews = JArray.Parse(responseString);
            bool reviewed;
            if (reviews.Count > 0)
            {
                reviewBtn.Text = "Đã đánh giá";
                reviewed = true;
            }
            else
            {
                reviewed= false;
            }
            if (parcel.ParStatus == "COMPLETED" && !reviewed)
            {
                reviewBtn.Enabled = true;
                reviewBtn.BackColor = ColorTranslator.FromHtml("226, 111, 111");
            }
        }

        private void DisplayTrackingTree()
        {
            treeView1.Nodes.Clear();
            if (parcel.ParRouteLocation == null || parcel.ParRouteLocation.Length <= 0) return;
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
            for(int i=1; i < timeLog.Length; i++)
            {
                int j = i - 1;
                treeView1.Nodes[j].Nodes.Add(Name, timeLog[i], 3, 3);
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

        private void chatBtn_Click(object sender, EventArgs e)
        {
            string command = $"mailto:trackrservice@gmail.com?subject= Trackr - Liên hệ về đơn hàng #{parcel.ParID}";
            Process.Start(command);
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            CustomerReview customerReview = new CustomerReview(parcel.ParID, parcel.ParDescription);
            customerReview.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            CustomerParcelCancel customerParcelCancel = new CustomerParcelCancel(parcel.ParID);
            customerParcelCancel.Show();
        }
    }
}
