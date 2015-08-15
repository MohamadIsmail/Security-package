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
    public partial class Multiplicative_Inverse_form : Form
    {
        public Multiplicative_Inverse_form()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiplicative_Inverse obj = new Multiplicative_Inverse();
            int num=Convert.ToInt32( NumberTextBox.Text);
            int Base= Convert.ToInt32(BaseTextBox.Text);
            int res=obj.calculate_inverse(num, Base);
            ResTextBox.Text =Convert.ToString( res);
        }
    }
}
