namespace ejercicio1tp2
{
    partial class FPrincipal
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
            this.tvalorabsoluto = new System.Windows.Forms.Button();
            this.tdecimales = new System.Windows.Forms.Button();
            this.tnumero = new System.Windows.Forms.TextBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvalorabsoluto
            // 
            this.tvalorabsoluto.Location = new System.Drawing.Point(174, 135);
            this.tvalorabsoluto.Name = "tvalorabsoluto";
            this.tvalorabsoluto.Size = new System.Drawing.Size(126, 40);
            this.tvalorabsoluto.TabIndex = 0;
            this.tvalorabsoluto.Text = "valor absoluto";
            this.tvalorabsoluto.UseVisualStyleBackColor = true;
            this.tvalorabsoluto.Click += new System.EventHandler(this.tvalorabsoluto_Click);
            // 
            // tdecimales
            // 
            this.tdecimales.Location = new System.Drawing.Point(174, 190);
            this.tdecimales.Name = "tdecimales";
            this.tdecimales.Size = new System.Drawing.Size(126, 40);
            this.tdecimales.TabIndex = 1;
            this.tdecimales.Text = "decimales";
            this.tdecimales.UseVisualStyleBackColor = true;
            this.tdecimales.Click += new System.EventHandler(this.tdecimales_Click);
            // 
            // tnumero
            // 
            this.tnumero.Location = new System.Drawing.Point(128, 86);
            this.tnumero.Name = "tnumero";
            this.tnumero.Size = new System.Drawing.Size(225, 22);
            this.tnumero.TabIndex = 2;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(370, 218);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(126, 40);
            this.bCerrar.TabIndex = 3;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 270);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.tnumero);
            this.Controls.Add(this.tdecimales);
            this.Controls.Add(this.tvalorabsoluto);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros";
            this.Load += new System.EventHandler(this.FPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tvalorabsoluto;
        private System.Windows.Forms.Button tdecimales;
        private System.Windows.Forms.TextBox tnumero;
        private System.Windows.Forms.Button bCerrar;
    }
}

