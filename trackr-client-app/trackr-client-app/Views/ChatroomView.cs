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
        }

        private void ChatroomView_Load(object sender, EventArgs e)
        {
           client = new ClientWebSocket();
        }

        public async Task InitalizeConnection()
        {
           /*Uri serviceUri = new Uri("wss://trackrwebserver.azurewebsites.net:80");
           cts = new CancellationTokenSource();
           cts.CancelAfter(TimeSpan.FromSeconds(120));
           client.Options.KeepAliveInterval = TimeSpan.FromSeconds(10);
           try
            {
               await client.ConnectAsync(serviceUri, cts.Token);
               if(client.State == WebSocketState.Open)
                {
                    MessageBox.Show("Kết nối thành công");
                }
            }
           catch (WebSocketException ex)
           {
             MessageBox.Show(ex.ToString());
           }*/
           TcpClient tcpclient = new TcpClient();
            await tcpclient.ConnectAsync("20.212.38.176", 80);
            if(tcpclient.Connected)
            {
                MessageBox.Show("ok kết nối" + tcpclient.Client.RemoteEndPoint.ToString());
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
            await InitalizeConnection();
        }
    }
}
