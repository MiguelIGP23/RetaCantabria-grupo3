namespace UserControls
{
    partial class UCPuntoPeligroLista
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
            lblRuta = new Label();
            lbltxtRuta = new Label();
            lbltxtPosicion = new Label();
            lblPos = new Label();
            lbltxtNombre = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(27, 24);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(55, 15);
            lblRuta.TabIndex = 0;
            lblRuta.Text = "-Nº ruta:";
            lblRuta.Click += lblRuta_Click;
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(86, 24);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(45, 15);
            lbltxtRuta.TabIndex = 1;
            lbltxtRuta.Text = "txtRuta";
            lbltxtRuta.Click += lbltxtRuta_Click;
            // 
            // lbltxtPosicion
            // 
            lbltxtPosicion.AutoSize = true;
            lbltxtPosicion.Location = new Point(218, 24);
            lbltxtPosicion.Name = "lbltxtPosicion";
            lbltxtPosicion.Size = new Size(40, 15);
            lbltxtPosicion.TabIndex = 3;
            lbltxtPosicion.Text = "txtPos";
            lbltxtPosicion.Click += lbltxtPosicion_Click;
            // 
            // lblPos
            // 
            lblPos.AutoSize = true;
            lblPos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPos.Location = new Point(148, 24);
            lblPos.Name = "lblPos";
            lblPos.Size = new Size(60, 15);
            lblPos.TabIndex = 2;
            lblPos.Text = "-Posición:";
            lblPos.Click += lblPos_Click;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(326, 24);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(65, 15);
            lbltxtNombre.TabIndex = 5;
            lbltxtNombre.Text = "txtNombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(264, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "-Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // UCPuntoPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtPosicion);
            Controls.Add(lblPos);
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            Name = "UCPuntoPeligroLista";
            Size = new Size(600, 60);
            Click += UCPuntoPeligroLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRuta;
        private Label lbltxtRuta;
        private Label lbltxtPosicion;
        private Label lblPos;
        private Label lbltxtNombre;
        private Label lblNombre;
    }
}
