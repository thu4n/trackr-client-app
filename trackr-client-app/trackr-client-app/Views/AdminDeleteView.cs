using System;
using System.CodeDom;
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
    public partial class AdminDeleteView : Form
    {
        int id;
        string objectType;
        public AdminDeleteView()
        {
            InitializeComponent();
        }

        public AdminDeleteView(int id, string objectType)
        {
            this.id = id;
            this.objectType = objectType;
            InitializeComponent();
        }

        private async void yesBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var response = await client.DeleteAsync(UserSession.apiUrl + objectType + $"/{id}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Đã xóa thành công");
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại");
            }
            Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
