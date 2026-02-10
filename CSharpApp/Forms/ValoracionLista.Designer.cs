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
            flp_valoracionLista.SuspendLayout();
            SuspendLayout();
            // 
            // flp_valoracionLista
            // 
            flp_valoracionLista.Controls.Add(ucValoracionLista1);
            flp_valoracionLista.Location = new Point(61, 28);
            flp_valoracionLista.Name = "flp_valoracionLista";
            flp_valoracionLista.Size = new Size(457, 204);
            flp_valoracionLista.TabIndex = 0;
            // 
            // ucValoracionLista1
            // 
            ucValoracionLista1.Location = new Point(3, 3);
            ucValoracionLista1.Name = "ucValoracionLista1";
            ucValoracionLista1.Size = new Size(447, 105);
            ucValoracionLista1.TabIndex = 0;
            ucValoracionLista1.valoracion = null;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(230, 252);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(75, 23);
            btn_Volver.TabIndex = 1;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // ValoracionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 309);
            Controls.Add(btn_Volver);
            Controls.Add(flp_valoracionLista);
            Name = "ValoracionLista";
            Text = "ValoracionLista";
            Load += ValoracionLista_Load;
            flp_valoracionLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_valoracionLista;
        private Button btn_Volver;
        private UserControls.UCValoracionLista ucValoracionLista1;
    }
}