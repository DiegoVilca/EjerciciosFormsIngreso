using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFahrenheitCelsius_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(this.txtTemperatura.Text);

            double temperaturaCelsius = (temperatura - 32) * 5 / 9;

            MessageBox.Show(temperatura+" grados Fahrenheit equivale a "+temperaturaCelsius.ToString("N2")+" grados Celsius");
        }

        private void btnCelsiusFahrenheit_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(this.txtTemperatura.Text);

            double temperaturaFahrenheit = (temperatura * 9 / 5) + 32;

            MessageBox.Show(temperatura + " grados Celsius equivale a " + temperaturaFahrenheit.ToString("N2") + " grados Fahrenheit");
        }
    }
}
