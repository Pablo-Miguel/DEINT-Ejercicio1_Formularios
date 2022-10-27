using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACDAT_Ejercicio2_Formulaios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int cont;

            cont = txtCadena.Text.Count(c => c.Equals(Char.Parse(cbCaracter.Text)));

            txtResultado.Text = $"Numero de veces que sale la vocal {cbCaracter.Text}: {cont}";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cont = 0;

            cont = txtCadena.Text.Count(c => c.Equals(Char.Parse(cbCaracter.Text)));

            txtResultado.Text = cont + "";
        }
    }
}
