using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_formulario_botones_3
{
    public partial class FColores : Form
    {
        int azul = 0;
        int rojo = 0;
        int amarillo = 0;
        public FColores()
        {
            InitializeComponent();
            BackColor = Color.White;
            
        }

        private void FColores_Load(object sender, EventArgs e)
        {

        }

        private void bamarillo_Click(object sender, EventArgs e)
        {
            switch (BackColor.Name)
            {
                case "Purple":
                    BackColor = Color.Black;
                    break;
                case "Red":
                    BackColor = Color.Orange;
                    break;
                case "Blue":
                    BackColor = Color.Green;
                    break;
                default:
                    BackColor = Color.Yellow;
                    break;
            }
            amarillo++;
            bcerrar.Visible = true;
        }

        private void brojo_Click(object sender, EventArgs e)
        {

            switch (BackColor.Name)
            {
                case "Green":
                    BackColor = Color.Black;
                    break;
                case "Yellow":
                    BackColor = Color.Orange;
                    break;
                case "Blue":
                    BackColor = Color.Purple;
                    break;
                default:
                    BackColor = Color.Red;
                    break;
            }
            rojo++;
            bcerrar.Visible = true;
        }

        private void bazul_Click(object sender, EventArgs e)
        {


            switch (BackColor.Name)
            {
                case "Orange":
                    BackColor = Color.Black;
                    break;
                case "Red":
                    BackColor = Color.Purple;
                    break;
                case "Yellow":
                    BackColor = Color.Green;
                    break;

                default:
                    BackColor = Color.Blue;
                    break;
            }
            azul++;
            bcerrar.Visible = true;
        }

        private void bcerrar_Click(object sender, EventArgs e)
        {
            string primero = "";
            string segundo = "";
            string tercero = "";

            if (amarillo >= rojo && amarillo >= azul)
            {
                primero = "1°. - Color “Amarillo”: " + amarillo + (amarillo == 1 ? " vez" : " veces");

                if (azul <= rojo)
                {
                    tercero = "3°. - Color “Azul”: " + azul + (azul == 1 ? " vez" : " veces");
                    segundo = "2°. - Color “Rojo”: " + rojo + (rojo == 1 ? " vez" : " veces");
                }
                else
                {
                    tercero = "3°. - Color “Rojo”: " + rojo + (rojo == 1 ? " vez" : " veces");
                    segundo = "2°. - Color “Azul”: " + azul + (azul == 1 ? " vez" : " veces");
                }
            }
            else if (rojo >= azul)
            {
                primero = "1°. - Color “Rojo”: " + rojo + (rojo == 1 ? " vez" : " veces");

                if (amarillo <= azul)
                {
                    tercero = "3°. - Color “Amarillo”: " + amarillo + (amarillo == 1 ? " vez" : " veces");
                    segundo = "2°. - Color “Azul”: " + azul + (azul == 1 ? " vez" : " veces");
                }
                else
                {
                    segundo = "2°. - Color “Amarillo”: " + amarillo + (amarillo == 1 ? " vez" : " veces");
                    tercero = "3°. - Color “Azul”: " + azul + (azul == 1 ? " vez" : " veces");
                }
            }
            else
            {
                primero = "1°. - Color “Azul”: " + azul + (azul == 1 ? " vez" : " veces");

                if (rojo <= amarillo)
                {
                    tercero = "3°. - Color “Rojo”: " + rojo + (rojo == 1 ? " vez" : " veces");
                    segundo = "2°. - Color “Amarillo”: " + amarillo + (amarillo == 1 ? " vez" : " veces");
                }
                else
                {
                    segundo = "2°. - Color “Rojo”: " + rojo + (rojo == 1 ? " vez" : " veces");
                    tercero = "3°. - Color “Amarillo”: " + amarillo + (amarillo == 1 ? " vez" : " veces");
                }
            }

            MessageBox.Show(primero + "\n" + segundo + "\n" + tercero);
            Close();
        }
            
        
    }
}
