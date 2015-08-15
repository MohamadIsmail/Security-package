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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hill_cipher_Click(object sender, EventArgs e)
        {
            Hill_cipher_form hcf = new Hill_cipher_form();
            hcf.BringToFront();
            hcf.Show();
        }

        

        private void Multi_inverse_button_Click(object sender, EventArgs e)
        {
            Multiplicative_Inverse_form mif= new Multiplicative_Inverse_form();
            mif.BringToFront();
            mif.Show();
        }

        

        private void Others_Click(object sender, EventArgs e)
        {
            vfr f2 = new vfr();
            f2.BringToFront();
            f2.Show();
        }

        private void Mult_inverse_Click(object sender, EventArgs e)
        {
            Multiplicative_Inverse_form minf = new Multiplicative_Inverse_form();
            minf.BringToFront();
            minf.Show();
        }



    }
}
