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
    public partial class AdminCancelView : Form
    {
        Parcel parcel = new Parcel();
        public AdminCancelView()
        {
            InitializeComponent();
        }

        public AdminCancelView(Parcel parcel,string reason)
        {
            this.parcel = parcel;
            InitializeComponent();
            reasonTB.Text = reason;
        }

        private async void yesBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            parcel.ParStatus = "CANCELLED";
            yesBtn.Text = "Đang xử lý...";
            var json = JsonConvert.SerializeObject(parcel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã hủy giao đơn hàng này");
                Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                Close();
            }
        }

        private async void noBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            parcel.ParStatus = "PROCESSED";
            noBtn.Text = "Đang xử lý...";
            var json = JsonConvert.SerializeObject(parcel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đơn hàng sẽ tiếp tục được giao");
                Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                Close();
            }
        }
    }
}
