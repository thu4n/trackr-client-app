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
    public partial class AdminReviewDashboard : Form
    {
        int starSum = 0;
        public AdminReviewDashboard()
        {
            InitializeComponent();
        }

        private void AdminReviewDashboard_Load(object sender, EventArgs e)
        {
            GetReviewData();
        }
        private async void GetReviewData()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(UserSession.apiUrl + "review");
            var json = await response.Content.ReadAsStringAsync();
            JArray reviews = JArray.Parse(json);
            foreach ( var review in reviews.Cast<JObject>())
            {
                Review newReview = JsonConvert.DeserializeObject<Review>(review.ToString());
                UserSession.reviews.Add(newReview);
                starSum += newReview.star;
            }
            DisplayReviewData();
        }
        private void DisplayReviewData()
        {
            reviewGridView.Rows.Clear();
            double reviewAvg = (double)starSum / UserSession.reviews.Count;
            reviewAvg = Math.Round(reviewAvg, 2);
            int i = 1;
            foreach(var review in UserSession.reviews)
            {
                Parcel parcel = UserSession.parcels.Find(x => x.ParID == review.parId);
                reviewGridView.Rows.Add(i++, review.parId, parcel.ParDescription, review.star + " ★", review.reDescription);
            }
            avgLabel.Text = $"Đánh giá trung bình: {reviewAvg}/5★";
            countLabel.Text = $"Tổng lượt đánh giá: {UserSession.reviews.Count} lượt";

        }
    }
}
