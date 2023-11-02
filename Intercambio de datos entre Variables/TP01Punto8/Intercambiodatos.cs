using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto8
{
    public partial class Intercambiodatos : Form
    {
        public Intercambiodatos()
        {
            InitializeComponent();
        }
        private void bintercambio_Click(object sender, EventArgs e)
        { 
            //Cáñculo de intercambio de valores
            int ValorA = Convert.ToInt32(txtboxa.Text);
            int ValorB = Convert.ToInt32(txtboxb.Text);
            int Aux = ValorA; 
            ValorA = ValorB;
            ValorB = Aux; 
            
            //Resultado intercambio de valores
            MessageBox.Show($"El nuevo valor de A es: {ValorA} y el de B es {ValorB}");

        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón cerrar
            Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
