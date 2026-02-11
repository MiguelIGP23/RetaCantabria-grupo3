namespace UserControls
{
    partial class UCUsuarioLista
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblId = new Label();
            lbltxtId = new Label();
            lbltxtNombre = new Label();
            lbltxtApellido = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(103, 32);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "-Nombre:";
            lblNombre.Click += lblNombre_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(319, 32);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(77, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "-Apellido:";
            lblApellido.Click += lblApellido_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.Location = new Point(18, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(33, 20);
            lblId.TabIndex = 5;
            lblId.Text = "-Id:";
            lblId.Click += lblId_Click;
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(48, 32);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(39, 20);
            lbltxtId.TabIndex = 10;
            lbltxtId.Text = "txtId";
            lbltxtId.Click += lbltxtId_Click_1;
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(171, 32);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(81, 20);
            lbltxtNombre.TabIndex = 11;
            lbltxtNombre.Text = "txtNombre";
            lbltxtNombre.Click += lbltxtNombre_Click_1;
            // 
            // lbltxtApellido
            // 
            lbltxtApellido.AutoSize = true;
            lbltxtApellido.Location = new Point(387, 32);
            lbltxtApellido.Name = "lbltxtApellido";
            lbltxtApellido.Size = new Size(83, 20);
            lbltxtApellido.TabIndex = 12;
            lbltxtApellido.Text = "txtApellido";
            lbltxtApellido.Click += lbltxtApellido_Click_1;
            // 
            // UCUsuarioLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtApellido);
            Controls.Add(lbltxtNombre);
            Controls.Add(lbltxtId);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCUsuarioLista";
            Size = new Size(571, 84);
            Click += UCUsuarioLista_Click_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblId;
        private Label lbltxtId;
        private Label lbltxtNombre;
        private Label lbltxtApellido;
    }
}
