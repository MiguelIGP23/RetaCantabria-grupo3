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
            btnCancelar.Location = new Point(386, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(54, 198);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbl_nombreActividad
            // 
            lbl_nombreActividad.AutoSize = true;
            lbl_nombreActividad.Location = new Point(54, 36);
            lbl_nombreActividad.Name = "lbl_nombreActividad";
            lbl_nombreActividad.Size = new Size(120, 15);
            lbl_nombreActividad.TabIndex = 2;
            lbl_nombreActividad.Text = "Nombre de Actividad";
            // 
            // lblRutaActivida
            // 
            lblRutaActivida.AutoSize = true;
            lblRutaActivida.Location = new Point(54, 89);
            lblRutaActivida.Name = "lblRutaActivida";
            lblRutaActivida.Size = new Size(110, 15);
            lblRutaActivida.TabIndex = 3;
            lblRutaActivida.Text = "Ruta de la actividad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // cmbRuta
            // 
            cmbRuta.FormattingEnabled = true;
            cmbRuta.Location = new Point(198, 89);
            cmbRuta.Name = "cmbRuta";
            cmbRuta.Size = new Size(106, 23);
            cmbRuta.TabIndex = 5;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(198, 198);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // CrearEditarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 240);
            Controls.Add(btnBorrar);
            Controls.Add(cmbRuta);
            Controls.Add(txtNombre);
            Controls.Add(lblRutaActivida);
            Controls.Add(lbl_nombreActividad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "CrearEditarActividades";
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