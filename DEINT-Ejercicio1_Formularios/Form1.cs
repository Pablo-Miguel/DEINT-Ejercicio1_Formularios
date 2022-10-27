using DEINT_Ejercicio1_Formularios.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_Ejercicio1_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            txtresultado.Text = suma.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            txtresultado.Text = resta.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void btnmultiplica_Click(object sender, EventArgs e)
        {
            Multiplicar multiplica = new Multiplicar();
            txtresultado.Text = multiplica.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtv1.Clear();
            txtv2.Clear();
            txtresultado.Clear();
        }
    }
}
