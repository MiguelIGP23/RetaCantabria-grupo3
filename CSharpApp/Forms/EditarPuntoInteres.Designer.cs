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
            lbltxtId = new Label();
            lblId = new Label();
            lbltxtIdRuta = new Label();
            lblRutaId = new Label();
            cbTipo = new ComboBox();
            tbCaractetisticas = new TextBox();
            lblCaracteristicas = new Label();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).BeginInit();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(479, 64);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(257, 27);
            tbNombre.TabIndex = 86;
            // 
            // nudTimestamp
            // 
            nudTimestamp.Location = new Point(670, 145);
            nudTimestamp.Margin = new Padding(3, 4, 3, 4);
            nudTimestamp.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTimestamp.Name = "nudTimestamp";
            nudTimestamp.Size = new Size(66, 27);
            nudTimestamp.TabIndex = 85;
            nudTimestamp.TextAlign = HorizontalAlignment.Right;
            // 
            // nudElevacion
            // 
            nudElevacion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudElevacion.Location = new Point(486, 145);
            nudElevacion.Margin = new Padding(3, 4, 3, 4);
            nudElevacion.Maximum = new decimal(new int[] { 3800, 0, 0, 0 });
            nudElevacion.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudElevacion.Name = "nudElevacion";
            nudElevacion.Size = new Size(66, 27);
            nudElevacion.TabIndex = 83;
            nudElevacion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLongitud
            // 
            nudLongitud.DecimalPlaces = 4;
            nudLongitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongitud.Location = new Point(294, 145);
            nudLongitud.Margin = new Padding(3, 4, 3, 4);
            nudLongitud.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitud.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(83, 27);
            nudLongitud.TabIndex = 82;
            nudLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLatitud
            // 
            nudLatitud.DecimalPlaces = 4;
            nudLatitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatitud.Location = new Point(112, 145);
            nudLatitud.Margin = new Padding(3, 4, 3, 4);
            nudLatitud.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitud.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitud.Name = "nudLatitud";
            nudLatitud.Size = new Size(81, 27);
            nudLatitud.TabIndex = 81;
            nudLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(405, 265);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(331, 107);
            tbDescripcion.TabIndex = 79;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(405, 427);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 78;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(248, 427);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 77;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(405, 221);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 76;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(577, 148);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(92, 20);
            lblTimestamp.TabIndex = 75;
            lblTimestamp.Text = "-Timestamp:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(46, 221);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(48, 20);
            lblTipo.TabIndex = 74;
            lblTipo.Text = "-Tipo:";
            // 
            // lblElevacion
            // 
            lblElevacion.AutoSize = true;
            lblElevacion.Location = new Point(405, 148);
            lblElevacion.Name = "lblElevacion";
            lblElevacion.Size = new Size(81, 20);
            lblElevacion.TabIndex = 72;
            lblElevacion.Text = "-Elevación:";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(215, 148);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(77, 20);
            lblLongitud.TabIndex = 71;
            lblLongitud.Text = "-Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Location = new Point(46, 148);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(64, 20);
            lblLatitud.TabIndex = 70;
            lblLatitud.Text = "-Latitud:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(405, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 68;
            lblNombre.Text = "-Nombre:";
            // 
            // lbltxtId
            // 
            lbltxtId.AutoSize = true;
            lbltxtId.Location = new Point(126, 64);
            lbltxtId.Name = "lbltxtId";
            lbltxtId.Size = new Size(39, 20);
            lbltxtId.TabIndex = 67;
            lbltxtId.Text = "txtId";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(46, 64);
            lblId.Name = "lblId";
            lblId.Size = new Size(78, 20);
            lblId.TabIndex = 66;
            lblId.Text = "-Nº punto:";
            // 
            // lbltxtIdRuta
            // 
            lbltxtIdRuta.AutoSize = true;
            lbltxtIdRuta.Location = new Point(286, 64);
            lbltxtIdRuta.Name = "lbltxtIdRuta";
            lbltxtIdRuta.Size = new Size(56, 20);
            lbltxtIdRuta.TabIndex = 89;
            lbltxtIdRuta.Text = "txtRuta";
            // 
            // lblRutaId
            // 
            lblRutaId.AutoSize = true;
            lblRutaId.Location = new Point(218, 64);
            lblRutaId.Name = "lblRutaId";
            lblRutaId.Size = new Size(65, 20);
            lblRutaId.TabIndex = 88;
            lblRutaId.Text = "-Nº ruta:";
            // 
            // cbTipo
            // 
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(100, 218);
            cbTipo.Margin = new Padding(3, 4, 3, 4);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(224, 28);
            cbTipo.TabIndex = 90;
            // 
            // tbCaractetisticas
            // 
            tbCaractetisticas.Location = new Point(46, 320);
            tbCaractetisticas.Margin = new Padding(3, 4, 3, 4);
            tbCaractetisticas.Multiline = true;
            tbCaractetisticas.Name = "tbCaractetisticas";
            tbCaractetisticas.Size = new Size(278, 52);
            tbCaractetisticas.TabIndex = 92;
            // 
            // lblCaracteristicas
            // 
            lblCaracteristicas.AutoSize = true;
            lblCaracteristicas.Location = new Point(46, 281);
            lblCaracteristicas.Name = "lblCaracteristicas";
            lblCaracteristicas.Size = new Size(113, 20);
            lblCaracteristicas.TabIndex = 91;
            lblCaracteristicas.Text = "-Características:";
            // 
            // EditarPuntoInteres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 521);
            Controls.Add(tbCaractetisticas);
            Controls.Add(lblCaracteristicas);
            Controls.Add(cbTipo);
            Controls.Add(lbltxtIdRuta);
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
            Controls.Add(lbltxtId);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarPuntoInteres";
            StartPosition = FormStartPosition.CenterParent;
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
        private Label lbltxtId;
        private Label lblId;
        private Label lbltxtIdRuta;
        private Label lblRutaId;
        private ComboBox cbTipo;
        private TextBox tbCaractetisticas;
        private Label lblCaracteristicas;
    }
}