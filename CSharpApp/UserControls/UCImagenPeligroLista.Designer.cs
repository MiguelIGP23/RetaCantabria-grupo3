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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPuntoPeligro
            // 
            lblPuntoPeligro.AutoSize = true;
            lblPuntoPeligro.Location = new Point(22, 25);
            lblPuntoPeligro.Name = "lblPuntoPeligro";
            lblPuntoPeligro.Size = new Size(87, 15);
            lblPuntoPeligro.TabIndex = 0;
            lblPuntoPeligro.Text = "-Punto peligro:";
            // 
            // lbltxtPuntoPeligro
            // 
            lbltxtPuntoPeligro.AutoSize = true;
            lbltxtPuntoPeligro.Location = new Point(115, 25);
            lbltxtPuntoPeligro.Name = "lbltxtPuntoPeligro";
            lbltxtPuntoPeligro.Size = new Size(47, 15);
            lbltxtPuntoPeligro.TabIndex = 1;
            lbltxtPuntoPeligro.Text = "txtNum";
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.Location = new Point(105, 56);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(151, 50);
            lbltxtDescripcion.TabIndex = 3;
            lbltxtDescripcion.Text = "Barranco al borde del acantilado con pirañas y tiburones uuuuuuuh";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 56);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "-Descripción:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 140);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UCImagenPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lbltxtPuntoPeligro);
            Controls.Add(lblPuntoPeligro);
            Name = "UCImagenPeligroLista";
            Size = new Size(281, 278);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPuntoPeligro;
        private Label lbltxtPuntoPeligro;
        private Label lbltxtDescripcion;
        private Label lblDescripcion;
        private PictureBox pictureBox1;
    }
}
