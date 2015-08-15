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

namespace HelloNetworks
{
    public partial class ServerFrm : Form
    {
        public Socket s;
        public Socket clientSock;
        RSA rsa;
        public ServerFrm()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1000);
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            s.Bind(ep);
            s.Listen(100); //To determine the maximum number of connections you can specify, retrieve the MaxConnections value. Listen does not block.
            tb_msg.Text="Waiting for a client to connect...";
            
           
            
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
           
          
            byte[] messageByteArray = Encoding.ASCII.GetBytes(tb_msg.Text);
            //Sockets deals with binary data only 
            //GetBytes function gets the binary representation of a string in ASCII format.

            clientSock.Send(messageByteArray);


            tb_msg.Text+="\r\nMessage has been sent.";
            
           


        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            ///////////Accept Connection/////////////////
            clientSock = s.Accept();
            tb_msg.Text += "\r\nClient Connected";
        }

        private void ServerFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientSock.Close();
        }

        private void RSA_button_Click(object sender, EventArgs e)
        {
            rsa = new RSA();
            Int64 p=Convert.ToInt64( PTextBox.Text);
            Int64 q=Convert.ToInt64( QTextBox.Text);
            Int64 txt = Convert.ToInt64(PTtextBox.Text);

            tb_msg.Text=Convert.ToString( rsa.encrypt(txt, p, q));
        }

        private void AES_button_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            tb_msg.Text= aes.encrypt(AESPTexBox.Text, KeyTextBox.Text);
        }

        private void MD5_button_Click(object sender, EventArgs e)
        {
            MD5 md5= new MD5();
            tb_msg.Text= md5.Calculate_MD5_Value(MD5Text.Text);
        }

       
    }
}
