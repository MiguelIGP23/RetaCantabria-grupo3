namespace UserControls
{
    partial class UCPuntoDeInteresLista
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
            lbltxtNombre.Location = new Point(422, 29);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(81, 20);
            lbltxtNombre.TabIndex = 11;
            lbltxtNombre.Text = "txtNombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(351, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "-Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // lbltxtTipo
            // 
            lbltxtTipo.AutoSize = true;
            lbltxtTipo.Location = new Point(213, 29);
            lbltxtTipo.Name = "lbltxtTipo";
            lbltxtTipo.Size = new Size(56, 20);
            lbltxtTipo.TabIndex = 9;
            lbltxtTipo.Text = "txtTipo";
            lbltxtTipo.Click += lbltxtTipo_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTipo.Location = new Point(161, 29);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(50, 20);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "-Tipo:";
            lblTipo.Click += lblTipo_Click;
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(91, 29);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(56, 20);
            lbltxtRuta.TabIndex = 7;
            lbltxtRuta.Text = "txtRuta";
            lbltxtRuta.Click += lbltxtRuta_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(24, 29);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(71, 20);
            lblRuta.TabIndex = 6;
            lblRuta.Text = "-Nº ruta:";
            lblRuta.Click += lblRuta_Click;
            // 
            // UCPuntoDeInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtTipo);
            Controls.Add(lblTipo);
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCPuntoDeInteresLista";
            Size = new Size(686, 80);
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
