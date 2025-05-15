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
    public partial class conversion13 : Form
    {
        public conversion13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtvalor.Text, out double onzl))
                txtresul.Text = (onzl * 29.5735).ToString("N3") + " ml";
            else
                MessageBox.Show("Ingrese un número válido.");
        }
    }
}
