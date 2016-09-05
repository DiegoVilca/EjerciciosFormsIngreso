using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form6 : Form
    {

        Random numeroRandom;
        int miRandom;
        int intentos;


        public Form6()
        {
            InitializeComponent();
            numeroRandom = new Random();
            
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            miRandom = numeroRandom.Next(1, 100);
            intentos = 0;
            txtIntentos.Text = "0";
            txtIngresarNumero.Clear();
            //MessageBox.Show(miRandom.ToString()); //Muestro el numero secreto
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
                    Aptitud(intentos);
                }
            }
        }//Fin btnVerificar

        private void Aptitud(int cantIntentos)
        { 
            if(cantIntentos == 1)
                MessageBox.Show("Usted es un Psiquico, ganó en 1 intento");
            if(cantIntentos == 2)
                MessageBox.Show("Excelente percepción, ganó en 2 intentos");
            if (cantIntentos == 3)
                MessageBox.Show("Esto es suerte, ganó en 3 intentos");
            if (cantIntentos == 4)
                MessageBox.Show("Excelente tecnica, ganó en 4 intentos");
            if (cantIntentos == 5)
                MessageBox.Show("Usted esta en la media, ganó en 5 intentos");
            if (cantIntentos >= 6  && cantIntentos <= 10)
                MessageBox.Show("Falta tecnica, ganó en "+txtIntentos.Text+" intentos");
            if (cantIntentos > 10)
                MessageBox.Show("Afortunado en el amor, ganó en "+txtIntentos.Text+" intentos");

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Adivina el numero secreto (entre 1 y 100)");
        }




    }
}
