using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01Punto10
{
    public partial class Salarioempleado : Form
    {
        public Salarioempleado()
        {
            InitializeComponent();
        }

        private void bcalculosalario_Click(object sender, EventArgs e)
        {
            //Datos
            string Nombreempleado = txtboxnombre.Text;
            int Fechaingreso = dtcalendario.Value.Year;
            double Tarifahoraria = double.Parse(txtboxtarifa.Text); 
            double Horasdia = double.Parse(txtboxhorasdia.Text);
            int Diaspormes = int.Parse(txtboxdiasmes.Text);

            //Cálculo salario bruto
            double Salariobruto = Tarifahoraria * Horasdia * Diaspormes;

            //Cálculo años antiguedad
            int Antiguedad = DateTime.Now.Year - Fechaingreso;

            //Cálculo retenciones
            double Retenciones = Salariobruto * 0.2; //20% de retenciones sobre salario bruto

            //Cálculo antiguedad
            double Totalantiguedad = Salariobruto * 0.015 * Antiguedad; //1,5% sobre salario bruto * años de antiguedad

            //Cálculo salario neto
            double Salarioneto = Salariobruto + Totalantiguedad - Retenciones;

            //Resultado
            MessageBox.Show($"El salario de {Nombreempleado} es de: ${Salarioneto}");

        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
