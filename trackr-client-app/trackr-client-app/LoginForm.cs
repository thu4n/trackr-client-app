﻿using System;
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
using trackr_client_app.Models;

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
                { "account", username },
                { "password", password }
            };
            string jsonString = JsonConvert.SerializeObject(values);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://trackrwebserver.azurewebsites.net/api/Login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            MessageBox.Show(responseString);
            JObject json = JObject.Parse(responseString); // Chuyển string nhận được thành Json Object
            if (json.TryGetValue("id", out var id))  // Lấy thông tin từ trường token của Json Object
            {
                json.TryGetValue("role", out var role);
                Authorize(role.ToString(), id.ToString());
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }
        private void Authorize(string role, string id)
        {
            if(role == "Admin")
            {
                
            }
            else if(role == "Customer")
            {
                GetCustomerInfo(id);
            }
            else if (role == "DeliveryMan")
            {

            }
        }
        private async void GetAdminInfo(string id)
        {
            var response = await client.GetAsync($"https://trackrwebserver.azurewebsites.net/api/Admin/{id}");

        }
        private async void GetCustomerInfo(string id)
        {
            var response = await client.GetAsync($"https://trackrwebserver.azurewebsites.net/api/Customer/{id}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            UserSession.customer = JsonConvert.DeserializeObject<Customer>(json.ToString());
            GetCustomerDashBoard(UserSession.customer.CusName);
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
