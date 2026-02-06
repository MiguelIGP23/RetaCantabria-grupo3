namespace UserControls
{
    partial class UCImagenPeligroLista
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
            lblPuntoPeligro = new Label();
            lbltxtPuntoPeligro = new Label();
            lbltxtDescripcion = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPuntoPeligro.Location = new Point(22, 20);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(90, 15);
            lblPuntoPeligro.TabIndex = 0;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(115, 20);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(47, 15);
            lbltxtPuntoPeligro.TabIndex = 1;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(302, 20);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(358, 50);
            lbltxtDescripcion.TabIndex = 3;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(219, 20);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "-Descripción:";
            // 
            // UCImagenPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Name = "UCImagenPeligroLista";
            Size = new Size(690, 75);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntoPeligro;
        private Label lbltxtPuntoPeligro;
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
    }
}
