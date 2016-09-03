namespace Ejercicio2
{
    partial class Form2
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
            this.txtLargoTerreno = new System.Windows.Forms.TextBox();
            this.txtAnchoTerreno = new System.Windows.Forms.TextBox();
            this.txtRadioTerreno = new System.Windows.Forms.TextBox();
            this.btnRectanguloAlambre = new System.Windows.Forms.Button();
            this.btbCirculoAlambre = new System.Windows.Forms.Button();
            this.btbMateriales = new System.Windows.Forms.Button();
            this.lblLargoTerreno = new System.Windows.Forms.Label();
            this.lblAnchoTerreno = new System.Windows.Forms.Label();
            this.lblRadioTerreno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLargoTerreno
            // 
            this.txtLargoTerreno.Location = new System.Drawing.Point(115, 50);
            this.txtLargoTerreno.Name = "txtLargoTerreno";
            this.txtLargoTerreno.Size = new System.Drawing.Size(100, 20);
            this.txtLargoTerreno.TabIndex = 0;
            // 
            // txtAnchoTerreno
            // 
            this.txtAnchoTerreno.Location = new System.Drawing.Point(115, 100);
            this.txtAnchoTerreno.Name = "txtAnchoTerreno";
            this.txtAnchoTerreno.Size = new System.Drawing.Size(100, 20);
            this.txtAnchoTerreno.TabIndex = 1;
            // 
            // txtRadioTerreno
            // 
            this.txtRadioTerreno.Location = new System.Drawing.Point(115, 151);
            this.txtRadioTerreno.Name = "txtRadioTerreno";
            this.txtRadioTerreno.Size = new System.Drawing.Size(100, 20);
            this.txtRadioTerreno.TabIndex = 2;
            // 
            // btnRectanguloAlambre
            // 
            this.btnRectanguloAlambre.Location = new System.Drawing.Point(84, 215);
            this.btnRectanguloAlambre.Name = "btnRectanguloAlambre";
            this.btnRectanguloAlambre.Size = new System.Drawing.Size(160, 23);
            this.btnRectanguloAlambre.TabIndex = 3;
            this.btnRectanguloAlambre.Text = "&Rectangulo de alambre";
            this.btnRectanguloAlambre.UseVisualStyleBackColor = true;
            this.btnRectanguloAlambre.Click += new System.EventHandler(this.btnRectanguloAlambre_Click);
            // 
            // btbCirculoAlambre
            // 
            this.btbCirculoAlambre.Location = new System.Drawing.Point(84, 244);
            this.btbCirculoAlambre.Name = "btbCirculoAlambre";
            this.btbCirculoAlambre.Size = new System.Drawing.Size(160, 23);
            this.btbCirculoAlambre.TabIndex = 4;
            this.btbCirculoAlambre.Text = "&Circulo de alambre";
            this.btbCirculoAlambre.UseVisualStyleBackColor = true;
            this.btbCirculoAlambre.Click += new System.EventHandler(this.btbCirculoAlambre_Click);
            // 
            // btbMateriales
            // 
            this.btbMateriales.Location = new System.Drawing.Point(84, 273);
            this.btbMateriales.Name = "btbMateriales";
            this.btbMateriales.Size = new System.Drawing.Size(160, 23);
            this.btbMateriales.TabIndex = 5;
            this.btbMateriales.Text = "Materiales Contrapiso";
            this.btbMateriales.UseVisualStyleBackColor = true;
            this.btbMateriales.Click += new System.EventHandler(this.btbMateriales_Click);
            // 
            // lblLargoTerreno
            // 
            this.lblLargoTerreno.AutoSize = true;
            this.lblLargoTerreno.Location = new System.Drawing.Point(116, 34);
            this.lblLargoTerreno.Name = "lblLargoTerreno";
            this.lblLargoTerreno.Size = new System.Drawing.Size(87, 13);
            this.lblLargoTerreno.TabIndex = 6;
            this.lblLargoTerreno.Text = "&Largo del terreno";
            // 
            // lblAnchoTerreno
            // 
            this.lblAnchoTerreno.AutoSize = true;
            this.lblAnchoTerreno.Location = new System.Drawing.Point(112, 84);
            this.lblAnchoTerreno.Name = "lblAnchoTerreno";
            this.lblAnchoTerreno.Size = new System.Drawing.Size(91, 13);
            this.lblAnchoTerreno.TabIndex = 7;
            this.lblAnchoTerreno.Text = "&Ancho del terreno";
            // 
            // lblRadioTerreno
            // 
            this.lblRadioTerreno.AutoSize = true;
            this.lblRadioTerreno.Location = new System.Drawing.Point(112, 135);
            this.lblRadioTerreno.Name = "lblRadioTerreno";
            this.lblRadioTerreno.Size = new System.Drawing.Size(71, 13);
            this.lblRadioTerreno.TabIndex = 8;
            this.lblRadioTerreno.Text = "&Radio terreno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 359);
            this.Controls.Add(this.lblRadioTerreno);
            this.Controls.Add(this.lblAnchoTerreno);
            this.Controls.Add(this.lblLargoTerreno);
            this.Controls.Add(this.btbMateriales);
            this.Controls.Add(this.btbCirculoAlambre);
            this.Controls.Add(this.btnRectanguloAlambre);
            this.Controls.Add(this.txtRadioTerreno);
            this.Controls.Add(this.txtAnchoTerreno);
            this.Controls.Add(this.txtLargoTerreno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLargoTerreno;
        private System.Windows.Forms.TextBox txtAnchoTerreno;
        private System.Windows.Forms.TextBox txtRadioTerreno;
        private System.Windows.Forms.Button btnRectanguloAlambre;
        private System.Windows.Forms.Button btbCirculoAlambre;
        private System.Windows.Forms.Button btbMateriales;
        private System.Windows.Forms.Label lblLargoTerreno;
        private System.Windows.Forms.Label lblAnchoTerreno;
        private System.Windows.Forms.Label lblRadioTerreno;
    }
}

