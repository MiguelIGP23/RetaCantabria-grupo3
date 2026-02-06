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
            mudGravedad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudPosicion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mudGravedad).BeginInit();
            SuspendLayout();
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(351, 168);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(77, 15);
            lblDescripcion.TabIndex = 46;
            lblDescripcion.Text = "-Descripción:";
            // 
            // lblTimestamp
            // 
            lblTimestamp.AutoSize = true;
            lblTimestamp.Location = new Point(188, 168);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(75, 15);
            lblTimestamp.TabIndex = 44;
            lblTimestamp.Text = "-Timestamp:";
            // 
            // lblGravedad
            // 
            lblGravedad.AutoSize = true;
            lblGravedad.Location = new Point(37, 168);
            lblGravedad.Name = "lblGravedad";
            lblGravedad.Size = new Size(65, 15);
            lblGravedad.TabIndex = 42;
            lblGravedad.Text = "-Gravedad:";
            // 
            // lblKilometro
            // 
            lblKilometro.AutoSize = true;
            lblKilometro.Location = new Point(502, 101);
            lblKilometro.Name = "lblKilometro";
            lblKilometro.Size = new Size(67, 15);
            lblKilometro.TabIndex = 40;
            lblKilometro.Text = "-Kilómetro:";
            // 
            // lblElevacion
            // 
            lblElevacion.AutoSize = true;
            lblElevacion.Location = new Point(351, 101);
            lblElevacion.Name = "lblElevacion";
            lblElevacion.Size = new Size(65, 15);
            lblElevacion.TabIndex = 38;
            lblElevacion.Text = "-Elevación:";
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(185, 101);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(63, 15);
            lblLongitud.TabIndex = 36;
            lblLongitud.Text = "-Longitud:";
            // 
            // lblLatitud
            // 
            lblLatitud.AutoSize = true;
            lblLatitud.Location = new Point(37, 101);
            lblLatitud.Name = "lblLatitud";
            lblLatitud.Size = new Size(52, 15);
            lblLatitud.TabIndex = 34;
            lblLatitud.Text = "-Latitud:";
            // 
            // lblPos
            // 
            lblPos.AutoSize = true;
            lblPos.Location = new Point(188, 38);
            lblPos.Name = "lblPos";
            lblPos.Size = new Size(60, 15);
            lblPos.TabIndex = 32;
            lblPos.Text = "-Posición:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(371, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 15);
            lblNombre.TabIndex = 30;
            lblNombre.Text = "-Nombre:";
            // 
            // lbltxtRuta
            // 
            lbltxtRuta.AutoSize = true;
            lbltxtRuta.Location = new Point(96, 38);
            lbltxtRuta.Name = "lbltxtRuta";
            lbltxtRuta.Size = new Size(44, 15);
            lbltxtRuta.TabIndex = 29;
            lbltxtRuta.Text = "txtRuta";
            // 
            // lblRuta
            // 
            lblRuta.AutoSize = true;
            lblRuta.Location = new Point(37, 38);
            lblRuta.Name = "lblRuta";
            lblRuta.Size = new Size(53, 15);
            lblRuta.TabIndex = 28;
            lblRuta.Text = "-Nº ruta:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(203, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 48;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(341, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 49;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(434, 165);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(199, 58);
            tbDescripcion.TabIndex = 57;
            // 
            // nudPosicion
            // 
            nudPosicion.Location = new Point(254, 36);
            nudPosicion.Name = "nudPosicion";
            nudPosicion.Size = new Size(58, 23);
            nudPosicion.TabIndex = 58;
            nudPosicion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLatitud
            // 
            nudLatitud.DecimalPlaces = 4;
            nudLatitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatitud.Location = new Point(95, 99);
            nudLatitud.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatitud.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatitud.Name = "nudLatitud";
            nudLatitud.Size = new Size(71, 23);
            nudLatitud.TabIndex = 59;
            nudLatitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLongitud
            // 
            nudLongitud.DecimalPlaces = 4;
            nudLongitud.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLongitud.Location = new Point(254, 99);
            nudLongitud.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLongitud.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLongitud.Name = "nudLongitud";
            nudLongitud.Size = new Size(73, 23);
            nudLongitud.TabIndex = 60;
            nudLongitud.TextAlign = HorizontalAlignment.Right;
            // 
            // nudElevacion
            // 
            nudElevacion.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudElevacion.Location = new Point(422, 99);
            nudElevacion.Maximum = new decimal(new int[] { 3800, 0, 0, 0 });
            nudElevacion.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudElevacion.Name = "nudElevacion";
            nudElevacion.Size = new Size(58, 23);
            nudElevacion.TabIndex = 61;
            nudElevacion.TextAlign = HorizontalAlignment.Right;
            // 
            // nudKilometro
            // 
            nudKilometro.Location = new Point(575, 99);
            nudKilometro.Name = "nudKilometro";
            nudKilometro.Size = new Size(58, 23);
            nudKilometro.TabIndex = 62;
            nudKilometro.TextAlign = HorizontalAlignment.Right;
            // 
            // nudTimestamp
            // 
            nudTimestamp.Location = new Point(269, 166);
            nudTimestamp.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudTimestamp.Name = "nudTimestamp";
            nudTimestamp.Size = new Size(58, 23);
            nudTimestamp.TabIndex = 63;
            nudTimestamp.TextAlign = HorizontalAlignment.Right;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(434, 35);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(199, 23);
            tbNombre.TabIndex = 64;
            // 
            // mudGravedad
            // 
            mudGravedad.Location = new Point(108, 165);
            mudGravedad.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            mudGravedad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mudGravedad.Name = "mudGravedad";
            mudGravedad.Size = new Size(58, 23);
            mudGravedad.TabIndex = 65;
            mudGravedad.TextAlign = HorizontalAlignment.Right;
            mudGravedad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EditarPuntoPeligro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 312);
            Controls.Add(mudGravedad);
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
            Name = "EditarPuntoPeligro";
            Text = "CrearPuntoPeligro";
            ((System.ComponentModel.ISupportInitialize)nudPosicion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLongitud).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudElevacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilometro).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTimestamp).EndInit();
            ((System.ComponentModel.ISupportInitialize)mudGravedad).EndInit();
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
        private NumericUpDown mudGravedad;
    }
}