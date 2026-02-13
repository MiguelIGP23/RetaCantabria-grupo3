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
            flpImagenesLista.Location = new Point(38, 35);
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
            btnNuevaImagen.BackColor = Color.DarkSeaGreen;
            btnNuevaImagen.FlatAppearance.BorderSize = 0;
            btnNuevaImagen.FlatStyle = FlatStyle.Flat;
            btnNuevaImagen.Location = new Point(431, 465);
            btnNuevaImagen.Margin = new Padding(0);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(399, 36);
            btnNuevaImagen.TabIndex = 4;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = false;
            btnNuevaImagen.Click += btnNuevaImagen_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(38, 465);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(393, 36);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // ImagenesInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(880, 530);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenesLista);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ImagenesInteresLista";
            StartPosition = FormStartPosition.CenterScreen;
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