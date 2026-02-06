namespace Forms
{
    partial class EditarPuntoInteres
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
            tbNombre = new TextBox();
            nudTimestamp = new NumericUpDown();
            nudElevacion = new NumericUpDown();
            nudLongitud = new NumericUpDown();
            nudLatitud = new NumericUpDown();
            tbDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblDescripcion = new Label();
            lblTimestamp = new Label();
            lblTipo = new Label();
            lblElevacion = new Label();
            lblLongitud = new Label();
            lblLatitud = new Label();
            lblNombre = new Label();
            lbltxtRuta = new Label();
            lblId = new Label();
            txtRutaId = new Label();
            lblRutaId = new Label();
            cbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(419, 48);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(225, 23);
            tbNombre.TabIndex = 86;
            // 
            // nudTimestamp
            // 
            nudTimestamp.Location = new Point(586, 109);
            nudTimestamp.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTimestamp.Name = "nudTimestamp";
            nudTimestamp.Size = new Size(58, 23);
            nudTimestamp.TabIndex = 85;
            nudTimestamp.TextAlign = HorizontalAlignment.Right;
            // 
            // nudElevacion
            // 
            nudElevacion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudElevacion.Location = new Point(425, 109);
            nudElevacion.Maximum = new decimal(new int[] { 3800, 0, 0, 0 });
            nudElevacion.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudElevacion.Name = "nudElevacion";
            nudElevacion.Size = new Size(58, 23);
            nudElevacion.TabIndex = 83;
            nudElevacion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLongitud
            // 
            nudLongitud.DecimalPlaces = 4;
            nudLongitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongitud.Location = new Point(257, 109);
            nudLongitud.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitud.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(73, 23);
            nudLongitud.TabIndex = 82;
            nudLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLatitud
            // 
            nudLatitud.DecimalPlaces = 4;
            nudLatitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatitud.Location = new Point(98, 109);
            nudLatitud.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitud.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitud.Name = "nudLatitud";
            nudLatitud.Size = new Size(71, 23);
            nudLatitud.TabIndex = 81;
            nudLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(437, 173);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(207, 107);
            tbDescripcion.TabIndex = 79;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(219, 257);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 78;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(81, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 77;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(354, 176);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 76;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(505, 111);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(75, 15);
            lblTimestamp.TabIndex = 75;
            lblTimestamp.Text = "-Timestamp:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(40, 178);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 15);
            lblTipo.TabIndex = 74;
            lblTipo.Text = "-Tipo:";
            // 
            // lblElevacion
            // 
            lblElevacion.AutoSize = true;
            lblElevacion.Location = new Point(354, 111);
            lblElevacion.Name = "lblElevacion";
            lblElevacion.Size = new Size(65, 15);
            lblElevacion.TabIndex = 72;
            lblElevacion.Text = "-Elevación:";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(188, 111);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(63, 15);
            lblLongitud.TabIndex = 71;
            lblLongitud.Text = "-Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Location = new Point(40, 111);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(52, 15);
            lblLatitud.TabIndex = 70;
            lblLatitud.Text = "-Latitud:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(354, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 68;
            lblNombre.Text = "-Nombre:";
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(110, 48);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(30, 15);
            lbltxtRuta.TabIndex = 67;
            lbltxtRuta.Text = "txtId";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(40, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(64, 15);
            lblId.TabIndex = 66;
            lblId.Text = "-Nº punto:";
            // 
            // txtRutaId
            // 
            txtRutaId.AutoSize = true;
            txtRutaId.Location = new Point(250, 48);
            txtRutaId.Name = "txtRutaId";
            txtRutaId.Size = new Size(44, 15);
            txtRutaId.TabIndex = 89;
            txtRutaId.Text = "txtRuta";
            // 
            // lblRutaId
            // 
            lblRutaId.AutoSize = true;
            lblRutaId.Location = new Point(191, 48);
            lblRutaId.Name = "lblRutaId";
            lblRutaId.Size = new Size(53, 15);
            lblRutaId.TabIndex = 88;
            lblRutaId.Text = "-Nº ruta:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(85, 176);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(159, 23);
            cbTipo.TabIndex = 90;
            // 
            // EditarPuntoInteres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 316);
            Controls.Add(cbTipo);
            Controls.Add(txtRutaId);
            Controls.Add(lblRutaId);
            Controls.Add(tbNombre);
            Controls.Add(nudTimestamp);
            Controls.Add(nudElevacion);
            Controls.Add(nudLongitud);
            Controls.Add(nudLatitud);
            Controls.Add(tbDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTimestamp);
            Controls.Add(lblTipo);
            Controls.Add(lblElevacion);
            Controls.Add(lblLongitud);
            Controls.Add(lblLatitud);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtRuta);
            Controls.Add(lblId);
            Name = "EditarPuntoInteres";
            Text = "EditarPuntoInteres";
            Load += EditarPuntoInteres_Load;
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbNombre;
        private NumericUpDown nudTimestamp;
        private NumericUpDown nudElevacion;
        private NumericUpDown nudLongitud;
        private NumericUpDown nudLatitud;
        private TextBox tbDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblDescripcion;
        private Label lblTimestamp;
        private Label lblTipo;
        private Label lblElevacion;
        private Label lblLongitud;
        private Label lblLatitud;
        private Label lblNombre;
        private Label lbltxtRuta;
        private Label lblId;
        private Label txtRutaId;
        private Label lblRutaId;
        private ComboBox cbTipo;
    }
}