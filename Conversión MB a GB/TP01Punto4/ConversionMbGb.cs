using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto4
{
    public partial class ConversionMBGB : Form
    {
        public ConversionMBGB()
        {
            InitializeComponent();
        }
        private void bconversion_Click(object sender, EventArgs e)
        {
            //Cálculo de conversipon de MB a GB
            double mb = Convert.ToDouble(tbtamaño.Text);
            double gb = mb / 1024;
            string valorreducido = gb.ToString("0.00"); 

            //Mensaje de valor en GB
            MessageBox.Show("El valor en GB del archivo de es de: " + valorreducido + " GB ");
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            //botón de cerrar
            Close();
        }
        private void ltamaño_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}
