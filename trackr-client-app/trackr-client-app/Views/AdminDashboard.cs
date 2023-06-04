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
        public List<DeliveryMan> deliveryMen = new List<DeliveryMan>();
        public static List<Customer> customers = new List<Customer>();
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = UserSession.admin.AdName;
            GetDeliveryManData();
            GetParcelData();
            GetCustomerData();
        }
        #region Parcel Data
        private async void GetParcelData()
        {
            var response = await client.GetAsync(UserSession.apiUrl + "Parcel");
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
            parcelGridView.Rows.Clear();
            foreach (Parcel parcel in UserSession.parcels)
            {
                DeliveryMan delivery = new DeliveryMan();
                if (parcel.ManID > 0)
                {
                    delivery = UserSession.deliveryMen.Find(x => x.ManID == parcel.ManID);

                }
                else delivery.ManName = "Chưa có người giao";
                parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(), parcel.ParStatus, delivery.ManName);
            }
        }

        private void parcelGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (parcelGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {
                Parcel parcel = UserSession.parcels[e.RowIndex];
                AdminParcelView adminParcelView = new AdminParcelView(parcel);
                adminParcelView.Show();
            }
        }
        #endregion

        #region DeliveryMan Data
        private async void GetDeliveryManData()
        {
            var response = await client.GetAsync(UserSession.apiUrl + "DeliveryMan");
            var responseString = await response.Content.ReadAsStringAsync();
            var deliveryManArray = JArray.Parse(responseString);
            LoadDeliveryManData(deliveryManArray);
        }

        private void LoadDeliveryManData(JArray deliveryManArray)
        {
            foreach(JObject deliveryMan in deliveryManArray.Cast<JObject>())
            {
                DeliveryMan newDeliveryMan = new DeliveryMan();
                newDeliveryMan = JsonConvert.DeserializeObject<DeliveryMan>(deliveryMan.ToString());
                UserSession.deliveryMen.Add(newDeliveryMan);
            }
        }
        
        private void DisplayDeliveryManData()
        {
            int i = 1;
            deliveryGridView.Rows.Clear();
            foreach(DeliveryMan deliveryMan in UserSession.deliveryMen)
            {
                deliveryGridView.Rows.Add(i++, deliveryMan.ManID.ToString(), deliveryMan.ManName, deliveryMan.ManPhone);
            }
        }

        private void deliveryGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deliveryGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {
                DeliveryMan deli = UserSession.deliveryMen[e.RowIndex];
                AdminDeliveryView adminDeliveryView = new AdminDeliveryView(deli);
                adminDeliveryView.Show();
            }
        }
        #endregion

        #region Customer Data

        private async void GetCustomerData()
        {
            var response = await client.GetAsync(UserSession.apiUrl + "Customer");
            var responseString = await response.Content.ReadAsStringAsync();
            var customerArray = JArray.Parse(responseString);
            LoadCustomerData(customerArray);
        }

        private void LoadCustomerData(JArray customerArray)
        {
            foreach(JObject customer in customerArray.Cast<JObject>())
            {
                Customer newCustomer = new Customer();
                newCustomer = JsonConvert.DeserializeObject<Customer>(customer.ToString());
                UserSession.customers.Add(newCustomer);
            }
        }

        private void DisplayCustomerData()
        {
            int i = 1;
            customerGridView.Rows.Clear();
            foreach(Customer customer in UserSession.customers)
            {
                customerGridView.Rows.Add(i++, customer.CusID.ToString(), customer.CusName, customer.CusAddress);
            }
        }

        private void customerGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1)
            {
                Customer customer = UserSession.customers[e.RowIndex];
                AdminCustomerView customerView = new AdminCustomerView(customer);
                customerView.Show();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex){
                case 0:
                    {
                        DisplayParcelData(); break;
                    }
                case 1: 
                    {
                        DisplayDeliveryManData(); break;
                    }
                case 2:
                    {
                        DisplayCustomerData(); break;
                    }
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            AdminCreateParcelView adminCreateParcelView = new AdminCreateParcelView();
            adminCreateParcelView.Tag = this;
            adminCreateParcelView.Show();
        }

        public void RefreshData()
        {
            UserSession.customers.Clear();
            UserSession.deliveryMen.Clear();
            UserSession.parcels.Clear();
            GetParcelData();
            GetCustomerData();
            GetDeliveryManData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
