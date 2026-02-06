namespace UserControls
{
    partial class ImagenPeligroCompleto
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
            pbImagen = new PictureBox();
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            lbltxtPuntoPeligro = new Label();
            lblPuntoPeligro = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(31, 142);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(284, 157);
            pbImagen.TabIndex = 18;
            pbImagen.TabStop = false;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(114, 53);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(201, 67);
            lbltxtDescripcion.TabIndex = 17;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(31, 53);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(122, 20);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(47, 15);
            lbltxtPuntoPeligro.TabIndex = 15;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Location = new Point(31, 20);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(87, 15);
            lblPuntoPeligro.TabIndex = 14;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // ImagenPeligroCompleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbImagen);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Name = "ImagenPeligroCompleto";
            Size = new Size(346, 332);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagen;
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
        private Label lbltxtPuntoPeligro;
        private Label lblPuntoPeligro;
    }
}
