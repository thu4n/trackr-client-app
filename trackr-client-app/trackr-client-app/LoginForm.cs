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
using trackr_client_app.Models;
using trackr_client_app.Views;

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

        public static string ComputeSHA256(string s)
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
            loginBtn.Text = "Đang đăng nhập...";
            string username = accountTB.Text; 
            string password = passwordTB.Text;
            string hash = ComputeSHA256(password);
            var values = new Dictionary<string, string>
            {
                { "account", username },
                { "password", hash }
            };
            string jsonString = JsonConvert.SerializeObject(values);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(UserSession.apiUrl + "Login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString); // Chuyển string nhận được thành Json Object
            if (json.TryGetValue("id", out var id))  // Lấy thông tin từ trường token của Json Object
            {
                json.TryGetValue("role", out var role);
                Authorize(role.ToString(), id.ToString());
                loginBtn.Text = "Đăng nhập";
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                loginBtn.Text = "Đăng nhập";
            }
        }
        private void Authorize(string role, string id)
        {
            if(UserSession.customers.Count > 0)
            {
                UserSession.customers.Clear();
            }
            if(UserSession.parcels.Count > 0)
            {
                UserSession.parcels.Clear();
            }
            if(role == "Admin")
            {
                GetAdminInfo(id);
            }
            else if(role == "Customer")
            {
                GetCustomerInfo(id);
            }
            else if (role == "DeliveryMan")
            {
                GetDeliveryInfo(id);
            }
        }
        private async void GetAdminInfo(string id)
        {
            var response = await client.GetAsync(UserSession.apiUrl + $"Admin/{id}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            UserSession.admin = JsonConvert.DeserializeObject<Admin>(json.ToString());
            GetAdminDashBoard();
        }

        private void GetAdminDashBoard()
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Tag = this;
            adminDashboard.StartPosition = FormStartPosition.Manual;
            adminDashboard.Location = this.Location;
            adminDashboard.Show();
            Hide();
        }

        private async void GetDeliveryInfo(string id)
        {
            var response = await client.GetAsync(UserSession.apiUrl + $"DeliveryMan/{id}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            UserSession.delivery = JsonConvert.DeserializeObject<DeliveryMan>(json.ToString());
            GetDeliveryDashBoard();
        }
        private void GetDeliveryDashBoard()
        {
            DeliveryDashboard dashboard = new DeliveryDashboard();
            dashboard.Tag = this;
            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Location = this.Location;
            dashboard.Show();
            Hide();
        }
        private async void GetCustomerInfo(string id)
        {
            var response = await client.GetAsync(UserSession.apiUrl + $"Customer/{id}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            UserSession.customer = JsonConvert.DeserializeObject<Customer>(json.ToString());
            GetCustomerDashBoard();
        }
        private void GetCustomerDashBoard()
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Tag = this;
            customerDashboard.StartPosition = FormStartPosition.Manual;
            customerDashboard.Location = this.Location;
            customerDashboard.Show();
            Hide();
        }

        private void forgotPwdLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
        }
    }
}
