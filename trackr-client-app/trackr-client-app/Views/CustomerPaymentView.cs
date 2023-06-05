using Newtonsoft.Json;
using QRCoder;
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
    public partial class CustomerPaymentView : Form
    {
        Parcel parcel = new Parcel();
        public CustomerPaymentView()
        {
            InitializeComponent();
        }

        public CustomerPaymentView(Parcel parcel)
        {
            this.parcel = parcel;
            InitializeComponent();
        }

        private async void confBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            parcel.ParStatus = "COMPLETED";
            parcel.ManID = UserSession.delivery.ManID;
            string jsonString = JsonConvert.SerializeObject(parcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(UserSession.apiUrl + $"Parcel/{parcel.ParID}", jsonContent);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Thanh toán thành công, nhân viên vui lòng thông tin lại cho khách hàng");
            }
            Close();
        }

        private void CustomerPaymentView_Load(object sender, EventArgs e)
        {
            moneyLabel2.Text = parcel.Price.ToString();
            codeLabel2.Text = parcel.ParID.ToString();
            string url = $"https://qrpay.zalopay.vn/merchant/shop/34999/581496/581496_581497/581496_581497_581498?a={parcel.Price}&d=%C4%90%C6%A1n+h%C3%A0ng+%23{parcel.ParID}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = qrCodeImage;
        }
    }
}
