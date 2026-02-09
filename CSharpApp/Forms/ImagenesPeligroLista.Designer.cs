namespace Forms
{
    partial class ImagenesPeligroLista
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
            flpImagenes = new FlowLayoutPanel();
            ucImagenPeligroLista1 = new UserControls.UCImagenPeligroLista();
            btnVolver = new Button();
            btnNuevaImagen = new Button();
            flpImagenes.SuspendLayout();
            SuspendLayout();
            // 
            // flpImagenes
            // 
            flpImagenes.AutoScroll = true;
            flpImagenes.Controls.Add(ucImagenPeligroLista1);
            flpImagenes.Location = new Point(57, 73);
            flpImagenes.Margin = new Padding(3, 4, 3, 4);
            flpImagenes.Name = "flpImagenes";
            flpImagenes.Size = new Size(800, 393);
            flpImagenes.TabIndex = 0;
            // 
            // ucImagenPeligroLista1
            // 
            ucImagenPeligroLista1.ImagenPeligro = null;
            ucImagenPeligroLista1.Location = new Point(3, 5);
            ucImagenPeligroLista1.Margin = new Padding(3, 5, 3, 5);
            ucImagenPeligroLista1.Name = "ucImagenPeligroLista1";
            ucImagenPeligroLista1.Size = new Size(789, 100);
            ucImagenPeligroLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(242, 501);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNuevaImagen
            // 
            btnNuevaImagen.Location = new Point(518, 501);
            btnNuevaImagen.Margin = new Padding(3, 4, 3, 4);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(128, 31);
            btnNuevaImagen.TabIndex = 2;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = true;
            btnNuevaImagen.Click += btnNuevaImagen_Click;
            // 
            // ImagenesPeligroLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenesPeligroLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ImagenesPeligroLista";
            Load += ImagenesPeligroLista_Load;
            flpImagenes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpImagenes;
        private UserControls.UCImagenPeligroLista ucImagenPeligroLista1;
        private Button btnVolver;
        private Button btnNuevaImagen;
    }
}