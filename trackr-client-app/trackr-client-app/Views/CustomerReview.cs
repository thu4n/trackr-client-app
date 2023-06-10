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
        public CustomerReview()
        {
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
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 0;
            star4.ImageIndex = 0;
            star5.ImageIndex = 0;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 0;
            star5.ImageIndex = 0;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 1;
            star5.ImageIndex = 0;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.ImageIndex = 1;
            star2.ImageIndex = 1;
            star3.ImageIndex = 1;
            star4.ImageIndex = 1;
            star5.ImageIndex = 1;
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        private async void reviewBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            //var response = await client.PostAsync(UserSession.apiUrl + "review",content);
        }
    }
}
