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
            flpImagenes.Location = new Point(33, 29);
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
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(36, 456);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(378, 37);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNuevaImagen
            // 
            btnNuevaImagen.BackColor = Color.DarkSeaGreen;
            btnNuevaImagen.FlatAppearance.BorderSize = 0;
            btnNuevaImagen.FlatStyle = FlatStyle.Flat;
            btnNuevaImagen.Location = new Point(414, 456);
            btnNuevaImagen.Margin = new Padding(0);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(419, 37);
            btnNuevaImagen.TabIndex = 2;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = false;
            btnNuevaImagen.Click += btnNuevaImagen_Click;
            // 
            // ImagenesPeligroLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(869, 518);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenesPeligroLista";
            StartPosition = FormStartPosition.CenterScreen;
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