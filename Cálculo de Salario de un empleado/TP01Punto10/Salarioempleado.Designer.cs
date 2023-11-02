namespace TP01Punto10
{
    partial class Salarioempleado
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
            this.txtboxnombre = new System.Windows.Forms.TextBox();
            this.ltitulo = new System.Windows.Forms.Label();
            this.lnombreempleado = new System.Windows.Forms.Label();
            this.lañoingreso = new System.Windows.Forms.Label();
            this.ltarifahoraria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxdiasmes = new System.Windows.Forms.TextBox();
            this.txtboxtarifa = new System.Windows.Forms.TextBox();
            this.txtboxhorasdia = new System.Windows.Forms.TextBox();
            this.bcalculosalario = new System.Windows.Forms.Button();
            this.bcerrar = new System.Windows.Forms.Button();
            this.dtcalendario = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtboxnombre
            // 
            this.txtboxnombre.Location = new System.Drawing.Point(361, 100);
            this.txtboxnombre.Name = "txtboxnombre";
            this.txtboxnombre.Size = new System.Drawing.Size(149, 20);
            this.txtboxnombre.TabIndex = 0;
            // 
            // ltitulo
            // 
            this.ltitulo.AutoSize = true;
            this.ltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitulo.Location = new System.Drawing.Point(206, 36);
            this.ltitulo.Name = "ltitulo";
            this.ltitulo.Size = new System.Drawing.Size(403, 31);
            this.ltitulo.TabIndex = 1;
            this.ltitulo.Text = "SALARIO DE UN EMPLEADO";
            // 
            // lnombreempleado
            // 
            this.lnombreempleado.AutoSize = true;
            this.lnombreempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombreempleado.Location = new System.Drawing.Point(131, 95);
            this.lnombreempleado.Name = "lnombreempleado";
            this.lnombreempleado.Size = new System.Drawing.Size(224, 25);
            this.lnombreempleado.TabIndex = 2;
            this.lnombreempleado.Text = "Nombre de empleado:";
            // 
            // lañoingreso
            // 
            this.lañoingreso.AutoSize = true;
            this.lañoingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lañoingreso.Location = new System.Drawing.Point(190, 132);
            this.lañoingreso.Name = "lañoingreso";
            this.lañoingreso.Size = new System.Drawing.Size(165, 25);
            this.lañoingreso.TabIndex = 3;
            this.lañoingreso.Text = "Año de ingreso:";
            // 
            // ltarifahoraria
            // 
            this.ltarifahoraria.AutoSize = true;
            this.ltarifahoraria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltarifahoraria.Location = new System.Drawing.Point(207, 170);
            this.ltarifahoraria.Name = "ltarifahoraria";
            this.ltarifahoraria.Size = new System.Drawing.Size(148, 25);
            this.ltarifahoraria.TabIndex = 4;
            this.ltarifahoraria.Text = "Tarifa horaria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Horas de trabajo por día:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dias que trabajó al mes:";
            // 
            // txtboxdiasmes
            // 
            this.txtboxdiasmes.Location = new System.Drawing.Point(361, 248);
            this.txtboxdiasmes.Name = "txtboxdiasmes";
            this.txtboxdiasmes.Size = new System.Drawing.Size(100, 20);
            this.txtboxdiasmes.TabIndex = 7;
            // 
            // txtboxtarifa
            // 
            this.txtboxtarifa.Location = new System.Drawing.Point(361, 175);
            this.txtboxtarifa.Name = "txtboxtarifa";
            this.txtboxtarifa.Size = new System.Drawing.Size(100, 20);
            this.txtboxtarifa.TabIndex = 9;
            // 
            // txtboxhorasdia
            // 
            this.txtboxhorasdia.Location = new System.Drawing.Point(361, 212);
            this.txtboxhorasdia.Name = "txtboxhorasdia";
            this.txtboxhorasdia.Size = new System.Drawing.Size(100, 20);
            this.txtboxhorasdia.TabIndex = 10;
            // 
            // bcalculosalario
            // 
            this.bcalculosalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcalculosalario.Location = new System.Drawing.Point(312, 287);
            this.bcalculosalario.Name = "bcalculosalario";
            this.bcalculosalario.Size = new System.Drawing.Size(198, 72);
            this.bcalculosalario.TabIndex = 11;
            this.bcalculosalario.Text = "Calcular salario ";
            this.bcalculosalario.UseVisualStyleBackColor = true;
            this.bcalculosalario.Click += new System.EventHandler(this.bcalculosalario_Click);
            // 
            // bcerrar
            // 
            this.bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcerrar.Location = new System.Drawing.Point(351, 380);
            this.bcerrar.Name = "bcerrar";
            this.bcerrar.Size = new System.Drawing.Size(122, 45);
            this.bcerrar.TabIndex = 12;
            this.bcerrar.Text = "Cerrar";
            this.bcerrar.UseVisualStyleBackColor = true;
            this.bcerrar.Click += new System.EventHandler(this.bcerrar_Click);
            // 
            // dtcalendario
            // 
            this.dtcalendario.Location = new System.Drawing.Point(361, 135);
            this.dtcalendario.Name = "dtcalendario";
            this.dtcalendario.Size = new System.Drawing.Size(212, 20);
            this.dtcalendario.TabIndex = 13;
            // 
            // Salarioempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtcalendario);
            this.Controls.Add(this.bcerrar);
            this.Controls.Add(this.bcalculosalario);
            this.Controls.Add(this.txtboxhorasdia);
            this.Controls.Add(this.txtboxtarifa);
            this.Controls.Add(this.txtboxdiasmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ltarifahoraria);
            this.Controls.Add(this.lañoingreso);
            this.Controls.Add(this.lnombreempleado);
            this.Controls.Add(this.ltitulo);
            this.Controls.Add(this.txtboxnombre);
            this.Name = "Salarioempleado";
            this.Text = "Salario de un empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxnombre;
        private System.Windows.Forms.Label ltitulo;
        private System.Windows.Forms.Label lnombreempleado;
        private System.Windows.Forms.Label lañoingreso;
        private System.Windows.Forms.Label ltarifahoraria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxdiasmes;
        private System.Windows.Forms.TextBox txtboxtarifa;
        private System.Windows.Forms.TextBox txtboxhorasdia;
        private System.Windows.Forms.Button bcalculosalario;
        private System.Windows.Forms.Button bcerrar;
        private System.Windows.Forms.DateTimePicker dtcalendario;
    }
}

