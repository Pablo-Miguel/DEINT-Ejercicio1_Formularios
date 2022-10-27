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
            if (txtCadena.Text.Equals(""))
            {
                MessageBox.Show("Campo vacío");
            }
            else if (!txtCadena.Text.Contains(cbCaracter.Text))
            {
                MessageBox.Show("La cadena no contiene el caracter");
            }
            else
            {
                int cont;

                cont = txtCadena.Text.Count(c => c.Equals(Char.Parse(cbCaracter.Text)));

                txtResultado.Text = $"Numero de veces que sale la vocal {cbCaracter.Text}: {cont}";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCadena.Text.Equals(""))
            {
                MessageBox.Show("Campo vacío");
            }
            else if (!txtCadena.Text.Contains(cbCaracter.Text))
            {
                MessageBox.Show("La cadena no contiene el caracter");
            }
            else 
            {
                txtResultado.Text = txtCadena.Text.Replace(cbCaracter.Text, "");
            }

        }
    }
}
