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
            flp_Valoracion = new FlowLayoutPanel();
            btn_Volver = new Button();
            btn_Nuevo = new Button();
            ucValoracionLista1 = new UserControls.UCValoracionLista();
            flp_Valoracion.SuspendLayout();
            SuspendLayout();
            // 
            // flp_Valoracion
            // 
            flp_Valoracion.Controls.Add(ucValoracionLista1);
            flp_Valoracion.Location = new Point(49, 12);
            flp_Valoracion.Name = "flp_Valoracion";
            flp_Valoracion.Size = new Size(453, 239);
            flp_Valoracion.TabIndex = 0;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(128, 286);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(75, 23);
            btn_Volver.TabIndex = 1;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(329, 286);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(75, 23);
            btn_Nuevo.TabIndex = 2;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // ucValoracionLista1
            // 
            ucValoracionLista1.Location = new Point(3, 3);
            ucValoracionLista1.Name = "ucValoracionLista1";
            ucValoracionLista1.Size = new Size(447, 105);
            ucValoracionLista1.TabIndex = 0;
            ucValoracionLista1.valoracion = null;
            // 
            // ValoracionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 324);
            Controls.Add(btn_Nuevo);
            Controls.Add(btn_Volver);
            Controls.Add(flp_Valoracion);
            Name = "ValoracionLista";
            Text = "ValoracionLista";
            flp_Valoracion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_Valoracion;
        private Button btn_Volver;
        private Button btn_Nuevo;
        private UserControls.UCValoracionLista ucValoracionLista1;
    }
}