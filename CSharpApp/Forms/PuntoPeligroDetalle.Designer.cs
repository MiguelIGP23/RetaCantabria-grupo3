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
            ucPuntoPeligroCompleto1.Location = new Point(12, 14);
            ucPuntoPeligroCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucPuntoPeligroCompleto1.Name = "ucPuntoPeligroCompleto1";
            ucPuntoPeligroCompleto1.PuntoPeligro = null;
            ucPuntoPeligroCompleto1.Size = new Size(634, 231);
            ucPuntoPeligroCompleto1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(47, 272);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(298, 40);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkSeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(47, 312);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(298, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(345, 312);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(298, 40);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnImagenes
            // 
            btnImagenes.BackColor = Color.DarkSeaGreen;
            btnImagenes.FlatAppearance.BorderSize = 0;
            btnImagenes.FlatStyle = FlatStyle.Flat;
            btnImagenes.Location = new Point(345, 272);
            btnImagenes.Margin = new Padding(0);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(298, 40);
            btnImagenes.TabIndex = 4;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = false;
            btnImagenes.Click += btnImagenes_Click;
            // 
            // PuntoPeligroDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(699, 383);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(ucPuntoPeligroCompleto1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntoPeligroDetalle";
            StartPosition = FormStartPosition.CenterScreen;
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