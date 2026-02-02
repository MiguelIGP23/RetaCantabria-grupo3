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
            lblNombre.Location = new Point(90, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(279, 24);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(16, 24);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(42, 24);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(30, 15);
            lbltxtId.TabIndex = 10;
            lbltxtId.Text = "txtId";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(150, 24);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(64, 15);
            lbltxtNombre.TabIndex = 11;
            lbltxtNombre.Text = "txtNombre";
            // 
            // lbltxtApellido
            // 
            lbltxtApellido.AutoSize = true;
            lbltxtApellido.Location = new Point(339, 24);
            lbltxtApellido.Name = "lbltxtApellido";
            lbltxtApellido.Size = new Size(64, 15);
            lbltxtApellido.TabIndex = 12;
            lbltxtApellido.Text = "txtApellido";
            // 
            // UCUsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtApellido);
            Controls.Add(lbltxtNombre);
            Controls.Add(lbltxtId);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblId);
            Name = "UCUsuarioLista";
            Size = new Size(500, 63);
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
