namespace UserControls
{
    partial class UCActividaLista
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
            lblId = new Label();
            lbltxtId = new Label();
            lbltxtNombre = new Label();
            lblNombre = new Label();
            lbltxtRuta = new Label();
            lblRuta = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(28, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(80, 15);
            lblId.TabIndex = 0;
            lblId.Text = "-Nº actividad:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(114, 24);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(30, 15);
            lbltxtId.TabIndex = 1;
            lbltxtId.Text = "txtId";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(93, 59);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(64, 15);
            lbltxtNombre.TabIndex = 3;
            lbltxtNombre.Text = "txtNombre";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "-Nombre:";
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(246, 24);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(44, 15);
            lbltxtRuta.TabIndex = 5;
            lbltxtRuta.Text = "txtRuta";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(187, 24);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(53, 15);
            lblRuta.TabIndex = 4;
            lblRuta.Text = "-Nº ruta:";
            // 
            // UCActividaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtId);
            Controls.Add(lblId);
            Name = "UCActividaLista";
            Size = new Size(400, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lbltxtId;
        private Label lbltxtNombre;
        private Label lblNombre;
        private Label lbltxtRuta;
        private Label lblRuta;
    }
}
