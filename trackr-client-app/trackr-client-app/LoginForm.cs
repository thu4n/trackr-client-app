using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace trackr_client_app
{
    public partial class LoginForm : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Text = "Trackr - Đăng nhập";
        }

        string ComputeSHA256(string s)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Cần chuyển đổi string sang dạng byte khi Hash
                byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                // Chuyển đổi chuỗi vừa hash sang dạng string để dễ sử dụng
                return BitConverter.ToString(hashValue).Replace("-", "").ToLower();
            }
        }

        private void navigateRegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Tag = this;
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = this.Location;
            registerForm.Show();
            Hide();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            string username = accountTB.Text; 
            string password = passwordTB.Text;
            string padding = "@@@!0Di3m***";
            string hash = ComputeSHA256(password + padding);
            var values = new Dictionary<string, string>
            {
                { "account", username },
                { "password", hash }
            };
            string jsonString = JsonConvert.SerializeObject(values);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"https://testtestserver20230526163638.azurewebsites.net/api/Login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseString);
            JObject json = JObject.Parse(responseString); // Chuyển string nhận được thành Json Object
            if (json.TryGetValue("id", out var id))  // Lấy thông tin từ trường token của Json Object
            {
                json.TryGetValue("name", out var name);
                GetCustomerDashBoard(name.ToString());
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
        private void GetCustomerDashBoard(string name)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard(name);
            customerDashboard.Tag = this;
            customerDashboard.StartPosition = FormStartPosition.Manual;
            customerDashboard.Location = this.Location;
            customerDashboard.Show();
            Hide();

        }
    }
}
