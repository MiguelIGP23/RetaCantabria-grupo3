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
            lbltxtPuntoPeligro = new Label();
            lblPuntoPeligro = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(244, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 37;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(101, 250);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(165, 187);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(217, 23);
            tbUrl.TabIndex = 35;
            // 
            // btnBuscarImagen
            // 
            btnBuscarImagen.Location = new Point(36, 183);
            btnBuscarImagen.Name = "btnBuscarImagen";
            btnBuscarImagen.Size = new Size(114, 29);
            btnBuscarImagen.TabIndex = 34;
            btnBuscarImagen.Text = "Buscar imágen";
            btnBuscarImagen.UseVisualStyleBackColor = true;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(119, 72);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(263, 68);
            tbDescripcion.TabIndex = 33;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(36, 75);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 32;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(129, 34);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(47, 15);
            lbltxtPuntoPeligro.TabIndex = 31;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Location = new Point(36, 34);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(87, 15);
            lblPuntoPeligro.TabIndex = 30;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // CrearEditarImagenInteres
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
            Name = "CrearEditarImagenInteres";
            Text = "CrearEditarImagenInteres";
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
        private Label lbltxtPuntoPeligro;
        private Label lblPuntoPeligro;
    }
}