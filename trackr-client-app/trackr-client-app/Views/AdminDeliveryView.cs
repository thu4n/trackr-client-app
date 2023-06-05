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
using System.Windows.Controls;
using System.Windows.Forms;
using trackr_client_app.Models;

namespace trackr_client_app.Views
{
    public partial class AdminDeliveryView : Form
    {
        DeliveryMan deliveryMan = new DeliveryMan();
        List<Parcel> parcels = new List<Parcel>();
        public AdminDeliveryView()
        {
            InitializeComponent();
        }

        public AdminDeliveryView(DeliveryMan delivery)
        {
            this.deliveryMan = delivery;
            InitializeComponent();
        }

        private void AdminDeliveryView_Load(object sender, EventArgs e)
        {
            nameTB.Text = deliveryMan.ManName;
            codeTB.Text = deliveryMan.ManID.ToString();
            phoneTB.Text = deliveryMan.ManPhone;
            if(deliveryMan.ManImage != null )
            {
                imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
                imgBox.LoadAsync(deliveryMan.ManImage);
            }
            LoadParcelData();
        }

        private void LoadParcelData()
        {
            int i = 1;
            parcelGridView.Rows.Clear();
            foreach (Parcel parcel in UserSession.parcels)
            {
                if(deliveryMan.ManID == parcel.ManID)
                {
                    string[] locations = new string[] { "" };
                    if (parcel.ParRouteLocation != null)
                    {
                        locations = parcel.ParRouteLocation.Split('@');
                    }
                    parcelGridView.Rows.Add(i++, parcel.ParID.ToString(), parcel.ParDescription, parcel.ParDeliveryDate.ToString(), locations.Last());

                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            AdminDeleteView adminDeleteView = new AdminDeleteView(deliveryMan.ManID, "DeliveryMan");
            adminDeleteView.Show();
        }
    }
}
