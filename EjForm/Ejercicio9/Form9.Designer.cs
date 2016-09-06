namespace Ejercicio9
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRespuesta);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.lblOperacion);
            this.groupBox1.Controls.Add(this.lblNum1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtOperacion);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(85, 39);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(157, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(85, 80);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(157, 20);
            this.txtOperacion.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(85, 123);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(157, 20);
            this.txtNum2.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(85, 174);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(157, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(97, 428);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(157, 23);
            this.btnResultado.TabIndex = 5;
            this.btnResultado.Text = "Aceptar";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(85, 20);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(76, 13);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "Primer Numero";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(85, 61);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(56, 13);
            this.lblOperacion.TabIndex = 6;
            this.lblOperacion.Text = "Operacion";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(85, 104);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Segundo Numero";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(85, 155);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(74, 13);
            this.lblRespuesta.TabIndex = 8;
            this.lblRespuesta.Text = "Su Respuesta";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 485);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblRespuesta;
    }
}

