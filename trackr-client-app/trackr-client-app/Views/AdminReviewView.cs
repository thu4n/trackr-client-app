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
    public partial class AdminReviewView : Form
    {
        int id = 0;
        public AdminReviewView()
        {
            InitializeComponent();
        }

        public AdminReviewView(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private async void AdminReviewView_Load(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(UserSession.apiUrl + $"review/parcel?id={id}");
            var responseString = await response.Content.ReadAsStringAsync();
            var reviews = JArray.Parse(responseString);
            if (reviews.Count > 0)
            {
                titleLabel.Text = $"Đánh giá cho đơn hàng #{id}";
                foreach(var review in reviews.Cast<JObject>())
                {
                    Review newReview = JsonConvert.DeserializeObject<Review>(review.ToString());
                    RateStar(newReview.star);
                    feedbackTB.Text = newReview.reDescription;
                }
            }
            else
            {
                titleLabel.Text = "Chưa có đánh giá cho đơn hàng này";
            }
        }

        private void RateStar(int x)
        {
            switch(x)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        star1.ImageIndex = 1;
                        break;
                    }
                case 2:
                    {
                        star1.ImageIndex = 1;
                        star2.ImageIndex = 1;
                        break;
                    }
                case 3:
                    {
                        star1.ImageIndex = 1;
                        star2.ImageIndex = 1;
                        star3.ImageIndex = 1;
                        break;
                    }
                case 4:
                    {
                        star1.ImageIndex = 1;
                        star2.ImageIndex = 1;
                        star3.ImageIndex = 1;
                        star4.ImageIndex = 1;
                        break;
                    }
                case 5:
                    {
                        star1.ImageIndex = 1;
                        star2.ImageIndex = 1;
                        star3.ImageIndex = 1;
                        star4.ImageIndex = 1;
                        star5.ImageIndex = 1;
                        break;
                    }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
