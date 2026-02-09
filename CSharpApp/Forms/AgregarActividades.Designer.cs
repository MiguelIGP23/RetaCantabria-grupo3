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
            btnCancelar.Location = new Point(441, 264);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(318, 264);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lbl_nombreActividad
            // 
            lbl_nombreActividad.AutoSize = true;
            lbl_nombreActividad.Location = new Point(62, 48);
            lbl_nombreActividad.Name = "lbl_nombreActividad";
            lbl_nombreActividad.Size = new Size(152, 20);
            lbl_nombreActividad.TabIndex = 2;
            lbl_nombreActividad.Text = "Nombre de Actividad";
            // 
            // lblRutaActivida
            // 
            lblRutaActivida.AutoSize = true;
            lblRutaActivida.Location = new Point(62, 119);
            lblRutaActivida.Name = "lblRutaActivida";
            lblRutaActivida.Size = new Size(141, 20);
            lblRutaActivida.TabIndex = 3;
            lblRutaActivida.Text = "Ruta de la actividad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(226, 44);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtNombreRuta
            // 
            txtNombreRuta.Location = new Point(226, 115);
            txtNombreRuta.Margin = new Padding(3, 4, 3, 4);
            txtNombreRuta.Name = "txtNombreRuta";
            txtNombreRuta.Size = new Size(114, 27);
            txtNombreRuta.TabIndex = 5;
            // 
            // AgregarActividades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 320);
            Controls.Add(txtNombreRuta);
            Controls.Add(txtNombre);
            Controls.Add(lblRutaActivida);
            Controls.Add(lbl_nombreActividad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AgregarActividades";
            StartPosition = FormStartPosition.CenterParent;
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