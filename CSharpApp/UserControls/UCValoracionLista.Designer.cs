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
            lbl_id.Location = new Point(90, 63);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(31, 20);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "-Id:";
            lbl_id.Click += lbl_id_Click;
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Location = new Point(269, 63);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(56, 20);
            lbl_fecha.TabIndex = 1;
            lbl_fecha.Text = "-Fecha:";
            lbl_fecha.Click += lbl_fecha_Click;
            // 
            // lbl_dificultad
            // 
            lbl_dificultad.AutoSize = true;
            lbl_dificultad.Location = new Point(59, 107);
            lbl_dificultad.Name = "lbl_dificultad";
            lbl_dificultad.Size = new Size(83, 20);
            lbl_dificultad.TabIndex = 2;
            lbl_dificultad.Text = "-Dificultad:";
            lbl_dificultad.Click += lbl_dificultad_Click;
            // 
            // lbl_InteresC
            // 
            lbl_InteresC.AutoSize = true;
            lbl_InteresC.Location = new Point(263, 107);
            lbl_InteresC.Name = "lbl_InteresC";
            lbl_InteresC.Size = new Size(115, 20);
            lbl_InteresC.TabIndex = 3;
            lbl_InteresC.Text = "-Interes cultural:";
            lbl_InteresC.Click += lbl_InteresC_Click;
            // 
            // lbl_txtIdValora
            // 
            lbl_txtIdValora.AutoSize = true;
            lbl_txtIdValora.Location = new Point(147, 63);
            lbl_txtIdValora.Name = "lbl_txtIdValora";
            lbl_txtIdValora.Size = new Size(81, 20);
            lbl_txtIdValora.TabIndex = 4;
            lbl_txtIdValora.Text = "txtIdValora";
            lbl_txtIdValora.Click += lbl_txtIdValora_Click;
            // 
            // lbl_txtDificultad
            // 
            lbl_txtDificultad.AutoSize = true;
            lbl_txtDificultad.Location = new Point(147, 107);
            lbl_txtDificultad.Name = "lbl_txtDificultad";
            lbl_txtDificultad.Size = new Size(91, 20);
            lbl_txtDificultad.TabIndex = 5;
            lbl_txtDificultad.Text = "txtDificultad";
            lbl_txtDificultad.Click += lbl_txtDificultad_Click;
            // 
            // lbl_txtFecha
            // 
            lbl_txtFecha.AutoSize = true;
            lbl_txtFecha.Location = new Point(352, 63);
            lbl_txtFecha.Name = "lbl_txtFecha";
            lbl_txtFecha.Size = new Size(64, 20);
            lbl_txtFecha.TabIndex = 6;
            lbl_txtFecha.Text = "txtFecha";
            lbl_txtFecha.Click += lbl_txtFecha_Click;
            // 
            // lbl_txtInteresCultural
            // 
            lbl_txtInteresCultural.AutoSize = true;
            lbl_txtInteresCultural.Location = new Point(374, 107);
            lbl_txtInteresCultural.Name = "lbl_txtInteresCultural";
            lbl_txtInteresCultural.Size = new Size(121, 20);
            lbl_txtInteresCultural.TabIndex = 7;
            lbl_txtInteresCultural.Text = "txtInteresCultural";
            lbl_txtInteresCultural.Click += lbl_txtInteresCultural_Click;
            // 
            // UCValoracionLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_txtInteresCultural);
            Controls.Add(lbl_txtFecha);
            Controls.Add(lbl_txtDificultad);
            Controls.Add(lbl_txtIdValora);
            Controls.Add(lbl_InteresC);
            Controls.Add(lbl_dificultad);
            Controls.Add(lbl_fecha);
            Controls.Add(lbl_id);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCValoracionLista";
            Size = new Size(541, 179);
            Click += UCValoracionLista_Click;
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
