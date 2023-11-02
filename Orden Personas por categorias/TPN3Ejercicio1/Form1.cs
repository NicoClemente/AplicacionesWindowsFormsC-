using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPN3Ejercicio1
{
    public partial class FCategoria : Form
    {
        public FCategoria()
        {
            InitializeComponent();
        }


        int contadorQuerubin = 0;
        int contadorBenjamin = 0;
        int contadorInfantil = 0;
        int contadorCadete = 0;
        int contadorJuvenil = 0;
        int contadorAmateur = 0;
        int contadorVeteranos = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            nudyear.Maximum = DateTime.Now.Year - 2;

        }

        private void bingreso_Click(object sender, EventArgs e)
        {
            string nombre = tbnombre.Text.Trim();
            string apellido = tbapellido.Text.Trim();

            int dia = Convert.ToInt16(nudday.Value);
            int mes = Convert.ToInt16(nudmonth.Value);
            int anio = Convert.ToInt16(nudyear.Value);
            int ultimodiames = 31;
            bool esbisiesto = (anio % 4 == 0 && anio % 100 == 0) && (anio % 400 == 0);

            string categoria = "";




            //Verificación para que Nombre y Apellido no aparezcan vacios

            if (tbnombre.Text == "")
            {
                MessageBox.Show("Completar el apartado de nombre");
                tbnombre.Focus();


            }

            else if (tbapellido.Text == "")
            {
                MessageBox.Show("Completar el apartado de apellido");
                tbapellido.Focus();



            }


            //Verificar Meses de 30 o 31 dias

            else if (nombre != "" && apellido != "")

            {
                switch (mes)
                {

                    case 2:
                        if (esbisiesto)
                        {
                            ultimodiames = 29;
                        }
                        else
                        {
                            ultimodiames = 28;
                        }
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:

                        ultimodiames = 30;
                        break;


                }
                if (dia > ultimodiames)
                {
                    MessageBox.Show("El dia ingresado es erroneo");
                }


                else
                {


                    //Verificar edad y categoria

                    int diaactual = DateTime.Today.Day;
                    int mesactual = DateTime.Today.Month;
                    int anioactual = DateTime.Today.Year;

                    int edad = anioactual - anio;
                    if ((mes > mesactual) || (mes == mesactual) && (dia > diaactual)){
                        edad--;
                    }

                    if (edad < 3)
                    {
                        MessageBox.Show("La edad de ingreso debe ser mayor a 3 años");
                        tbnombre.Text = "";
                        tbapellido.Text = "";
                        nudday.Value = 1;
                        nudmonth.Value = 1;
                        nudyear.Value = 2000;
                    }
                    else
                    {
                        if (edad <= 5)
                        {
                            contadorQuerubin = ++contadorQuerubin;
                            lQuerubinContadora.Text = Convert.ToString(contadorQuerubin);
                            categoria = "Querubín";
                        }


                        else if (edad <= 8)
                        {
                            contadorBenjamin = ++contadorBenjamin;
                            lBenjaminContadora.Text = Convert.ToString(contadorBenjamin);
                            categoria = "Benjamín";
                        }
                        else if (edad <= 12)
                        {
                            contadorInfantil = ++contadorInfantil;
                            lInfantilContadora.Text = Convert.ToString(contadorInfantil);
                            categoria = "Infantil";
                        }
                        else if (edad <= 15)
                        {
                            contadorCadete = ++contadorCadete;
                            lCadeteContadora.Text = Convert.ToString(contadorCadete);
                            categoria = "Cadete";

                        }
                        else if (edad <= 18)
                        {
                            contadorJuvenil = ++contadorJuvenil;
                            lJuvenilContadora.Text = Convert.ToString(contadorJuvenil);
                            categoria = "Juvenil";
                        }
                        else if (edad <= 30)
                        {
                            contadorAmateur = ++contadorAmateur;
                            lAmateurContadora.Text = Convert.ToString(contadorAmateur);
                            categoria = "Amateur";
                        }
                        else
                        {
                            contadorVeteranos = ++contadorVeteranos;
                            lVeteranosContadora.Text = Convert.ToString(contadorVeteranos);
                            categoria = "Veteranos";

                        }


                        string apellidomayus = (apellido.Substring(0, 1)).ToUpper() + apellido.Substring(1, apellido.Length - 1).ToLower();
                        string nombremayus = (nombre.Substring(0, 1)).ToUpper() + nombre.Substring(1, nombre.Length - 1).ToLower();

                        //Mensaje exitoso
                        MessageBox.Show($"Ingreso exitoso:\n" +
                                     $"{apellidomayus}, {nombremayus}\n" +
                                     $"Edad {edad} años\n" +
                                     $"Categoria {categoria}");


                        tbnombre.Text = "";
                        tbapellido.Text = "";
                        nudday.Value = 1;
                        nudmonth.Value = 1;
                        nudyear.Value = 2000;
                    }

                }
            }

            

            
        }
        
      
        private void bcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

   

        
    




