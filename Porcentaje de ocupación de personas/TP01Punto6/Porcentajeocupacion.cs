using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto6
{
    public partial class Porcentajeocupacion : Form
    {
        public Porcentajeocupacion()
        {
            InitializeComponent();
        }

        private void porcentajeocupacion_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bporcentaje_Click(object sender, EventArgs e)
        {
            //Cálculo de porcentaje de ocupación
            int cupo = Convert.ToInt32(tbcupo.Text);
            int persona = Convert.ToInt32(tbpersonas.Text);
            int porcentaje = (persona * 100) / cupo;

            //Mensaje de porcentaje de ocupación
            MessageBox.Show($"El porcentaje de ocupación es de: {porcentaje} %");


        }

        private void bmas_Click(object sender, EventArgs e)
        {
            int cupo = Convert.ToInt32(tbcupo.Text);
            int persona = Convert.ToInt32(tbpersonas.Text);

            if (persona < cupo) // Verificar que no supere el máximo de cupo
            {
                tbpersonas.Text = Convert.ToString(++persona);
            }
            else
            {
                MessageBox.Show("El número de personas no puede superar el máximo de cupo.");
            }
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            int persona = Convert.ToInt32(tbpersonas.Text);

            if (persona > 0) // Verificar que no baje de 0
            {
                tbpersonas.Text = Convert.ToString(--persona);
            }
            else
            {
                MessageBox.Show("El número de personas no puede ser negativo.");
            }
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón de cerrar
            Close();
        }
    }
}