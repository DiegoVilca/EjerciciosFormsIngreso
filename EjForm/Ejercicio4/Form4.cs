using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class ComboBox : Form
    {

        public double precio = 35;
        public double precioFinal;


        public ComboBox()
        {
            InitializeComponent();
            this.comboBox1.Items.Add("ArgentinaLuz");
            this.comboBox1.Items.Add("FelipeLamparas");
            this.comboBox1.Items.Add("JeLuz");
            this.comboBox1.Items.Add("HazIluminacion");
            this.comboBox1.Items.Add("Osram");
        }

        
        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            int cantidadLamparas = int.Parse(txtCantLamparas.Text);

            PrecioDescuento(cantidadLamparas);
        }


        /// <summary>
        /// Calcula el precio con descuento
        /// </summary>
        /// <param name="cantidad">cantidad de unidades</param>
        public void PrecioDescuento(int cantidad)
        {
                       
            if (cantidad>=6)
            {
                precioFinal = precio * cantidad * 0.5;

                Impuesto(precioFinal);

            }//Fin if(cantidad >= 6)


            if (cantidad == 5)
            {
                if (comboBox1.Text == "ArgentinaLuz")
                {
                    precioFinal = precio * cantidad * 0.6;

                    Impuesto(precioFinal);
                }
                else
                {
                    precioFinal = precio * cantidad * 0.7;

                    Impuesto(precioFinal);
                }
            }//Fin if(cantidad == 5)

            if (cantidad == 4)
            {
                if (comboBox1.Text == "ArgentinaLuz" || comboBox1.Text == "FelipeLamparas")
                {
                    precioFinal = precio * cantidad * 0.75;

                    Impuesto(precioFinal);
                }
                else
                {
                    precioFinal = precio * cantidad * 0.8;

                    Impuesto(precioFinal);
                }
            }//Fin if(cantidad == 4)

            if (cantidad == 3)
            {
                if (comboBox1.Text == "ArgentinaLuz")
                {
                    precioFinal = precio * cantidad * 0.85;

                    Impuesto(precioFinal);
                }
                else 
                {
                    if (comboBox1.Text == "FelipeLamparas")
                    {
                        precioFinal = precio * cantidad * 0.9;

                        Impuesto(precioFinal);
                    }
                    else
                    {
                        precioFinal = precio * cantidad * 0.95;

                        Impuesto(precioFinal);
                    }
                }
            }//Fin if(cantidad == 3)

            if (cantidad == 2 || cantidad == 1)
            {
                precioFinal = precio * cantidad;

                Impuesto(precioFinal);
            }//Fin if(cantidad == 2 || cantidad == 1)
        
        }



        public void Impuesto (double precioFinal)
        {
            if (precioFinal>120)
            {
                double impuesto = precioFinal * 0.1;
                double precioImpuesto = precioFinal * 1.1;
                txtPrecioDescuento.Text = precioImpuesto.ToString("N3");

                MessageBox.Show("IIBB Usted pago $"+precioImpuesto);
            }
            else
                txtPrecioDescuento.Text = precioFinal.ToString("N2"); 
        }
    }
}
