namespace UserControls
{
    partial class UCImagenInteresCompleto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            lbltxtPuntoInteres = new Label();
            lblPuntoInteres = new Label();
            pbImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(111, 56);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(191, 67);
            lbltxtDescripcion.TabIndex = 12;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(28, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 15);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoInteres
            // 
            lbltxtPuntoInteres.AutoSize = true;
            lbltxtPuntoInteres.Location = new Point(119, 23);
            lbltxtPuntoInteres.Name = "lbltxtPuntoInteres";
            lbltxtPuntoInteres.Size = new Size(47, 15);
            lbltxtPuntoInteres.TabIndex = 10;
            lbltxtPuntoInteres.Text = "txtNum";
            // 
            // lblPuntoInteres
            // 
            lblPuntoInteres.AutoSize = true;
            lblPuntoInteres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPuntoInteres.Location = new Point(28, 23);
            lblPuntoInteres.Name = "lblPuntoInteres";
            lblPuntoInteres.Size = new Size(90, 15);
            lblPuntoInteres.TabIndex = 9;
            lblPuntoInteres.Text = "-Punto interés:";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(28, 145);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(284, 157);
            pbImagen.TabIndex = 13;
            pbImagen.TabStop = false;
            // 
            // UCImagenInteresCompleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbImagen);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoInteres);
            Controls.Add(lblPuntoInteres);
            Name = "UCImagenInteresCompleto";
            Size = new Size(346, 332);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxtDescripcion;
        private Label lblDescripcion;
        private Label lbltxtPuntoInteres;
        private Label lblPuntoInteres;
        private PictureBox pbImagen;
    }
}
