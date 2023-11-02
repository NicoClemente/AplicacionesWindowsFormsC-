using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Etiqueta
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, +14);      //tamaño inicial de la etiqueta en 14
        }

        private void tTexto_TextChanged(object sender, EventArgs e)
        {
            string texto = tTexto.Text;       //asigno la textbox a un string "texto"
            lEtiqueta.Text = texto;
        }

        private void NUDLetra_ValueChanged(object sender, EventArgs e)
        {
            {
               float tamaño_inicial = lFuente.Font.Size;

                switch (NUDLetra.Value)             //Cada vez que pasa por un NumericUpDown se aplica un case relacionado al numero 
                {
                    case 1:
                        lFuente.Name = "Microsoft Sans Serif";
                        lFuente.Text = "Microsoft Sans Serif";                    //Cambia la fuente a "Microsoft Sans Serif"
                        lFuente.Font = new Font(lFuente.Name, tamaño_inicial);
                        lEtiqueta.Font = lFuente.Font = new Font(lFuente.Name, tamaño_inicial);
                        break;
                    case 2:
                        lFuente.Name = "Ink Free";
                        lFuente.Text = "Ink Free"; 
                        lFuente.Font = new Font(lFuente.Name, tamaño_inicial);    //Cambia la fuente a "Ink Free"
                        lEtiqueta.Font = lFuente.Font = new Font(lFuente.Name, tamaño_inicial);
                        break;
                    case 3:
                        lFuente.Name = "MV Boli";
                        lFuente.Text = "MV Boli";       
                        lFuente.Font = new Font(lFuente.Name, lFuente.Font.Size);               //Cambia la fuente a "MV Boli"
                        lEtiqueta.Font = lFuente.Font = new Font(lFuente.Name, tamaño_inicial);
                        break;
                    case 4:
                        lFuente.Name = "Palatino Linotype";
                        lFuente.Text = "Palatino Linotype"; 
                        lFuente.Font = new Font(lFuente.Name, lFuente.Font.Size);               //Cambia la fuente a "Palatino Linotype"
                        lEtiqueta.Font = lFuente.Font = new Font(lFuente.Name, tamaño_inicial);
                        break;
                    default:
                        break;
                }

            }
        }

        private void bCambioDeColor_Click(object sender, EventArgs e)
        {
            {   // Se aplican los cambios de colores en el caso de que haya un color anteriormente
                if (lEtiqueta.ForeColor == Color.Black)            
                {
                    lEtiqueta.ForeColor = Color.Red;
                }
                else if (lEtiqueta.ForeColor == Color.Red)
                {
                    lEtiqueta.ForeColor = Color.Blue;
                }
                else if (lEtiqueta.ForeColor == Color.Blue)
                {
                    lEtiqueta.ForeColor = Color.Green;
                }
                else if (lEtiqueta.ForeColor == Color.Green)
                {
                    lEtiqueta.ForeColor = Color.Purple;
                }
                else
                    lEtiqueta.ForeColor = Color.Black;
            }

        }

        private void bDisminuirTamaño_Click(object sender, EventArgs e)
        { //Al clickear la etiqueta disminuye y si llega a ser 10  salta un MB.Show y se desactiva el boton para seguir disminuyendo

            lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size - 2);
            if (lEtiqueta.Font.Size == 10)
            {
                bDisminuirTamaño.Enabled = false;
                MessageBox.Show("Llegaste al limite de tamaño");
            }
            else if (lEtiqueta.Font.Size == 18)
            {
                bAumentarTamaño.Enabled = true;

            }

        }

        private void bAumentarTamaño_Click(object sender, EventArgs e)
         
        {
            //Al clickear la etiqueta aumenta y si llega a ser 20  salta un MB.Show y se desactiva el boton para seguir aumentando
            lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size + 2);
            bDisminuirTamaño.Enabled = true;

            if (lEtiqueta.Font.Size == 20)
            {
                bAumentarTamaño.Enabled = false;
                MessageBox.Show("Llegaste al limite de tamaño");

            }
             if (lEtiqueta.Font.Size == 12)
                {
                bDisminuirTamaño.Enabled = true;
               
            }         

        }

        private void bCerrar_Click(object sender, EventArgs e)
        { //boton cerrar
            Close();
        }

        private void bCerrar_KeyDown(object sender, KeyEventArgs e)
        { //boton cerrar con escape
            bCerrar.Visible = true;
            
        }

        private void bCerrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}