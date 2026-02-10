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
            lbl_id = new Label();
            lbl_fecha = new Label();
            lbl_dificultad = new Label();
            lbl_InteresC = new Label();
            lbl_txtIdValora = new Label();
            lbl_txtDificultad = new Label();
            lbl_txtFecha = new Label();
            lbl_txtInteresCultural = new Label();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(79, 47);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(25, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "-Id:";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(235, 47);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(46, 15);
            lbl_fecha.TabIndex = 1;
            lbl_fecha.Text = "-Fecha:";
            // 
            // lbl_dificultad
            // 
            lbl_dificultad.AutoSize = true;
            lbl_dificultad.Location = new Point(52, 80);
            lbl_dificultad.Name = "lbl_dificultad";
            lbl_dificultad.Size = new Size(66, 15);
            lbl_dificultad.TabIndex = 2;
            lbl_dificultad.Text = "-Dificultad:";
            // 
            // lbl_InteresC
            // 
            lbl_InteresC.AutoSize = true;
            lbl_InteresC.Location = new Point(230, 80);
            lbl_InteresC.Name = "lbl_InteresC";
            lbl_InteresC.Size = new Size(93, 15);
            lbl_InteresC.TabIndex = 3;
            lbl_InteresC.Text = "-Interes cultural:";
            // 
            // lbl_txtIdValora
            // 
            lbl_txtIdValora.AutoSize = true;
            lbl_txtIdValora.Location = new Point(129, 47);
            lbl_txtIdValora.Name = "lbl_txtIdValora";
            lbl_txtIdValora.Size = new Size(62, 15);
            lbl_txtIdValora.TabIndex = 4;
            lbl_txtIdValora.Text = "txtIdValora";
            // 
            // lbl_txtDificultad
            // 
            lbl_txtDificultad.AutoSize = true;
            lbl_txtDificultad.Location = new Point(129, 80);
            lbl_txtDificultad.Name = "lbl_txtDificultad";
            lbl_txtDificultad.Size = new Size(71, 15);
            lbl_txtDificultad.TabIndex = 5;
            lbl_txtDificultad.Text = "txtDificultad";
            // 
            // lbl_txtFecha
            // 
            lbl_txtFecha.AutoSize = true;
            lbl_txtFecha.Location = new Point(308, 47);
            lbl_txtFecha.Name = "lbl_txtFecha";
            lbl_txtFecha.Size = new Size(51, 15);
            lbl_txtFecha.TabIndex = 6;
            lbl_txtFecha.Text = "txtFecha";
            // 
            // lbl_txtInteresCultural
            // 
            lbl_txtInteresCultural.AutoSize = true;
            lbl_txtInteresCultural.Location = new Point(327, 80);
            lbl_txtInteresCultural.Name = "lbl_txtInteresCultural";
            lbl_txtInteresCultural.Size = new Size(97, 15);
            lbl_txtInteresCultural.TabIndex = 7;
            lbl_txtInteresCultural.Text = "txtInteresCultural";
            // 
            // UCValoracionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_txtInteresCultural);
            Controls.Add(lbl_txtFecha);
            Controls.Add(lbl_txtDificultad);
            Controls.Add(lbl_txtIdValora);
            Controls.Add(lbl_InteresC);
            Controls.Add(lbl_dificultad);
            Controls.Add(lbl_fecha);
            Controls.Add(lbl_id);
            Name = "UCValoracionLista";
            Size = new Size(473, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private Label lbl_fecha;
        private Label lbl_dificultad;
        private Label lbl_InteresC;
        private Label lbl_txtIdValora;
        private Label lbl_txtDificultad;
        private Label lbl_txtFecha;
        private Label lbl_txtInteresCultural;
    }
}
