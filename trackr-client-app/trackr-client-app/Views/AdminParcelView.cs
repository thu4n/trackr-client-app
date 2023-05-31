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
            GetCustomerData();
            parcelCodeTB.Text = parcel.ParID.ToString();
            parcelNameTB.Text = parcel.ParDescription;
            statusTB.Text = parcel.ParStatus;
            noteTB.Text = parcel.Note;
            parcelImg.ImageLocation = parcel.ParImage;
            parcelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            DisplayTrackingTree();
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
            cusAddressTB.Text = customer.CusAddress;
            cusNameTB.Text = customer.CusName;
            cusPhoneTB.Text = customer.CusPhone;

        }
        private void DisplayTrackingTree()
        {
            string[] locationLog = parcel.ParLocation.Split('@');
            string[] timeLog = parcel.Realtime.Split('@');
            int i = 0;
            foreach (var timeMark in timeLog)
            {
                string locationMark = locationLog[i++];
                treeView1.Nodes.Add(timeMark + " " + locationMark);

            }
        }
    }
}
