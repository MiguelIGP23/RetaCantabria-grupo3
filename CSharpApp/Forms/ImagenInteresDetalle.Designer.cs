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
            ucImagenInteresCompleto1.Location = new Point(14, 32);
            ucImagenInteresCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucImagenInteresCompleto1.Name = "ucImagenInteresCompleto1";
            ucImagenInteresCompleto1.Size = new Size(395, 443);
            ucImagenInteresCompleto1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(47, 508);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(293, 508);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(171, 508);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // ImagenInteresDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 571);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(ucImagenInteresCompleto1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenInteresDetalle";
            Text = "ImagenInteresDetalle";
            Load += ImagenInteresDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCImagenInteresCompleto ucImagenInteresCompleto1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnEditar;
    }
}