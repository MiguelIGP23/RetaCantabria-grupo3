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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutasLista));
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
            btnMostrarFiltros = new Button();
            btnCalendario = new Button();
            btnUsuarios = new Button();
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
            flpRutas.Location = new Point(35, 400);
            flpRutas.Margin = new Padding(3, 4, 3, 4);
            flpRutas.Name = "flpRutas";
            flpRutas.Size = new Size(709, 399);
            flpRutas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkSeaGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Image = RetaEquipo3.Properties.Resources.nuevo;
            btnAgregar.Location = new Point(779, 630);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(45, 45);
            btnAgregar.TabIndex = 6;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.DarkSeaGreen;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(779, 475);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(45, 45);
            btnLogout.TabIndex = 7;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ckNombre
            // 
            ckNombre.AutoSize = true;
            ckNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckNombre.Location = new Point(47, 45);
            ckNombre.Name = "ckNombre";
            ckNombre.Size = new Size(89, 24);
            ckNombre.TabIndex = 8;
            ckNombre.Text = "Nombre";
            ckNombre.TextAlign = ContentAlignment.MiddleCenter;
            ckNombre.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(139, 41);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(260, 27);
            tbNombre.TabIndex = 9;
            // 
            // ckPuntuacion
            // 
            ckPuntuacion.AutoSize = true;
            ckPuntuacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckPuntuacion.Location = new Point(423, 43);
            ckPuntuacion.Name = "ckPuntuacion";
            ckPuntuacion.Size = new Size(187, 24);
            ckPuntuacion.TabIndex = 10;
            ckPuntuacion.Text = "Puntuación (min,max)";
            ckPuntuacion.TextAlign = ContentAlignment.MiddleCenter;
            ckPuntuacion.UseVisualStyleBackColor = true;
            // 
            // nudPuntuacionMin
            // 
            nudPuntuacionMin.Location = new Point(616, 40);
            nudPuntuacionMin.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudPuntuacionMin.Name = "nudPuntuacionMin";
            nudPuntuacionMin.Size = new Size(60, 27);
            nudPuntuacionMin.TabIndex = 11;
            nudPuntuacionMin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudPuntuacionMax
            // 
            nudPuntuacionMax.Location = new Point(688, 40);
            nudPuntuacionMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudPuntuacionMax.Name = "nudPuntuacionMax";
            nudPuntuacionMax.Size = new Size(60, 27);
            nudPuntuacionMax.TabIndex = 12;
            nudPuntuacionMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDistanciaMax
            // 
            nudDistanciaMax.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudDistanciaMax.Location = new Point(326, 106);
            nudDistanciaMax.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudDistanciaMax.Name = "nudDistanciaMax";
            nudDistanciaMax.Size = new Size(73, 27);
            nudDistanciaMax.TabIndex = 15;
            nudDistanciaMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDistanciaMin
            // 
            nudDistanciaMin.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudDistanciaMin.Location = new Point(242, 106);
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
            ckDistancia.Location = new Point(47, 109);
            ckDistancia.Name = "ckDistancia";
            ckDistancia.Size = new Size(172, 24);
            ckDistancia.TabIndex = 13;
            ckDistancia.Text = "Distancia (min,max)";
            ckDistancia.TextAlign = ContentAlignment.MiddleCenter;
            ckDistancia.UseVisualStyleBackColor = true;
            // 
            // nudDuracionMax
            // 
            nudDuracionMax.Location = new Point(675, 110);
            nudDuracionMax.Maximum = new decimal(new int[] { 720, 0, 0, 0 });
            nudDuracionMax.Name = "nudDuracionMax";
            nudDuracionMax.Size = new Size(73, 27);
            nudDuracionMax.TabIndex = 18;
            nudDuracionMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDuracionMin
            // 
            nudDuracionMin.Location = new Point(596, 110);
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
            ckDuracion.Location = new Point(423, 110);
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
            ckPrimavera.Location = new Point(170, 316);
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
            ckVerano.Location = new Point(273, 316);
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
            ckInvierno.Location = new Point(436, 316);
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
            ckOtono.Location = new Point(357, 316);
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
            ckClasificacion.Location = new Point(47, 176);
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
            cbClasificacion.Location = new Point(170, 174);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(151, 28);
            cbClasificacion.TabIndex = 28;
            // 
            // ckAccesible
            // 
            ckAccesible.AutoSize = true;
            ckAccesible.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckAccesible.Location = new Point(423, 176);
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
            ckFamiliar.Location = new Point(596, 178);
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
            ckEsfuerzo.Location = new Point(47, 242);
            ckEsfuerzo.Name = "ckEsfuerzo";
            ckEsfuerzo.Size = new Size(168, 24);
            ckEsfuerzo.TabIndex = 31;
            ckEsfuerzo.Text = "Esfuerzo (min,max)";
            ckEsfuerzo.TextAlign = ContentAlignment.MiddleCenter;
            ckEsfuerzo.UseVisualStyleBackColor = true;
            // 
            // nudRiesgoMax
            // 
            nudRiesgoMax.Location = new Point(675, 239);
            nudRiesgoMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudRiesgoMax.Name = "nudRiesgoMax";
            nudRiesgoMax.Size = new Size(73, 27);
            nudRiesgoMax.TabIndex = 36;
            nudRiesgoMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudRiesgoMin
            // 
            nudRiesgoMin.Location = new Point(584, 239);
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
            ckRiesgo.Location = new Point(423, 242);
            ckRiesgo.Name = "ckRiesgo";
            ckRiesgo.Size = new Size(155, 24);
            ckRiesgo.TabIndex = 34;
            ckRiesgo.Text = "Riesgo (min,max)";
            ckRiesgo.TextAlign = ContentAlignment.MiddleCenter;
            ckRiesgo.UseVisualStyleBackColor = true;
            // 
            // nudEsfuerzoMax
            // 
            nudEsfuerzoMax.Location = new Point(310, 241);
            nudEsfuerzoMax.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudEsfuerzoMax.Name = "nudEsfuerzoMax";
            nudEsfuerzoMax.Size = new Size(73, 27);
            nudEsfuerzoMax.TabIndex = 38;
            nudEsfuerzoMax.TextAlign = HorizontalAlignment.Right;
            // 
            // nudEsfuerzoMin
            // 
            nudEsfuerzoMin.Location = new Point(219, 241);
            nudEsfuerzoMin.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudEsfuerzoMin.Name = "nudEsfuerzoMin";
            nudEsfuerzoMin.Size = new Size(73, 27);
            nudEsfuerzoMin.TabIndex = 37;
            nudEsfuerzoMin.TextAlign = HorizontalAlignment.Right;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.DarkSeaGreen;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Segoe UI", 11F);
            btnFiltrar.Location = new Point(560, 307);
            btnFiltrar.Margin = new Padding(0);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(188, 40);
            btnFiltrar.TabIndex = 39;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // ckTemporada
            // 
            ckTemporada.AutoSize = true;
            ckTemporada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckTemporada.Location = new Point(47, 316);
            ckTemporada.Name = "ckTemporada";
            ckTemporada.Size = new Size(110, 24);
            ckTemporada.TabIndex = 40;
            ckTemporada.Text = "Temporada";
            ckTemporada.TextAlign = ContentAlignment.MiddleCenter;
            ckTemporada.UseVisualStyleBackColor = true;
            // 
            // btnMostrarFiltros
            // 
            btnMostrarFiltros.BackColor = Color.DarkSeaGreen;
            btnMostrarFiltros.FlatAppearance.BorderSize = 0;
            btnMostrarFiltros.FlatStyle = FlatStyle.Flat;
            btnMostrarFiltros.Image = (Image)resources.GetObject("btnMostrarFiltros.Image");
            btnMostrarFiltros.Location = new Point(775, 400);
            btnMostrarFiltros.Margin = new Padding(0);
            btnMostrarFiltros.Name = "btnMostrarFiltros";
            btnMostrarFiltros.Size = new Size(45, 45);
            btnMostrarFiltros.TabIndex = 41;
            btnMostrarFiltros.UseVisualStyleBackColor = false;
            btnMostrarFiltros.Click += btnMostrarFiltros_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = Color.DarkSeaGreen;
            btnCalendario.FlatAppearance.BorderSize = 0;
            btnCalendario.FlatStyle = FlatStyle.Flat;
            btnCalendario.Image = RetaEquipo3.Properties.Resources.calendario;
            btnCalendario.Location = new Point(779, 550);
            btnCalendario.Margin = new Padding(0);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(45, 45);
            btnCalendario.TabIndex = 42;
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.DarkSeaGreen;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.FlatStyle = FlatStyle.Flat;
            btnUsuarios.Image = RetaEquipo3.Properties.Resources.usuarios;
            btnUsuarios.Location = new Point(779, 730);
            btnUsuarios.Margin = new Padding(0);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(45, 45);
            btnUsuarios.TabIndex = 43;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // RutasLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(851, 833);
            Controls.Add(btnUsuarios);
            Controls.Add(btnCalendario);
            Controls.Add(btnMostrarFiltros);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "RutasLista";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnMostrarFiltros;
        private Button btnCalendario;
        private Button btnUsuarios;
    }
}