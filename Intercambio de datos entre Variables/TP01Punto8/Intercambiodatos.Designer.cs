namespace TP01Punto8
{
    partial class Intercambiodatos
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
            this.bintercambio = new System.Windows.Forms.Button();
            this.lvalora = new System.Windows.Forms.Label();
            this.lvalorb = new System.Windows.Forms.Label();
            this.txtboxa = new System.Windows.Forms.TextBox();
            this.txtboxb = new System.Windows.Forms.TextBox();
            this.ltitulo = new System.Windows.Forms.Label();
            this.bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bintercambio
            // 
            this.bintercambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bintercambio.Location = new System.Drawing.Point(353, 226);
            this.bintercambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bintercambio.Name = "bintercambio";
            this.bintercambio.Size = new System.Drawing.Size(195, 113);
            this.bintercambio.TabIndex = 0;
            this.bintercambio.Text = "Intercambio de datos";
            this.bintercambio.UseVisualStyleBackColor = true;
            this.bintercambio.Click += new System.EventHandler(this.bintercambio_Click);
            // 
            // lvalora
            // 
            this.lvalora.AutoSize = true;
            this.lvalora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalora.Location = new System.Drawing.Point(319, 135);
            this.lvalora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvalora.Name = "lvalora";
            this.lvalora.Size = new System.Drawing.Size(114, 25);
            this.lvalora.TabIndex = 1;
            this.lvalora.Text = "Valor de A";
            this.lvalora.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvalorb
            // 
            this.lvalorb.AutoSize = true;
            this.lvalorb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvalorb.Location = new System.Drawing.Point(319, 173);
            this.lvalorb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvalorb.Name = "lvalorb";
            this.lvalorb.Size = new System.Drawing.Size(113, 25);
            this.lvalorb.TabIndex = 2;
            this.lvalorb.Text = "Valor de B";
            // 
            // txtboxa
            // 
            this.txtboxa.Location = new System.Drawing.Point(451, 135);
            this.txtboxa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxa.Name = "txtboxa";
            this.txtboxa.Size = new System.Drawing.Size(132, 22);
            this.txtboxa.TabIndex = 3;
            // 
            // txtboxb
            // 
            this.txtboxb.Location = new System.Drawing.Point(451, 173);
            this.txtboxb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtboxb.Name = "txtboxb";
            this.txtboxb.Size = new System.Drawing.Size(132, 22);
            this.txtboxb.TabIndex = 4;
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(45, 76);
            this.ltitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(796, 36);
            this.ltitulo.TabIndex = 5;
            this.ltitulo.Text = "INTERCAMBIO DE DATOS ENTRE VARIABLES A Y B";
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(375, 366);
            this.bcerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(152, 68);
            this.bcerrar.TabIndex = 6;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // Intercambiodatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 455);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.txtboxb);
            this.Controls.Add(this.txtboxa);
            this.Controls.Add(this.lvalorb);
            this.Controls.Add(this.lvalora);
            this.Controls.Add(this.bintercambio);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Intercambiodatos";
            this.Text = "Intercambio de datos entre variables A y B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bintercambio;
        private System.Windows.Forms.Label lvalora;
        private System.Windows.Forms.Label lvalorb;
        private System.Windows.Forms.TextBox txtboxa;
        private System.Windows.Forms.TextBox txtboxb;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Button bcerrar;
    }
}

