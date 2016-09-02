namespace Ejercicio1
{
    partial class Form1
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.txtPrecio3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(89, 203);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "&Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(88, 243);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "&Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(89, 284);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioFinal.TabIndex = 2;
            this.btnPrecioFinal.Text = "&Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(89, 35);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio1.TabIndex = 3;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(89, 87);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio2.TabIndex = 4;
            // 
            // txtPrecio3
            // 
            this.txtPrecio3.Location = new System.Drawing.Point(89, 136);
            this.txtPrecio3.Name = "txtPrecio3";
            this.txtPrecio3.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio Uno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio Dos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio Tres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio3);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnSuma);
            this.Name = "Form1";
            this.Text = "Ferrete Facturacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.TextBox txtPrecio3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

