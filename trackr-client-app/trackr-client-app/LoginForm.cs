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
            var values = new Dictionary<string, string>
            {
                { "username", username },
                { "password", password }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://dummyjson.com/auth/login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString); // Chuyển string nhận được thành Json Object
            if (json.TryGetValue("token", out var token))  // Lấy thông tin từ trường token của Json Object
            {
                json.TryGetValue("username", out var name);
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
