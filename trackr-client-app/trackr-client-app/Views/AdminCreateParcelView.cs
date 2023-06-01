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
        public AdminCreateParcelView()
        {
            InitializeComponent();
        }

        // Nút upload hình, do lười suy nghĩ nên không để tên khác
        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            fileInfo = new FileInfo(ofd.FileName);
            imgPathTB.Text = fileInfo.FullName;
            parcelSample.ImageLocation = fileInfo.FullName;
        }

        private async void PostParcel()
        {
            //var value = 
        }
        private async void realUploadBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://testtestserver20230526163638.azurewebsites.net/api/Image");
            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(File.OpenRead(fileInfo.FullName)), "File", fileInfo.Name);
            request.Content = content;
            var response = await client.SendAsync(request);
            string uriStr = await response.Content.ReadAsStringAsync();
            JObject uri = JObject.Parse(uriStr);
            uri.TryGetValue("blob", out var blobStr);
            JObject blob = JObject.Parse(blobStr.ToString());
            blob.TryGetValue("uri", out var blobUri);

            Parcel newParcel = new Parcel();
            newParcel.ParImage = blobUri.ToString();
            newParcel.Note = noteTB.Text;
            newParcel.CusID = int.Parse(cusTB.Text);
            newParcel.ParDescription = nameTB.Text;

            string jsonString = JsonConvert.SerializeObject(newParcel);
            var jsonContent = new StringContent(jsonString, Encoding.UTF8, "application/json");
            var postResponse = await client.PostAsync("https://testtestserver20230526163638.azurewebsites.net/api/Parcel", jsonContent);
            var responseString = await postResponse.Content.ReadAsStringAsync();
            MessageBox.Show(postResponse.StatusCode.ToString());
        }

        private void AdminCreateParcelView_Load(object sender, EventArgs e)
        {
            dateTB.Text = DateTime.Now.ToString();
            parcelSample.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
