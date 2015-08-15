using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Task
{
    public partial class Hill_cipher_form : Form
    {
        public Hill_cipher_form()
        {
            InitializeComponent();
        }
        Hill_cipher obj;
        int[,] layers;
        private void Hill_cipher_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            obj = new Hill_cipher();
            int dim = Convert.ToInt32(textBox4.Text);
            int[,] key = new int[dim, dim];
            char[] delimiterChars = { ' ' };
            string[] words = KeytextBox.Text.Split(delimiterChars);
            List<int> layersList = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                    layersList.Add(Convert.ToInt32(words[i]));
            }

            layers = new int[dim, dim];
            int cnt = 0;
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    layers[i, j] = layersList[cnt++];
                }
            }
            EncResultTextBox.Text = obj.encrypt(PlaintextBox.Text, layers);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text = obj.decrypt(EncResultTextBox.Text, layers);
        }
    }
}
