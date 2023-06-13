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
using trackr_client_app.Views;

namespace trackr_client_app.Views
{
    public partial class CustomerParcelCancel : Form
    {
        Parcel parcel = new Parcel();
        int id;
        public CustomerParcelCancel()
        {
            InitializeComponent();
        }

        public CustomerParcelCancel(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private async void cancelConfirmBtn_Click(object sender, EventArgs e)
        {
            if(reasonTB.Text.Length <= 3)
            {
                MessageBox.Show("Vui lòng điền lý do hủy đơn hàng");
                return;
            }
            Parcel cancelParcel = UserSession.parcels.Find(x => x.ParID == id);
            cancelParcel.ParStatus = "IN_CANCEL@" + reasonTB.Text;
            cancelConfirmBtn.Text = "Đang gửi yêu cầu";
            string json = JsonConvert.SerializeObject(cancelParcel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var client = new HttpClient();
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã gửi yêu cầu hủy đơn hàng");
                Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
