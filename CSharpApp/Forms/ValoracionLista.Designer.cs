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
            flp_valoracionLista.Location = new Point(70, 37);
            flp_valoracionLista.Margin = new Padding(3, 4, 3, 4);
            flp_valoracionLista.Name = "flp_valoracionLista";
            flp_valoracionLista.Size = new Size(580, 270);
            flp_valoracionLista.TabIndex = 0;
            // 
            // ucValoracionLista1
            // 
            ucValoracionLista1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ucValoracionLista1.Location = new Point(3, 5);
            ucValoracionLista1.Margin = new Padding(3, 5, 3, 5);
            ucValoracionLista1.Name = "ucValoracionLista1";
            ucValoracionLista1.Size = new Size(511, 140);
            ucValoracionLista1.TabIndex = 0;
            ucValoracionLista1.valoracion = null;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(186, 340);
            btn_Volver.Margin = new Padding(3, 4, 3, 4);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(86, 31);
            btn_Volver.TabIndex = 1;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(363, 340);
            btnNueva.Margin = new Padding(3, 4, 3, 4);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(86, 31);
            btnNueva.TabIndex = 2;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // ValoracionLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 412);
            Controls.Add(btnNueva);
            Controls.Add(btn_Volver);
            Controls.Add(flp_valoracionLista);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ValoracionLista";
            StartPosition = FormStartPosition.CenterParent;
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