using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Batiskaf
{
    public partial class Server : UserControl
    {
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            try
            {
                IPAddress localAddress = IPAddress.Any;
                Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndpoint = new IPEndPoint(localAddress, 5557);
                listenSocket.Bind(ipEndpoint);
                listenSocket.BeginAccept(new AsyncCallback(ReceiveCallback), listenSocket);
                MessageBox.Show("Ожидание соединения…" + "listenSocket.LocalEndPoint");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void ReceiveCallback(IAsyncResult AsyncCall)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] message = new Byte[4096];

            Socket listener = (Socket)AsyncCall.AsyncState;
            Socket client = listener.EndAccept(AsyncCall);

            MessageBox.Show("Принято соединение от: {0}" + client.RemoteEndPoint);
            client.Send(encoding.GetBytes("Hello...\r\n"));

            client.Receive(message);
            string msg = encoding.GetString(message).Trim(new char[] { ' ', '\0' });
            MessageBox.Show(msg);
            client.Send(message);


            MessageBox.Show("Закрытие соединения");
            client.Close();

            // После того как завершили соединение, говорим ОС что мы готовы принять новое
            listener.BeginAccept(new AsyncCallback(ReceiveCallback), listener);
        }
    }
}
