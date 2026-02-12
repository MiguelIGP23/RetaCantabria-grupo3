namespace UserControls
{
    partial class UCImagenPeligroLista
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
            lblImagenId = new Label();
            lbltxtImagenId = new Label();
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblImagenId
            // 
            lblImagenId.AutoSize = true;
            lblImagenId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImagenId.Location = new Point(25, 27);
            lblImagenId.Name = "lblImagenId";
            lblImagenId.Size = new Size(94, 20);
            lblImagenId.TabIndex = 0;
            lblImagenId.Text = "-Nº imágen:";
            lblImagenId.Click += lblPuntoPeligro_Click;
            // 
            // lbltxtImagenId
            // 
            lbltxtImagenId.AutoSize = true;
            lbltxtImagenId.Location = new Point(125, 27);
            lbltxtImagenId.Name = "lbltxtImagenId";
            lbltxtImagenId.Size = new Size(89, 20);
            lbltxtImagenId.TabIndex = 1;
            lbltxtImagenId.Text = "txtImagenId";
            lbltxtImagenId.Click += lbltxtPuntoPeligro_Click;
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(356, 27);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(409, 67);
            lbltxtDescripcion.TabIndex = 3;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            lbltxtDescripcion.Click += lbltxtDescripcion_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(250, 27);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "-Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // UCImagenPeligroLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtImagenId);
            Controls.Add(lblImagenId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCImagenPeligroLista";
            Size = new Size(789, 100);
            Click += UCImagenPeligroLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblImagenId;
        private Label lbltxtImagenId;
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
    }
}
