namespace TPN4Ejercicio1
{
    partial class FSucesiones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bTablaMultiplicar = new System.Windows.Forms.Button();
            this.bFibonacci = new System.Windows.Forms.Button();
            this.bserie = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lrespuesta = new System.Windows.Forms.Label();
            this.nudTabla = new System.Windows.Forms.NumericUpDown();
            this.nudFibonacci = new System.Windows.Forms.NumericUpDown();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fibonacci de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cada:";
            // 
            // bTablaMultiplicar
            // 
            this.bTablaMultiplicar.Location = new System.Drawing.Point(25, 78);
            this.bTablaMultiplicar.Name = "bTablaMultiplicar";
            this.bTablaMultiplicar.Size = new System.Drawing.Size(160, 48);
            this.bTablaMultiplicar.TabIndex = 2;
            this.bTablaMultiplicar.Text = "&Tabla de  multiplicar";
            this.bTablaMultiplicar.UseVisualStyleBackColor = true;
            this.bTablaMultiplicar.Click += new System.EventHandler(this.bTablaMultiplicar_Click);
            // 
            // bFibonacci
            // 
            this.bFibonacci.Location = new System.Drawing.Point(25, 176);
            this.bFibonacci.Name = "bFibonacci";
            this.bFibonacci.Size = new System.Drawing.Size(160, 48);
            this.bFibonacci.TabIndex = 4;
            this.bFibonacci.Text = "&Fibonacci";
            this.bFibonacci.UseVisualStyleBackColor = true;
            this.bFibonacci.Click += new System.EventHandler(this.bFibonacci_Click);
            // 
            // bserie
            // 
            this.bserie.Location = new System.Drawing.Point(25, 328);
            this.bserie.Name = "bserie";
            this.bserie.Size = new System.Drawing.Size(160, 48);
            this.bserie.TabIndex = 8;
            this.bserie.Text = "&Serie";
            this.bserie.UseVisualStyleBackColor = true;
            this.bserie.Click += new System.EventHandler(this.bserie_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Location = new System.Drawing.Point(3, 427);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(682, 48);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // lrespuesta
            // 
            this.lrespuesta.AutoSize = true;
            this.lrespuesta.Location = new System.Drawing.Point(199, 35);
            this.lrespuesta.Name = "lrespuesta";
            this.lrespuesta.Size = new System.Drawing.Size(0, 16);
            this.lrespuesta.TabIndex = 20;
            this.lrespuesta.Click += new System.EventHandler(this.lrespuesta_Click);
            // 
            // nudTabla
            // 
            this.nudTabla.Location = new System.Drawing.Point(100, 33);
            this.nudTabla.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudTabla.Name = "nudTabla";
            this.nudTabla.Size = new System.Drawing.Size(60, 22);
            this.nudTabla.TabIndex = 1;
            // 
            // nudFibonacci
            // 
            this.nudFibonacci.Location = new System.Drawing.Point(125, 142);
            this.nudFibonacci.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFibonacci.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFibonacci.Name = "nudFibonacci";
            this.nudFibonacci.Size = new System.Drawing.Size(60, 22);
            this.nudFibonacci.TabIndex = 3;
            this.nudFibonacci.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(100, 230);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(60, 22);
            this.nudDesde.TabIndex = 5;
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(99, 261);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(60, 22);
            this.nudHasta.TabIndex = 6;
            // 
            // nudCada
            // 
            this.nudCada.Location = new System.Drawing.Point(100, 289);
            this.nudCada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(60, 22);
            this.nudCada.TabIndex = 7;
            this.nudCada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FSucesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(685, 484);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.nudFibonacci);
            this.Controls.Add(this.nudTabla);
            this.Controls.Add(this.lrespuesta);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bserie);
            this.Controls.Add(this.bFibonacci);
            this.Controls.Add(this.bTablaMultiplicar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSucesiones";
            this.Text = "Sucesiones";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FSucesiones_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bTablaMultiplicar;
        private System.Windows.Forms.Button bFibonacci;
        private System.Windows.Forms.Button bserie;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lrespuesta;
        private System.Windows.Forms.NumericUpDown nudTabla;
        private System.Windows.Forms.NumericUpDown nudFibonacci;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.NumericUpDown nudCada;
    }
}

