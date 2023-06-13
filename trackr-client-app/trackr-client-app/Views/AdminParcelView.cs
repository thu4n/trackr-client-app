using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using trackr_client_app.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trackr_client_app.Views
{
    public partial class AdminParcelView : Form
    {
        Parcel parcel;
        public AdminParcelView()
        {
            InitializeComponent();
            
        }

        public AdminParcelView(Parcel parcel)
        {
            this.parcel = parcel;
            InitializeComponent();
        }

        private void AdminParcelView_Load(object sender, EventArgs e)
        {
            GetCancelStatus();
            GetCustomerData();
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            noteTB.Text = parcel.Note;
            parcelImg.ImageLocation = parcel.ParImage;
            parcelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            priceTB.Text = parcel.Price.ToString();
            DisplayTrackingTree();
        }
        private void GetCancelStatus()
        {
            string status = parcel.ParStatus;
            if (parcel.ParStatus.Contains('@'))
            {
                status = parcel.ParStatus.Split('@')[0];
                cancelBtn.Visible = true;
            }
            statusTB.Text = status;
        }
        private async void GetCustomerData()
        {
            HttpClient client = new HttpClient();
            string cusID = parcel.CusID.ToString();
            var response = await client.GetAsync(UserSession.apiUrl + $"Customer/{cusID}");
            var responseString = await response.Content.ReadAsStringAsync();
            var data = JObject.Parse(responseString);
            Customer customer = JsonConvert.DeserializeObject<Customer>(data.ToString());
            cusCodeTB.Text = customer.CusID.ToString();
            cusAddressTB.Text = customer.CusAddress.Replace('*',',');
            cusNameTB.Text = customer.CusName;
            cusPhoneTB.Text = customer.CusPhone;

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
            for (int i = 1; i < timeLog.Length; i++)
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            AdminDeleteView adminDeleteView = new AdminDeleteView(parcel.ParID, "parcel");
            adminDeleteView.Show();
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            AdminReviewView adminReviewView = new AdminReviewView(parcel.ParID);
            adminReviewView.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var reason = parcel.ParStatus.Split('@')[1];
            AdminCancelView adminCancelView = new AdminCancelView(parcel, reason);
            adminCancelView.Show();
        }
    }
}
