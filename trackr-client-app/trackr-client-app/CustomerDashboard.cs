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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trackr_client_app.Models;

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
            
        }

        private void CustomerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }

        private async void CustomerDashboard_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string cusID = UserSession.customer.CusID.ToString();
            var response = await client.GetAsync($"https://testtestserver20230526163638.azurewebsites.net/api/Customer/Parcel?id={cusID}");
            var responseString = await response.Content.ReadAsStringAsync();
            var parcels = JArray.Parse(responseString);
            var data = LoadData(parcels);
            DisplayData(data);
        }
        private List<Parcel> LoadData(JArray parcels)
        {
            List<Parcel> data = new List<Parcel>();
            foreach(JObject parcel in parcels.Cast<JObject>())
            {
                Parcel newParcel = new Parcel();
                newParcel = JsonConvert.DeserializeObject<Parcel>(parcel.ToString());
                data.Add(newParcel);
            }
            return data;
        }
        private void DisplayData(List<Parcel> data)
        {
            int i = 1;
            foreach(Parcel parcel in data)
            {
                parcelGridView.Rows.Add(i++, parcel.ParID.ToString(),parcel.ParDescription,parcel.ParDeliveryDate.ToString(),parcel.ParStatus);
            }
        }

        private void parcelGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(parcelGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1) 
            {
                /*CustomerParcelView customerParcelView = new CustomerParcelView();
                customerParcelView.Show();*/
            }
        }
    }
}
