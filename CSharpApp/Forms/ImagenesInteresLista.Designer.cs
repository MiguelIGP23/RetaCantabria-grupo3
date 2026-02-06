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
            btnNuevaImagen = new Button();
            btnVolver = new Button();
            ucImagenInteresLista1 = new UserControls.UCImagenInteresLista();
            flpImagenesLista.SuspendLayout();
            SuspendLayout();
            // 
            // flpImagenesLista
            // 
            flpImagenesLista.AutoScroll = true;
            flpImagenesLista.Controls.Add(ucImagenInteresLista1);
            flpImagenesLista.Location = new Point(51, 42);
            flpImagenesLista.Name = "flpImagenesLista";
            flpImagenesLista.Size = new Size(700, 295);
            flpImagenesLista.TabIndex = 0;
            // 
            // btnNuevaImagen
            // 
            btnNuevaImagen.Location = new Point(461, 373);
            btnNuevaImagen.Name = "btnNuevaImagen";
            btnNuevaImagen.Size = new Size(112, 23);
            btnNuevaImagen.TabIndex = 4;
            btnNuevaImagen.Text = "Nueva imágen";
            btnNuevaImagen.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(220, 373);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // ucImagenInteresLista1
            // 
            ucImagenInteresLista1.ImagenDeInteres = null;
            ucImagenInteresLista1.Location = new Point(3, 3);
            ucImagenInteresLista1.Name = "ucImagenInteresLista1";
            ucImagenInteresLista1.Size = new Size(690, 75);
            ucImagenInteresLista1.TabIndex = 0;
            // 
            // ImagenesInteresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevaImagen);
            Controls.Add(btnVolver);
            Controls.Add(flpImagenesLista);
            Name = "ImagenesInteresLista";
            Text = "ImagenesInteresLista";
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