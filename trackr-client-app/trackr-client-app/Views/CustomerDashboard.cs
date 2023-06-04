using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using trackr_client_app.Models;
using trackr_client_app.Views;

namespace trackr_client_app
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = searchTB.Text;
            parcelGridView.ClearSelection();
            parcelGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           try
           {
                foreach (DataGridViewRow row in parcelGridView.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
           }
           catch (Exception ex)
           {
                MessageBox.Show(ex.ToString());
           }
            
        }

        private void CustomerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginForm = (LoginForm)Tag;
            loginForm.Close();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = UserSession.customer.CusName;
            if (UserSession.customer.CusImage != null)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.LoadAsync(UserSession.customer.CusImage);
            }
            GetData();
        }

        private async void GetData()
        {
            HttpClient client = new HttpClient();
            string cusID = UserSession.customer.CusID.ToString();
            var response = await client.GetAsync(UserSession.apiUrl + $"Customer/Parcel?id={cusID}");
            var responseString = await response.Content.ReadAsStringAsync();
            var parcels = JArray.Parse(responseString);
            LoadData(parcels);
            DisplayData();

        }
        private void LoadData(JArray parcels)
        {
            foreach(JObject parcel in parcels.Cast<JObject>())
            {
                Parcel newParcel = new Parcel();
                newParcel = JsonConvert.DeserializeObject<Parcel>(parcel.ToString());
                UserSession.parcels.Add(newParcel);
            }
        }
        private void DisplayData()
        {
            int i = 1;
            foreach(Parcel parcel in UserSession.parcels)
            {
                parcelGridView.Rows.Add(i++, parcel.ParID.ToString(),parcel.ParDescription,parcel.ParDeliveryDate.ToString(),parcel.ParStatus);
            }
        }

        private void parcelGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(parcelGridView.CurrentCell.ColumnIndex == 1 && e.RowIndex != -1) 
            {
                Parcel parcel = UserSession.parcels[e.RowIndex];
                CustomerParcelView customerParcelView = new CustomerParcelView(parcel);
                customerParcelView.Show();
            }
        }

        public void RefreshData()
        {
            UserSession.parcels.Clear();
            parcelGridView.Rows.Clear();
            GetData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            CustomerInfoView customerInfoView = new CustomerInfoView();
            customerInfoView.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CustomerInfoView customerInfoView = new CustomerInfoView();
            customerInfoView.Show();
        }

        private void chatBtn_Click(object sender, EventArgs e)
        {
            ChatroomView chatroomView = new ChatroomView();
            chatroomView.Show();
        }
    }
}
