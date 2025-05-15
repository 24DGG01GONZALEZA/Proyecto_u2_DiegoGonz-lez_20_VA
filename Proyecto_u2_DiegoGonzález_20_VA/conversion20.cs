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
    public partial class conversion20 : Form
    {
        public conversion20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double ml))
                txtresul.Text = (ml / 16.387).ToString("N3") + " pulgadas cubicas";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
