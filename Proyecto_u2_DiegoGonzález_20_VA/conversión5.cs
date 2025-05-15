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
    public partial class conversión5 : Form
    {
        public conversión5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double pies3))
                txtresul.Text = (pies3 * 1728).ToString("N3") + "pulgadas";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
