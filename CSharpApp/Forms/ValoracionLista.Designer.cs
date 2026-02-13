namespace Forms
{
    partial class ValoracionLista
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
            flp_valoracionLista = new FlowLayoutPanel();
            ucValoracionLista1 = new UserControls.UCValoracionLista();
            btn_Volver = new Button();
            btnNueva = new Button();
            flp_valoracionLista.SuspendLayout();
            SuspendLayout();
            // 
            // flp_valoracionLista
            // 
            flp_valoracionLista.AutoScroll = true;
            flp_valoracionLista.Controls.Add(ucValoracionLista1);
            flp_valoracionLista.Location = new Point(28, 38);
            flp_valoracionLista.Margin = new Padding(3, 4, 3, 4);
            flp_valoracionLista.Name = "flp_valoracionLista";
            flp_valoracionLista.Size = new Size(472, 461);
            flp_valoracionLista.TabIndex = 0;
            // 
            // ucValoracionLista1
            // 
            ucValoracionLista1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ucValoracionLista1.Location = new Point(3, 5);
            ucValoracionLista1.Margin = new Padding(3, 5, 3, 5);
            ucValoracionLista1.Name = "ucValoracionLista1";
            ucValoracionLista1.Size = new Size(438, 140);
            ucValoracionLista1.TabIndex = 0;
            ucValoracionLista1.valoracion = null;
            // 
            // btn_Volver
            // 
            btn_Volver.BackColor = Color.DarkSeaGreen;
            btn_Volver.FlatAppearance.BorderSize = 0;
            btn_Volver.FlatStyle = FlatStyle.Flat;
            btn_Volver.Location = new Point(43, 535);
            btn_Volver.Margin = new Padding(0);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(220, 40);
            btn_Volver.TabIndex = 1;
            btn_Volver.Text = "<--";
            btn_Volver.UseVisualStyleBackColor = false;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.DarkSeaGreen;
            btnNueva.FlatAppearance.BorderSize = 0;
            btnNueva.FlatStyle = FlatStyle.Flat;
            btnNueva.Location = new Point(263, 535);
            btnNueva.Margin = new Padding(0);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(193, 40);
            btnNueva.TabIndex = 2;
            btnNueva.Text = "+";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // ValoracionLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(507, 608);
            Controls.Add(btnNueva);
            Controls.Add(btn_Volver);
            Controls.Add(flp_valoracionLista);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ValoracionLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ValoracionLista";
            Load += ValoracionLista_Load;
            flp_valoracionLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_valoracionLista;
        private Button btn_Volver;
        private UserControls.UCValoracionLista ucValoracionLista1;
        private Button btnNueva;
    }
}