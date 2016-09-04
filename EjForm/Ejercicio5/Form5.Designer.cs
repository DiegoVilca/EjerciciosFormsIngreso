namespace Ejercicio5
{
    partial class Form5
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
            this.txtIngresarNumero = new System.Windows.Forms.TextBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblIngreseNumero = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIngresarNumero
            // 
            this.txtIngresarNumero.Location = new System.Drawing.Point(80, 29);
            this.txtIngresarNumero.Name = "txtIngresarNumero";
            this.txtIngresarNumero.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarNumero.TabIndex = 0;
            // 
            // txtIntentos
            // 
            this.txtIntentos.Location = new System.Drawing.Point(80, 79);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(100, 20);
            this.txtIntentos.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(92, 149);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(92, 203);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 3;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblIngreseNumero
            // 
            this.lblIngreseNumero.AutoSize = true;
            this.lblIngreseNumero.Location = new System.Drawing.Point(89, 13);
            this.lblIngreseNumero.Name = "lblIngreseNumero";
            this.lblIngreseNumero.Size = new System.Drawing.Size(82, 13);
            this.lblIngreseNumero.TabIndex = 4;
            this.lblIngreseNumero.Text = "&Ingrese Numero";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(93, 63);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(45, 13);
            this.lblIntentos.TabIndex = 5;
            this.lblIntentos.Text = "&Intentos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblIngreseNumero);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.txtIngresarNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngresarNumero;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblIngreseNumero;
        private System.Windows.Forms.Label lblIntentos;
    }
}

