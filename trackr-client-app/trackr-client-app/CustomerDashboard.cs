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
using Newtonsoft.Json.Linq;

namespace trackr_client_app
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }
        public CustomerDashboard(string name)
        {
            InitializeComponent();
            usernameLabel.Text = name;
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://testtestserver20230526163638.azurewebsites.net/api/Parcel");
            var responseString = await response.Content.ReadAsStringAsync();
            var arr = JArray.Parse(responseString);
            foreach(var item in arr)
            {
                MessageBox.Show(item.ToString());
            }
            /*CustomerParcelView customerParcelView = new CustomerParcelView();
            customerParcelView.Show();*/
        }

        private void CustomerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }
    }
}
