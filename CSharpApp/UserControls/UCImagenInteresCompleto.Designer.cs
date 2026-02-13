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
            lbltxtImagen = new Label();
            lblImagen = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(139, 75);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(218, 90);
            lbltxtDescripcion.TabIndex = 12;
            lbltxtDescripcion.Text = "txtDescripcion";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(35, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 20);
            lblDescripcion.TabIndex = 11;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoInteres
            // 
            lbltxtPuntoInteres.AutoSize = true;
            lbltxtPuntoInteres.Location = new Point(125, 30);
            lbltxtPuntoInteres.Name = "lbltxtPuntoInteres";
            lbltxtPuntoInteres.Size = new Size(58, 20);
            lbltxtPuntoInteres.TabIndex = 10;
            lbltxtPuntoInteres.Text = "txtNum";
            // 
            // lblPuntoInteres
            // 
            lblPuntoInteres.AutoSize = true;
            lblPuntoInteres.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPuntoInteres.Location = new Point(35, 30);
            lblPuntoInteres.Name = "lblPuntoInteres";
            lblPuntoInteres.Size = new Size(84, 20);
            lblPuntoInteres.TabIndex = 9;
            lblPuntoInteres.Text = "-Nº punto:";
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(32, 193);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(325, 216);
            pbImagen.TabIndex = 13;
            pbImagen.TabStop = false;
            // 
            // lbltxtImagen
            // 
            lbltxtImagen.AutoSize = true;
            lbltxtImagen.Location = new Point(300, 30);
            lbltxtImagen.Name = "lbltxtImagen";
            lbltxtImagen.Size = new Size(58, 20);
            lbltxtImagen.TabIndex = 15;
            lbltxtImagen.Text = "txtNum";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImagen.Location = new Point(200, 30);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(94, 20);
            lblImagen.TabIndex = 14;
            lblImagen.Text = "-Nº imágen:";
            // 
            // UCImagenInteresCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtImagen);
            Controls.Add(lblImagen);
            Controls.Add(pbImagen);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoInteres);
            Controls.Add(lblPuntoInteres);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCImagenInteresCompleto";
            Size = new Size(395, 451);
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
        private Label lbltxtImagen;
        private Label lblImagen;
    }
}
