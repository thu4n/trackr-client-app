using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;

namespace trackr_client_app.Views
{
    public partial class CustomerInfoView : Form
    {
        bool update = false;
        OpenFileDialog ofd = new OpenFileDialog();
        FileInfo fileInfo;
        bool imageChanged = false;
        public CustomerInfoView()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            update = true;
            LoadView(update);
        }

        private void CustomerInfoView_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadView(update);
        }

        private void LoadData()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            accountTB.Text = UserSession.customer.CusAccount;
            birthTB.Text = UserSession.customer.CusBirth.ToShortDateString();
            string[] address = UserSession.customer.CusAddress.Split('*');
            streetTB.Text = address[0];
            districtTB.Text = address[1];
            cityTB.Text = address[2];
            phoneTB.Text = UserSession.customer.CusPhone;
            nameTB.Text = UserSession.customer.CusName;
            if (UserSession.customer.CusImage != null) pictureBox1.LoadAsync(UserSession.customer.CusImage);
        }

        private void LoadView(bool update)
        {
            confBtn.Visible = update;
            noBtn.Visible = update;
            browseBtn.Visible = update;

            updateBtn.Visible = !update;
            accountTB.ReadOnly = !update;
            birthTB.ReadOnly = !update;
            streetTB.ReadOnly = !update;
            cityTB.ReadOnly = !update;
            phoneTB.ReadOnly = !update;
            nameTB.ReadOnly = !update;

        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            LoadData();
            update = false;
            LoadView(update);
        }

        public static bool CheckEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void FillCustomerData(Customer customer)
        {
            customer.CusName = nameTB.Text;
            customer.CusAccount = accountTB.Text;
            customer.CusBirth = Convert.ToDateTime(birthTB.Text);
            customer.CusPhone = phoneTB.Text;
            customer.CusAddress = streetTB.Text + "*" + districtTB.Text + "*" + cityTB.Text;
        }
        private void confBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmail(accountTB.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }
            Customer newCustomer = UserSession.customer;
            FillCustomerData(newCustomer);
            PostCustomer(newCustomer);
        }
        private async void PostCustomer(Customer newCustomer)
        {
            var client = new HttpClient();
            if (imageChanged) // Chỉ tạo post request cho hình ảnh nếu có thay đổi từ phía user
            {
                var request = new HttpRequestMessage(HttpMethod.Post, UserSession.apiUrl + "Image");
                var content = new MultipartFormDataContent();
                content.Add(new StreamContent(File.OpenRead(fileInfo.FullName)), "File", fileInfo.Name);
                request.Content = content;

                var response = await client.SendAsync(request);
                string uriStr = await response.Content.ReadAsStringAsync();
                JObject uri = JObject.Parse(uriStr);
                uri.TryGetValue("blob", out var blobStr);
                JObject blob = JObject.Parse(blobStr.ToString());
                blob.TryGetValue("uri", out var blobUri);

                newCustomer.CusImage = blobUri.ToString();
            }
            string jsonString = JsonConvert.SerializeObject(newCustomer);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var postResponse = await client.PutAsync(UserSession.apiUrl + $"Customer/{newCustomer.CusID}", jsonContent);
            var responseString = await postResponse.Content.ReadAsStringAsync();
            if (postResponse.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Đã cập nhật thành công");
            }
            else MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");

        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            try
            {
                fileInfo = new FileInfo(ofd.FileName);
                if(RegisterForm.imgExtensions.Contains(fileInfo.Extension))
                {
                    pictureBox1.ImageLocation = ofd.FileName;
                    imageChanged = true;
                }
                else
                {
                    MessageBox.Show("Định dạng file hình ảnh không đúng");
                }

            }
            catch(ArgumentException)
            {
                MessageBox.Show("Không có file nào được chọn");
            }
        }

    }
}
