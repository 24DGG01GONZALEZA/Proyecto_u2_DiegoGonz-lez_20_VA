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
    public partial class conversion2 : Form
    {
        public conversion2()
        {
            InitializeComponent();
        }

        private void conversion2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double galon))
                txtresul.Text = (galon * 3.785).ToString("N3") + "litros";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
