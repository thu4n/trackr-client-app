using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trackr_client_app.Views
{
    public partial class CustomerPaymentView : Form
    {
        int price, id;
        public CustomerPaymentView()
        {
            InitializeComponent();
        }

        public CustomerPaymentView(int price, int id)
        {
            this.price = price;
            this.id = id;
            InitializeComponent();
        }

        private void CustomerPaymentView_Load(object sender, EventArgs e)
        {
            moneyLabel2.Text = price.ToString();
            codeLabel2.Text = id.ToString();
            string url = $"https://qrpay.zalopay.vn/merchant/shop/34999/581496/581496_581497/581496_581497_581498?a={price}&d=%C4%90%C6%A1n+h%C3%A0ng+%23{id}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = qrCodeImage;
        }
    }
}
