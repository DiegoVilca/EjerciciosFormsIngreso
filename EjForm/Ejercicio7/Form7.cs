using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7
{
    public partial class Form7 : Form
    {
        static private Random numeroRandom;
        static private int eleccionMaquina;
        public Form7()
        {
            InitializeComponent();
            
        }

        static Form7()
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
            if ( eleccionMaquina == 1)
                MessageBox.Show("Empate");
            if (eleccionMaquina == 2)
                MessageBox.Show("Perdio");
            if (eleccionMaquina == 3)
                MessageBox.Show("Gano");
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            if (eleccionMaquina == 2)
                MessageBox.Show("Empate");
            if (eleccionMaquina == 3)
                MessageBox.Show("Perdio");
            if (eleccionMaquina == 1)
                MessageBox.Show("Gano");
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            if (eleccionMaquina == 3)
                MessageBox.Show("Empate");
            if (eleccionMaquina == 1)
                MessageBox.Show("Perdio");
            if (eleccionMaquina == 2)
                MessageBox.Show("Gano");
        }
    }
}
