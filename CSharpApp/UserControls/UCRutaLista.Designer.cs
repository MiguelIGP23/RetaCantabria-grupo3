namespace UserControls
{
    partial class UCRutaLista
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
            lbltxtNombre = new Label();
            lblDistancia = new Label();
            lbltxtDistancia = new Label();
            lbltxtDuracion = new Label();
            lblDuracion = new Label();
            lblNombre = new Label();
            lbltxtEstrellas = new Label();
            lblEstrellas = new Label();
            SuspendLayout();
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(74, 25);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(62, 15);
            lbltxtNombre.TabIndex = 1;
            lbltxtNombre.Text = "txtnombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDistancia.Location = new Point(242, 25);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(60, 15);
            lblDistancia.TabIndex = 2;
            lblDistancia.Text = "Distancia:";
            lblDistancia.Click += lblDistancia_Click;
            // 
            // lbltxtDistancia
            // 
            lbltxtDistancia.AutoSize = true;
            lbltxtDistancia.Location = new Point(296, 25);
            lbltxtDistancia.Name = "lbltxtDistancia";
            lbltxtDistancia.Size = new Size(36, 15);
            lbltxtDistancia.TabIndex = 3;
            lbltxtDistancia.Text = "txtDis";
            lbltxtDistancia.Click += lbltxtDistancia_Click;
            // 
            // lbltxtDuracion
            // 
            lbltxtDuracion.AutoSize = true;
            lbltxtDuracion.Location = new Point(430, 25);
            lbltxtDuracion.Name = "lbltxtDuracion";
            lbltxtDuracion.Size = new Size(39, 15);
            lbltxtDuracion.TabIndex = 5;
            lbltxtDuracion.Text = "txtDur";
            lbltxtDuracion.Click += lbltxtDuracion_Click;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracion.Location = new Point(375, 25);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(60, 15);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duración:";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(23, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lbltxtEstrellas
            // 
            lbltxtEstrellas.AutoSize = true;
            lbltxtEstrellas.Location = new Point(549, 25);
            lbltxtEstrellas.Name = "lbltxtEstrellas";
            lbltxtEstrellas.Size = new Size(35, 15);
            lbltxtEstrellas.TabIndex = 7;
            lbltxtEstrellas.Text = "txtEst";
            lbltxtEstrellas.Click += lbltxtEstrellas_Click;
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstrellas.Location = new Point(497, 25);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(55, 15);
            lblEstrellas.TabIndex = 6;
            lblEstrellas.Text = "Estrellas:";
            lblEstrellas.Click += lblEstrellas_Click;
            // 
            // UCRutaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtEstrellas);
            Controls.Add(lblEstrellas);
            Controls.Add(lbltxtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(lbltxtDistancia);
            Controls.Add(lblDistancia);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Name = "UCRutaLista";
            Size = new Size(600, 67);
            Load += UCRutaLista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbltxtNombre;
        private Label lblDistancia;
        private Label lbltxtDistancia;
        private Label lbltxtDuracion;
        private Label lblDuracion;
        private Label lblNombre;
        private Label lbltxtEstrellas;
        private Label lblEstrellas;
    }
}
