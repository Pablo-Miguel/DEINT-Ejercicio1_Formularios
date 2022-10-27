using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_Ejercicio3_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            txtTablas.Text = "";

            for (int i = 0; i <= 10; i++) {
                txtTablas.Text += $"{txtNumero.Value} x {i} = {txtNumero.Value * i}\r\n";
            }
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            txtTablas.Text = "";

            for (int i = 10; i >= 0; i--)
            {
                txtTablas.Text += $"{txtNumero.Value} x {i} = {txtNumero.Value * i}\r\n";
            }
        }
    }
}
