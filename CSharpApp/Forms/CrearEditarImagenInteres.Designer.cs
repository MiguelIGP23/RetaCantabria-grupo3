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
            tbUrl = new TextBox();
            btnBuscarImagen = new Button();
            tbDescripcion = new TextBox();
            lblDescripcion = new Label();
            lbltxtPuntoInteres = new Label();
            lblPuntoInteres = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(279, 333);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 333);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(189, 249);
            tbUrl.Margin = new Padding(3, 4, 3, 4);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(247, 27);
            tbUrl.TabIndex = 35;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(41, 244);
            btnBuscarImagen.Margin = new Padding(3, 4, 3, 4);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(130, 39);
            btnBuscarImagen.TabIndex = 34;
            btnBuscarImagen.Text = "Buscar imágen";
            btnBuscarImagen.UseVisualStyleBackColor = true;
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
            lblDescripcion.Location = new Point(41, 100);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 32;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoInteres
            // 
            lbltxtPuntoInteres.AutoSize = true;
            lbltxtPuntoInteres.Location = new Point(151, 45);
            lbltxtPuntoInteres.Name = "lbltxtPuntoInteres";
            lbltxtPuntoInteres.Size = new Size(58, 20);
            lbltxtPuntoInteres.TabIndex = 31;
            lbltxtPuntoInteres.Text = "txtNum";
            // 
            // lblPuntoInteres
            // 
            lblPuntoInteres.AutoSize = true;
            lblPuntoInteres.Location = new Point(41, 45);
            lblPuntoInteres.Name = "lblPuntoInteres";
            lblPuntoInteres.Size = new Size(104, 20);
            lblPuntoInteres.TabIndex = 30;
            lblPuntoInteres.Text = "-Punto interés:";
            // 
            // CrearEditarImagenInteres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 404);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(tbUrl);
            Controls.Add(btnBuscarImagen);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoInteres);
            Controls.Add(lblPuntoInteres);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarImagenInteres";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CrearEditarImagenInteres";
            Load += CrearEditarImagenInteres_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox tbUrl;
        private Button btnBuscarImagen;
        private TextBox tbDescripcion;
        private Label lblDescripcion;
        private Label lbltxtPuntoInteres;
        private Label lblPuntoInteres;
    }
}