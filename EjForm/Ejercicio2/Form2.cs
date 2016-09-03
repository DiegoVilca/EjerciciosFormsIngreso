using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRectanguloAlambre_Click(object sender, EventArgs e)
        {
            double largo = double.Parse(this.txtLargoTerreno.Text);
            double ancho = double.Parse(this.txtAnchoTerreno.Text);
            double perimetro = (largo + ancho)*2;
            double cantidadAlambre = perimetro * 3;

            MessageBox.Show("La cantidad de alambre a comprar es: " + cantidadAlambre.ToString("N3"));

        }

        private void btbCirculoAlambre_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(this.txtRadioTerreno.Text);
            double circunferencia = 2 * Math.PI * radio;
            double cantidadAlambre = circunferencia * 3;

            MessageBox.Show("La cantidad de alambre a comprar es: " + cantidadAlambre.ToString("N3"));
        }

        private void btbMateriales_Click(object sender, EventArgs e)
        {
            double largo = double.Parse(this.txtLargoTerreno.Text);
            double ancho = double.Parse(this.txtAnchoTerreno.Text);
            double area = largo * ancho;

            MessageBox.Show("Se necesitaran "+ area * 2 + " bolsas de cemento y "+ area * 3+" bolsas de cal");
        }
    }
}
