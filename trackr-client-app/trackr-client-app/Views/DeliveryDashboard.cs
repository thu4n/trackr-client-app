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
using trackr_client_app.Models;

namespace trackr_client_app.Views
{
    public partial class DeliveryDashboard : Form
    {
        public DeliveryDashboard()
        {
            InitializeComponent();
        }

        private void DeliveryDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = UserSession.delivery.ManName;
            GetData();
        }

        private async void GetData()
        {
            HttpClient client = new HttpClient();

            // Lấy đơn hàng trước
            var response = await client.GetAsync(UserSession.apiUrl + "Parcel");
            var responseString = await response.Content.ReadAsStringAsync();
            var parcels = JArray.Parse(responseString);
            LoadParcelData(parcels);

            // Lấy thông tin khách hàng, do bất đồng bộ nên để chung một hàm để đảm bảo thứ tự không bị sai
            response = await client.GetAsync(UserSession.apiUrl + "Customer");
            responseString = await response.Content.ReadAsStringAsync();
            var customers = JArray.Parse(responseString);
            LoadCustomerData(customers);
            DisplayData();
        }
        private void LoadCustomerData(JArray customers)
        {
            foreach(JObject customer in customers.Cast<JObject>())
            {
                Customer newCustomer = new Customer();
                newCustomer = JsonConvert.DeserializeObject<Customer>(customer.ToString());
                UserSession.customers.Add(newCustomer);
            }
        }
        private void LoadParcelData(JArray parcels)
        {
            foreach (JObject parcel in parcels.Cast<JObject>())
            {
                Parcel newParcel = new Parcel();
                newParcel = JsonConvert.DeserializeObject<Parcel>(parcel.ToString());
                if(newParcel.ParStatus == "READY_TO_SHIP")
                {
                    UserSession.parcels.Add(newParcel);
                }
            }
        }
        private void DisplayData()
        {
            int i = 1;
            foreach (Parcel parcel in UserSession.parcels)
            {
                Customer customer = UserSession.customers.Find(x => x.CusID == parcel.CusID);
                parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(), customer.CusAddress);
            }
        }
        private void parcelGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Parcel parcel = UserSession.parcels[e.RowIndex];
                DeliveryConfirmView deliveryConfirmView = new DeliveryConfirmView(parcel);
                deliveryConfirmView.StartPosition = FormStartPosition.CenterScreen;
                deliveryConfirmView.Show();
            }
        }
    }
}
