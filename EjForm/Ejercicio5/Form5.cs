using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form5 : Form
    {

        Random numeroRandom;
        int miRandom;
        int intentos;
 
        public Form5()
        {
            InitializeComponent();
            numeroRandom = new Random();
            
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            miRandom = numeroRandom.Next(1,100);
            intentos = 0;
            txtIntentos.Text = "0";
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numeroIngresado = int.Parse(txtIngresarNumero.Text);


            if (numeroIngresado < miRandom)
            {
                MessageBox.Show("Falta!!!");
                intentos++;
                txtIntentos.Text = intentos.ToString();
            }
            else 
            {
                if (numeroIngresado > miRandom)
                {
                    MessageBox.Show("Se Paso!!!");
                    intentos++;
                    txtIntentos.Text = intentos.ToString();
                }
                else
                {
                    if (numeroIngresado == miRandom)
                    intentos++;
                    txtIntentos.Text = intentos.ToString();
                    //MessageBox.Show("Felicidades, ganó!!! Y en solo "+intentos+" intentos pedazo de Boludo!!!");
                    MessageBox.Show("Felicidades, ganaste!!! Y en solo " + intentos + " intentos!!!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Adivina el numero secreto (entre 1 y 100)");
        }


    }
}
