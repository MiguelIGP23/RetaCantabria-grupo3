namespace UserControls
{
    partial class UCImagenPuntoInteres
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
            lblIdImagendeInteres = new Label();
            lblurl = new Label();
            lblDescripcion = new Label();
            lblIdPuntodeInteres = new Label();
            lbltxtIdImagendeInteres = new Label();
            lbltxturl = new Label();
            lbltxtDescripcion = new Label();
            lbltxtIdPuntodeInteres = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIdImagendeInteres
            // 
            lblIdImagendeInteres.AutoSize = true;
            lblIdImagendeInteres.Location = new Point(67, 59);
            lblIdImagendeInteres.Name = "lblIdImagendeInteres";
            lblIdImagendeInteres.Size = new Size(114, 15);
            lblIdImagendeInteres.TabIndex = 0;
            lblIdImagendeInteres.Text = "Id Imagen de Interes";
            // 
            // lblurl
            // 
            lblurl.AutoSize = true;
            lblurl.Location = new Point(67, 97);
            lblurl.Name = "lblurl";
            lblurl.Size = new Size(28, 15);
            lblurl.TabIndex = 1;
            lblurl.Text = "URL";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(67, 143);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblIdPuntodeInteres
            // 
            lblIdPuntodeInteres.AutoSize = true;
            lblIdPuntodeInteres.Location = new Point(67, 187);
            lblIdPuntodeInteres.Name = "lblIdPuntodeInteres";
            lblIdPuntodeInteres.Size = new Size(106, 15);
            lblIdPuntodeInteres.TabIndex = 3;
            lblIdPuntodeInteres.Text = "Id Punto de interes";
            // 
            // lbltxtIdImagendeInteres
            // 
            lbltxtIdImagendeInteres.AutoSize = true;
            lbltxtIdImagendeInteres.Location = new Point(291, 59);
            lbltxtIdImagendeInteres.Name = "lbltxtIdImagendeInteres";
            lbltxtIdImagendeInteres.Size = new Size(119, 15);
            lbltxtIdImagendeInteres.TabIndex = 4;
            lbltxtIdImagendeInteres.Text = "txtIdImagendeInteres";
            // 
            // lbltxturl
            // 
            lbltxturl.AutoSize = true;
            lbltxturl.Location = new Point(291, 97);
            lbltxturl.Name = "lbltxturl";
            lbltxturl.Size = new Size(35, 15);
            lbltxturl.TabIndex = 5;
            lbltxturl.Text = "txturl";
            // 
            // lbltxtDescripcion
            // 
            lbltxtDescripcion.AutoSize = true;
            lbltxtDescripcion.Location = new Point(291, 143);
            lbltxtDescripcion.Name = "lbltxtDescripcion";
            lbltxtDescripcion.Size = new Size(83, 15);
            lbltxtDescripcion.TabIndex = 6;
            lbltxtDescripcion.Text = "txtDescripcion";
            // 
            // lbltxtIdPuntodeInteres
            // 
            lbltxtIdPuntodeInteres.AutoSize = true;
            lbltxtIdPuntodeInteres.Location = new Point(291, 187);
            lbltxtIdPuntodeInteres.Name = "lbltxtIdPuntodeInteres";
            lbltxtIdPuntodeInteres.Size = new Size(111, 15);
            lbltxtIdPuntodeInteres.TabIndex = 7;
            lbltxtIdPuntodeInteres.Text = "txtIdPuntodeInteres";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(67, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 104);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UCImagenPuntoInteres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lbltxtIdPuntodeInteres);
            Controls.Add(lbltxtDescripcion);
            Controls.Add(lbltxturl);
            Controls.Add(lbltxtIdImagendeInteres);
            Controls.Add(lblIdPuntodeInteres);
            Controls.Add(lblDescripcion);
            Controls.Add(lblurl);
            Controls.Add(lblIdImagendeInteres);
            Name = "UCImagenPuntoInteres";
            Size = new Size(454, 355);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdImagendeInteres;
        private Label lblurl;
        private Label lblDescripcion;
        private Label lblIdPuntodeInteres;
        private Label lbltxtIdImagendeInteres;
        private Label lbltxturl;
        private Label lbltxtDescripcion;
        private Label lbltxtIdPuntodeInteres;
        private PictureBox pictureBox1;
    }
}
