using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace ServerApp
{
    public partial class btnOpen : Form
    {
        private TcpListener tcpListener;
        private Thread listenThread;
        private delegate void WriteMessageDelegate(string msg);
        private int connectedClients = 0;
        public btnOpen()
        {
            InitializeComponent();
            Server();
        }

        private void Server()
        {
            this.tcpListener = new TcpListener(IPAddress.Loopback, 8080);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();

            while (true)
            {
                TcpClient client = this.tcpListener.AcceptTcpClient();
                connectedClients++;
                lblNumberOfConnections.Text = connectedClients.ToString();

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }


        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }
                ASCIIEncoding encoder = new ASCIIEncoding();
                string msg = encoder.GetString(message, 0, bytesRead);
                WriteMessage(msg);
                Echo(msg, encoder, clientStream);
            }

            tcpClient.Close();
        }

        private void WriteMessage(string msg)
        {
            if (this.rtbServer.InvokeRequired)
            {
                WriteMessageDelegate d = new WriteMessageDelegate(WriteMessage);
                this.rtbServer.Invoke(d, new object[] { msg });
            }
            else
            {
                this.rtbServer.AppendText(msg + Environment.NewLine);
            }
        }

        private void Echo(string msg, ASCIIEncoding encoder, NetworkStream clientStream)
        {
            byte[] buffer = encoder.GetBytes(msg);

            clientStream.Write(buffer, 0, buffer.Length);
            clientStream.Flush();
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/CristianoToanHD");
        }

        private void btnGooglePlus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://plus.google.com/+ToànNguyễnVănIT");
        }

       
    }
}
