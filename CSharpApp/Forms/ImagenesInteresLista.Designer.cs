namespace Forms
{
    partial class ImagenesInteresLista
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
            flpImagenesLista = new FlowLayoutPanel();
            ucImagenInteresLista1 = new UserControls.UCImagenInteresLista();
            btnNuevaImagen = new Button();
            btnVolver = new Button();
            flpImagenesLista.SuspendLayout();
            SuspendLayout();
            // 
            // flpImagenesLista
            // 
            flpImagenesLista.AutoScroll = true;
            flpImagenesLista.Controls.Add(ucImagenInteresLista1);
            flpImagenesLista.Location = new Point(58, 56);
            flpImagenesLista.Margin = new Padding(3, 4, 3, 4);
            flpImagenesLista.Name = "flpImagenesLista";
            flpImagenesLista.Size = new Size(800, 393);
            flpImagenesLista.TabIndex = 0;
            // 
            // ucImagenInteresLista1
            // 
            ucImagenInteresLista1.ImagenInteres = null;
            ucImagenInteresLista1.Location = new Point(3, 5);
            ucImagenInteresLista1.Margin = new Padding(3, 5, 3, 5);
            ucImagenInteresLista1.Name = "ucImagenInteresLista1";
            ucImagenInteresLista1.Size = new Size(789, 100);
            ucImagenInteresLista1.TabIndex = 0;
            // 
            // btnNuevaImagen
            // 
            btnNuevaImagen.Location = new Point(527, 497);
            btnNuevaImagen.Margin = new Padding(3, 4, 3, 4);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(128, 31);
            btnNuevaImagen.TabIndex = 4;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = true;
            btnNuevaImagen.Click += btnNuevaImagen_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(251, 497);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ImagenesInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenesLista);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenesInteresLista";
            Text = "ImagenesInteresLista";
            Load += ImagenesInteresLista_Load;
            flpImagenesLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpImagenesLista;
        private UserControls.UCImagenInteresLista ucImagenInteresLista1;
        private Button btnNuevaImagen;
        private Button btnVolver;
    }
}