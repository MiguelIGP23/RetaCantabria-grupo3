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
            lbltxtNombre.Location = new Point(93, 33);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(78, 20);
            lbltxtNombre.TabIndex = 1;
            lbltxtNombre.Text = "txtnombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDistancia.Location = new Point(259, 33);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(77, 20);
            lblDistancia.TabIndex = 2;
            lblDistancia.Text = "Distancia:";
            lblDistancia.Click += lblDistancia_Click;
            // 
            // lbltxtDistancia
            // 
            lbltxtDistancia.AutoSize = true;
            lbltxtDistancia.Location = new Point(334, 33);
            lbltxtDistancia.Name = "lbltxtDistancia";
            lbltxtDistancia.Size = new Size(47, 20);
            lbltxtDistancia.TabIndex = 3;
            lbltxtDistancia.Text = "txtDis";
            lbltxtDistancia.Click += lbltxtDistancia_Click;
            // 
            // lbltxtDuracion
            // 
            lbltxtDuracion.AutoSize = true;
            lbltxtDuracion.Location = new Point(474, 33);
            lbltxtDuracion.Name = "lbltxtDuracion";
            lbltxtDuracion.Size = new Size(50, 20);
            lbltxtDuracion.TabIndex = 5;
            lbltxtDuracion.Text = "txtDur";
            lbltxtDuracion.Click += lbltxtDuracion_Click;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracion.Location = new Point(397, 33);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(76, 20);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duración:";
            lblDuracion.Click += lblDuracion_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(26, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lbltxtEstrellas
            // 
            lbltxtEstrellas.AutoSize = true;
            lbltxtEstrellas.Location = new Point(627, 33);
            lbltxtEstrellas.Name = "lbltxtEstrellas";
            lbltxtEstrellas.Size = new Size(45, 20);
            lbltxtEstrellas.TabIndex = 7;
            lbltxtEstrellas.Text = "txtEst";
            lbltxtEstrellas.Click += lbltxtEstrellas_Click;
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstrellas.Location = new Point(538, 33);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(92, 20);
            lblEstrellas.TabIndex = 6;
            lblEstrellas.Text = "Puntuación:";
            lblEstrellas.Click += lblEstrellas_Click;
            // 
            // UCRutaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtEstrellas);
            Controls.Add(lblEstrellas);
            Controls.Add(lbltxtDuracion);
            Controls.Add(lblDuracion);
            Controls.Add(lbltxtDistancia);
            Controls.Add(lblDistancia);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCRutaLista";
            Size = new Size(686, 89);
            Click += UCRutaLista_Click;
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
