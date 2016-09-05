namespace Ejercicio6
{
    partial class Form6
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
            this.lblIngreseNumero = new System.Windows.Forms.Label();
            this.txtIngresarNumero = new System.Windows.Forms.TextBox();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngreseNumero
            // 
            this.lblIngreseNumero.AutoSize = true;
            this.lblIngreseNumero.Location = new System.Drawing.Point(89, 39);
            this.lblIngreseNumero.Name = "lblIngreseNumero";
            this.lblIngreseNumero.Size = new System.Drawing.Size(82, 13);
            this.lblIngreseNumero.TabIndex = 5;
            this.lblIngreseNumero.Text = "&Ingrese Numero";
            // 
            // txtIngresarNumero
            // 
            this.txtIngresarNumero.Location = new System.Drawing.Point(81, 55);
            this.txtIngresarNumero.Name = "txtIngresarNumero";
            this.txtIngresarNumero.Size = new System.Drawing.Size(100, 20);
            this.txtIngresarNumero.TabIndex = 6;
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(107, 104);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(45, 13);
            this.lblIntentos.TabIndex = 7;
            this.lblIntentos.Text = "&Intentos";
            // 
            // txtIntentos
            // 
            this.txtIntentos.Location = new System.Drawing.Point(81, 120);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.Size = new System.Drawing.Size(100, 20);
            this.txtIntentos.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(92, 197);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(92, 251);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 10;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIngreseNumero);
            this.groupBox1.Controls.Add(this.btnComenzar);
            this.groupBox1.Controls.Add(this.txtIngresarNumero);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.lblIntentos);
            this.groupBox1.Controls.Add(this.txtIntentos);
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 329);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 365);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseNumero;
        private System.Windows.Forms.TextBox txtIngresarNumero;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

