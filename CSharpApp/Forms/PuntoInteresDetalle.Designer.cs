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
            btnImagenes.Location = new Point(497, 489);
            btnImagenes.Margin = new Padding(3, 4, 3, 4);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(119, 31);
            btnImagenes.TabIndex = 8;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(361, 489);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(227, 489);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(93, 489);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(690, 560);
            Controls.Add(ucPuntoDeInteresCompleto1);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntoInteresDetalle";
            Text = "PuntosInteresDetalle";
            Load += PuntoInteresDetalle_Load;
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