namespace UserControls
{
    partial class UCValoracionLista
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_txtFecha = new Label();
            lbl_txtDificultad = new Label();
            lbl_txtIdValora = new Label();
            lbl_Fecha = new Label();
            lbl_Dificultad = new Label();
            lbl_IdValora = new Label();
            lbl_txtInteresCultural = new Label();
            lbl_InteresC = new Label();
            SuspendLayout();
            // 
            // lbl_txtFecha
            // 
            lbl_txtFecha.AutoSize = true;
            lbl_txtFecha.Location = new Point(127, 60);
            lbl_txtFecha.Name = "lbl_txtFecha";
            lbl_txtFecha.Size = new Size(51, 15);
            lbl_txtFecha.TabIndex = 18;
            lbl_txtFecha.Text = "txtFecha";
            // 
            // lbl_txtDificultad
            // 
            lbl_txtDificultad.AutoSize = true;
            lbl_txtDificultad.Location = new Point(307, 30);
            lbl_txtDificultad.Name = "lbl_txtDificultad";
            lbl_txtDificultad.Size = new Size(71, 15);
            lbl_txtDificultad.TabIndex = 17;
            lbl_txtDificultad.Text = "txtDificultad";
            // 
            // lbl_txtIdValora
            // 
            lbl_txtIdValora.AutoSize = true;
            lbl_txtIdValora.Location = new Point(127, 30);
            lbl_txtIdValora.Name = "lbl_txtIdValora";
            lbl_txtIdValora.Size = new Size(62, 15);
            lbl_txtIdValora.TabIndex = 16;
            lbl_txtIdValora.Text = "txtIdValora";
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(48, 60);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(38, 15);
            lbl_Fecha.TabIndex = 15;
            lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Dificultad
            // 
            lbl_Dificultad.AutoSize = true;
            lbl_Dificultad.Location = new Point(225, 30);
            lbl_Dificultad.Name = "lbl_Dificultad";
            lbl_Dificultad.Size = new Size(58, 15);
            lbl_Dificultad.TabIndex = 14;
            lbl_Dificultad.Text = "Dificultad";
            // 
            // lbl_IdValora
            // 
            lbl_IdValora.AutoSize = true;
            lbl_IdValora.Location = new Point(48, 30);
            lbl_IdValora.Name = "lbl_IdValora";
            lbl_IdValora.Size = new Size(49, 15);
            lbl_IdValora.TabIndex = 13;
            lbl_IdValora.Text = "IdValora";
            // 
            // lbl_txtInteresCultural
            // 
            lbl_txtInteresCultural.AutoSize = true;
            lbl_txtInteresCultural.Location = new Point(321, 60);
            lbl_txtInteresCultural.Name = "lbl_txtInteresCultural";
            lbl_txtInteresCultural.Size = new Size(97, 15);
            lbl_txtInteresCultural.TabIndex = 20;
            lbl_txtInteresCultural.Text = "txtInteresCultural";
            // 
            // lbl_InteresC
            // 
            lbl_InteresC.AutoSize = true;
            lbl_InteresC.Location = new Point(224, 60);
            lbl_InteresC.Name = "lbl_InteresC";
            lbl_InteresC.Size = new Size(87, 15);
            lbl_InteresC.TabIndex = 19;
            lbl_InteresC.Text = "Interes Cultural";
            // 
            // UCValoracionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_txtInteresCultural);
            Controls.Add(lbl_InteresC);
            Controls.Add(lbl_txtFecha);
            Controls.Add(lbl_txtDificultad);
            Controls.Add(lbl_txtIdValora);
            Controls.Add(lbl_Fecha);
            Controls.Add(lbl_Dificultad);
            Controls.Add(lbl_IdValora);
            Name = "UCValoracionLista";
            Size = new Size(447, 105);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_txtFecha;
        private Label lbl_txtDificultad;
        private Label lbl_txtIdValora;
        private Label lbl_Fecha;
        private Label lbl_Dificultad;
        private Label lbl_IdValora;
        private Label lbl_txtInteresCultural;
        private Label lbl_InteresC;
    }
}
