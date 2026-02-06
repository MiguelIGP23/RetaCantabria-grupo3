namespace Forms
{
    partial class PuntosInteresLista
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
            flpListaPuntos = new FlowLayoutPanel();
            ucImagenInteresLista1 = new UserControls.UCImagenInteresLista();
            btnVolver = new Button();
            flpListaPuntos.SuspendLayout();
            SuspendLayout();
            // 
            // flpListaPuntos
            // 
            flpListaPuntos.AutoScroll = true;
            flpListaPuntos.Controls.Add(ucImagenInteresLista1);
            flpListaPuntos.Location = new Point(35, 32);
            flpListaPuntos.Name = "flpListaPuntos";
            flpListaPuntos.Size = new Size(635, 243);
            flpListaPuntos.TabIndex = 0;
            // 
            // ucImagenInteresLista1
            // 
            ucImagenInteresLista1.ImagenDeInteres = null;
            ucImagenInteresLista1.Location = new Point(3, 3);
            ucImagenInteresLista1.Name = "ucImagenInteresLista1";
            ucImagenInteresLista1.Size = new Size(623, 75);
            ucImagenInteresLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(271, 293);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // PuntosInteresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnVolver);
            Controls.Add(flpListaPuntos);
            Name = "PuntosInteresLista";
            Text = "PuntosInteresLista";
            Load += PuntosInteresLista_Load;
            flpListaPuntos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpListaPuntos;
        private Button btnVolver;
        private UserControls.UCImagenInteresLista ucImagenInteresLista1;
    }
}