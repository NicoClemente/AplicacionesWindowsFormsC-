namespace TPN3Ejercicio1
{
    partial class FCategoria
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
            this.bingreso = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.nudday = new System.Windows.Forms.NumericUpDown();
            this.nudmonth = new System.Windows.Forms.NumericUpDown();
            this.nudyear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lVeteranosContadora = new System.Windows.Forms.Label();
            this.lJuvenilContadora = new System.Windows.Forms.Label();
            this.lCadeteContadora = new System.Windows.Forms.Label();
            this.lQuerubinContadora = new System.Windows.Forms.Label();
            this.lAmateurContadora = new System.Windows.Forms.Label();
            this.lInfantilContadora = new System.Windows.Forms.Label();
            this.lBenjaminContadora = new System.Windows.Forms.Label();
            this.lVeteranos = new System.Windows.Forms.Label();
            this.lAmateur = new System.Windows.Forms.Label();
            this.lJuvenil = new System.Windows.Forms.Label();
            this.lCadete = new System.Windows.Forms.Label();
            this.lInfantil = new System.Windows.Forms.Label();
            this.lBenjamin = new System.Windows.Forms.Label();
            this.lQuerubin = new System.Windows.Forms.Label();
            this.lCategorias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).BeginInit();
            this.SuspendLayout();
            // 
            // bingreso
            // 
            this.bingreso.Location = new System.Drawing.Point(172, 235);
            this.bingreso.Margin = new System.Windows.Forms.Padding(4);
            this.bingreso.Name = "bingreso";
            this.bingreso.Size = new System.Drawing.Size(195, 28);
            this.bingreso.TabIndex = 6;
            this.bingreso.Text = "&Ingresar";
            this.bingreso.UseVisualStyleBackColor = true;
            this.bingreso.Click += new System.EventHandler(this.bingreso_Click);
            this.bingreso.Enter += new System.EventHandler(this.bingreso_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bcancelar.Location = new System.Drawing.Point(5, 337);
            this.bcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(718, 28);
            this.bcancelar.TabIndex = 7;
            this.bcancelar.Text = "&Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            this.bcancelar.Click += new System.EventHandler(this.bcancelar_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(165, 71);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(203, 22);
            this.tbnombre.TabIndex = 1;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(165, 114);
            this.tbapellido.Margin = new System.Windows.Forms.Padding(4);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(203, 22);
            this.tbapellido.TabIndex = 2;
            // 
            // nudday
            // 
            this.nudday.Location = new System.Drawing.Point(172, 186);
            this.nudday.Margin = new System.Windows.Forms.Padding(4);
            this.nudday.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudday.Name = "nudday";
            this.nudday.Size = new System.Drawing.Size(57, 22);
            this.nudday.TabIndex = 3;
            this.nudday.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudmonth
            // 
            this.nudmonth.Location = new System.Drawing.Point(236, 186);
            this.nudmonth.Margin = new System.Windows.Forms.Padding(4);
            this.nudmonth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudmonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudmonth.Name = "nudmonth";
            this.nudmonth.Size = new System.Drawing.Size(60, 22);
            this.nudmonth.TabIndex = 4;
            this.nudmonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudyear
            // 
            this.nudyear.Location = new System.Drawing.Point(303, 184);
            this.nudyear.Margin = new System.Windows.Forms.Padding(4);
            this.nudyear.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudyear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudyear.Name = "nudyear";
            this.nudyear.Size = new System.Drawing.Size(64, 22);
            this.nudyear.TabIndex = 5;
            this.nudyear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // lVeteranosContadora
            // 
            this.lVeteranosContadora.AutoSize = true;
            this.lVeteranosContadora.Location = new System.Drawing.Point(676, 137);
            this.lVeteranosContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVeteranosContadora.Name = "lVeteranosContadora";
            this.lVeteranosContadora.Size = new System.Drawing.Size(14, 16);
            this.lVeteranosContadora.TabIndex = 39;
            this.lVeteranosContadora.Text = "0";
            // 
            // lJuvenilContadora
            // 
            this.lJuvenilContadora.AutoSize = true;
            this.lJuvenilContadora.Location = new System.Drawing.Point(656, 103);
            this.lJuvenilContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lJuvenilContadora.Name = "lJuvenilContadora";
            this.lJuvenilContadora.Size = new System.Drawing.Size(14, 16);
            this.lJuvenilContadora.TabIndex = 38;
            this.lJuvenilContadora.Text = "0";
            // 
            // lCadeteContadora
            // 
            this.lCadeteContadora.AutoSize = true;
            this.lCadeteContadora.Location = new System.Drawing.Point(657, 74);
            this.lCadeteContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCadeteContadora.Name = "lCadeteContadora";
            this.lCadeteContadora.Size = new System.Drawing.Size(14, 16);
            this.lCadeteContadora.TabIndex = 37;
            this.lCadeteContadora.Text = "0";
            // 
            // lQuerubinContadora
            // 
            this.lQuerubinContadora.AutoSize = true;
            this.lQuerubinContadora.Location = new System.Drawing.Point(670, 50);
            this.lQuerubinContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuerubinContadora.Name = "lQuerubinContadora";
            this.lQuerubinContadora.Size = new System.Drawing.Size(14, 16);
            this.lQuerubinContadora.TabIndex = 36;
            this.lQuerubinContadora.Text = "0";
            // 
            // lAmateurContadora
            // 
            this.lAmateurContadora.AutoSize = true;
            this.lAmateurContadora.Location = new System.Drawing.Point(516, 137);
            this.lAmateurContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmateurContadora.Name = "lAmateurContadora";
            this.lAmateurContadora.Size = new System.Drawing.Size(14, 16);
            this.lAmateurContadora.TabIndex = 35;
            this.lAmateurContadora.Text = "0";
            // 
            // lInfantilContadora
            // 
            this.lInfantilContadora.AutoSize = true;
            this.lInfantilContadora.Location = new System.Drawing.Point(505, 103);
            this.lInfantilContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInfantilContadora.Name = "lInfantilContadora";
            this.lInfantilContadora.Size = new System.Drawing.Size(14, 16);
            this.lInfantilContadora.TabIndex = 34;
            this.lInfantilContadora.Text = "0";
            // 
            // lBenjaminContadora
            // 
            this.lBenjaminContadora.AutoSize = true;
            this.lBenjaminContadora.Location = new System.Drawing.Point(510, 68);
            this.lBenjaminContadora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBenjaminContadora.Name = "lBenjaminContadora";
            this.lBenjaminContadora.Size = new System.Drawing.Size(14, 16);
            this.lBenjaminContadora.TabIndex = 33;
            this.lBenjaminContadora.Text = "0";
            // 
            // lVeteranos
            // 
            this.lVeteranos.AutoSize = true;
            this.lVeteranos.Location = new System.Drawing.Point(591, 137);
            this.lVeteranos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVeteranos.Name = "lVeteranos";
            this.lVeteranos.Size = new System.Drawing.Size(72, 16);
            this.lVeteranos.TabIndex = 32;
            this.lVeteranos.Text = "Veteranos:";
            // 
            // lAmateur
            // 
            this.lAmateur.AutoSize = true;
            this.lAmateur.Location = new System.Drawing.Point(442, 137);
            this.lAmateur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAmateur.Name = "lAmateur";
            this.lAmateur.Size = new System.Drawing.Size(60, 16);
            this.lAmateur.TabIndex = 31;
            this.lAmateur.Text = "Amateur:";
            // 
            // lJuvenil
            // 
            this.lJuvenil.AutoSize = true;
            this.lJuvenil.Location = new System.Drawing.Point(591, 103);
            this.lJuvenil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lJuvenil.Name = "lJuvenil";
            this.lJuvenil.Size = new System.Drawing.Size(52, 16);
            this.lJuvenil.TabIndex = 30;
            this.lJuvenil.Text = "Juvenil:";
            // 
            // lCadete
            // 
            this.lCadete.AutoSize = true;
            this.lCadete.Location = new System.Drawing.Point(591, 74);
            this.lCadete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCadete.Name = "lCadete";
            this.lCadete.Size = new System.Drawing.Size(54, 16);
            this.lCadete.TabIndex = 29;
            this.lCadete.Text = "Cadete:";
            // 
            // lInfantil
            // 
            this.lInfantil.AutoSize = true;
            this.lInfantil.Location = new System.Drawing.Point(442, 103);
            this.lInfantil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInfantil.Name = "lInfantil";
            this.lInfantil.Size = new System.Drawing.Size(47, 16);
            this.lInfantil.TabIndex = 28;
            this.lInfantil.Text = "Infantil:";
            // 
            // lBenjamin
            // 
            this.lBenjamin.AutoSize = true;
            this.lBenjamin.Location = new System.Drawing.Point(442, 68);
            this.lBenjamin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lBenjamin.Name = "lBenjamin";
            this.lBenjamin.Size = new System.Drawing.Size(66, 16);
            this.lBenjamin.TabIndex = 27;
            this.lBenjamin.Text = "Benjamin:";
            // 
            // lQuerubin
            // 
            this.lQuerubin.AutoSize = true;
            this.lQuerubin.Location = new System.Drawing.Point(591, 50);
            this.lQuerubin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lQuerubin.Name = "lQuerubin";
            this.lQuerubin.Size = new System.Drawing.Size(64, 16);
            this.lQuerubin.TabIndex = 26;
            this.lQuerubin.Text = "Querubin:";
            // 
            // lCategorias
            // 
            this.lCategorias.AutoSize = true;
            this.lCategorias.Location = new System.Drawing.Point(444, 34);
            this.lCategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCategorias.Name = "lCategorias";
            this.lCategorias.Size = new System.Drawing.Size(76, 16);
            this.lCategorias.TabIndex = 25;
            this.lCategorias.Text = "Categorías:";
            // 
            // FCategoria
            // 
            this.AcceptButton = this.bingreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bcancelar;
            this.ClientSize = new System.Drawing.Size(735, 372);
            this.Controls.Add(this.lVeteranosContadora);
            this.Controls.Add(this.lJuvenilContadora);
            this.Controls.Add(this.lCadeteContadora);
            this.Controls.Add(this.lQuerubinContadora);
            this.Controls.Add(this.lAmateurContadora);
            this.Controls.Add(this.lInfantilContadora);
            this.Controls.Add(this.lBenjaminContadora);
            this.Controls.Add(this.lVeteranos);
            this.Controls.Add(this.lAmateur);
            this.Controls.Add(this.lJuvenil);
            this.Controls.Add(this.lCadete);
            this.Controls.Add(this.lInfantil);
            this.Controls.Add(this.lBenjamin);
            this.Controls.Add(this.lQuerubin);
            this.Controls.Add(this.lCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudyear);
            this.Controls.Add(this.nudmonth);
            this.Controls.Add(this.nudday);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bingreso);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bingreso;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.NumericUpDown nudday;
        private System.Windows.Forms.NumericUpDown nudmonth;
        private System.Windows.Forms.NumericUpDown nudyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lVeteranosContadora;
        private System.Windows.Forms.Label lJuvenilContadora;
        private System.Windows.Forms.Label lCadeteContadora;
        private System.Windows.Forms.Label lQuerubinContadora;
        private System.Windows.Forms.Label lAmateurContadora;
        private System.Windows.Forms.Label lInfantilContadora;
        private System.Windows.Forms.Label lBenjaminContadora;
        private System.Windows.Forms.Label lVeteranos;
        private System.Windows.Forms.Label lAmateur;
        private System.Windows.Forms.Label lJuvenil;
        private System.Windows.Forms.Label lCadete;
        private System.Windows.Forms.Label lInfantil;
        private System.Windows.Forms.Label lBenjamin;
        private System.Windows.Forms.Label lQuerubin;
        private System.Windows.Forms.Label lCategorias;
    }
}

