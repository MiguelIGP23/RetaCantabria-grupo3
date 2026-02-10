namespace Forms
{
    partial class CrearEditarRuta
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblInicio = new Label();
            lblFinal = new Label();
            txtInicio = new TextBox();
            txtFinal = new TextBox();
            lblLongini = new Label();
            lblLongfin = new Label();
            lblLatini = new Label();
            lblLatfin = new Label();
            lblDuracion = new Label();
            lblDistiancia = new Label();
            lblDesneg = new Label();
            lblAltmin = new Label();
            lblDespos = new Label();
            lblAltmax = new Label();
            lblClasificacion = new Label();
            cbClasificacion = new ComboBox();
            lblTerreno = new Label();
            lblIndicaciones = new Label();
            lblTemporada = new Label();
            btnGPX = new Button();
            lblRecomendaciones = new Label();
            label2 = new Label();
            lblRutaGPX = new Label();
            txtRecomendaciones = new TextBox();
            txtZonaGeo = new TextBox();
            nudTipoTerreno = new NumericUpDown();
            nudIndicaciones = new NumericUpDown();
            btnCancelar = new Button();
            btnAceptar = new Button();
            chkAccesibilidad = new CheckBox();
            chkFamiliar = new CheckBox();
            nudLatIni = new NumericUpDown();
            nudLatFin = new NumericUpDown();
            nudLonIni = new NumericUpDown();
            nudLonFin = new NumericUpDown();
            nudDistancia = new NumericUpDown();
            nudDesnivelNeg = new NumericUpDown();
            nudDesnivelPos = new NumericUpDown();
            label1 = new Label();
            label3 = new Label();
            nudAltitudMin = new NumericUpDown();
            nudAltitudMax = new NumericUpDown();
            nudDuracion = new NumericUpDown();
            ckInvierno = new CheckBox();
            ckOtono = new CheckBox();
            ckVerano = new CheckBox();
            ckPrimavera = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudTipoTerreno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIndicaciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatIni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLatFin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLonIni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLonFin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDesnivelNeg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDesnivelPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAltitudMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAltitudMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(40, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "-Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 30);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(589, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInicio.Location = new Point(40, 85);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(57, 20);
            lblInicio.TabIndex = 2;
            lblInicio.Text = "-Inicio:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFinal.Location = new Point(395, 85);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(40, 20);
            lblFinal.TabIndex = 3;
            lblFinal.Text = "-Fin:";
            // 
            // txtInicio
            // 
            txtInicio.Location = new Point(103, 82);
            txtInicio.Margin = new Padding(3, 4, 3, 4);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(267, 27);
            txtInicio.TabIndex = 4;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(441, 82);
            txtFinal.Margin = new Padding(3, 4, 3, 4);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(267, 27);
            txtFinal.TabIndex = 5;
            // 
            // lblLongini
            // 
            lblLongini.AutoSize = true;
            lblLongini.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLongini.Location = new Point(40, 189);
            lblLongini.Name = "lblLongini";
            lblLongini.Size = new Size(126, 20);
            lblLongini.TabIndex = 6;
            lblLongini.Text = "-Longitud inicial:";
            // 
            // lblLongfin
            // 
            lblLongfin.AutoSize = true;
            lblLongfin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLongfin.Location = new Point(395, 189);
            lblLongfin.Name = "lblLongfin";
            lblLongfin.Size = new Size(117, 20);
            lblLongfin.TabIndex = 7;
            lblLongfin.Text = "-Longitud final:";
            // 
            // lblLatini
            // 
            lblLatini.AutoSize = true;
            lblLatini.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLatini.Location = new Point(40, 139);
            lblLatini.Name = "lblLatini";
            lblLatini.Size = new Size(113, 20);
            lblLatini.TabIndex = 8;
            lblLatini.Text = "-Latitud inicial:";
            // 
            // lblLatfin
            // 
            lblLatfin.AutoSize = true;
            lblLatfin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLatfin.Location = new Point(395, 139);
            lblLatfin.Name = "lblLatfin";
            lblLatfin.Size = new Size(104, 20);
            lblLatfin.TabIndex = 9;
            lblLatfin.Text = "-Latitud final:";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDuracion.Location = new Point(40, 247);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(82, 20);
            lblDuracion.TabIndex = 14;
            lblDuracion.Text = "-Duración:";
            // 
            // lblDistiancia
            // 
            lblDistiancia.AutoSize = true;
            lblDistiancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDistiancia.Location = new Point(395, 247);
            lblDistiancia.Name = "lblDistiancia";
            lblDistiancia.Size = new Size(83, 20);
            lblDistiancia.TabIndex = 15;
            lblDistiancia.Text = "-Distancia:";
            // 
            // lblDesneg
            // 
            lblDesneg.AutoSize = true;
            lblDesneg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDesneg.Location = new Point(40, 303);
            lblDesneg.Name = "lblDesneg";
            lblDesneg.Size = new Size(143, 20);
            lblDesneg.TabIndex = 18;
            lblDesneg.Text = "-Desnivel negativo:";
            // 
            // lblAltmin
            // 
            lblAltmin.AutoSize = true;
            lblAltmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAltmin.Location = new Point(40, 362);
            lblAltmin.Name = "lblAltmin";
            lblAltmin.Size = new Size(125, 20);
            lblAltmin.TabIndex = 19;
            lblAltmin.Text = "-Altitud mínima:";
            // 
            // lblDespos
            // 
            lblDespos.AutoSize = true;
            lblDespos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDespos.Location = new Point(395, 303);
            lblDespos.Name = "lblDespos";
            lblDespos.Size = new Size(138, 20);
            lblDespos.TabIndex = 22;
            lblDespos.Text = "-Desnivel positivo:";
            // 
            // lblAltmax
            // 
            lblAltmax.AutoSize = true;
            lblAltmax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAltmax.Location = new Point(395, 362);
            lblAltmax.Name = "lblAltmax";
            lblAltmax.Size = new Size(128, 20);
            lblAltmax.TabIndex = 23;
            lblAltmax.Text = "-Altitud máxima:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblClasificacion.Location = new Point(40, 418);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(105, 20);
            lblClasificacion.TabIndex = 26;
            lblClasificacion.Text = "-Clasificacion:";
            // 
            // cbClasificacion
            // 
            cbClasificacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(145, 414);
            cbClasificacion.Margin = new Padding(3, 4, 3, 4);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(146, 28);
            cbClasificacion.TabIndex = 27;
            // 
            // lblTerreno
            // 
            lblTerreno.AutoSize = true;
            lblTerreno.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTerreno.Location = new Point(396, 422);
            lblTerreno.Name = "lblTerreno";
            lblTerreno.Size = new Size(73, 20);
            lblTerreno.TabIndex = 33;
            lblTerreno.Text = "-Terreno:";
            // 
            // lblIndicaciones
            // 
            lblIndicaciones.AutoSize = true;
            lblIndicaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIndicaciones.Location = new Point(539, 422);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(105, 20);
            lblIndicaciones.TabIndex = 34;
            lblIndicaciones.Text = "-Indicaciones:";
            // 
            // lblTemporada
            // 
            lblTemporada.AutoSize = true;
            lblTemporada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTemporada.Location = new Point(40, 475);
            lblTemporada.Name = "lblTemporada";
            lblTemporada.Size = new Size(98, 20);
            lblTemporada.TabIndex = 35;
            lblTemporada.Text = "-Temporada:";
            // 
            // btnGPX
            // 
            btnGPX.Location = new Point(40, 631);
            btnGPX.Margin = new Padding(3, 4, 3, 4);
            btnGPX.Name = "btnGPX";
            btnGPX.Size = new Size(141, 31);
            btnGPX.TabIndex = 38;
            btnGPX.Text = "Subir Archivo GPX";
            btnGPX.UseVisualStyleBackColor = true;
            btnGPX.Click += btnGPX_Click;
            // 
            // lblRecomendaciones
            // 
            lblRecomendaciones.AutoSize = true;
            lblRecomendaciones.FlatStyle = FlatStyle.System;
            lblRecomendaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecomendaciones.Location = new Point(40, 579);
            lblRecomendaciones.Name = "lblRecomendaciones";
            lblRecomendaciones.Size = new Size(67, 20);
            lblRecomendaciones.TabIndex = 39;
            lblRecomendaciones.Text = "-Equipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(396, 530);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 40;
            label2.Text = "-Zona geográfica:";
            // 
            // lblRutaGPX
            // 
            lblRutaGPX.Location = new Point(40, 684);
            lblRutaGPX.Name = "lblRutaGPX";
            lblRutaGPX.Size = new Size(429, 31);
            lblRutaGPX.TabIndex = 41;
            lblRutaGPX.Text = "RutaEjemplo GPX";
            // 
            // txtRecomendaciones
            // 
            txtRecomendaciones.Location = new Point(113, 576);
            txtRecomendaciones.Margin = new Padding(3, 4, 3, 4);
            txtRecomendaciones.Name = "txtRecomendaciones";
            txtRecomendaciones.Size = new Size(595, 27);
            txtRecomendaciones.TabIndex = 42;
            // 
            // txtZonaGeo
            // 
            txtZonaGeo.Location = new Point(529, 527);
            txtZonaGeo.Margin = new Padding(3, 4, 3, 4);
            txtZonaGeo.Name = "txtZonaGeo";
            txtZonaGeo.Size = new Size(180, 27);
            txtZonaGeo.TabIndex = 43;
            // 
            // nudTipoTerreno
            // 
            nudTipoTerreno.Location = new Point(468, 420);
            nudTipoTerreno.Margin = new Padding(3, 4, 3, 4);
            nudTipoTerreno.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudTipoTerreno.Name = "nudTipoTerreno";
            nudTipoTerreno.Size = new Size(55, 27);
            nudTipoTerreno.TabIndex = 46;
            nudTipoTerreno.Tag = "";
            nudTipoTerreno.TextAlign = HorizontalAlignment.Right;
            // 
            // nudIndicaciones
            // 
            nudIndicaciones.Location = new Point(650, 420);
            nudIndicaciones.Margin = new Padding(3, 4, 3, 4);
            nudIndicaciones.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudIndicaciones.Name = "nudIndicaciones";
            nudIndicaciones.Size = new Size(58, 27);
            nudIndicaciones.TabIndex = 47;
            nudIndicaciones.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(558, 684);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 50;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(558, 631);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 31);
            btnAceptar.TabIndex = 51;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click_1;
            // 
            // chkAccesibilidad
            // 
            chkAccesibilidad.AutoSize = true;
            chkAccesibilidad.CheckAlign = ContentAlignment.MiddleRight;
            chkAccesibilidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkAccesibilidad.Location = new Point(40, 530);
            chkAccesibilidad.Margin = new Padding(3, 4, 3, 4);
            chkAccesibilidad.Name = "chkAccesibilidad";
            chkAccesibilidad.Size = new Size(106, 24);
            chkAccesibilidad.TabIndex = 52;
            chkAccesibilidad.Text = "-Accesible:";
            chkAccesibilidad.UseVisualStyleBackColor = true;
            // 
            // chkFamiliar
            // 
            chkFamiliar.AutoSize = true;
            chkFamiliar.CheckAlign = ContentAlignment.MiddleRight;
            chkFamiliar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkFamiliar.Location = new Point(189, 530);
            chkFamiliar.Margin = new Padding(3, 4, 3, 4);
            chkFamiliar.Name = "chkFamiliar";
            chkFamiliar.Size = new Size(133, 24);
            chkFamiliar.TabIndex = 53;
            chkFamiliar.Text = "-Ruta familiar:";
            chkFamiliar.UseVisualStyleBackColor = true;
            // 
            // nudLatIni
            // 
            nudLatIni.DecimalPlaces = 4;
            nudLatIni.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatIni.Location = new Point(175, 139);
            nudLatIni.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatIni.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatIni.Name = "nudLatIni";
            nudLatIni.Size = new Size(115, 27);
            nudLatIni.TabIndex = 54;
            nudLatIni.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLatFin
            // 
            nudLatFin.DecimalPlaces = 4;
            nudLatFin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLatFin.Location = new Point(518, 139);
            nudLatFin.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            nudLatFin.Minimum = new decimal(new int[] { 90, 0, 0, int.MinValue });
            nudLatFin.Name = "nudLatFin";
            nudLatFin.Size = new Size(121, 27);
            nudLatFin.TabIndex = 55;
            nudLatFin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLonIni
            // 
            nudLonIni.DecimalPlaces = 4;
            nudLonIni.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLonIni.Location = new Point(172, 187);
            nudLonIni.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLonIni.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLonIni.Name = "nudLonIni";
            nudLonIni.Size = new Size(115, 27);
            nudLonIni.TabIndex = 56;
            nudLonIni.TextAlign = HorizontalAlignment.Right;
            // 
            // nudLonFin
            // 
            nudLonFin.DecimalPlaces = 4;
            nudLonFin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudLonFin.Location = new Point(518, 187);
            nudLonFin.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            nudLonFin.Minimum = new decimal(new int[] { 180, 0, 0, int.MinValue });
            nudLonFin.Name = "nudLonFin";
            nudLonFin.Size = new Size(121, 27);
            nudLonFin.TabIndex = 57;
            nudLonFin.TextAlign = HorizontalAlignment.Right;
            // 
            // nudDistancia
            // 
            nudDistancia.Location = new Point(483, 245);
            nudDistancia.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            nudDistancia.Name = "nudDistancia";
            nudDistancia.Size = new Size(92, 27);
            nudDistancia.TabIndex = 59;
            nudDistancia.TextAlign = HorizontalAlignment.Right;
            nudDistancia.ThousandsSeparator = true;
            // 
            // nudDesnivelNeg
            // 
            nudDesnivelNeg.Location = new Point(189, 301);
            nudDesnivelNeg.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudDesnivelNeg.Name = "nudDesnivelNeg";
            nudDesnivelNeg.Size = new Size(101, 27);
            nudDesnivelNeg.TabIndex = 60;
            nudDesnivelNeg.TextAlign = HorizontalAlignment.Right;
            nudDesnivelNeg.ThousandsSeparator = true;
            // 
            // nudDesnivelPos
            // 
            nudDesnivelPos.Location = new Point(539, 301);
            nudDesnivelPos.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudDesnivelPos.Name = "nudDesnivelPos";
            nudDesnivelPos.Size = new Size(100, 27);
            nudDesnivelPos.TabIndex = 61;
            nudDesnivelPos.TextAlign = HorizontalAlignment.Right;
            nudDesnivelPos.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 247);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 62;
            label1.Text = "minutos.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(581, 247);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 63;
            label3.Text = "metros.";
            // 
            // nudAltitudMin
            // 
            nudAltitudMin.Location = new Point(171, 360);
            nudAltitudMin.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAltitudMin.Name = "nudAltitudMin";
            nudAltitudMin.Size = new Size(119, 27);
            nudAltitudMin.TabIndex = 64;
            nudAltitudMin.TextAlign = HorizontalAlignment.Right;
            nudAltitudMin.ThousandsSeparator = true;
            // 
            // nudAltitudMax
            // 
            nudAltitudMax.Location = new Point(529, 360);
            nudAltitudMax.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudAltitudMax.Name = "nudAltitudMax";
            nudAltitudMax.Size = new Size(110, 27);
            nudAltitudMax.TabIndex = 65;
            nudAltitudMax.TextAlign = HorizontalAlignment.Right;
            nudAltitudMax.ThousandsSeparator = true;
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(128, 245);
            nudDuracion.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(81, 27);
            nudDuracion.TabIndex = 58;
            nudDuracion.TextAlign = HorizontalAlignment.Right;
            // 
            // ckInvierno
            // 
            ckInvierno.AutoSize = true;
            ckInvierno.Location = new Point(518, 474);
            ckInvierno.Name = "ckInvierno";
            ckInvierno.Size = new Size(84, 24);
            ckInvierno.TabIndex = 69;
            ckInvierno.Text = "Invierno";
            ckInvierno.TextAlign = ContentAlignment.MiddleCenter;
            ckInvierno.UseVisualStyleBackColor = true;
            // 
            // ckOtono
            // 
            ckOtono.AutoSize = true;
            ckOtono.Location = new Point(405, 474);
            ckOtono.Name = "ckOtono";
            ckOtono.Size = new Size(73, 24);
            ckOtono.TabIndex = 68;
            ckOtono.Text = "Otoño";
            ckOtono.TextAlign = ContentAlignment.MiddleCenter;
            ckOtono.UseVisualStyleBackColor = true;
            // 
            // ckVerano
            // 
            ckVerano.AutoSize = true;
            ckVerano.Location = new Point(293, 474);
            ckVerano.Name = "ckVerano";
            ckVerano.Size = new Size(77, 24);
            ckVerano.TabIndex = 67;
            ckVerano.Text = "Verano";
            ckVerano.TextAlign = ContentAlignment.MiddleCenter;
            ckVerano.UseVisualStyleBackColor = true;
            // 
            // ckPrimavera
            // 
            ckPrimavera.AutoSize = true;
            ckPrimavera.Location = new Point(162, 475);
            ckPrimavera.Name = "ckPrimavera";
            ckPrimavera.Size = new Size(97, 24);
            ckPrimavera.TabIndex = 66;
            ckPrimavera.Text = "Primavera";
            ckPrimavera.TextAlign = ContentAlignment.MiddleCenter;
            ckPrimavera.UseVisualStyleBackColor = true;
            // 
            // CrearEditarRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 737);
            Controls.Add(ckInvierno);
            Controls.Add(ckOtono);
            Controls.Add(ckVerano);
            Controls.Add(ckPrimavera);
            Controls.Add(nudAltitudMax);
            Controls.Add(nudAltitudMin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(nudDesnivelPos);
            Controls.Add(nudDesnivelNeg);
            Controls.Add(nudDistancia);
            Controls.Add(nudDuracion);
            Controls.Add(nudLonFin);
            Controls.Add(nudLonIni);
            Controls.Add(nudLatFin);
            Controls.Add(nudLatIni);
            Controls.Add(chkFamiliar);
            Controls.Add(chkAccesibilidad);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(nudIndicaciones);
            Controls.Add(nudTipoTerreno);
            Controls.Add(txtZonaGeo);
            Controls.Add(txtRecomendaciones);
            Controls.Add(lblRutaGPX);
            Controls.Add(label2);
            Controls.Add(lblRecomendaciones);
            Controls.Add(btnGPX);
            Controls.Add(lblTemporada);
            Controls.Add(lblIndicaciones);
            Controls.Add(lblTerreno);
            Controls.Add(cbClasificacion);
            Controls.Add(lblClasificacion);
            Controls.Add(lblAltmax);
            Controls.Add(lblDespos);
            Controls.Add(lblAltmin);
            Controls.Add(lblDesneg);
            Controls.Add(lblDistiancia);
            Controls.Add(lblDuracion);
            Controls.Add(lblLatfin);
            Controls.Add(lblLatini);
            Controls.Add(lblLongfin);
            Controls.Add(lblLongini);
            Controls.Add(txtFinal);
            Controls.Add(txtInicio);
            Controls.Add(lblFinal);
            Controls.Add(lblInicio);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarRuta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarRuta";
            FormClosing += CrearEditarRuta_FormClosing;
            Load += CrearEditarRuta_Load;
            ((System.ComponentModel.ISupportInitialize)nudTipoTerreno).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIndicaciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatIni).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLatFin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLonIni).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLonFin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDistancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDesnivelNeg).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDesnivelPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAltitudMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAltitudMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblInicio;
        private Label lblFinal;
        private TextBox txtInicio;
        private TextBox txtFinal;
        private Label lblLongini;
        private Label lblLongfin;
        private Label lblLatini;
        private Label lblLatfin;
        private Label lblDuracion;
        private Label lblDistiancia;
        private Label lblDesneg;
        private Label lblAltmin;
        private Label lblDespos;
        private Label lblAltmax;
        private Label lblClasificacion;
        private ComboBox cbClasificacion;
        private Label lblTerreno;
        private Label lblIndicaciones;
        private Label lblTemporada;
        private Button btnGPX;
        private Label lblRecomendaciones;
        private Label label2;
        private Label lblRutaGPX;
        private TextBox txtRecomendaciones;
        private TextBox txtZonaGeo;
        private NumericUpDown nudTipoTerreno;
        private NumericUpDown nudIndicaciones;
        private Button btnCancelar;
        private Button btnAceptar;
        private CheckBox chkAccesibilidad;
        private CheckBox chkFamiliar;
        private NumericUpDown nudLatIni;
        private NumericUpDown nudLatFin;
        private NumericUpDown nudLonIni;
        private NumericUpDown nudLonFin;
        private NumericUpDown nudDistancia;
        private NumericUpDown nudDesnivelNeg;
        private NumericUpDown nudDesnivelPos;
        private Label label1;
        private Label label3;
        private NumericUpDown nudAltitudMin;
        private NumericUpDown nudAltitudMax;
        private NumericUpDown nudDuracion;
        private CheckBox ckInvierno;
        private CheckBox ckOtono;
        private CheckBox ckVerano;
        private CheckBox ckPrimavera;
    }
}