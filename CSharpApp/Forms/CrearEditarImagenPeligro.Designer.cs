namespace Forms
{
    partial class CrearEditarImagenPeligro
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
            lblDescripcion = new Label();
            lbltxtPuntoPeligro = new Label();
            lblPuntoPeligro = new Label();
            tbDescripcion = new TextBox();
            btnBuscarImagen = new Button();
            tbUrl = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 101);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 21;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(147, 45);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(58, 20);
            lbltxtPuntoPeligro.TabIndex = 20;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Location = new Point(41, 45);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(108, 20);
            lblPuntoPeligro.TabIndex = 19;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(147, 97);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(300, 89);
            tbDescripcion.TabIndex = 24;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(41, 245);
            btnBuscarImagen.Margin = new Padding(3, 4, 3, 4);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(130, 39);
            btnBuscarImagen.TabIndex = 26;
            btnBuscarImagen.Text = "Buscar imágen";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += button1_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(200, 251);
            tbUrl.Margin = new Padding(3, 4, 3, 4);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(247, 27);
            tbUrl.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 339);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(279, 339);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // CrearEditarImagenPeligro
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
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarImagenPeligro";
            Text = "CrearEditarImagenPeligro";
            Load += CrearEditarImagenPeligro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescripcion;
        private Label lbltxtPuntoPeligro;
        private Label lblPuntoPeligro;
        private TextBox tbDescripcion;
        private Button btnBuscarImagen;
        private TextBox tbUrl;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}