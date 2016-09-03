namespace Ejercicio3
{
    partial class Form3
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.btnFahrenheitCelsius = new System.Windows.Forms.Button();
            this.btnCelsiusFahrenheit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(76, 65);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(129, 20);
            this.txtTemperatura.TabIndex = 1;
            // 
            // btnFahrenheitCelsius
            // 
            this.btnFahrenheitCelsius.Location = new System.Drawing.Point(76, 141);
            this.btnFahrenheitCelsius.Name = "btnFahrenheitCelsius";
            this.btnFahrenheitCelsius.Size = new System.Drawing.Size(129, 23);
            this.btnFahrenheitCelsius.TabIndex = 2;
            this.btnFahrenheitCelsius.Text = "De Fahrenheit a Celsius";
            this.btnFahrenheitCelsius.UseVisualStyleBackColor = true;
            this.btnFahrenheitCelsius.Click += new System.EventHandler(this.btnFahrenheitCelsius_Click);
            // 
            // btnCelsiusFahrenheit
            // 
            this.btnCelsiusFahrenheit.Location = new System.Drawing.Point(76, 186);
            this.btnCelsiusFahrenheit.Name = "btnCelsiusFahrenheit";
            this.btnCelsiusFahrenheit.Size = new System.Drawing.Size(129, 23);
            this.btnCelsiusFahrenheit.TabIndex = 3;
            this.btnCelsiusFahrenheit.Text = "De Celsius a Fahrenheit";
            this.btnCelsiusFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelsiusFahrenheit.Click += new System.EventHandler(this.btnCelsiusFahrenheit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCelsiusFahrenheit);
            this.Controls.Add(this.btnFahrenheitCelsius);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Button btnFahrenheitCelsius;
        private System.Windows.Forms.Button btnCelsiusFahrenheit;
    }
}

