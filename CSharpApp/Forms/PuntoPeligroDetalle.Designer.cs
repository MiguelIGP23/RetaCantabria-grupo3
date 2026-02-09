namespace Forms
{
    partial class PuntoPeligroDetalle
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
            ucPuntoPeligroCompleto1 = new UserControls.UCPuntoPeligroCompleto();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnImagenes = new Button();
            SuspendLayout();
            // 
            // ucPuntoPeligroCompleto1
            // 
            ucPuntoPeligroCompleto1.Location = new Point(34, 56);
            ucPuntoPeligroCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucPuntoPeligroCompleto1.Name = "ucPuntoPeligroCompleto1";
            ucPuntoPeligroCompleto1.PuntoPeligro = null;
            ucPuntoPeligroCompleto1.Size = new Size(634, 231);
            ucPuntoPeligroCompleto1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(89, 348);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(224, 348);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(358, 348);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnImagenes
            // 
            btnImagenes.Location = new Point(494, 348);
            btnImagenes.Margin = new Padding(3, 4, 3, 4);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(119, 31);
            btnImagenes.TabIndex = 4;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = true;
            btnImagenes.Click += btnImagenes_Click;
            // 
            // PuntoPeligroDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 444);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(ucPuntoPeligroCompleto1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntoPeligroDetalle";
            Text = "PuntoPeligroDetalle";
            Load += PuntoPeligroDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCPuntoPeligroCompleto ucPuntoPeligroCompleto1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnImagenes;
    }
}