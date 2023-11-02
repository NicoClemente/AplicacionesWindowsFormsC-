namespace tp_formulario_botones_3
{
    partial class FColores
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
            this.bamarillo = new System.Windows.Forms.Button();
            this.brojo = new System.Windows.Forms.Button();
            this.bazul = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bamarillo
            // 
            this.bamarillo.Location = new System.Drawing.Point(29, 54);
            this.bamarillo.Name = "bamarillo";
            this.bamarillo.Size = new System.Drawing.Size(75, 23);
            this.bamarillo.TabIndex = 0;
            this.bamarillo.Text = "&Amarillo";
            this.bamarillo.UseVisualStyleBackColor = true;
            this.bamarillo.Click += new System.EventHandler(this.bamarillo_Click);
            // 
            // brojo
            // 
            this.brojo.Location = new System.Drawing.Point(166, 54);
            this.brojo.Name = "brojo";
            this.brojo.Size = new System.Drawing.Size(75, 23);
            this.brojo.TabIndex = 1;
            this.brojo.Text = "&Rojo";
            this.brojo.UseVisualStyleBackColor = true;
            this.brojo.Click += new System.EventHandler(this.brojo_Click);
            // 
            // bazul
            // 
            this.bazul.Location = new System.Drawing.Point(310, 54);
            this.bazul.Name = "bazul";
            this.bazul.Size = new System.Drawing.Size(75, 23);
            this.bazul.TabIndex = 2;
            this.bazul.Text = "A&zul";
            this.bazul.UseVisualStyleBackColor = true;
            this.bazul.Click += new System.EventHandler(this.bazul_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bcerrar.Location = new System.Drawing.Point(16, 113);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(373, 34);
            this.bcerrar.TabIndex = 3;
            this.bcerrar.Text = "&Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Visible = false;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // FColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bcerrar;
            this.ClientSize = new System.Drawing.Size(401, 161);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.bazul);
            this.Controls.Add(this.brojo);
            this.Controls.Add(this.bamarillo);
            this.Name = "FColores";
            this.Text = "Mezcla de colores";
            this.Load += new System.EventHandler(this.FColores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bamarillo;
        private System.Windows.Forms.Button brojo;
        private System.Windows.Forms.Button bazul;
        private System.Windows.Forms.Button bcerrar;
    }
}

