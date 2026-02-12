namespace UserControls
{
    partial class UCImagenPeligroCompleto
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
            lbltxtImagenId = new Label();
            lblImagen = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.Location = new Point(35, 189);
            pbImagen.Margin = new Padding(3, 4, 3, 4);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(325, 209);
            pbImagen.TabIndex = 18;
            pbImagen.TabStop = false;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(130, 71);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(230, 89);
            lbltxtDescripcion.TabIndex = 17;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(35, 71);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 20);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(125, 27);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(58, 20);
            lbltxtPuntoPeligro.TabIndex = 15;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPuntoPeligro.Location = new Point(35, 27);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(84, 20);
            lblPuntoPeligro.TabIndex = 14;
            lblPuntoPeligro.Text = "-Nº punto:";
            // 
            // lbltxtImagenId
            // 
            lbltxtImagenId.AutoSize = true;
            lbltxtImagenId.Location = new Point(302, 27);
            lbltxtImagenId.Name = "lbltxtImagenId";
            lbltxtImagenId.Size = new Size(58, 20);
            lbltxtImagenId.TabIndex = 20;
            lbltxtImagenId.Text = "txtNum";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImagen.Location = new Point(202, 27);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(94, 20);
            lblImagen.TabIndex = 19;
            lblImagen.Text = "-Nº imágen:";
            // 
            // UCImagenPeligroCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtImagenId);
            Controls.Add(lblImagen);
            Controls.Add(pbImagen);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCImagenPeligroCompleto";
            Size = new Size(395, 443);
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
        private Label lbltxtImagenId;
        private Label lblImagen;
    }
}
