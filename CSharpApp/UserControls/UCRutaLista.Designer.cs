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
            label2 = new Label();
            lblDistancia = new Label();
            lbltxtDistancia = new Label();
            lbltxtDuracion = new Label();
            lblDuracion = new Label();
            lblNombre = new Label();
            lbltxtEstrellas = new Label();
            lblEstrellas = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 25);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "txtnombre";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(260, 25);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(58, 15);
            lblDistancia.TabIndex = 2;
            lblDistancia.Text = "Distancia:";
            // 
            // lbltxtDistancia
            // 
            lbltxtDistancia.AutoSize = true;
            lbltxtDistancia.Location = new Point(324, 25);
            lbltxtDistancia.Name = "lbltxtDistancia";
            lbltxtDistancia.Size = new Size(36, 15);
            lbltxtDistancia.TabIndex = 3;
            lbltxtDistancia.Text = "txtDis";
            // 
            // lbltxtDuracion
            // 
            lbltxtDuracion.AutoSize = true;
            lbltxtDuracion.Location = new Point(439, 25);
            lbltxtDuracion.Name = "lbltxtDuracion";
            lbltxtDuracion.Size = new Size(39, 15);
            lbltxtDuracion.TabIndex = 5;
            lbltxtDuracion.Text = "txtDur";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(375, 25);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(58, 15);
            lblDuracion.TabIndex = 4;
            lblDuracion.Text = "Duración:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 25);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lbltxtEstrellas
            // 
            lbltxtEstrellas.AutoSize = true;
            lbltxtEstrellas.Location = new Point(555, 25);
            lbltxtEstrellas.Name = "lbltxtEstrellas";
            lbltxtEstrellas.Size = new Size(35, 15);
            lbltxtEstrellas.TabIndex = 7;
            lbltxtEstrellas.Text = "txtEst";
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.Location = new Point(497, 25);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(52, 15);
            lblEstrellas.TabIndex = 6;
            lblEstrellas.Text = "Estrellas:";
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
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Name = "UCRutaLista";
            Size = new Size(600, 67);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lblDistancia;
        private Label lbltxtDistancia;
        private Label lbltxtDuracion;
        private Label lblDuracion;
        private Label lblNombre;
        private Label lbltxtEstrellas;
        private Label lblEstrellas;
    }
}
