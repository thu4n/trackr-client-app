using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trackr_client_app.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace trackr_client_app.Views
{
    public partial class AdminCreateParcelView : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        FileInfo fileInfo;
        Dictionary<int, string> customerData = new Dictionary<int, string>();
        public static readonly List<string> imgExtensions = new List<string> { ".png", ".jpg", ".jpeg", ".gif" };
        public AdminCreateParcelView()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            try
            {
                fileInfo = new FileInfo(ofd.FileName);
                if (imgExtensions.Contains(fileInfo.Extension.ToLowerInvariant()))
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    imgPathTB.Text = fileInfo.FullName;
                    parcelSample.ImageLocation = fileInfo.FullName;
                }
                else
                {
                    MessageBox.Show("Định dạng file hình ảnh không hợp lệ");
                    return;
                }
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Không có file nào được chọn");
            }
        }
        private async void realUploadBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, UserSession.apiUrl + "Image");
            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(File.OpenRead(fileInfo.FullName)), "File", fileInfo.Name);
            request.Content = content;
            realUploadBtn.Text = "Đang tạo đơn...";

            var response = await client.SendAsync(request);
            string uriStr = await response.Content.ReadAsStringAsync();
            JObject uri = JObject.Parse(uriStr);
            uri.TryGetValue("blob", out var blobStr);
            JObject blob = JObject.Parse(blobStr.ToString());
            blob.TryGetValue("uri", out var blobUri);

            Parcel newParcel = new Parcel();
            newParcel.ParImage = blobUri.ToString();
            newParcel.Note = noteTB.Text;
            newParcel.CusID = int.Parse(cusCodeBox.Text);
            newParcel.ParDescription = nameTB.Text;
            newParcel.ParLocation = "@Bưu điện Trung tâm Sài Gòn, 125 Công xã Paris, Bến Nghé, Quận 1,TPHCM";

            string jsonString = JsonConvert.SerializeObject(newParcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var postResponse = await client.PostAsync(UserSession.apiUrl + "Parcel", jsonContent);
            var responseString = await postResponse.Content.ReadAsStringAsync();
            if(postResponse.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Đã tạo thành công");
            }
            else MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau");

            var adminDashboard = (AdminDashboard)Tag;
            adminDashboard.RefreshData();
            Close();
        }

        private void AdminCreateParcelView_Load(object sender, EventArgs e)
        {
            dateTB.Text = DateTime.Now.ToString();
            parcelSample.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach(var customer in UserSession.customers)
            {
                customerData.Add(customer.CusID, customer.CusName);
                cusCodeBox.Items.Add(customer.CusID);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cusCodeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var obj = cusCodeBox.SelectedItem;
            int id = int.Parse(obj.ToString());
            customerData.TryGetValue(id, out var name);
            cusNameTB.Text = name;
        }
    }
}
