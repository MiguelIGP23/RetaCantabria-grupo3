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
            imagenPeligroCompleto1.Font = new Font("Segoe UI", 9F);
            imagenPeligroCompleto1.ImagenPeligro = null;
            imagenPeligroCompleto1.Location = new Point(14, 16);
            imagenPeligroCompleto1.Margin = new Padding(3, 5, 3, 5);
            imagenPeligroCompleto1.Name = "imagenPeligroCompleto1";
            imagenPeligroCompleto1.Size = new Size(395, 443);
            imagenPeligroCompleto1.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(170, 505);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 31);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(291, 505);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(46, 505);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ImagenPeligroDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 571);
            Controls.Add(btnVolver);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(imagenPeligroCompleto1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenPeligroDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImagenPeligroDetalle";
            Load += ImagenPeligroDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCImagenPeligroCompleto imagenPeligroCompleto1;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnVolver;
    }
}