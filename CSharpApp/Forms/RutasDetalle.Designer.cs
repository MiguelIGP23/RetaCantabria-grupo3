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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btnVolver = new Button();
            button4 = new Button();
            pbDescarga = new PictureBox();
            cbFicha = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbDescarga).BeginInit();
            SuspendLayout();
            // 
            // ucRutaCompleto1
            // 
            ucRutaCompleto1.Font = new Font("Segoe UI", 9F);
            ucRutaCompleto1.Location = new Point(12, 12);
            ucRutaCompleto1.Margin = new Padding(3, 4, 3, 4);
            ucRutaCompleto1.Name = "ucRutaCompleto1";
            ucRutaCompleto1.Ruta = null;
            ucRutaCompleto1.Size = new Size(700, 396);
            ucRutaCompleto1.TabIndex = 0;
            // 
            // btnPuntosPeligro
            // 
            btnPuntosPeligro.Location = new Point(216, 435);
            btnPuntosPeligro.Name = "btnPuntosPeligro";
            btnPuntosPeligro.Size = new Size(109, 23);
            btnPuntosPeligro.TabIndex = 2;
            btnPuntosPeligro.Text = "Puntos de peligro";
            btnPuntosPeligro.UseVisualStyleBackColor = true;
            btnPuntosPeligro.Click += btnPuntosPeligro_Click;
            // 
            // btnPuntosInteres
            // 
            btnPuntosInteres.Location = new Point(378, 436);
            btnPuntosInteres.Name = "btnPuntosInteres";
            btnPuntosInteres.Size = new Size(109, 23);
            btnPuntosInteres.TabIndex = 3;
            btnPuntosInteres.Text = "Puntos de interés";
            btnPuntosInteres.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(546, 435);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 5;
            button1.Text = "Puntos de peligro";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(53, 497);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 6;
            button2.Text = "Puntos de peligro";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(216, 497);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 7;
            button3.Text = "Puntos de peligro";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(53, 435);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(109, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // button4
            // 
            button4.Location = new Point(378, 498);
            button4.Name = "button4";
            button4.Size = new Size(109, 23);
            button4.TabIndex = 8;
            button4.Text = "Puntos de peligro";
            button4.UseVisualStyleBackColor = true;
            // 
            // pbDescarga
            // 
            pbDescarga.Image = (Image)resources.GetObject("pbDescarga.Image");
            pbDescarga.Location = new Point(603, 360);
            pbDescarga.Name = "pbDescarga";
            pbDescarga.Size = new Size(27, 28);
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
            cbFicha.Location = new Point(468, 365);
            cbFicha.Name = "cbFicha";
            cbFicha.Size = new Size(121, 23);
            cbFicha.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(386, 368);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 67;
            label1.Text = "-Elegir ficha:";
            // 
            // RutasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 564);
            Controls.Add(pbDescarga);
            Controls.Add(cbFicha);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnVolver);
            Controls.Add(btnPuntosInteres);
            Controls.Add(btnPuntosPeligro);
            Controls.Add(ucRutaCompleto1);
            Name = "RutasDetalle";
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnVolver;
        private Button button4;
        private PictureBox pbDescarga;
        private ComboBox cbFicha;
        private Label label1;
    }
}