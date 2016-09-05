using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio8
{
    public partial class Form8 : Form
    {
        static private Random numeroRandom;
        static private int eleccionMaquina;
        private int contadorE = 0;
        private int contadorG = 0;
        private int contadorP = 0;

        public Form8()
        {
            InitializeComponent();
            txtEmpatados.Text = "0";
            txtGanados.Text = "0";
            txtPerdidos.Text = "0";
        }

        static Form8()
        {
            numeroRandom = new Random();
            eleccionMaquina = numeroRandom.Next(1, 4);
            MessageBox.Show(eleccionMaquina.ToString());
        }

        //Piedra = 1
        //Papel = 2
        //Tijera = 3

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            if (eleccionMaquina == 1)
            {
                MessageBox.Show("Empate");
                contadorE = contadorE + 1;
                txtEmpatados.Text = contadorE.ToString();
                eleccionMaquina = numeroRandom.Next(1, 4);
                MessageBox.Show(eleccionMaquina.ToString());
            }
            else
            {
                if (eleccionMaquina == 2)
                {
                    MessageBox.Show("Perdio");
                    contadorP = contadorP + 1;
                    txtPerdidos.Text = contadorP.ToString();
                    eleccionMaquina = numeroRandom.Next(1, 4);
                    MessageBox.Show(eleccionMaquina.ToString());
                }
                else
                {
                    if (eleccionMaquina == 3)
                    {
                        MessageBox.Show("Gano");
                        contadorG = contadorG + 1;
                        txtGanados.Text = contadorG.ToString();
                        eleccionMaquina = numeroRandom.Next(1, 4);
                        MessageBox.Show(eleccionMaquina.ToString());
                    }
                }


            }

            
        }



        private void btnPapel_Click(object sender, EventArgs e)
        {
            if (eleccionMaquina == 2)
            {
                MessageBox.Show("Empate");
                contadorE = contadorE + 1;
                txtEmpatados.Text = contadorE.ToString();
                eleccionMaquina = numeroRandom.Next(1, 4);
                MessageBox.Show(eleccionMaquina.ToString());
            }
            else
            {
                if (eleccionMaquina == 3)
                {
                    MessageBox.Show("Perdio");
                    contadorP = contadorP + 1;
                    txtPerdidos.Text = contadorP.ToString();
                    eleccionMaquina = numeroRandom.Next(1, 4);
                    MessageBox.Show(eleccionMaquina.ToString());
                }
                else
                {
                    if (eleccionMaquina == 1)
                    {
                        MessageBox.Show("Gano");
                        contadorG = contadorG + 1;
                        txtGanados.Text = contadorG.ToString();
                        eleccionMaquina = numeroRandom.Next(1, 4);
                        MessageBox.Show(eleccionMaquina.ToString());
                    }
                }


            }
        }



        private void btnTijera_Click(object sender, EventArgs e)
        {
            if (eleccionMaquina == 3)
            {
                MessageBox.Show("Empate");
                contadorE = contadorE + 1;
                txtEmpatados.Text = contadorE.ToString();
                eleccionMaquina = numeroRandom.Next(1, 4);
                MessageBox.Show(eleccionMaquina.ToString());
            }
            else
            {
                if (eleccionMaquina == 1)
                {
                    MessageBox.Show("Perdio");
                    contadorP = contadorP + 1;
                    txtPerdidos.Text = contadorP.ToString();
                    eleccionMaquina = numeroRandom.Next(1, 4);
                    MessageBox.Show(eleccionMaquina.ToString());
                }
                else
                {
                    if (eleccionMaquina == 2)
                    {
                        MessageBox.Show("Gano");
                        contadorG = contadorG + 1;
                        txtGanados.Text = contadorG.ToString();
                        eleccionMaquina = numeroRandom.Next(1, 4);
                        MessageBox.Show(eleccionMaquina.ToString());
                    }
                }


            }
        }



        private void btnRecargar_Click(object sender, EventArgs e)
        {
            contadorE = 0;
            contadorP = 0;
            contadorG = 0;

            txtEmpatados.Clear();
            txtGanados.Clear();
            txtPerdidos.Clear();

            eleccionMaquina = numeroRandom.Next(1, 4);
            MessageBox.Show(eleccionMaquina.ToString());
        }

        
    }
}
