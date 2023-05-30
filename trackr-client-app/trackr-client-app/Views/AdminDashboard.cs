using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Windows.Markup;
using trackr_client_app.Models;

namespace trackr_client_app.Views
{
    public partial class AdminDashboard : Form
    {
        List<Parcel> data = new List<Parcel>();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = UserSession.admin.AdName;
            /*DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = UserSession.admin.AdName;
            btn.Name = UserSession.admin.AdName;
            btn.Text = UserSession.admin.AdName;
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Rows.Add("thuan");*/
        }

        private async void GetParcelData()
        {
            HttpClient client = new HttpClient();
            string cusID = UserSession.customer.CusID.ToString();
            var response = await client.GetAsync("https://trackrwebserver.azurewebsites.net/api/Parcel");
            var responseString = await response.Content.ReadAsStringAsync();
            var parcels = JArray.Parse(responseString);
            /*var data = LoadData(parcels);
            DisplayData(data);*/
        }
        private List<Parcel> LoadParcelData(JArray parcels)
        {
            foreach (JObject parcel in parcels.Cast<JObject>())
            {
                Parcel newParcel = new Parcel();
                newParcel = JsonConvert.DeserializeObject<Parcel>(parcel.ToString());
                data.Add(newParcel);
            }
            return data;
        }

        private void DisplayParcelData(List<Parcel> data)
        {
            int i = 1;
            foreach (Parcel parcel in data)
            {
                //parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(), parcel.ParStatus);
            }
        }

        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
