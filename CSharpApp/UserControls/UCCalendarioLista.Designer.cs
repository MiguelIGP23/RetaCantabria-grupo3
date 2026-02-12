namespace UserControls
{
    partial class UCCalendarioLista
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
            lblFecha = new Label();
            lblTxtFecha = new Label();
            lblTxtRuta = new Label();
            lblRuta = new Label();
            lblTxtHora = new Label();
            lblHora = new Label();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(28, 33);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 20);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "-Fecha:";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblTxtFecha
            // 
            lblTxtFecha.AutoSize = true;
            lblTxtFecha.Location = new Point(93, 33);
            lblTxtFecha.Name = "lblTxtFecha";
            lblTxtFecha.Size = new Size(64, 20);
            lblTxtFecha.TabIndex = 1;
            lblTxtFecha.Text = "txtFecha";
            lblTxtFecha.Click += lblTxtFecha_Click;
            // 
            // lblTxtRuta
            // 
            lblTxtRuta.AutoSize = true;
            lblTxtRuta.Location = new Point(388, 33);
            lblTxtRuta.Name = "lblTxtRuta";
            lblTxtRuta.Size = new Size(50, 20);
            lblTxtRuta.TabIndex = 3;
            lblTxtRuta.Text = "label3";
            lblTxtRuta.Click += lblTxtRuta_Click;
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRuta.Location = new Point(332, 33);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(52, 20);
            lblRuta.TabIndex = 2;
            lblRuta.Text = "-Ruta:";
            lblRuta.Click += lblRuta_Click;
            // 
            // lblTxtHora
            // 
            lblTxtHora.AutoSize = true;
            lblTxtHora.Location = new Point(250, 33);
            lblTxtHora.Name = "lblTxtHora";
            lblTxtHora.Size = new Size(59, 20);
            lblTxtHora.TabIndex = 5;
            lblTxtHora.Text = "txtHora";
            lblTxtHora.Click += lblTxtHora_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.Location = new Point(194, 33);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(53, 20);
            lblHora.TabIndex = 4;
            lblHora.Text = "-Hora:";
            lblHora.Click += lblHora_Click;
            // 
            // UCCalendarioLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTxtHora);
            Controls.Add(lblHora);
            Controls.Add(lblTxtRuta);
            Controls.Add(lblRuta);
            Controls.Add(lblTxtFecha);
            Controls.Add(lblFecha);
            Name = "UCCalendarioLista";
            Size = new Size(680, 90);
            Click += UCCalendarioLista_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblTxtFecha;
        private Label lblTxtRuta;
        private Label lblRuta;
        private Label lblTxtHora;
        private Label lblHora;
    }
}
