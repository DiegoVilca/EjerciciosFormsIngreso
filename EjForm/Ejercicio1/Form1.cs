using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3;

            MessageBox.Show(suma.ToString());
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3;
            double promedio = (double)suma / 3;

            MessageBox.Show(promedio.ToString());
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.txtPrecio1.Text);
            int num2 = int.Parse(this.txtPrecio2.Text);
            int num3 = int.Parse(this.txtPrecio3.Text);

            int suma = num1 + num2 + num3;
            double precioFinal = suma * 1.21;

            MessageBox.Show(precioFinal.ToString());
        }
    }
}
