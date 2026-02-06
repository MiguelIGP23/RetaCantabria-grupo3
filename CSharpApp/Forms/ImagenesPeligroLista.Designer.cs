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
            flpImagenes.Location = new Point(50, 55);
            flpImagenes.Name = "flpImagenes";
            flpImagenes.Size = new Size(700, 295);
            flpImagenes.TabIndex = 0;
            // 
            // ucImagenPeligroLista1
            // 
            ucImagenPeligroLista1.ImagenPeligro = null;
            ucImagenPeligroLista1.Location = new Point(3, 3);
            ucImagenPeligroLista1.Name = "ucImagenPeligroLista1";
            ucImagenPeligroLista1.Size = new Size(690, 75);
            ucImagenPeligroLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(212, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnNuevaImagen
            // 
            btnNuevaImagen.Location = new Point(453, 376);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(112, 23);
            btnNuevaImagen.TabIndex = 2;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = true;
            // 
            // ImagenesPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenes);
            Name = "ImagenesPeligroLista";
            Text = "ImagenesPeligroLista";
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