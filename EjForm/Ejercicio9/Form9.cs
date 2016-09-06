using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Form9 : Form
    {
        static Random numeroRandom;
        private int primerNumero;
        private int segundoNumero;
        private int operador;
        private int resultado;
        

        public Form9()
        {
            InitializeComponent();

            primerNumero = numeroRandom.Next(1, 11);
            this.txtNum1.Text = primerNumero.ToString();
            segundoNumero = numeroRandom.Next(1, 11);
            this.txtNum2.Text = segundoNumero.ToString();
            operador = numeroRandom.Next(1, 5);

            switch (operador)
            {
                case 1: resultado = primerNumero + segundoNumero;
                    this.txtOperacion.Text = "+";
                    break;
                case 2: resultado = primerNumero - segundoNumero;
                    this.txtOperacion.Text = "-";
                    break;
                case 3: resultado = primerNumero * segundoNumero;
                    this.txtOperacion.Text = "*";
                    break;
                case 4: resultado = primerNumero / segundoNumero;
                    this.txtOperacion.Text = "/";
                    break;
            }
        }

        static Form9()
        {
            
            numeroRandom = new Random();
            

        }

        
        private void btnResultado_Click(object sender, EventArgs e)
        {


            if (resultado == int.Parse(this.txtResultado.Text))
            {
                MessageBox.Show("Es correcto");
            }
            else
            MessageBox.Show("Es incorrecto");
            
        }

        




    }
}
