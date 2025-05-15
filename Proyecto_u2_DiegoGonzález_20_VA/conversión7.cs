using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_u2_DiegoGonzález_20_VA
{
    public partial class conversión7 : Form
    {
        public conversión7()
        {
            InitializeComponent();
        }

        private void conversión7_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double cm3))
                txtresul.Text = (cm3 / 1000000).ToString("N3") + "m3";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
