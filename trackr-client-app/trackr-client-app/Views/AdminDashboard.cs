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
        private static readonly HttpClient client = new HttpClient();
        List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
        List<Customer> customers = new List<Customer>();
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
        #region Parcel Data
        private async void GetParcelData()
        {
            var response = await client.GetAsync("https://trackrwebserver.azurewebsites.net/api/Parcel");
            var responseString = await response.Content.ReadAsStringAsync();
            var parcels = JArray.Parse(responseString);
            LoadParcelData(parcels);
            DisplayParcelData();
        }
        private void LoadParcelData(JArray parcels)
        {
            foreach (JObject parcel in parcels.Cast<JObject>())
            {
                Parcel newParcel = new Parcel();
                newParcel = JsonConvert.DeserializeObject<Parcel>(parcel.ToString());
                UserSession.parcels.Add(newParcel);
            }
        }

        private void DisplayParcelData()
        {
            int i = 1;
            foreach (Parcel parcel in UserSession.parcels)
            {
                parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(), parcel.ParStatus);
            }
        }
        #endregion

        #region DeliveryMan Data
        private async void GetDeliveryManData()
        {
            var response = await client.GetAsync("https://trackrwebserver.azurewebsites.net/api/DeliveryMan");
            var responseString = await response.Content.ReadAsStringAsync();
            var deliveryManArray = JArray.Parse(responseString);
            LoadDeliveryManData(deliveryManArray);
            DisplayDeliveryManData();
        }

        private void LoadDeliveryManData(JArray deliveryManArray)
        {
            foreach(JObject deliveryMan in deliveryManArray.Cast<JObject>())
            {
                DeliveryMan newDeliveryMan = new DeliveryMan();
                newDeliveryMan = JsonConvert.DeserializeObject<DeliveryMan>(deliveryMan.ToString());
                deliveryMen.Add(newDeliveryMan);
            }
        }
        
        private void DisplayDeliveryManData()
        {
            int i = 1;
            foreach(DeliveryMan deliveryMan in deliveryMen)
            {
                deliveryGridView.Rows.Add(i++, deliveryMan.ManID.ToString(), deliveryMan.ManName, deliveryMan.ManPhone);
            }
        }
        #endregion

        #region Customer Data
        
        private async void GetCustomerData()
        {
            var response = await client.GetAsync("https://trackrwebserver.azurewebsites.net/api/DeliveryMan");
            var responseString = await response.Content.ReadAsStringAsync();
            var customerArray = JArray.Parse(responseString);
            LoadCustomerData(customerArray);
            DisplayCustomerData();
        }

        private void LoadCustomerData(JArray customerArray)
        {
            foreach(JObject customer in customerArray.Cast<JObject>())
            {
                Customer newCustomer = new Customer();
                newCustomer = JsonConvert.DeserializeObject<Customer>(customer.ToString());
                customers.Add(newCustomer);
            }
        }

        private void DisplayCustomerData()
        {
            int i = 1;
            foreach(Customer customer in customers)
            {
                customerGridView.Rows.Add(i++, customer.CusID.ToString(), customer.CusName, customer.CusAddress);
            }
        }
        #endregion
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
