namespace Forms
{
    partial class RutasDetalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutasDetalle));
            ucRutaCompleto1 = new UserControls.UCRutaCompleto();
            btnPuntosPeligro = new Button();
            btnPuntosInteres = new Button();
            btnActividades = new Button();
            btnValoraciones = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            btnEditar = new Button();
            cbFicha = new ComboBox();
            label1 = new Label();
            btnValidar = new Button();
            btnMapa = new Button();
            btnDescargar = new Button();
            SuspendLayout();
            // 
            // ucRutaCompleto1
            // 
            ucRutaCompleto1.Font = new Font("Segoe UI", 9F);
            ucRutaCompleto1.Location = new Point(12, 14);
            ucRutaCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucRutaCompleto1.Name = "ucRutaCompleto1";
            ucRutaCompleto1.Ruta = null;
            ucRutaCompleto1.Size = new Size(802, 530);
            ucRutaCompleto1.TabIndex = 0;
            // 
            // btnPuntosPeligro
            // 
            btnPuntosPeligro.BackColor = Color.DarkSeaGreen;
            btnPuntosPeligro.FlatAppearance.BorderSize = 0;
            btnPuntosPeligro.FlatStyle = FlatStyle.Flat;
            btnPuntosPeligro.Location = new Point(39, 580);
            btnPuntosPeligro.Margin = new Padding(0);
            btnPuntosPeligro.Name = "btnPuntosPeligro";
            btnPuntosPeligro.Size = new Size(195, 40);
            btnPuntosPeligro.TabIndex = 2;
            btnPuntosPeligro.Text = "Puntos de peligro";
            btnPuntosPeligro.UseVisualStyleBackColor = false;
            btnPuntosPeligro.Click += btnPuntosPeligro_Click;
            // 
            // btnPuntosInteres
            // 
            btnPuntosInteres.BackColor = Color.DarkSeaGreen;
            btnPuntosInteres.FlatAppearance.BorderSize = 0;
            btnPuntosInteres.FlatStyle = FlatStyle.Flat;
            btnPuntosInteres.Location = new Point(234, 580);
            btnPuntosInteres.Margin = new Padding(0);
            btnPuntosInteres.Name = "btnPuntosInteres";
            btnPuntosInteres.Size = new Size(184, 40);
            btnPuntosInteres.TabIndex = 3;
            btnPuntosInteres.Text = "Puntos de interés";
            btnPuntosInteres.UseVisualStyleBackColor = false;
            btnPuntosInteres.Click += btnPuntosInteres_Click;
            // 
            // btnActividades
            // 
            btnActividades.BackColor = Color.DarkSeaGreen;
            btnActividades.FlatAppearance.BorderSize = 0;
            btnActividades.FlatStyle = FlatStyle.Flat;
            btnActividades.Location = new Point(418, 580);
            btnActividades.Margin = new Padding(0);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(183, 40);
            btnActividades.TabIndex = 5;
            btnActividades.Text = "Actividades";
            btnActividades.UseVisualStyleBackColor = false;
            btnActividades.Click += btnActividades_Click;
            // 
            // btnValoraciones
            // 
            btnValoraciones.BackColor = Color.DarkSeaGreen;
            btnValoraciones.FlatAppearance.BorderSize = 0;
            btnValoraciones.FlatStyle = FlatStyle.Flat;
            btnValoraciones.Location = new Point(601, 580);
            btnValoraciones.Margin = new Padding(0);
            btnValoraciones.Name = "btnValoraciones";
            btnValoraciones.Size = new Size(195, 40);
            btnValoraciones.TabIndex = 6;
            btnValoraciones.Text = "Valoraciones";
            btnValoraciones.UseVisualStyleBackColor = false;
            btnValoraciones.Click += btnValoraciones_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkSeaGreen;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(234, 620);
            btnEliminar.Margin = new Padding(0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(184, 40);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(39, 620);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(195, 40);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "<--";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.DarkSeaGreen;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Location = new Point(418, 620);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(183, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // cbFicha
            // 
            cbFicha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFicha.FormattingEnabled = true;
            cbFicha.Items.AddRange(new object[] { "Organización", "Seguridad", "Usuario" });
            cbFicha.Location = new Point(543, 488);
            cbFicha.Margin = new Padding(3, 4, 3, 4);
            cbFicha.Name = "cbFicha";
            cbFicha.Size = new Size(138, 28);
            cbFicha.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(441, 491);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 67;
            label1.Text = "-Elegir ficha:";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.DarkSeaGreen;
            btnValidar.FlatAppearance.BorderSize = 0;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Location = new Point(601, 620);
            btnValidar.Margin = new Padding(0);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(195, 40);
            btnValidar.TabIndex = 70;
            btnValidar.Text = "Validar/Desvalidar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMapa
            // 
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Image = RetaEquipo3.Properties.Resources.mapa;
            btnMapa.Location = new Point(762, 482);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(38, 38);
            btnMapa.TabIndex = 71;
            btnMapa.UseVisualStyleBackColor = true;
            btnMapa.Click += btnMapa_Click;
            // 
            // btnDescargar
            // 
            btnDescargar.FlatAppearance.BorderSize = 0;
            btnDescargar.FlatStyle = FlatStyle.Flat;
            btnDescargar.Image = (Image)resources.GetObject("btnDescargar.Image");
            btnDescargar.Location = new Point(687, 482);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(38, 38);
            btnDescargar.TabIndex = 72;
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // RutasDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(835, 697);
            Controls.Add(btnDescargar);
            Controls.Add(btnMapa);
            Controls.Add(btnValidar);
            Controls.Add(cbFicha);
            Controls.Add(label1);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnValoraciones);
            Controls.Add(btnActividades);
            Controls.Add(btnVolver);
            Controls.Add(btnPuntosInteres);
            Controls.Add(btnPuntosPeligro);
            Controls.Add(ucRutaCompleto1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RutasDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RutasDetalle";
            Load += RutasDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UserControls.UCRutaCompleto ucRutaCompleto1;
        private Button btnPuntosPeligro;
        private Button btnPuntosInteres;
        private Button btnActividades;
        private Button btnValoraciones;
        private Button btnEliminar;
        private Button btnVolver;
        private Button btnEditar;
        private ComboBox cbFicha;
        private Label label1;
        private Button btnValidar;
        private Button btnMapa;
        private Button btnDescargar;
    }
}