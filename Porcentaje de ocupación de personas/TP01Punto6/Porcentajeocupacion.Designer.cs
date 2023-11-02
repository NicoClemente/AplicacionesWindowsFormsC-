namespace TP01Punto6
{
    partial class Porcentajeocupacion
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
            this.bmenos = new System.Windows.Forms.Button();
            this.bmas = new System.Windows.Forms.Button();
            this.bporcentaje = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.tbpersonas = new System.Windows.Forms.TextBox();
            this.tbcupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bmenos
            // 
            this.bmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmenos.Location = new System.Drawing.Point(220, 252);
            this.bmenos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bmenos.Name = "bmenos";
            this.bmenos.Size = new System.Drawing.Size(141, 38);
            this.bmenos.TabIndex = 0;
            this.bmenos.Text = "-1 persona";
            this.bmenos.UseVisualStyleBackColor = true;
            this.bmenos.Click += new System.EventHandler(this.bmenos_Click);
            // 
            // bmas
            // 
            this.bmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmas.Location = new System.Drawing.Point(511, 252);
            this.bmas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bmas.Name = "bmas";
            this.bmas.Size = new System.Drawing.Size(139, 38);
            this.bmas.TabIndex = 1;
            this.bmas.Text = "+1 persona";
            this.bmas.UseVisualStyleBackColor = true;
            this.bmas.Click += new System.EventHandler(this.bmas_Click);
            // 
            // bporcentaje
            // 
            this.bporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bporcentaje.Location = new System.Drawing.Point(337, 320);
            this.bporcentaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bporcentaje.Name = "bporcentaje";
            this.bporcentaje.Size = new System.Drawing.Size(192, 114);
            this.bporcentaje.TabIndex = 2;
            this.bporcentaje.Text = "Porcentaje de ocupación de la sala";
            this.bporcentaje.UseVisualStyleBackColor = true;
            this.bporcentaje.Click += new System.EventHandler(this.bporcentaje_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(368, 474);
            this.bcerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(133, 49);
            this.bcerrar.TabIndex = 3;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // tbpersonas
            // 
            this.tbpersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpersonas.Location = new System.Drawing.Point(368, 252);
            this.tbpersonas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpersonas.Name = "tbpersonas";
            this.tbpersonas.Size = new System.Drawing.Size(132, 36);
            this.tbpersonas.TabIndex = 4;
            // 
            // tbcupo
            // 
            this.tbcupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcupo.Location = new System.Drawing.Point(368, 127);
            this.tbcupo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbcupo.Name = "tbcupo";
            this.tbcupo.Size = new System.Drawing.Size(132, 36);
            this.tbcupo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cupo de la sala";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Personas actuales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(659, 48);
            this.label3.TabIndex = 9;
            this.label3.Text = "PORCENTAJE DE OCUPACIÓN";
            // 
            // Porcentajeocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcupo);
            this.Controls.Add(this.tbpersonas);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.bporcentaje);
            this.Controls.Add(this.bmas);
            this.Controls.Add(this.bmenos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Porcentajeocupacion";
            this.Text = "Cupo total de una sala";
            this.Load += new System.EventHandler(this.porcentajeocupacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bmenos;
        private System.Windows.Forms.Button bmas;
        private System.Windows.Forms.Button bporcentaje;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.TextBox tbpersonas;
        private System.Windows.Forms.TextBox tbcupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

