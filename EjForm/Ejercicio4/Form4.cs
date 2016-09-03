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
    public partial class Form4 : Form
    {
        public Form4()
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
            
            
        }
    }
}
