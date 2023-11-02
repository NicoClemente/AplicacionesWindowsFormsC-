using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto9
{
    public partial class Sumahorarios : Form
    {
        public Sumahorarios()
        {
            InitializeComponent();
        }

        private void bsumahorarios_Click(object sender, EventArgs e)
        { 
            //Valores ingresados
            int Horas1 = Convert.ToInt32(txtboxhoras1.Text);
            int Horas2 = Convert.ToInt32(txtboxhoras2.Text);
            int Minutos1 = Convert.ToInt32(txtboxminutos1.Text);
            int Minutos2 = Convert.ToInt32(txtboxminutos2.Text);
            int Segundos1 = Convert.ToInt32(txtboxsegundos1.Text);
            int Segundos2 = Convert.ToInt32(txtboxsegundos2.Text);

            //Cálculo suma de tiempos en segundos
            int Totalsegundos = Segundos1 + Segundos2 + (Minutos1 * 60) + (Minutos2 * 60) + (Horas1 * 3600) + (Horas2 * 3660);

            //
            int Horastotales = Totalsegundos / 3600;
            int Minutostotales = (Totalsegundos % 3600) % 60;
            int Segundostotales = (Totalsegundos % 3600) % 60;

            txtboxresultado.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", Horastotales, Minutostotales, Segundostotales);

        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lmin2_Click(object sender, EventArgs e)
        {

        }

        private void Sumahorarios_Load(object sender, EventArgs e)
        {

        }
    }
}
