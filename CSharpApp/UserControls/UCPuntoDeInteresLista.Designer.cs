namespace UserControls
{
    partial class UCPuntoDeInteresLista
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
            lblidPuntodeInteres = new Label();
            lbltxtIdPuntoInteres = new Label();
            label3 = new Label();
            label4 = new Label();
            lblLatitud = new Label();
            lbltxtLatitud = new Label();
            lblLongitud = new Label();
            lbltxtLongitud = new Label();
            lblTipo = new Label();
            lbltxtTipo = new Label();
            SuspendLayout();
            // 
            // lblidPuntodeInteres
            // 
            lblidPuntodeInteres.AutoSize = true;
            lblidPuntodeInteres.Location = new Point(21, 33);
            lblidPuntodeInteres.Name = "lblidPuntodeInteres";
            lblidPuntodeInteres.Size = new Size(103, 15);
            lblidPuntodeInteres.TabIndex = 0;
            lblidPuntodeInteres.Text = "idPunto de interes";
            // 
            // lbltxtIdPuntoInteres
            // 
            lbltxtIdPuntoInteres.AutoSize = true;
            lbltxtIdPuntoInteres.Location = new Point(147, 33);
            lbltxtIdPuntoInteres.Name = "lbltxtIdPuntoInteres";
            lbltxtIdPuntoInteres.Size = new Size(98, 15);
            lbltxtIdPuntoInteres.TabIndex = 1;
            lbltxtIdPuntoInteres.Text = "txtIdPuntoInteres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 33);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 33);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "txtNombre";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Location = new Point(500, 33);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(44, 15);
            lblLatitud.TabIndex = 4;
            lblLatitud.Text = "Latitud";
            // 
            // lbltxtLatitud
            // 
            lbltxtLatitud.AutoSize = true;
            lbltxtLatitud.Location = new Point(573, 33);
            lbltxtLatitud.Name = "lbltxtLatitud";
            lbltxtLatitud.Size = new Size(58, 15);
            lbltxtLatitud.TabIndex = 5;
            lbltxtLatitud.Text = "txtLatitud";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(678, 34);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(55, 15);
            lblLongitud.TabIndex = 6;
            lblLongitud.Text = "Longitud";
            // 
            // lbltxtLongitud
            // 
            lbltxtLongitud.AutoSize = true;
            lbltxtLongitud.Location = new Point(755, 34);
            lbltxtLongitud.Name = "lbltxtLongitud";
            lbltxtLongitud.Size = new Size(69, 15);
            lbltxtLongitud.TabIndex = 7;
            lbltxtLongitud.Text = "txtLongitud";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(842, 35);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // lbltxtTipo
            // 
            lbltxtTipo.AutoSize = true;
            lbltxtTipo.Location = new Point(903, 35);
            lbltxtTipo.Name = "lbltxtTipo";
            lbltxtTipo.Size = new Size(44, 15);
            lbltxtTipo.TabIndex = 9;
            lbltxtTipo.Text = "txtTipo";
            // 
            // UCPuntoDeInteres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbltxtTipo);
            Controls.Add(lblTipo);
            Controls.Add(lbltxtLongitud);
            Controls.Add(lblLongitud);
            Controls.Add(lbltxtLatitud);
            Controls.Add(lblLatitud);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbltxtIdPuntoInteres);
            Controls.Add(lblidPuntodeInteres);
            Name = "UCPuntoDeInteres";
            Size = new Size(964, 92);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblidPuntodeInteres;
        private Label lbltxtIdPuntoInteres;
        private Label label3;
        private Label label4;
        private Label lblLatitud;
        private Label lbltxtLatitud;
        private Label lblLongitud;
        private Label lbltxtLongitud;
        private Label lblTipo;
        private Label lbltxtTipo;
    }
}
