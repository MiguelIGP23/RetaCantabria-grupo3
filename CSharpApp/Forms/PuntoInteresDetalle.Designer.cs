namespace Forms
{
    partial class PuntoInteresDetalle
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
            btnImagenes = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            ucPuntoDeInteresCompleto1 = new UserControls.UCPuntoDeInteresCompleto();
            SuspendLayout();
            // 
            // btnImagenes
            // 
            btnImagenes.Location = new Point(435, 367);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(104, 23);
            btnImagenes.TabIndex = 8;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(316, 367);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(199, 367);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(81, 367);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // ucPuntoDeInteresCompleto1
            // 
            ucPuntoDeInteresCompleto1.Location = new Point(12, 12);
            ucPuntoDeInteresCompleto1.Name = "ucPuntoDeInteresCompleto1";
            ucPuntoDeInteresCompleto1.puntoInteres = null;
            ucPuntoDeInteresCompleto1.Size = new Size(569, 324);
            ucPuntoDeInteresCompleto1.TabIndex = 9;
            // 
            // PuntoInteresDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 420);
            Controls.Add(ucPuntoDeInteresCompleto1);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Name = "PuntoInteresDetalle";
            Text = "PuntosInteresDetalle";
            ResumeLayout(false);
        }

        #endregion

        private Button btnImagenes;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
        private UserControls.UCPuntoDeInteresCompleto ucPuntoDeInteresCompleto1;
    }
}