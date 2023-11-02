using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movedizo
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();
        }

        private void FMovedizo_Load(object sender, EventArgs e)
        {
            
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Verde":
                case "Gris":

                    Text = "Rojo";
                    BackColor = Color.Red;
                    Left += 10;
                    Top += 10;
                    Width -= 15;
                    Height += 10;



                    break;

                case "Rojo":

                    Text = "Azul";
                    BackColor = Color.Blue;
                    Left -= 15;
                    Width += 20;
                    Height += 5;
                    break;
                case "Azul":
                    Text = "Verde";
                    BackColor = Color.Green;
                    Left -= 5;
                    Top -= 15;
                    Width -= 5;
                    Height -= 15;
                    break;
            }
        }
    }
}
