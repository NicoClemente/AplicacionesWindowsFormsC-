using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto7
{
    public partial class Sumadigitos : Form
    {
        public Sumadigitos()
        {
            InitializeComponent();
        }

        private void bsumacifras_Click(object sender, EventArgs e)
        {
            //Cálculo de suma de dígitos de número entero
            int Numero = Convert.ToInt32(txtboxcifra.Text);
            int Sumadigitos = (Numero / 10 + Numero % 10);
            
            //Resultado de suma de dígitos de numero entero
            MessageBox.Show($"La suma de los dígitos de {Numero} da un total de {Sumadigitos}");
        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón cerrar
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxcifra_TextChanged(object sender, EventArgs e)
        {

        }

        private void lcifra_Click(object sender, EventArgs e)
        {

        }

        private void Sumadigitos_Load(object sender, EventArgs e)
        {

        }

       
    }
}
