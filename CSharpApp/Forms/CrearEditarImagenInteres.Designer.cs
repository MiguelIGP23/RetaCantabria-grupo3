namespace Forms
{
    partial class CrearEditarImagenInteres
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnBuscarImagen = new Button();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            lbltxtPuntoInteres = new Label();
            lblPuntoInteres = new Label();
            lblImagen = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(230, 327);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(206, 39);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(33, 327);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(197, 39);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.BackColor = Color.DarkSeaGreen;
            btnBuscarImagen.FlatAppearance.BorderSize = 0;
            btnBuscarImagen.FlatStyle = FlatStyle.Flat;
            btnBuscarImagen.Location = new Point(33, 238);
            btnBuscarImagen.Margin = new Padding(0);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(130, 39);
            btnBuscarImagen.TabIndex = 34;
            btnBuscarImagen.Text = "Buscar imágen";
            btnBuscarImagen.UseVisualStyleBackColor = false;
            btnBuscarImagen.Click += btnBuscarImagen_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(136, 96);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(300, 89);
            tbDescripcion.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(33, 99);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 32;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoInteres
            // 
            lbltxtPuntoInteres.AutoSize = true;
            lbltxtPuntoInteres.Location = new Point(143, 45);
            lbltxtPuntoInteres.Name = "lbltxtPuntoInteres";
            lbltxtPuntoInteres.Size = new Size(58, 20);
            lbltxtPuntoInteres.TabIndex = 31;
            lbltxtPuntoInteres.Text = "txtNum";
            // 
            // lblPuntoInteres
            // 
            lblPuntoInteres.AutoSize = true;
            lblPuntoInteres.Location = new Point(33, 45);
            lblPuntoInteres.Name = "lblPuntoInteres";
            lblPuntoInteres.Size = new Size(104, 20);
            lblPuntoInteres.TabIndex = 30;
            lblPuntoInteres.Text = "-Punto interés:";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(210, 247);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(81, 20);
            lblImagen.TabIndex = 38;
            lblImagen.Text = "------------";
            // 
            // CrearEditarImagenInteres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(487, 404);
            Controls.Add(lblImagen);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnBuscarImagen);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoInteres);
            Controls.Add(lblPuntoInteres);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarImagenInteres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearEditarImagenInteres";
            Load += CrearEditarImagenInteres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnBuscarImagen;
        private TextBox tbDescripcion;
        private Label lblDescripcion;
        private Label lbltxtPuntoInteres;
        private Label lblPuntoInteres;
        private Label lblImagen;
    }
}