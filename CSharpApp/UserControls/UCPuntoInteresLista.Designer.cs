namespace UserControls
{
    partial class UCPuntoInteresLista
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
            lblNombre = new Label();
            lbltxtTipo = new Label();
            lblTipo = new Label();
            lbltxtRuta = new Label();
            lblRuta = new Label();
            SuspendLayout();
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(369, 22);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(65, 15);
            lbltxtNombre.TabIndex = 11;
            lbltxtNombre.Text = "txtNombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(307, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "-Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lbltxtTipo
            // 
            lbltxtTipo.AutoSize = true;
            lbltxtTipo.Location = new Point(186, 22);
            lbltxtTipo.Name = "lbltxtTipo";
            lbltxtTipo.Size = new Size(44, 15);
            lbltxtTipo.TabIndex = 9;
            lbltxtTipo.Text = "txtTipo";
            lbltxtTipo.Click += lbltxtTipo_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipo.Location = new Point(141, 22);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "-Tipo:";
            lblTipo.Click += lblTipo_Click;
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(80, 22);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(45, 15);
            lbltxtRuta.TabIndex = 7;
            lbltxtRuta.Text = "txtRuta";
            lbltxtRuta.Click += lbltxtRuta_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(21, 22);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(55, 15);
            lblRuta.TabIndex = 6;
            lblRuta.Text = "-Nº ruta:";
            lblRuta.Click += lblRuta_Click;
            // 
            // UCPuntoInteresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtTipo);
            Controls.Add(lblTipo);
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            Name = "UCPuntoInteresLista";
            Size = new Size(600, 60);
            Click += UCPuntoDeInteresLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltxtNombre;
        private Label lblNombre;
        private Label lbltxtTipo;
        private Label lblTipo;
        private Label lbltxtRuta;
        private Label lblRuta;
    }
}
