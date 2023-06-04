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
    public partial class DeliveryConfirmView : Form
    {
        Parcel parcel = new Parcel();
        public DeliveryConfirmView()
        {
            InitializeComponent();
        }

        public DeliveryConfirmView(Parcel parcel)
        {
            this.parcel = parcel;
            InitializeComponent();
        }
        private void DeliveryConfirmView_Load(object sender, EventArgs e)
        {

        }

        private async void yesBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            parcel.ParStatus = "PROCESSED";
            parcel.ManID = UserSession.delivery.ManID;
            string jsonString = JsonConvert.SerializeObject(parcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", jsonContent);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã nhận giao đơn hàng thành công");
            }
            var dashboard = (DeliveryDashboard)Tag;
            dashboard.RefreshData();
            Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
