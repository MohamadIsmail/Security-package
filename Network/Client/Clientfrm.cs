using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Clientfrm : Form
    {
        Socket clientSock;
        public Clientfrm()
        {
            InitializeComponent();
        }
        RSA rsa;
        private void Clientfrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            IPAddress host = IPAddress.Parse("127.0.0.1");
            //192.168.1.1 refers to the server
            //Put down the IP of the computer next to you.
            //Or 127.0.0.1 if you’ll run both client and server on your machine
            IPEndPoint hostEndpoint = new IPEndPoint(host, 1000);
            //8000 is the port number and must match that of the server.

            clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            clientSock.Connect(hostEndpoint);
            tb_clientmsg.Text = "Connected....\r\nReceiving....";
            

        }

        private void btn_Recieve_Click(object sender, EventArgs e)
        {
            /////////Receiving////////////
            byte[] clientData = new byte[1024];
            //Prepare the byte array which will be filled with the message sent by the server.
            int receivedBytesLen = clientSock.Receive(clientData);
            //Receive will block (i.e.wait forever) until the server sends data
            string message = Encoding.ASCII.GetString(clientData);
            //Parse the string out of the byte array.
            tb_clientmsg.Text += "\r\nServer says:\r\n" + message;
            

        }

        private void Clientfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientSock.Close();
        }

        private void RSA_button_Click(object sender, EventArgs e)
        {
            rsa = new RSA();
            Int64 p=Convert.ToInt64( PTextBox.Text);
            Int64 q=Convert.ToInt64( QTextBox.Text);
            Int64 txt = Convert.ToInt64(tb_clientmsg.Text);

            PTtextBox.Text=Convert.ToString( rsa.decrypt(txt, p, q));

        }

        private void AES_button_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
             AESPTextBox.Text = aes.decrypt(tb_clientmsg.Text, KeyTextBox.Text);
        }
    }
}
