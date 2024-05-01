using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void lblSuma_Click(object sender, EventArgs e)
        {
            Int32 a = 0;
            Int32 b = 0;
            Int32 suma = 0;

            a = Convert.ToInt32(txtNumeroUno.Text);
            b = Convert.ToInt32(txtNumeroDos.Text);

            suma = a + b;

            lblResultadoIgual.Text = Convert.ToString(suma);
        }

        private void lblResta_Click(object sender, EventArgs e)
        {
            Int32 a = 0;
            Int32 b = 0;
            Int32 resta = 0;

            a = Convert.ToInt32(txtNumeroUno.Text);
            b = Convert.ToInt32(txtNumeroDos.Text);

            resta = a - b;

            lblResultadoIgual.Text = Convert.ToString(resta);
        }

        private void lblMultiplicar_Click(object sender, EventArgs e)
        {
            Int32 a = 0;
            Int32 b = 0;
            Int32 multiplicar = 0;

            a = Convert.ToInt32(txtNumeroUno.Text);
            b = Convert.ToInt32(txtNumeroDos.Text);

            multiplicar = a * b;

            lblResultadoIgual.Text = Convert.ToString(multiplicar);
        }

        private void lblDividir_Click(object sender, EventArgs e)
        {
            Double a = 0;
            Double b = 0;
            Double dividir = 0;

            a = Convert.ToDouble(txtNumeroUno.Text);
            b = Convert.ToDouble(txtNumeroDos.Text);

            dividir = a / b;

            lblResultadoIgual.Text = Convert.ToString(dividir);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumeroUno.Text = "";
            txtNumeroDos.Text = "";
            lblResultadoIgual.Text = "";

        }
    }
}
