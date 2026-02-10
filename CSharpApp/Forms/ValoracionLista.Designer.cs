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
            btn_Nuevo = new Button();
            btn_borrar = new Button();
            ucValoracionLista1 = new UserControls.UCValoracionLista();
            flp_valoracionLista.SuspendLayout();
            SuspendLayout();
            // 
            // flp_valoracionLista
            // 
            flp_valoracionLista.Controls.Add(ucValoracionLista1);
            flp_valoracionLista.Location = new Point(61, 28);
            flp_valoracionLista.Name = "flp_valoracionLista";
            flp_valoracionLista.Size = new Size(460, 204);
            flp_valoracionLista.TabIndex = 0;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Location = new Point(321, 254);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(75, 23);
            btn_Nuevo.TabIndex = 1;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(142, 254);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 2;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(570, 309);
            Controls.Add(btn_borrar);
            Controls.Add(btn_Nuevo);
            Controls.Add(flp_valoracionLista);
            Name = "ValoracionLista";
            Text = "ValoracionLista";
            flp_valoracionLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_valoracionLista;
        private Button btn_Nuevo;
        private Button btn_borrar;
        private UserControls.UCValoracionLista ucValoracionLista1;
    }
}