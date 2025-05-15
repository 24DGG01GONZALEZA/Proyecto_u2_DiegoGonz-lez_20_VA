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
    public partial class conversion15 : Form
    {
        public conversion15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double galones))
                txtresul.Text = (galones * 128).ToString("N3") + " onzl";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
