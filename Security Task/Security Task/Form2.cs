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
    public partial class vfr : Form
    {
        AutokeyVigenere auto;
        RepeatingKeyVigenere rp;
        Columnar col;
        RailFence rf;
        Ceaser csr;
        Monoalphabetic mono;
        PlayFair pf;
        int[] temp;
        public vfr()
        {
            InitializeComponent();
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Autokey_button_Click(object sender, EventArgs e)
        {
            auto = new AutokeyVigenere();
            EncResTextbox.Text= auto.encrypt(KeyTextBox.Text, PtTextBox.Text);
        }

        private void vfr_Load(object sender, EventArgs e)
        {

        }

        private void Rail_fence_button_Click(object sender, EventArgs e)
        {
            rf = new RailFence();
            EncResTextbox.Text= rf.encrypt(PtTextBox.Text, Convert.ToInt32(KeyTextBox.Text));
        }

        private void Columnar_button_Click(object sender, EventArgs e)
        {
            col = new Columnar();
            char[] delimiterChars = { ' ' };
            string[] words = KeyTextBox.Text.Split(delimiterChars);
            List<int> t = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                    t.Add(Convert.ToInt32(words[i]));
            }
            temp = t.ToArray();
            EncResTextbox.Text = col.encrypt(PtTextBox.Text, temp);
        }

        private void Playfair_button_Click(object sender, EventArgs e)
        {
            pf = new PlayFair();
            EncResTextbox.Text= pf.Encrypt(PtTextBox.Text, KeyTextBox.Text);
        }

        private void Repeating_key_button_Click(object sender, EventArgs e)
        {
            rp = new RepeatingKeyVigenere();
            EncResTextbox.Text= rp.encrypt(KeyTextBox.Text, PtTextBox.Text);
        }

        private void Ceaser_button_Click(object sender, EventArgs e)
        {
            csr = new Ceaser();
            EncResTextbox.Text= csr.Encrypt(PtTextBox.Text, KeyTextBox.Text);
        }

        private void ceaser_dec_button_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text = csr.Decrypt(EncResTextbox.Text, KeyTextBox.Text);
        }

        private void Monoalphabetic_button_Click(object sender, EventArgs e)
        {
            mono = new Monoalphabetic();
            EncResTextbox.Text= mono.Encrypt(PtTextBox.Text, KeyTextBox.Text);
        }

        private void AutokeyDecButton_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text= auto.decrypt(KeyTextBox.Text, EncResTextbox.Text);
        }

        private void RepeastingKeyButton_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text= rp.decrypt(KeyTextBox.Text, EncResTextbox.Text);
        }

        private void RailFenceDecButton_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text= rf.decrypt(EncResTextbox.Text, Convert.ToInt32(KeyTextBox.Text));
        }

        private void Columnar_Dec_button_Click(object sender, EventArgs e)
        {
           DecResTextBox.Text= col.decrypt(EncResTextbox.Text, temp);
        }

        private void Mono_dec_button_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text= mono.Decrypt(EncResTextbox.Text, KeyTextBox.Text);
        }

        private void PlayFair_dec_button_Click(object sender, EventArgs e)
        {
            DecResTextBox.Text = pf.Decrypt(EncResTextbox.Text, KeyTextBox.Text);
        }
    }
}
