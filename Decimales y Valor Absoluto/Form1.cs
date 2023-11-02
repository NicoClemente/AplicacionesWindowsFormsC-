using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1tp2
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tvalorabsoluto_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(tnumero.Text);
            double numeroredondeado = (numero % 1 < 0.5) ? (numero - numero % 1) : (numero - numero % 1) + 1;


            MessageBox.Show($" el valor es: {numeroredondeado}");
        }

        private void tdecimales_Click(object sender, EventArgs e)
        {

            double numero = Convert.ToDouble(tnumero.Text);
            double parteDecimal = numero - Math.Floor(numero); 

            if (parteDecimal >= 0.5)
            {
                numero = Math.Floor(numero) + 1; 
            }
            else
            {
                numero = Math.Floor(numero); 
            }

            MessageBox.Show($"El número redondeado es: {numero}");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
