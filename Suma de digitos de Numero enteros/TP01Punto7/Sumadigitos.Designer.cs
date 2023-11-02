namespace TP01Punto7
{
    partial class Sumadigitos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltitulo = new System.Windows.Forms.Label();
            this.txtboxcifra = new System.Windows.Forms.TextBox();
            this.bsumacifras = new System.Windows.Forms.Button();
            this.lcifra = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(24, 60);
            this.ltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(777, 29);
            this.ltitulo.TabIndex = 0;
            this.ltitulo.Text = "SUMA DE LOS DÍGITOS DE UN NÚMERO ENTERO POSITIVO";
            this.ltitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtboxcifra
            // 
            this.txtboxcifra.Location = new System.Drawing.Point(329, 164);
            this.txtboxcifra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxcifra.Name = "txtboxcifra";
            this.txtboxcifra.Size = new System.Drawing.Size(207, 22);
            this.txtboxcifra.TabIndex = 1;
            this.txtboxcifra.TextChanged += new System.EventHandler(this.txtboxcifra_TextChanged);
            // 
            // bsumacifras
            // 
            this.bsumacifras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsumacifras.Location = new System.Drawing.Point(329, 214);
            this.bsumacifras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bsumacifras.Name = "bsumacifras";
            this.bsumacifras.Size = new System.Drawing.Size(208, 112);
            this.bsumacifras.TabIndex = 2;
            this.bsumacifras.Text = "Calcular suma de los dígitos";
            this.bsumacifras.UseVisualStyleBackColor = true;
            this.bsumacifras.Click += new System.EventHandler(this.bsumacifras_Click);
            // 
            // lcifra
            // 
            this.lcifra.AutoSize = true;
            this.lcifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcifra.Location = new System.Drawing.Point(235, 116);
            this.lcifra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lcifra.Name = "lcifra";
            this.lcifra.Size = new System.Drawing.Size(385, 29);
            this.lcifra.TabIndex = 3;
            this.lcifra.Text = "Ingresar número de dos cifras:";
            this.lcifra.Click += new System.EventHandler(this.lcifra_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(348, 348);
            this.bcerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(171, 55);
            this.bcerrar.TabIndex = 4;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // Sumadigitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 438);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.lcifra);
            this.Controls.Add(this.bsumacifras);
            this.Controls.Add(this.txtboxcifra);
            this.Controls.Add(this.ltitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sumadigitos";
            this.Text = "Suma de los dígitos de un número entero positivo";
            this.Load += new System.EventHandler(this.Sumadigitos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.TextBox txtboxcifra;
        private System.Windows.Forms.Button bsumacifras;
        private System.Windows.Forms.Label lcifra;
        private System.Windows.Forms.Button bcerrar;
    }
}

