using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace trackr_client_app
{
    public partial class ForgotPasswordForm : Form
    {
        string otp = "t";
        string id = "";
        string role = "";
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private async void getCodeBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string email = emailTB.Text;
            var values = new Dictionary<string, string>
            {
                { "Account", email }
            };
            string jsonString = JsonConvert.SerializeObject(values);
            var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(UserSession.apiUrl + "ForgotPassword", content);
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã gửi OTP về địa chỉ email, vui lòng check cả thư mục spam");
                var responseString = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseString);
                if (json.TryGetValue("code", out var code))
                {
                    otp = code.ToString();
                    json.TryGetValue("id", out var id);
                    this.id = id.ToString();
                    json.TryGetValue("role", out var role);
                    this.role = role.ToString();
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
            }
        }

        private void validateBtn_Click(object sender, EventArgs e)
        {
            
            string input = LoginForm.ComputeSHA256(otpTB.Text);
            if(input == otp)
            {
                MessageBox.Show("OTP hợp lệ, vui lòng nhập lại mật khẩu mới");
                pwdLabel.Visible = true;
                pwdTB.Visible = true;
                confBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("OTP không hợp lệ");
            }
        }

        private async void confBtn_Click(object sender, EventArgs e)
        {
            confBtn.Text = "Đang gửi yêu cầu...";
            var client = new HttpClient();
            var response = await client.GetAsync(UserSession.apiUrl + role + $"/{id}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            Customer customer = JsonConvert.DeserializeObject<Customer>(json.ToString());
            customer.CusPassword = LoginForm.ComputeSHA256(pwdTB.Text);
            string jsonString = JsonConvert.SerializeObject(customer);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            response = await client.PutAsync(UserSession.apiUrl + role + $"/{id}", jsonContent);
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đổi mật khẩu mới thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
