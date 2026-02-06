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
            lblDescripcion.Location = new Point(36, 76);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 21;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(129, 34);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(47, 15);
            lbltxtPuntoPeligro.TabIndex = 20;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Location = new Point(36, 34);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(87, 15);
            lblPuntoPeligro.TabIndex = 19;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(129, 73);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(263, 68);
            tbDescripcion.TabIndex = 24;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(36, 184);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(114, 29);
            btnBuscarImagen.TabIndex = 26;
            btnBuscarImagen.Text = "Buscar imágen";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            btnBuscarImagen.Click += button1_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(175, 188);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(217, 23);
            tbUrl.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(101, 254);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(244, 254);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 29;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // CrearEditarImagenPeligro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 303);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(tbUrl);
            Controls.Add(btnBuscarImagen);
            Controls.Add(tbDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Name = "CrearEditarImagenPeligro";
            Text = "CrearEditarImagenPeligro";
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