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
            flpListaPuntos.Location = new Point(40, 43);
            flpListaPuntos.Margin = new Padding(3, 4, 3, 4);
            flpListaPuntos.Name = "flpListaPuntos";
            flpListaPuntos.Size = new Size(726, 324);
            flpListaPuntos.TabIndex = 0;
            // 
            // ucImagenInteresLista1
            // 
            ucImagenInteresLista1.ImagenInteres = null;
            ucImagenInteresLista1.Location = new Point(3, 5);
            ucImagenInteresLista1.Margin = new Padding(3, 5, 3, 5);
            ucImagenInteresLista1.Name = "ucImagenInteresLista1";
            ucImagenInteresLista1.Size = new Size(712, 100);
            ucImagenInteresLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(310, 391);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // PuntosInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnVolver);
            Controls.Add(flpListaPuntos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntosInteresLista";
            StartPosition = FormStartPosition.CenterParent;
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