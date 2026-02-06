namespace Forms
{
    partial class ImagenInteresDetalle
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
            ucImagenInteresCompleto1 = new UserControls.UCImagenInteresCompleto();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // ucImagenInteresCompleto1
            // 
            ucImagenInteresCompleto1.Location = new Point(12, 24);
            ucImagenInteresCompleto1.Name = "ucImagenInteresCompleto1";
            ucImagenInteresCompleto1.Size = new Size(346, 332);
            ucImagenInteresCompleto1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(41, 381);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Vovler";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(256, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(150, 381);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // ImagenInteresDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 428);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(ucImagenInteresCompleto1);
            Name = "ImagenInteresDetalle";
            Text = "ImagenInteresDetalle";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCImagenInteresCompleto ucImagenInteresCompleto1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnEditar;
    }
}