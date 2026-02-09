namespace Forms
{
    partial class RutasLista
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
            flpRutas = new FlowLayoutPanel();
            btnAgregar = new Button();
            btnLogout = new Button();
            ckNombre = new CheckBox();
            tbNombre = new TextBox();
            ckPuntuacion = new CheckBox();
            nudPuntuacionMin = new NumericUpDown();
            nudPuntuacionMax = new NumericUpDown();
            nudDistanciaMax = new NumericUpDown();
            nudDistanciaMin = new NumericUpDown();
            ckDistancia = new CheckBox();
            nudDuracionMax = new NumericUpDown();
            nudDuracionMin = new NumericUpDown();
            ckDuracion = new CheckBox();
            ckPrimavera = new CheckBox();
            ckVerano = new CheckBox();
            ckInvierno = new CheckBox();
            ckOtono = new CheckBox();
            ckClasificacion = new CheckBox();
            cbClasificacion = new ComboBox();
            ckAccesible = new CheckBox();
            ckFamiliar = new CheckBox();
            ckEsfuerzo = new CheckBox();
            nudRiesgoMax = new NumericUpDown();
            nudRiesgoMin = new NumericUpDown();
            ckRiesgo = new CheckBox();
            nudEsfuerzoMax = new NumericUpDown();
            nudEsfuerzoMin = new NumericUpDown();
            btnFiltrar = new Button();
            ckTemporada = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudPuntuacionMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPuntuacionMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanciaMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanciaMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRiesgoMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRiesgoMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEsfuerzoMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEsfuerzoMin).BeginInit();
            SuspendLayout();
            // 
            // flpRutas
            // 
            flpRutas.AutoScroll = true;
            flpRutas.Location = new Point(96, 430);
            flpRutas.Margin = new Padding(3, 4, 3, 4);
            flpRutas.Name = "flpRutas";
            flpRutas.Size = new Size(701, 399);
            flpRutas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(549, 883);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(270, 884);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ckNombre
            // 
            ckNombre.AutoSize = true;
            ckNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckNombre.Location = new Point(96, 53);
            ckNombre.Name = "ckNombre";
            ckNombre.Size = new Size(89, 24);
            ckNombre.TabIndex = 8;
            ckNombre.Text = "Nombre";
            ckNombre.TextAlign = ContentAlignment.MiddleCenter;
            ckNombre.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(188, 49);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(260, 27);
            tbNombre.TabIndex = 9;
            // 
            // ckPuntuacion
            // 
            ckPuntuacion.AutoSize = true;
            ckPuntuacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckPuntuacion.Location = new Point(472, 51);
            ckPuntuacion.Name = "ckPuntuacion";
            ckPuntuacion.Size = new Size(187, 24);
            ckPuntuacion.TabIndex = 10;
            ckPuntuacion.Text = "Puntuación (min,max)";
            ckPuntuacion.TextAlign = ContentAlignment.MiddleCenter;
            ckPuntuacion.UseVisualStyleBackColor = true;
            // 
            // nudPuntuacionMin
            // 
            nudPuntuacionMin.Location = new Point(665, 48);
            nudPuntuacionMin.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudPuntuacionMin.Name = "nudPuntuacionMin";
            nudPuntuacionMin.Size = new Size(60, 27);
            nudPuntuacionMin.TabIndex = 11;
            nudPuntuacionMin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudPuntuacionMax
            // 
            nudPuntuacionMax.Location = new Point(737, 48);
            nudPuntuacionMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudPuntuacionMax.Name = "nudPuntuacionMax";
            nudPuntuacionMax.Size = new Size(60, 27);
            nudPuntuacionMax.TabIndex = 12;
            nudPuntuacionMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDistanciaMax
            // 
            nudDistanciaMax.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudDistanciaMax.Location = new Point(375, 114);
            nudDistanciaMax.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudDistanciaMax.Name = "nudDistanciaMax";
            nudDistanciaMax.Size = new Size(73, 27);
            nudDistanciaMax.TabIndex = 15;
            nudDistanciaMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDistanciaMin
            // 
            nudDistanciaMin.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudDistanciaMin.Location = new Point(291, 114);
            nudDistanciaMin.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudDistanciaMin.Name = "nudDistanciaMin";
            nudDistanciaMin.Size = new Size(73, 27);
            nudDistanciaMin.TabIndex = 14;
            nudDistanciaMin.TextAlign = HorizontalAlignment.Right;
            // 
            // ckDistancia
            // 
            ckDistancia.AutoSize = true;
            ckDistancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckDistancia.Location = new Point(96, 117);
            ckDistancia.Name = "ckDistancia";
            ckDistancia.Size = new Size(172, 24);
            ckDistancia.TabIndex = 13;
            ckDistancia.Text = "Distancia (min,max)";
            ckDistancia.TextAlign = ContentAlignment.MiddleCenter;
            ckDistancia.UseVisualStyleBackColor = true;
            // 
            // nudDuracionMax
            // 
            nudDuracionMax.Location = new Point(724, 118);
            nudDuracionMax.Maximum = new decimal(new int[] { 720, 0, 0, 0 });
            nudDuracionMax.Name = "nudDuracionMax";
            nudDuracionMax.Size = new Size(73, 27);
            nudDuracionMax.TabIndex = 18;
            nudDuracionMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDuracionMin
            // 
            nudDuracionMin.Location = new Point(645, 118);
            nudDuracionMin.Maximum = new decimal(new int[] { 720, 0, 0, 0 });
            nudDuracionMin.Name = "nudDuracionMin";
            nudDuracionMin.Size = new Size(73, 27);
            nudDuracionMin.TabIndex = 17;
            nudDuracionMin.TextAlign = HorizontalAlignment.Right;
            // 
            // ckDuracion
            // 
            ckDuracion.AutoSize = true;
            ckDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckDuracion.Location = new Point(472, 118);
            ckDuracion.Name = "ckDuracion";
            ckDuracion.Size = new Size(171, 24);
            ckDuracion.TabIndex = 16;
            ckDuracion.Text = "Duración (min,max)";
            ckDuracion.TextAlign = ContentAlignment.MiddleCenter;
            ckDuracion.UseVisualStyleBackColor = true;
            // 
            // ckPrimavera
            // 
            ckPrimavera.AutoSize = true;
            ckPrimavera.Location = new Point(219, 324);
            ckPrimavera.Name = "ckPrimavera";
            ckPrimavera.Size = new Size(97, 24);
            ckPrimavera.TabIndex = 19;
            ckPrimavera.Text = "Primavera";
            ckPrimavera.TextAlign = ContentAlignment.MiddleCenter;
            ckPrimavera.UseVisualStyleBackColor = true;
            // 
            // ckVerano
            // 
            ckVerano.AutoSize = true;
            ckVerano.Location = new Point(322, 324);
            ckVerano.Name = "ckVerano";
            ckVerano.Size = new Size(77, 24);
            ckVerano.TabIndex = 24;
            ckVerano.Text = "Verano";
            ckVerano.TextAlign = ContentAlignment.MiddleCenter;
            ckVerano.UseVisualStyleBackColor = true;
            // 
            // ckInvierno
            // 
            ckInvierno.AutoSize = true;
            ckInvierno.Location = new Point(485, 324);
            ckInvierno.Name = "ckInvierno";
            ckInvierno.Size = new Size(84, 24);
            ckInvierno.TabIndex = 26;
            ckInvierno.Text = "Invierno";
            ckInvierno.TextAlign = ContentAlignment.MiddleCenter;
            ckInvierno.UseVisualStyleBackColor = true;
            // 
            // ckOtono
            // 
            ckOtono.AutoSize = true;
            ckOtono.Location = new Point(406, 324);
            ckOtono.Name = "ckOtono";
            ckOtono.Size = new Size(73, 24);
            ckOtono.TabIndex = 25;
            ckOtono.Text = "Otoño";
            ckOtono.TextAlign = ContentAlignment.MiddleCenter;
            ckOtono.UseVisualStyleBackColor = true;
            // 
            // ckClasificacion
            // 
            ckClasificacion.AutoSize = true;
            ckClasificacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckClasificacion.Location = new Point(96, 184);
            ckClasificacion.Name = "ckClasificacion";
            ckClasificacion.Size = new Size(117, 24);
            ckClasificacion.TabIndex = 27;
            ckClasificacion.Text = "Clasificación";
            ckClasificacion.TextAlign = ContentAlignment.MiddleCenter;
            ckClasificacion.UseVisualStyleBackColor = true;
            // 
            // cbClasificacion
            // 
            cbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(219, 182);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(151, 28);
            cbClasificacion.TabIndex = 28;
            // 
            // ckAccesible
            // 
            ckAccesible.AutoSize = true;
            ckAccesible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckAccesible.Location = new Point(472, 184);
            ckAccesible.Name = "ckAccesible";
            ckAccesible.Size = new Size(110, 24);
            ckAccesible.TabIndex = 29;
            ckAccesible.Text = "¿Accesible?";
            ckAccesible.TextAlign = ContentAlignment.MiddleCenter;
            ckAccesible.UseVisualStyleBackColor = true;
            // 
            // ckFamiliar
            // 
            ckFamiliar.AutoSize = true;
            ckFamiliar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckFamiliar.Location = new Point(645, 186);
            ckFamiliar.Name = "ckFamiliar";
            ckFamiliar.Size = new Size(101, 24);
            ckFamiliar.TabIndex = 30;
            ckFamiliar.Text = "¿Familiar?";
            ckFamiliar.TextAlign = ContentAlignment.MiddleCenter;
            ckFamiliar.UseVisualStyleBackColor = true;
            // 
            // ckEsfuerzo
            // 
            ckEsfuerzo.AutoSize = true;
            ckEsfuerzo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckEsfuerzo.Location = new Point(96, 250);
            ckEsfuerzo.Name = "ckEsfuerzo";
            ckEsfuerzo.Size = new Size(168, 24);
            ckEsfuerzo.TabIndex = 31;
            ckEsfuerzo.Text = "Esfuerzo (min,max)";
            ckEsfuerzo.TextAlign = ContentAlignment.MiddleCenter;
            ckEsfuerzo.UseVisualStyleBackColor = true;
            // 
            // nudRiesgoMax
            // 
            nudRiesgoMax.Location = new Point(724, 247);
            nudRiesgoMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRiesgoMax.Name = "nudRiesgoMax";
            nudRiesgoMax.Size = new Size(73, 27);
            nudRiesgoMax.TabIndex = 36;
            nudRiesgoMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudRiesgoMin
            // 
            nudRiesgoMin.Location = new Point(633, 247);
            nudRiesgoMin.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRiesgoMin.Name = "nudRiesgoMin";
            nudRiesgoMin.Size = new Size(73, 27);
            nudRiesgoMin.TabIndex = 35;
            nudRiesgoMin.TextAlign = HorizontalAlignment.Right;
            // 
            // ckRiesgo
            // 
            ckRiesgo.AutoSize = true;
            ckRiesgo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckRiesgo.Location = new Point(472, 250);
            ckRiesgo.Name = "ckRiesgo";
            ckRiesgo.Size = new Size(155, 24);
            ckRiesgo.TabIndex = 34;
            ckRiesgo.Text = "Riesgo (min,max)";
            ckRiesgo.TextAlign = ContentAlignment.MiddleCenter;
            ckRiesgo.UseVisualStyleBackColor = true;
            // 
            // nudEsfuerzoMax
            // 
            nudEsfuerzoMax.Location = new Point(359, 249);
            nudEsfuerzoMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudEsfuerzoMax.Name = "nudEsfuerzoMax";
            nudEsfuerzoMax.Size = new Size(73, 27);
            nudEsfuerzoMax.TabIndex = 38;
            nudEsfuerzoMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudEsfuerzoMin
            // 
            nudEsfuerzoMin.Location = new Point(268, 249);
            nudEsfuerzoMin.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudEsfuerzoMin.Name = "nudEsfuerzoMin";
            nudEsfuerzoMin.Size = new Size(73, 27);
            nudEsfuerzoMin.TabIndex = 37;
            nudEsfuerzoMin.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(601, 321);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(196, 29);
            btnFiltrar.TabIndex = 39;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckTemporada.Location = new Point(96, 324);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(110, 24);
            ckTemporada.TabIndex = 40;
            ckTemporada.Text = "Temporada";
            ckTemporada.TextAlign = ContentAlignment.MiddleCenter;
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // RutasLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 967);
            Controls.Add(ckTemporada);
            Controls.Add(btnFiltrar);
            Controls.Add(nudEsfuerzoMax);
            Controls.Add(nudEsfuerzoMin);
            Controls.Add(nudRiesgoMax);
            Controls.Add(nudRiesgoMin);
            Controls.Add(ckRiesgo);
            Controls.Add(ckEsfuerzo);
            Controls.Add(ckFamiliar);
            Controls.Add(ckAccesible);
            Controls.Add(cbClasificacion);
            Controls.Add(ckClasificacion);
            Controls.Add(ckInvierno);
            Controls.Add(ckOtono);
            Controls.Add(ckVerano);
            Controls.Add(ckPrimavera);
            Controls.Add(nudDuracionMax);
            Controls.Add(nudDuracionMin);
            Controls.Add(ckDuracion);
            Controls.Add(nudDistanciaMax);
            Controls.Add(nudDistanciaMin);
            Controls.Add(ckDistancia);
            Controls.Add(nudPuntuacionMax);
            Controls.Add(nudPuntuacionMin);
            Controls.Add(ckPuntuacion);
            Controls.Add(tbNombre);
            Controls.Add(ckNombre);
            Controls.Add(btnLogout);
            Controls.Add(btnAgregar);
            Controls.Add(flpRutas);
            Margin = new Padding(5);
            Name = "RutasLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rutas";
            Load += Rutas_Load;
            ((System.ComponentModel.ISupportInitialize)nudPuntuacionMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPuntuacionMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanciaMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistanciaMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracionMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRiesgoMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRiesgoMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEsfuerzoMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEsfuerzoMin).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private FlowLayoutPanel flpRutas;
        private UserControls.UCRutaLista ucRutaLista1;
        private Button btnAgregar;
        private Button btnLogout;
        private CheckBox ckNombre;
        private TextBox tbNombre;
        private CheckBox ckPuntuacion;
        private NumericUpDown nudPuntuacionMin;
        private NumericUpDown nudPuntuacionMax;
        private NumericUpDown nudDistanciaMax;
        private NumericUpDown nudDistanciaMin;
        private CheckBox ckDistancia;
        private NumericUpDown nudDuracionMax;
        private NumericUpDown nudDuracionMin;
        private CheckBox ckDuracion;
        private CheckBox ckPrimavera;
        private CheckBox ckVerano;
        private CheckBox ckInvierno;
        private CheckBox ckOtono;
        private CheckBox ckClasificacion;
        private ComboBox cbClasificacion;
        private CheckBox ckAccesible;
        private CheckBox ckFamiliar;
        private CheckBox ckEsfuerzo;
        private NumericUpDown nudRiesgoMax;
        private NumericUpDown nudRiesgoMin;
        private CheckBox ckRiesgo;
        private NumericUpDown nudEsfuerzoMax;
        private NumericUpDown nudEsfuerzoMin;
        private Button btnFiltrar;
        private CheckBox ckTemporada;
    }
}