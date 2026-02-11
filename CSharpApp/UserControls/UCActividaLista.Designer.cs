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
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(32, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(105, 20);
            lblId.TabIndex = 0;
            lblId.Text = "-Nº actividad:";
            lblId.Click += lblId_Click;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(130, 32);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(39, 20);
            lbltxtId.TabIndex = 1;
            lbltxtId.Text = "txtId";
            lbltxtId.Click += lbltxtId_Click;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(447, 32);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(81, 20);
            lbltxtNombre.TabIndex = 3;
            lbltxtNombre.Text = "txtNombre";
            lbltxtNombre.Click += lbltxtNombre_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(373, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "-Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(281, 32);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(56, 20);
            lbltxtRuta.TabIndex = 5;
            lbltxtRuta.Text = "txtRuta";
            lbltxtRuta.Click += lbltxtRuta_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(214, 32);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(71, 20);
            lblRuta.TabIndex = 4;
            lblRuta.Text = "-Nº ruta:";
            lblRuta.Click += lblRuta_Click;
            // 
            // UCActividaLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            Controls.Add(lbltxtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtId);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCActividaLista";
            Size = new Size(711, 93);
            Click += UCActividaLista_Click;
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
