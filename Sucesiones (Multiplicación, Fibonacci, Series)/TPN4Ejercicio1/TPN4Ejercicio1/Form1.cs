using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN4Ejercicio1
{
    public partial class FSucesiones : Form
    {
        public FSucesiones()
        {
            InitializeComponent();
        }

        private void bTablaMultiplicar_Click(object sender, EventArgs e)
        {
            int tabla = Convert.ToInt16(nudTabla.Value);
            string salida = "Tabla del " + tabla.ToString() + "\n";
            for (int i = 0; i <= 10; i++)
            {
                int resultado = tabla * i;
                salida += tabla + " * " + i + " = " + resultado + "\n";
            }
            lrespuesta.Text = salida;
            nudTabla.Maximum = 99;
        }

        private void lrespuesta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea limpiar los resultados?", "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                lrespuesta.Text = "";
            }
        }

        private void bFibonacci_Click(object sender, EventArgs e)
        {
            
            int numero = Convert.ToInt16(nudFibonacci.Value);
            int a = 1;
            int b = 1;
            string salida = "Fibonacci de " + numero + ":\n" + a + "," + b;
            int i = 3;
            while (i <= numero)
            {
                int siguiente = a + b;
                salida += "," + siguiente;
                a = b;
                b = siguiente;
                i++;

                
            }
            lrespuesta.Text = salida;
        }

        private void bserie_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt16(nudDesde.Value);
            int hasta = Convert.ToInt16(nudHasta.Value);
            int cada = Convert.ToInt16(nudCada.Value);
            string salida = "Números desde " + desde + " hasta " + hasta + " con una diferencia de " + cada + ":\n";
            int i = desde;

            // Validar que el número desde sea menor al número hasta
            if (desde < hasta)
            {
                do
                {
                    salida += i + ", ";
                    i += cada;

                }
                while (i < hasta);

            }
             else           
                {
                    MessageBox.Show("El número desde debe ser menor al número hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            {

            }
            lrespuesta.Text = salida;
        }

        private void FSucesiones_KeyDown(object sender, KeyEventArgs e)
        {            
        
                if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }

    
    }

