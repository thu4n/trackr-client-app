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

namespace trackr_client_app.Views
{
    public partial class AdminCreateParcelView : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        FileStream fs;
        public AdminCreateParcelView()
        {
            InitializeComponent();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            FileInfo fileInfo = new FileInfo(ofd.FileName);
            imgPathTB.Text = fileInfo.FullName;
        }

        private async void realUploadBtn_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:7111/api/Image");
            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(File.OpenRead("C:/Users/Admin/Downloads/lul.png")), "File", "lul.png");
            request.Content = content;
            var response = await client.SendAsync(request);
            string str = await response.Content.ReadAsStringAsync();
            MessageBox.Show(str);
        }
    }
}
