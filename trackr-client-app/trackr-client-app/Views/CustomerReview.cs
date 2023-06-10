using Newtonsoft.Json;
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
    public partial class CustomerReview : Form
    {
        int id;
        string name;
        int star = 0;
        public CustomerReview()
        {
            InitializeComponent();
        }
        public CustomerReview(int id, string name)
        {
            this.id = id;
            this.name = name;
            InitializeComponent();
        }
        #region StarRating
        private void star1_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 0;
            star3.ImageIndex = 0;
            star4.ImageIndex = 0;
            star5.ImageIndex = 0;
            star = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 0;
            star4.ImageIndex = 0;
            star5.ImageIndex = 0;
            star = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 0;
            star5.ImageIndex = 0;
            star = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 1;
            star5.ImageIndex = 0;
            star = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 1;
            star5.ImageIndex = 1;
            star = 5;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private async void reviewBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            Review review = new Review(id, feedbackTB.Text, star);
            string json = JsonConvert.SerializeObject(review);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            reviewBtn.Text = "Đang gửi...";
            var response = await client.PostAsync(UserSession.apiUrl + "review",content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã gửi thành công");
                Close();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");
                Close();
            }
        }

        private void CustomerReview_Load(object sender, EventArgs e)
        {
            parcelCodeTB.Text = id.ToString();
            parcelNameTB.Text = name;
        }
    }
}
