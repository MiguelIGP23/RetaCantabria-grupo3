namespace UserControls
{
    partial class UCImagenInteresLista
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
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            lbltxtId = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(340, 24);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(419, 61);
            lbltxtDescripcion.TabIndex = 8;
            lbltxtDescripcion.Text = "txtDescripcion";
            lbltxtDescripcion.Click += lbltxtDescripcion_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(238, 24);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 20);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "-Descripción:";
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(125, 24);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(58, 20);
            lbltxtId.TabIndex = 6;
            lbltxtId.Text = "txtNum";
            lbltxtId.Click += lbltxtPuntoInteres_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(25, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 20);
            lblId.TabIndex = 5;
            lblId.Text = "-Nº imágen:";
            lblId.Click += lblPuntoInteres_Click;
            // 
            // UCImagenInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtId);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCImagenInteresLista";
            Size = new Size(789, 100);
            Click += UCImagenInteresLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
        private Label lbltxtId;
        private Label lblId;
    }
}
