using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto5
{
    public partial class Fcalculodevuelto : Form
    {
        public Fcalculodevuelto()
        {
            InitializeComponent();
        }
        private void bvuelto_Click(object sender, EventArgs e)
        {
            //Cálculo de vuelto de compra
            string nombrecliente = Convert.ToString(tbcliente.Text);
            double valor = Convert.ToDouble(tbvalor.Text);
            double pago = Convert.ToDouble(tbpago.Text);

            double vuelto = pago - valor;

            //Mensaje de vuelto
            MessageBox.Show($"el vuelto para {nombrecliente} es de ${vuelto}");

        }
        private void bcerrar_Click(object sender, EventArgs e)
        {
            //Botón de cerrar
            Close();
        }
        
       
    }
}
