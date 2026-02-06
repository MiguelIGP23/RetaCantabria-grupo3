namespace Forms
{
    partial class AgregarActividades
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
            txtNombreRuta = new TextBox();
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
            btnAceptar.Location = new Point(278, 198);
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
            // txtNombreRuta
            // 
            txtNombreRuta.Location = new Point(198, 86);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(100, 23);
            txtNombreRuta.TabIndex = 5;
            // 
            // AgregarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 240);
            Controls.Add(txtNombreRuta);
            Controls.Add(txtNombre);
            Controls.Add(lblRutaActivida);
            Controls.Add(lbl_nombreActividad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "AgregarActividades";
            Text = "AgregarActividades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lbl_nombreActividad;
        private Label lblRutaActivida;
        private TextBox txtNombre;
        private TextBox txtNombreRuta;
    }
}