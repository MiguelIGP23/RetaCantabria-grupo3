namespace UserControls
{
    partial class UCUsuarioCompleto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblId = new Label();
            lblRol = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblNombre = new Label();
            lbltxtNombre = new Label();
            lbltxtEmail = new Label();
            lbltxtApellido = new Label();
            lbltxtRol = new Label();
            lbltxtId = new Label();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(23, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(177, 20);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 1;
            lblRol.Text = "Rol:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(177, 76);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 134);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(23, 76);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lbltxtNombre
            // 
            lbltxtNombre.AutoSize = true;
            lbltxtNombre.Location = new Point(83, 76);
            lbltxtNombre.Name = "lbltxtNombre";
            lbltxtNombre.Size = new Size(64, 15);
            lbltxtNombre.TabIndex = 9;
            lbltxtNombre.Text = "txtNombre";
            // 
            // lbltxtEmail
            // 
            lbltxtEmail.AutoSize = true;
            lbltxtEmail.Location = new Point(68, 134);
            lbltxtEmail.Name = "lbltxtEmail";
            lbltxtEmail.RightToLeft = RightToLeft.Yes;
            lbltxtEmail.Size = new Size(49, 15);
            lbltxtEmail.TabIndex = 8;
            lbltxtEmail.Text = "txtEmail";
            // 
            // lbltxtApellido
            // 
            lbltxtApellido.AutoSize = true;
            lbltxtApellido.Location = new Point(237, 76);
            lbltxtApellido.Name = "lbltxtApellido";
            lbltxtApellido.Size = new Size(64, 15);
            lbltxtApellido.TabIndex = 7;
            lbltxtApellido.Text = "txtApellido";
            // 
            // lbltxtRol
            // 
            lbltxtRol.AutoSize = true;
            lbltxtRol.Location = new Point(210, 20);
            lbltxtRol.Name = "lbltxtRol";
            lbltxtRol.Size = new Size(37, 15);
            lbltxtRol.TabIndex = 6;
            lbltxtRol.Text = "txtRol";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(49, 20);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(30, 15);
            lbltxtId.TabIndex = 5;
            lbltxtId.Text = "txtId";
            // 
            // UCUsuarioCompleto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtNombre);
            Controls.Add(lbltxtEmail);
            Controls.Add(lbltxtApellido);
            Controls.Add(lbltxtRol);
            Controls.Add(lbltxtId);
            Controls.Add(lblNombre);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblRol);
            Controls.Add(lblId);
            Name = "UCUsuarioCompleto";
            Size = new Size(347, 203);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblRol;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblNombre;
        private Label lbltxtNombre;
        private Label lbltxtEmail;
        private Label lbltxtApellido;
        private Label lbltxtRol;
        private Label lbltxtId;
    }
}
