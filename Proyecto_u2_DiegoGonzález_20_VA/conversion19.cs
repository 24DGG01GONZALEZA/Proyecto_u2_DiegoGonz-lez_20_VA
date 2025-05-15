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
    public partial class conversion19 : Form
    {
        public conversion19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double ml))
                txtresul.Text = (ml / 236.588).ToString("N3") + " tazas";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
