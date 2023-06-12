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
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Controls;
using System.Linq.Expressions;

namespace trackr_client_app.Views
{
    public partial class CustomerConfirmView : Form
    {
        Parcel parcel = new Parcel();
        Customer customer = new Customer();
        int id;
        public CustomerConfirmView()
        {
            InitializeComponent();
        }

        public CustomerConfirmView(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async void yesBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            parcel.ParStatus = "IN_CANCEL";
            parcel.ParID = this.id;
            string jsonString = JsonConvert.SerializeObject(parcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", jsonContent);
            var responseString = await response.Content.ReadAsStringAsync();
            
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đã gửi thành công yêu cầu hủy đơn hàng", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Yêu cầu bị lỗi");
                }
            Close();
        }
        

        private void noBtn_Click(object sender, EventArgs e)
        {
            CustomerParcelView customerParcelView = new CustomerParcelView();
            customerParcelView.Show();
        }
    }
}
