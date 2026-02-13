namespace Forms
{
    partial class EditarPuntoPeligro
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
            lblDescripcion = new Label();
            lblTimestamp = new Label();
            lblGravedad = new Label();
            lblKilometro = new Label();
            lblElevacion = new Label();
            lblLongitud = new Label();
            lblLatitud = new Label();
            lblPos = new Label();
            lblNombre = new Label();
            lbltxtRuta = new Label();
            lblRuta = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tbDescripcion = new TextBox();
            nudPosicion = new NumericUpDown();
            nudLatitud = new NumericUpDown();
            nudLongitud = new NumericUpDown();
            nudElevacion = new NumericUpDown();
            nudKilometro = new NumericUpDown();
            nudTimestamp = new NumericUpDown();
            tbNombre = new TextBox();
            nudGravedad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPosicion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGravedad).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(401, 224);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 20);
            lblDescripcion.TabIndex = 46;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(215, 224);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(92, 20);
            lblTimestamp.TabIndex = 44;
            lblTimestamp.Text = "-Timestamp:";
            // 
            // lblGravedad
            // 
            lblGravedad.AutoSize = true;
            lblGravedad.Location = new Point(42, 224);
            lblGravedad.Name = "lblGravedad";
            lblGravedad.Size = new Size(82, 20);
            lblGravedad.TabIndex = 42;
            lblGravedad.Text = "-Gravedad:";
            // 
            // lblKilometro
            // 
            lblKilometro.AutoSize = true;
            lblKilometro.Location = new Point(574, 135);
            lblKilometro.Name = "lblKilometro";
            lblKilometro.Size = new Size(84, 20);
            lblKilometro.TabIndex = 40;
            lblKilometro.Text = "-Kilómetro:";
            // 
            // lblElevacion
            // 
            lblElevacion.AutoSize = true;
            lblElevacion.Location = new Point(401, 135);
            lblElevacion.Name = "lblElevacion";
            lblElevacion.Size = new Size(81, 20);
            lblElevacion.TabIndex = 38;
            lblElevacion.Text = "-Elevación:";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(211, 135);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(77, 20);
            lblLongitud.TabIndex = 36;
            lblLongitud.Text = "-Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Location = new Point(42, 135);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(64, 20);
            lblLatitud.TabIndex = 34;
            lblLatitud.Text = "-Latitud:";
            // 
            // lblPos
            // 
            lblPos.AutoSize = true;
            lblPos.Location = new Point(215, 51);
            lblPos.Name = "lblPos";
            lblPos.Size = new Size(72, 20);
            lblPos.TabIndex = 32;
            lblPos.Text = "-Posición:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(424, 51);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(73, 20);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "-Nombre:";
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(110, 51);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(56, 20);
            lbltxtRuta.TabIndex = 29;
            lbltxtRuta.Text = "txtRuta";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(42, 51);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(65, 20);
            lblRuta.TabIndex = 28;
            lblRuta.Text = "-Nº ruta:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkSeaGreen;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(42, 339);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(347, 41);
            btnCancelar.TabIndex = 48;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkSeaGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(389, 339);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(334, 41);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(496, 220);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(227, 76);
            tbDescripcion.TabIndex = 57;
            // 
            // nudPosicion
            // 
            nudPosicion.Location = new Point(290, 48);
            nudPosicion.Margin = new Padding(3, 4, 3, 4);
            nudPosicion.Name = "nudPosicion";
            nudPosicion.Size = new Size(66, 27);
            nudPosicion.TabIndex = 58;
            nudPosicion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLatitud
            // 
            nudLatitud.DecimalPlaces = 4;
            nudLatitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatitud.Location = new Point(109, 132);
            nudLatitud.Margin = new Padding(3, 4, 3, 4);
            nudLatitud.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitud.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitud.Name = "nudLatitud";
            nudLatitud.Size = new Size(81, 27);
            nudLatitud.TabIndex = 59;
            nudLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLongitud
            // 
            nudLongitud.DecimalPlaces = 4;
            nudLongitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongitud.Location = new Point(290, 132);
            nudLongitud.Margin = new Padding(3, 4, 3, 4);
            nudLongitud.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitud.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(83, 27);
            nudLongitud.TabIndex = 60;
            nudLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudElevacion
            // 
            nudElevacion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudElevacion.Location = new Point(482, 132);
            nudElevacion.Margin = new Padding(3, 4, 3, 4);
            nudElevacion.Maximum = new decimal(new int[] { 3800, 0, 0, 0 });
            nudElevacion.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudElevacion.Name = "nudElevacion";
            nudElevacion.Size = new Size(66, 27);
            nudElevacion.TabIndex = 61;
            nudElevacion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudKilometro
            // 
            nudKilometro.Location = new Point(657, 132);
            nudKilometro.Margin = new Padding(3, 4, 3, 4);
            nudKilometro.Name = "nudKilometro";
            nudKilometro.Size = new Size(66, 27);
            nudKilometro.TabIndex = 62;
            nudKilometro.TextAlign = HorizontalAlignment.Right;
            // 
            // nudTimestamp
            // 
            nudTimestamp.Location = new Point(307, 221);
            nudTimestamp.Margin = new Padding(3, 4, 3, 4);
            nudTimestamp.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTimestamp.Name = "nudTimestamp";
            nudTimestamp.Size = new Size(66, 27);
            nudTimestamp.TabIndex = 63;
            nudTimestamp.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(496, 47);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(227, 27);
            tbNombre.TabIndex = 64;
            // 
            // nudGravedad
            // 
            nudGravedad.Location = new Point(123, 220);
            nudGravedad.Margin = new Padding(3, 4, 3, 4);
            nudGravedad.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudGravedad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudGravedad.Name = "nudGravedad";
            nudGravedad.Size = new Size(66, 27);
            nudGravedad.TabIndex = 65;
            nudGravedad.TextAlign = HorizontalAlignment.Right;
            nudGravedad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditarPuntoPeligro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(782, 416);
            Controls.Add(nudGravedad);
            Controls.Add(tbNombre);
            Controls.Add(nudTimestamp);
            Controls.Add(nudKilometro);
            Controls.Add(nudElevacion);
            Controls.Add(nudLongitud);
            Controls.Add(nudLatitud);
            Controls.Add(nudPosicion);
            Controls.Add(tbDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTimestamp);
            Controls.Add(lblGravedad);
            Controls.Add(lblKilometro);
            Controls.Add(lblElevacion);
            Controls.Add(lblLongitud);
            Controls.Add(lblLatitud);
            Controls.Add(lblPos);
            Controls.Add(lblNombre);
            Controls.Add(lbltxtRuta);
            Controls.Add(lblRuta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditarPuntoPeligro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearPuntoPeligro";
            Load += EditarPuntoPeligro_Load;
            ((System.ComponentModel.ISupportInitialize)nudPosicion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGravedad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDescripcion;
        private Label lblTimestamp;
        private Label lblGravedad;
        private Label lblKilometro;
        private Label lblElevacion;
        private Label lblLongitud;
        private Label lblLatitud;
        private Label lblPos;
        private Label lblNombre;
        private Label lbltxtRuta;
        private Label lblRuta;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox tbDescripcion;
        private NumericUpDown nudPosicion;
        private NumericUpDown nudLatitud;
        private NumericUpDown nudLongitud;
        private NumericUpDown nudElevacion;
        private NumericUpDown nudKilometro;
        private NumericUpDown nudTimestamp;
        private TextBox tbNombre;
        private NumericUpDown nudGravedad;
    }
}