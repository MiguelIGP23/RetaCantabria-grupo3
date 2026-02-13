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
            flpListaPuntos.Location = new Point(40, 40);
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
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(65, 400);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(690, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // PuntosInteresLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(802, 463);
            Controls.Add(btnVolver);
            Controls.Add(flpListaPuntos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PuntosInteresLista";
            StartPosition = FormStartPosition.CenterScreen;
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