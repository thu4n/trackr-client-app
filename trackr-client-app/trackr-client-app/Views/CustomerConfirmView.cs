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
using trackr_client_app.Views;
using System.Net.Http;

namespace trackr_client_app.Views
{
    public partial class CustomerConfirmView : Form
    {
        private readonly HttpClient client = new HttpClient();
        private Parcel parcel;
        public CustomerConfirmView(Parcel selectedParcel)
        {
            InitializeComponent();
            parcel = selectedParcel;
        }

        private async void yesBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(parcel.CancellationReason))
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    // Dẫn link API toàn bộ đơn
                    string apiUrl = $"testtestserver20230526163638.azurewebsites.net/api/Parcel";

                    // Gửi yêu cầu DELETE lên API để hủy đơn hàng
                    HttpResponseMessage response = await httpClient.DeleteAsync(apiUrl);

                    // Kiểm tra kết quả trả về từ API
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Đơn hàng đã được hủy thành công.");

                    }
                    else
                    {
                        MessageBox.Show("Không thể hủy đơn hàng. Vui lòng thử lại sau.");
                    }
                }
            }

            else
            {
                MessageBox.Show("Vui lòng chọn lý do huỷ đơn hàng.");
            }
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            CustomerParcelView customerParcelView = new CustomerParcelView();
            customerParcelView.Show();
        }
    }
}
