namespace Forms
{
    partial class CrearEditarActividades
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            btnAceptar = new Button();
            lbl_nombreActividad = new Label();
            lblRutaActivida = new Label();
            txtNombre = new TextBox();
            cmbRuta = new ComboBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(208, 200);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 38);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.DarkSeaGreen;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(324, 200);
            btnAceptar.Margin = new Padding(0);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 38);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbl_nombreActividad
            // 
            lbl_nombreActividad.AutoSize = true;
            lbl_nombreActividad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_nombreActividad.Location = new Point(44, 46);
            lbl_nombreActividad.Name = "lbl_nombreActividad";
            lbl_nombreActividad.Size = new Size(77, 20);
            lbl_nombreActividad.TabIndex = 2;
            lbl_nombreActividad.Text = "-Nombre:";
            // 
            // lblRutaActivida
            // 
            lblRutaActivida.AutoSize = true;
            lblRutaActivida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRutaActivida.Location = new Point(44, 117);
            lblRutaActivida.Name = "lblRutaActivida";
            lblRutaActivida.Size = new Size(52, 20);
            lblRutaActivida.TabIndex = 3;
            lblRutaActivida.Text = "-Ruta:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(208, 42);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 27);
            txtNombre.TabIndex = 4;
            // 
            // cmbRuta
            // 
            cmbRuta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRuta.FormattingEnabled = true;
            cmbRuta.Location = new Point(208, 117);
            cmbRuta.Margin = new Padding(3, 4, 3, 4);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(237, 28);
            cmbRuta.TabIndex = 5;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.DarkSeaGreen;
            btnBorrar.FlatAppearance.BorderSize = 0;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Location = new Point(82, 200);
            btnBorrar.Margin = new Padding(0);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(126, 38);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Eliminar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // CrearEditarActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(511, 278);
            Controls.Add(btnBorrar);
            Controls.Add(cmbRuta);
            Controls.Add(txtNombre);
            Controls.Add(lblRutaActivida);
            Controls.Add(lbl_nombreActividad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarActividades";
            Load += CrearEditarActividades_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lbl_nombreActividad;
        private Label lblRutaActivida;
        private TextBox txtNombre;
        private ComboBox cmbRuta;
        private Button btnBorrar;
    }
}