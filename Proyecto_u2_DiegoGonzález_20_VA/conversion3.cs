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
    public partial class conversion3 : Form
    {
        public conversion3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double litros))
                txtresul.Text = (litros * 1000).ToString("N3") + "galones";
            else
                MessageBox.Show("Ingrese un número válido.");
        }

        private void conversion3_Load(object sender, EventArgs e)
        {

        }
    }
}
