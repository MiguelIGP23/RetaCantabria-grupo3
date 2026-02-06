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
            ucPuntoPeligroCompleto1.Location = new Point(30, 42);
            ucPuntoPeligroCompleto1.Name = "ucPuntoPeligroCompleto1";
            ucPuntoPeligroCompleto1.PuntoPeligro = null;
            ucPuntoPeligroCompleto1.Size = new Size(555, 173);
            ucPuntoPeligroCompleto1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(78, 261);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 261);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(313, 261);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnImagenes
            // 
            btnImagenes.Location = new Point(432, 261);
            btnImagenes.Name = "btnImagenes";
            btnImagenes.Size = new Size(104, 23);
            btnImagenes.TabIndex = 4;
            btnImagenes.Text = "Ver imágenes";
            btnImagenes.UseVisualStyleBackColor = true;
            // 
            // PuntoPeligroDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 333);
            Controls.Add(btnImagenes);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVolver);
            Controls.Add(ucPuntoPeligroCompleto1);
            Name = "PuntoPeligroDetalle";
            Text = "PuntoPeligroDetalle";
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