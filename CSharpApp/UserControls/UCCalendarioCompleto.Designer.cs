namespace UserControls
{
    partial class UCCalendarioCompleto
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
            lblRutaId = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            lblUsuario = new Label();
            lblInformacion = new Label();
            lbltxtRutaId = new Label();
            lbltxtFecha = new Label();
            lbltxtHora = new Label();
            lbltxtUsuario = new Label();
            lbltxtInformacion = new Label();
            btnRuta = new Button();
            btnVolver = new Button();
            lbltxtNombreRuta = new Label();
            lblNombreRuta = new Label();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // lblRutaId
            // 
            lblRutaId.AutoSize = true;
            lblRutaId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRutaId.Location = new Point(43, 32);
            lblRutaId.Name = "lblRutaId";
            lblRutaId.Size = new Size(71, 20);
            lblRutaId.TabIndex = 0;
            lblRutaId.Text = "-Nº ruta:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(43, 84);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "-Fecha:";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.Location = new Point(253, 84);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(115, 20);
            lblHora.TabIndex = 2;
            lblHora.Text = "-Hora de inicio:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuario.Location = new Point(43, 142);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(127, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "-Organizada por:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInformacion.Location = new Point(43, 199);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(171, 20);
            lblInformacion.TabIndex = 5;
            lblInformacion.Text = "-Información adicional:";
            // 
            // lbltxtRutaId
            // 
            lbltxtRutaId.AutoSize = true;
            lbltxtRutaId.Location = new Point(120, 32);
            lbltxtRutaId.Name = "lbltxtRutaId";
            lbltxtRutaId.Size = new Size(69, 20);
            lbltxtRutaId.TabIndex = 6;
            lbltxtRutaId.Text = "txtIdRuta";
            // 
            // lbltxtFecha
            // 
            lbltxtFecha.AutoSize = true;
            lbltxtFecha.Location = new Point(108, 84);
            lbltxtFecha.Name = "lbltxtFecha";
            lbltxtFecha.Size = new Size(64, 20);
            lbltxtFecha.TabIndex = 7;
            lbltxtFecha.Text = "txtFecha";
            // 
            // lbltxtHora
            // 
            lbltxtHora.AutoSize = true;
            lbltxtHora.Location = new Point(374, 84);
            lbltxtHora.Name = "lbltxtHora";
            lbltxtHora.Size = new Size(59, 20);
            lbltxtHora.TabIndex = 8;
            lbltxtHora.Text = "txtHora";
            // 
            // lbltxtUsuario
            // 
            lbltxtUsuario.AutoSize = true;
            lbltxtUsuario.Location = new Point(176, 142);
            lbltxtUsuario.Name = "lbltxtUsuario";
            lbltxtUsuario.Size = new Size(76, 20);
            lbltxtUsuario.TabIndex = 9;
            lbltxtUsuario.Text = "txtUsuario";
            // 
            // lbltxtInformacion
            // 
            lbltxtInformacion.Location = new Point(238, 199);
            lbltxtInformacion.Name = "lbltxtInformacion";
            lbltxtInformacion.Size = new Size(433, 131);
            lbltxtInformacion.TabIndex = 10;
            lbltxtInformacion.Text = "txtInformacion";
            // 
            // btnRuta
            // 
            btnRuta.BackColor = Color.DarkSeaGreen;
            btnRuta.FlatAppearance.BorderSize = 0;
            btnRuta.FlatStyle = FlatStyle.Flat;
            btnRuta.Location = new Point(102, 250);
            btnRuta.Margin = new Padding(0);
            btnRuta.Name = "btnRuta";
            btnRuta.Size = new Size(112, 40);
            btnRuta.TabIndex = 11;
            btnRuta.Text = "Ver ruta";
            btnRuta.UseVisualStyleBackColor = false;
            btnRuta.Click += btnRuta_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(47, 250);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(55, 40);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "<--";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lbltxtNombreRuta
            // 
            lbltxtNombreRuta.AutoSize = true;
            lbltxtNombreRuta.Location = new Point(336, 32);
            lbltxtNombreRuta.Name = "lbltxtNombreRuta";
            lbltxtNombreRuta.Size = new Size(111, 20);
            lbltxtNombreRuta.TabIndex = 14;
            lbltxtNombreRuta.Text = "txtNombreRuta";
            // 
            // lblNombreRuta
            // 
            lblNombreRuta.AutoSize = true;
            lblNombreRuta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreRuta.Location = new Point(253, 32);
            lblNombreRuta.Name = "lblNombreRuta";
            lblNombreRuta.Size = new Size(77, 20);
            lblNombreRuta.TabIndex = 13;
            lblNombreRuta.Text = "-Nombre:";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(47, 290);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(167, 40);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // UCCalendarioCompleto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditar);
            Controls.Add(lbltxtNombreRuta);
            Controls.Add(lblNombreRuta);
            Controls.Add(btnVolver);
            Controls.Add(btnRuta);
            Controls.Add(lbltxtInformacion);
            Controls.Add(lbltxtUsuario);
            Controls.Add(lbltxtHora);
            Controls.Add(lbltxtFecha);
            Controls.Add(lbltxtRutaId);
            Controls.Add(lblInformacion);
            Controls.Add(lblUsuario);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(lblRutaId);
            Name = "UCCalendarioCompleto";
            Size = new Size(735, 370);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRutaId;
        private Label lblFecha;
        private Label lblHora;
        private Label lblUsuario;
        private Label lblInformacion;
        private Label lbltxtRutaId;
        private Label lbltxtFecha;
        private Label lbltxtHora;
        private Label lbltxtUsuario;
        private Label lbltxtInformacion;
        private Button btnRuta;
        private Button btnVolver;
        private Label lbltxtNombreRuta;
        private Label lblNombreRuta;
        private Button btnEditar;
    }
}
