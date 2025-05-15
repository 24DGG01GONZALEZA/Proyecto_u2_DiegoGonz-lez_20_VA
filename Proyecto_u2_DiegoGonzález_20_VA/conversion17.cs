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
    public partial class conversion17 : Form
    {
        public conversion17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double cucharadas))
                txtresul.Text = (cucharadas / 67.63).ToString("N3") + " litros";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
