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
            pbDescarga = new PictureBox();
            cbFicha = new ComboBox();
            label1 = new Label();
            btnValidar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbDescarga).BeginInit();
            SuspendLayout();
            // 
            // ucRutaCompleto1
            // 
            ucRutaCompleto1.Font = new Font("Segoe UI", 9F);
            ucRutaCompleto1.Location = new Point(14, 16);
            ucRutaCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucRutaCompleto1.Name = "ucRutaCompleto1";
            ucRutaCompleto1.Ruta = null;
            ucRutaCompleto1.Size = new Size(800, 528);
            ucRutaCompleto1.TabIndex = 0;
            // 
            // btnPuntosPeligro
            // 
            btnPuntosPeligro.Location = new Point(247, 580);
            btnPuntosPeligro.Margin = new Padding(3, 4, 3, 4);
            btnPuntosPeligro.Name = "btnPuntosPeligro";
            btnPuntosPeligro.Size = new Size(139, 31);
            btnPuntosPeligro.TabIndex = 2;
            btnPuntosPeligro.Text = "Puntos de peligro";
            btnPuntosPeligro.UseVisualStyleBackColor = true;
            btnPuntosPeligro.Click += btnPuntosPeligro_Click;
            // 
            // btnPuntosInteres
            // 
            btnPuntosInteres.Location = new Point(432, 581);
            btnPuntosInteres.Margin = new Padding(3, 4, 3, 4);
            btnPuntosInteres.Name = "btnPuntosInteres";
            btnPuntosInteres.Size = new Size(135, 31);
            btnPuntosInteres.TabIndex = 3;
            btnPuntosInteres.Text = "Puntos de interés";
            btnPuntosInteres.UseVisualStyleBackColor = true;
            btnPuntosInteres.Click += btnPuntosInteres_Click;
            // 
            // btnActividades
            // 
            btnActividades.Location = new Point(631, 580);
            btnActividades.Margin = new Padding(3, 4, 3, 4);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(144, 31);
            btnActividades.TabIndex = 5;
            btnActividades.Text = "Actividades";
            btnActividades.UseVisualStyleBackColor = true;
            btnActividades.Click += btnActividades_Click;
            // 
            // btnValoraciones
            // 
            btnValoraciones.Location = new Point(61, 663);
            btnValoraciones.Margin = new Padding(3, 4, 3, 4);
            btnValoraciones.Name = "btnValoraciones";
            btnValoraciones.Size = new Size(138, 31);
            btnValoraciones.TabIndex = 6;
            btnValoraciones.Text = "Valoraciones";
            btnValoraciones.UseVisualStyleBackColor = true;
            btnValoraciones.Click += btnValoraciones_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(247, 663);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 31);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 581);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(138, 31);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(432, 664);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(135, 31);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // pbDescarga
            // 
            pbDescarga.Image = (Image)resources.GetObject("pbDescarga.Image");
            pbDescarga.Location = new Point(689, 480);
            pbDescarga.Margin = new Padding(3, 4, 3, 4);
            pbDescarga.Name = "pbDescarga";
            pbDescarga.Size = new Size(31, 37);
            pbDescarga.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDescarga.TabIndex = 69;
            pbDescarga.TabStop = false;
            pbDescarga.Click += pbDescarga_Click;
            // 
            // cbFicha
            // 
            cbFicha.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFicha.FormattingEnabled = true;
            cbFicha.Items.AddRange(new object[] { "Organización", "Seguridad", "Usuario" });
            cbFicha.Location = new Point(535, 487);
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
            btnValidar.Location = new Point(631, 664);
            btnValidar.Margin = new Padding(3, 4, 3, 4);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(144, 31);
            btnValidar.TabIndex = 70;
            btnValidar.Text = "Validar/Desvalidar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // RutasDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 752);
            Controls.Add(btnValidar);
            Controls.Add(pbDescarga);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "RutasDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RutasDetalle";
            Load += RutasDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)pbDescarga).EndInit();
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
        private PictureBox pbDescarga;
        private ComboBox cbFicha;
        private Label label1;
        private Button btnValidar;
    }
}