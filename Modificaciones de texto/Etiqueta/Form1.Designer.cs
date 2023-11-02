namespace Etiqueta
{
    partial class Form1
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
            this.bAumentarTamaño = new System.Windows.Forms.Button();
            this.tTexto = new System.Windows.Forms.TextBox();
            this.lTexto = new System.Windows.Forms.Label();
            this.lLetra = new System.Windows.Forms.Label();
            this.NUDLetra = new System.Windows.Forms.NumericUpDown();
            this.lFuente = new System.Windows.Forms.Label();
            this.lEtiqueta = new System.Windows.Forms.Label();
            this.bDisminuirTamaño = new System.Windows.Forms.Button();
            this.bCambioDeColor = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDLetra)).BeginInit();
            this.SuspendLayout();
            // 
            // bAumentarTamaño
            // 
            this.bAumentarTamaño.Location = new System.Drawing.Point(200, 190);
            this.bAumentarTamaño.Name = "bAumentarTamaño";
            this.bAumentarTamaño.Size = new System.Drawing.Size(70, 26);
            this.bAumentarTamaño.TabIndex = 5;
            this.bAumentarTamaño.Text = "&> Tamaño";
            this.bAumentarTamaño.UseVisualStyleBackColor = true;
            this.bAumentarTamaño.Click += new System.EventHandler(this.bAumentarTamaño_Click);
            // 
            // tTexto
            // 
            this.tTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tTexto.Location = new System.Drawing.Point(128, 67);
            this.tTexto.MaxLength = 10;
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(90, 20);
            this.tTexto.TabIndex = 1;
            this.tTexto.Text = "ETIQUETA";
            this.tTexto.TextChanged += new System.EventHandler(this.tTexto_TextChanged);
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Location = new System.Drawing.Point(85, 70);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(37, 13);
            this.lTexto.TabIndex = 5;
            this.lTexto.Text = "Texto:";
            // 
            // lLetra
            // 
            this.lLetra.AutoSize = true;
            this.lLetra.Location = new System.Drawing.Point(88, 112);
            this.lLetra.Name = "lLetra";
            this.lLetra.Size = new System.Drawing.Size(34, 13);
            this.lLetra.TabIndex = 6;
            this.lLetra.Text = "Letra:";
            // 
            // NUDLetra
            // 
            this.NUDLetra.Location = new System.Drawing.Point(128, 110);
            this.NUDLetra.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NUDLetra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDLetra.Name = "NUDLetra";
            this.NUDLetra.Size = new System.Drawing.Size(38, 20);
            this.NUDLetra.TabIndex = 2;
            this.NUDLetra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDLetra.ValueChanged += new System.EventHandler(this.NUDLetra_ValueChanged);
            // 
            // lFuente
            // 
            this.lFuente.AutoSize = true;
            this.lFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFuente.Location = new System.Drawing.Point(172, 112);
            this.lFuente.Name = "lFuente";
            this.lFuente.Size = new System.Drawing.Size(134, 17);
            this.lFuente.TabIndex = 8;
            this.lFuente.Text = "Microsoft Sans Serif";
            // 
            // lEtiqueta
            // 
            this.lEtiqueta.AutoSize = true;
            this.lEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.lEtiqueta.Location = new System.Drawing.Point(124, 24);
            this.lEtiqueta.Name = "lEtiqueta";
            this.lEtiqueta.Size = new System.Drawing.Size(105, 24);
            this.lEtiqueta.TabIndex = 9;
            this.lEtiqueta.Text = "ETIQUETA";
            this.lEtiqueta.TextChanged += new System.EventHandler(this.tTexto_TextChanged);
            // 
            // bDisminuirTamaño
            // 
            this.bDisminuirTamaño.Enabled = false;
            this.bDisminuirTamaño.Location = new System.Drawing.Point(107, 191);
            this.bDisminuirTamaño.Name = "bDisminuirTamaño";
            this.bDisminuirTamaño.Size = new System.Drawing.Size(69, 24);
            this.bDisminuirTamaño.TabIndex = 4;
            this.bDisminuirTamaño.Text = "&<Tamaño";
            this.bDisminuirTamaño.UseVisualStyleBackColor = true;
            this.bDisminuirTamaño.Click += new System.EventHandler(this.bDisminuirTamaño_Click);
            // 
            // bCambioDeColor
            // 
            this.bCambioDeColor.Location = new System.Drawing.Point(116, 160);
            this.bCambioDeColor.Name = "bCambioDeColor";
            this.bCambioDeColor.Size = new System.Drawing.Size(137, 24);
            this.bCambioDeColor.TabIndex = 3;
            this.bCambioDeColor.Text = "Cambio de &Color";
            this.bCambioDeColor.UseVisualStyleBackColor = true;
            this.bCambioDeColor.Click += new System.EventHandler(this.bCambioDeColor_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 254);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(365, 33);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Salir";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Visible = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            this.bCerrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bCerrar_KeyDown);
            this.bCerrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bCerrar_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(365, 287);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCambioDeColor);
            this.Controls.Add(this.bDisminuirTamaño);
            this.Controls.Add(this.lEtiqueta);
            this.Controls.Add(this.lFuente);
            this.Controls.Add(this.NUDLetra);
            this.Controls.Add(this.lLetra);
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.tTexto);
            this.Controls.Add(this.bAumentarTamaño);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Etiqueta";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bCerrar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.NUDLetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAumentarTamaño;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.Label lLetra;
        private System.Windows.Forms.NumericUpDown NUDLetra;
        private System.Windows.Forms.Label lFuente;
        private System.Windows.Forms.Label lEtiqueta;
        private System.Windows.Forms.Button bDisminuirTamaño;
        private System.Windows.Forms.Button bCambioDeColor;
        private System.Windows.Forms.Button bCerrar;
    }
}

