using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;

namespace trackr_client_app.Views
{
    public partial class DeliveryParcelView : Form
    {
        Parcel parcel = new Parcel();
        Customer customer = new Customer();
        public DeliveryParcelView()
        {
            InitializeComponent();
        }

        public DeliveryParcelView(Parcel parcel, Customer customer)
        {
            this.parcel = parcel;
            this.customer = customer;
            InitializeComponent();
        }

        private void DeliveryParcelView_Load(object sender, EventArgs e)
        {
            priceTB.Text = parcel.Price.ToString();
            cusCodeTB.Text = customer.CusID.ToString();
            if(customer.CusAddress.Contains('*')) 
                cusAddressTB.Text = customer.CusAddress.Replace('*',',');
            cusNameTB.Text = customer.CusName;
            cusPhoneTB.Text = customer.CusPhone;
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            statusTB.Text = parcel.ParStatus;
            noteTB.Text = parcel.Note;
            orderDateTB.Text = parcel.ParDeliveryDate.ToShortDateString();
            estimateDateTB.Text = parcel.ParDeliveryDate.AddDays(3).ToShortDateString();
            parcelImg.ImageLocation = parcel.ParImage;
            parcelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            timeTB.Text = DateTime.Now.ToString();
            DisplayTrackingTree();
        }
        private void DisplayTrackingTree()
        {
            string[] routeLog = parcel.ParRouteLocation.Split('@');
            string[] timeLog = parcel.Realtime.Split('@');
            string[] locationLog = parcel.ParLocation.Split('@');
            int mark = locationLog.Length - 2;
            int.TryParse(routeLog[0], out var distance);

            distanceLabel.Text = $"Tổng khoảng cách ước tính: {distance} km";
            for (int i = 1; i < routeLog.Length; i++)
            {
                string log = routeLog[i];
                if(i > mark) locationTB.Items.Add(log);
                if(i == routeLog.Length - 1)
                {
                    log = routeLog[i].Replace('*',',');
                }
                treeView1.Nodes.Add("done", log, 0);
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
                for (int i =0; i < mark; i++)
                {
                    treeView1.Nodes[i].ImageIndex = 2;
                    treeView1.Nodes[i].SelectedImageIndex = 2;
                }

            }

        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            string location = locationTB.Text;
            string realtime = timeTB.Text;
            UpdateRoute(location, realtime);
        }

        private async void UpdateRoute(string location, string realtime)
        {
            var client = new HttpClient();
            parcel.ParLocation += "@" + location;
            parcel.Realtime += "@" + realtime;
            if(location == customer.CusAddress)
            {
                parcel.ParStatus = "COMPLETED";
            }
            string jsonString = JsonConvert.SerializeObject(parcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", jsonContent);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseString);
            Close();
        }
    }
}
