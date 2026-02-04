namespace UserControls
{
    partial class UCImagenInteresLista
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
            pbImagenInteres = new PictureBox();
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            lbltxtPuntoInteres = new Label();
            lblPuntoInteres = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagenInteres).BeginInit();
            SuspendLayout();
            // 
            // pbImagenInteres
            // 
            pbImagenInteres.Location = new Point(24, 112);
            pbImagenInteres.Name = "pbImagenInteres";
            pbImagenInteres.Size = new Size(234, 140);
            pbImagenInteres.TabIndex = 9;
            pbImagenInteres.TabStop = false;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(107, 49);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(151, 50);
            lbltxtDescripcion.TabIndex = 8;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(24, 49);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoInteres
            // 
            lbltxtPuntoInteres.AutoSize = true;
            lbltxtPuntoInteres.Location = new Point(117, 18);
            lbltxtPuntoInteres.Name = "lbltxtPuntoInteres";
            lbltxtPuntoInteres.Size = new Size(47, 15);
            lbltxtPuntoInteres.TabIndex = 6;
            lbltxtPuntoInteres.Text = "txtNum";
            // 
            // lblPuntoInteres
            // 
            lblPuntoInteres.AutoSize = true;
            lblPuntoInteres.Location = new Point(24, 18);
            lblPuntoInteres.Name = "lblPuntoInteres";
            lblPuntoInteres.Size = new Size(85, 15);
            lblPuntoInteres.TabIndex = 5;
            lblPuntoInteres.Text = "-Punto interés:";
            // 
            // UCImagenDeInteres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbImagenInteres);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoInteres);
            Controls.Add(lblPuntoInteres);
            Name = "UCImagenDeInteres";
            Size = new Size(281, 278);
            ((System.ComponentModel.ISupportInitialize)pbImagenInteres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagenInteres;
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
        private Label lbltxtPuntoInteres;
        private Label lblPuntoInteres;
    }
}
