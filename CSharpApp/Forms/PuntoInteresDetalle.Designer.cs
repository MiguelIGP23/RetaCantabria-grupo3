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
            ucPuntoDeInteresCompleto1 = new UserControls.UCPuntoInteresCompleto();
            SuspendLayout();
            // 
            // btnImagenes
            // 
            btnImagenes.BackColor = Color.DarkSeaGreen;
            btnImagenes.FlatAppearance.BorderSize = 0;
            btnImagenes.FlatStyle = FlatStyle.Flat;
            btnImagenes.Location = new Point(356, 473);
            btnImagenes.Margin = new Padding(0);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(298, 40);
            btnImagenes.TabIndex = 8;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = false;
            btnImagenes.Click += btnImagenes_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(356, 513);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(298, 40);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkSeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(58, 513);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(298, 40);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(58, 473);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(298, 40);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ucPuntoDeInteresCompleto1
            // 
            ucPuntoDeInteresCompleto1.Location = new Point(14, 16);
            ucPuntoDeInteresCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucPuntoDeInteresCompleto1.Name = "ucPuntoDeInteresCompleto1";
            ucPuntoDeInteresCompleto1.PuntoInteres = null;
            ucPuntoDeInteresCompleto1.Size = new Size(650, 432);
            ucPuntoDeInteresCompleto1.TabIndex = 9;
            // 
            // PuntoInteresDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(690, 583);
            Controls.Add(ucPuntoDeInteresCompleto1);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntoInteresDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PuntosInteresDetalle";
            Load += PuntoInteresDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnImagenes;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
        private UserControls.UCPuntoInteresCompleto ucPuntoDeInteresCompleto1;
    }
}