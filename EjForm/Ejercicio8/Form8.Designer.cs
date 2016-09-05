namespace Ejercicio8
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.lblEmpatados = new System.Windows.Forms.Label();
            this.lblPerdidos = new System.Windows.Forms.Label();
            this.lblGanados = new System.Windows.Forms.Label();
            this.txtEmpatados = new System.Windows.Forms.TextBox();
            this.txtPerdidos = new System.Windows.Forms.TextBox();
            this.txtGanados = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargar);
            this.groupBox1.Controls.Add(this.lblEmpatados);
            this.groupBox1.Controls.Add(this.lblPerdidos);
            this.groupBox1.Controls.Add(this.lblGanados);
            this.groupBox1.Controls.Add(this.txtEmpatados);
            this.groupBox1.Controls.Add(this.txtPerdidos);
            this.groupBox1.Controls.Add(this.txtGanados);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnPiedra);
            this.groupBox1.Controls.Add(this.btnTijera);
            this.groupBox1.Controls.Add(this.btnPapel);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 540);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Location = new System.Drawing.Point(328, 511);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(75, 23);
            this.btnRecargar.TabIndex = 10;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // lblEmpatados
            // 
            this.lblEmpatados.AutoSize = true;
            this.lblEmpatados.Location = new System.Drawing.Point(36, 126);
            this.lblEmpatados.Name = "lblEmpatados";
            this.lblEmpatados.Size = new System.Drawing.Size(60, 13);
            this.lblEmpatados.TabIndex = 9;
            this.lblEmpatados.Text = "Empatados";
            // 
            // lblPerdidos
            // 
            this.lblPerdidos.AutoSize = true;
            this.lblPerdidos.Location = new System.Drawing.Point(36, 72);
            this.lblPerdidos.Name = "lblPerdidos";
            this.lblPerdidos.Size = new System.Drawing.Size(48, 13);
            this.lblPerdidos.TabIndex = 8;
            this.lblPerdidos.Text = "Perdidos";
            // 
            // lblGanados
            // 
            this.lblGanados.AutoSize = true;
            this.lblGanados.Location = new System.Drawing.Point(36, 16);
            this.lblGanados.Name = "lblGanados";
            this.lblGanados.Size = new System.Drawing.Size(50, 13);
            this.lblGanados.TabIndex = 7;
            this.lblGanados.Text = "Ganados";
            // 
            // txtEmpatados
            // 
            this.txtEmpatados.Location = new System.Drawing.Point(36, 142);
            this.txtEmpatados.Name = "txtEmpatados";
            this.txtEmpatados.Size = new System.Drawing.Size(367, 20);
            this.txtEmpatados.TabIndex = 6;
            // 
            // txtPerdidos
            // 
            this.txtPerdidos.Location = new System.Drawing.Point(36, 88);
            this.txtPerdidos.Name = "txtPerdidos";
            this.txtPerdidos.Size = new System.Drawing.Size(367, 20);
            this.txtPerdidos.TabIndex = 5;
            // 
            // txtGanados
            // 
            this.txtGanados.Location = new System.Drawing.Point(36, 32);
            this.txtGanados.Name = "txtGanados";
            this.txtGanados.Size = new System.Drawing.Size(367, 20);
            this.txtGanados.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPiedra
            // 
            this.btnPiedra.AutoSize = true;
            this.btnPiedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPiedra.Image")));
            this.btnPiedra.Location = new System.Drawing.Point(36, 354);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(107, 103);
            this.btnPiedra.TabIndex = 0;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.AutoSize = true;
            this.btnTijera.Image = ((System.Drawing.Image)(resources.GetObject("btnTijera.Image")));
            this.btnTijera.Location = new System.Drawing.Point(297, 354);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(106, 107);
            this.btnTijera.TabIndex = 2;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.AutoSize = true;
            this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
            this.btnPapel.Location = new System.Drawing.Point(161, 352);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(109, 107);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 588);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Label lblEmpatados;
        private System.Windows.Forms.Label lblPerdidos;
        private System.Windows.Forms.Label lblGanados;
        private System.Windows.Forms.TextBox txtEmpatados;
        private System.Windows.Forms.TextBox txtPerdidos;
        private System.Windows.Forms.TextBox txtGanados;
        private System.Windows.Forms.Button btnRecargar;
    }
}

