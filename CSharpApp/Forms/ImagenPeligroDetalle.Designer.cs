namespace Forms
{
    partial class ImagenPeligroDetalle
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
            imagenPeligroCompleto1 = new UserControls.UCImagenPeligroCompleto();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // imagenPeligroCompleto1
            // 
            imagenPeligroCompleto1.Location = new Point(12, 12);
            imagenPeligroCompleto1.Name = "imagenPeligroCompleto1";
            imagenPeligroCompleto1.Size = new Size(346, 332);
            imagenPeligroCompleto1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(149, 379);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(40, 379);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Vovler";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // ImagenPeligroDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 428);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(imagenPeligroCompleto1);
            Name = "ImagenPeligroDetalle";
            Text = "ImagenPeligroDetalle";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCImagenPeligroCompleto imagenPeligroCompleto1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}