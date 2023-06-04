using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Threading;
using System.Net.Sockets;

namespace trackr_client_app.Views
{
    public partial class ChatroomView : Form
    {
        ClientWebSocket client;
        CancellationTokenSource cts;
        public ChatroomView()
        {
            InitializeComponent();
            chatBox.Text = "";
        }

        private async void ChatroomView_Load(object sender, EventArgs e)
        {
           client = new ClientWebSocket();
            await InitalizeConnection();
        }

        public async Task InitalizeConnection()
        {
           Uri serviceUri = new Uri("wss://trackr.webpubsub.azure.com/client/hubs/Hub?access_token=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJhdWQiOiJ3c3M6Ly90cmFja3Iud2VicHVic3ViLmF6dXJlLmNvbS9jbGllbnQvaHVicy9IdWIiLCJpYXQiOjE2ODU4NjA1NjAsImV4cCI6MTY4NTg2NDE2MH0.zSBGGEVeMBQdLeOihvT9m_FKhr0NWMkg70bTcKRhOm4");
           cts = new CancellationTokenSource();
           cts.CancelAfter(TimeSpan.FromSeconds(120));
           client.Options.KeepAliveInterval = TimeSpan.FromSeconds(10);
           try
            {
               await client.ConnectAsync(serviceUri, cts.Token);
               if(client.State == WebSocketState.Open)
                {
                    chatBox.Text += "Bạn đã tham gia vào cuộc trò chuyện\n";
                }
            }
           catch (WebSocketException ex)
           {
             MessageBox.Show(ex.ToString());
           }
           
        }

        public async Task SendMsg()
        {
            if(typeTB.Text.Length > 0)
            {
                string msg = typeTB.Text;
                ArraySegment<byte> msgSegments = new ArraySegment<byte>(Encoding.Unicode.GetBytes(msg));
                await client.SendAsync(msgSegments, WebSocketMessageType.Text, true, cts.Token).ConfigureAwait(false);
            }
        }

        private async Task RecvMsg(byte[] buffer)
        {
            while (true)
            {
                try
                {
                    var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None).ConfigureAwait(false);
                    var message = Encoding.Unicode.GetString(buffer, 0, result.Count);
                    if (result.EndOfMessage) break;
                }
                catch 
                {

                }

            }
        }

        private async void sendBtn_Click(object sender, EventArgs e)
        {
            //await InitalizeConnection();
        }
    }
}
