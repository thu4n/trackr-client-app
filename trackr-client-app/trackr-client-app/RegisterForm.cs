using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Net;

namespace trackr_client_app
{
    public partial class RegisterForm : Form
    {
        private bool returnToLogin = false;
        OpenFileDialog ofd = new OpenFileDialog();
        FileInfo fileInfo;
        public static readonly List<string> imgExtensions = new List<string> { ".png", ".jpg", ".jpeg", ".gif" };
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void returnLabel_Click(object sender, EventArgs e)
        {
            var loginForm = (LoginForm) Tag;
            loginForm.StartPosition = FormStartPosition.Manual;
            loginForm.Location = this.Location;
            loginForm.Show();
            returnToLogin = true;
            Close();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!returnToLogin)
            {
                var loginForm = (LoginForm)Tag;
                loginForm.Close();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        public static bool CheckEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch(FormatException)
            { 
                return false; 
            }
        }

        private void FillCustomerData(Customer customer)
        {
            string padding = "@@@!0Di3m***";
            customer.CusName = nameTB.Text;
            customer.CusAccount = accountTB.Text;
            customer.CusPassword = LoginForm.ComputeSHA256(passwordTB.Text + padding);
            customer.CusBirth = Convert.ToDateTime(birthTB.Text);
            customer.CusPhone = phoneTB.Text;
            customer.CusAddress = streetTB.Text + "@" + districtTB.Text + "@" + cityTB.Text;
            customer.CusDateRegister = DateTime.Now;
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (!CheckEmail(accountTB.Text))
            {
                MessageBox.Show("Địa chỉ email không hợp lệ");
                return;
            }
            if(passwordTB.Text != repwdTB.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống");
                return;
            }
            if(accountTB.Text == string.Empty || passwordTB.Text == string.Empty || repwdTB.Text == string.Empty )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            Customer newCustomer = new Customer();
            FillCustomerData(newCustomer);
            PostCustomer(newCustomer);
            registerBtn.Text = "Đang đăng ký...";
        }

        private async void PostCustomer(Customer newCustomer)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://testtestserver20230526163638.azurewebsites.net/api/Image");
            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(File.OpenRead(fileInfo.FullName)), "File", fileInfo.Name);
            request.Content = content;

            var response = await client.SendAsync(request);
            string uriStr = await response.Content.ReadAsStringAsync();
            JObject uri = JObject.Parse(uriStr);
            uri.TryGetValue("blob", out var blobStr);
            JObject blob = JObject.Parse(blobStr.ToString());
            blob.TryGetValue("uri", out var blobUri);

            newCustomer.CusImg = blobUri.ToString();

            string jsonString = JsonConvert.SerializeObject(newCustomer);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var postResponse = await client.PostAsync("https://testtestserver20230526163638.azurewebsites.net/api/Customer", jsonContent);
            var responseString = await postResponse.Content.ReadAsStringAsync();
            if (postResponse.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Đã tạo thành công");
                registerBtn.Text = "Đăng ký";
                var loginForm = (LoginForm)Tag;
                loginForm.Close();
            }
            else MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");

        }
        private void browseBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            try
            {
                fileInfo = new FileInfo(ofd.FileName);
                if (imgExtensions.Contains(fileInfo.Extension.ToLowerInvariant()))
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.ImageLocation = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("Định dạng file hình ảnh không hợp lệ");
                    return;
                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Không có file nào được chọn");
            }
        }
    }
}
