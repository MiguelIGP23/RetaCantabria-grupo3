namespace Forms
{
    partial class CrearEditarValoraciones
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
            btn_Aceptar = new Button();
            btn_Cancelar = new Button();
            lbl_dificultad = new Label();
            nud_Dificultad = new NumericUpDown();
            lbl_Estrellas = new Label();
            nud_Estrellas = new NumericUpDown();
            lbl_valoracionTec = new Label();
            lbl_Resena = new Label();
            tbValoracionTecnica = new TextBox();
            tbResena = new TextBox();
            mCalendario = new MonthCalendar();
            lblFecha = new Label();
            nudBelleza = new NumericUpDown();
            label1 = new Label();
            nudInteres = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nud_Dificultad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Estrellas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBelleza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInteres).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackColor = Color.DarkSeaGreen;
            btn_Aceptar.FlatAppearance.BorderSize = 0;
            btn_Aceptar.FlatStyle = FlatStyle.Flat;
            btn_Aceptar.Location = new Point(393, 331);
            btn_Aceptar.Margin = new Padding(0);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(385, 40);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = false;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.DarkSeaGreen;
            btn_Cancelar.FlatAppearance.BorderSize = 0;
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Location = new Point(18, 331);
            btn_Cancelar.Margin = new Padding(0);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(375, 40);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lbl_dificultad
            // 
            lbl_dificultad.AutoSize = true;
            lbl_dificultad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_dificultad.Location = new Point(129, 34);
            lbl_dificultad.Name = "lbl_dificultad";
            lbl_dificultad.Size = new Size(87, 20);
            lbl_dificultad.TabIndex = 2;
            lbl_dificultad.Text = "-Dificultad:";
            // 
            // nud_Dificultad
            // 
            nud_Dificultad.Location = new Point(222, 32);
            nud_Dificultad.Margin = new Padding(3, 4, 3, 4);
            nud_Dificultad.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_Dificultad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Dificultad.Name = "nud_Dificultad";
            nud_Dificultad.Size = new Size(45, 27);
            nud_Dificultad.TabIndex = 5;
            nud_Dificultad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_Estrellas
            // 
            lbl_Estrellas.AutoSize = true;
            lbl_Estrellas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Estrellas.Location = new Point(296, 34);
            lbl_Estrellas.Name = "lbl_Estrellas";
            lbl_Estrellas.Size = new Size(77, 20);
            lbl_Estrellas.TabIndex = 6;
            lbl_Estrellas.Text = "-Estrellas:";
            // 
            // nud_Estrellas
            // 
            nud_Estrellas.Location = new Point(379, 30);
            nud_Estrellas.Margin = new Padding(3, 4, 3, 4);
            nud_Estrellas.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_Estrellas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_Estrellas.Name = "nud_Estrellas";
            nud_Estrellas.Size = new Size(46, 27);
            nud_Estrellas.TabIndex = 7;
            nud_Estrellas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_valoracionTec
            // 
            lbl_valoracionTec.AutoSize = true;
            lbl_valoracionTec.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_valoracionTec.Location = new Point(282, 100);
            lbl_valoracionTec.Name = "lbl_valoracionTec";
            lbl_valoracionTec.Size = new Size(143, 20);
            lbl_valoracionTec.TabIndex = 8;
            lbl_valoracionTec.Text = "-ValoracionTecnica:";
            // 
            // lbl_Resena
            // 
            lbl_Resena.AutoSize = true;
            lbl_Resena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_Resena.Location = new Point(282, 212);
            lbl_Resena.Name = "lbl_Resena";
            lbl_Resena.Size = new Size(69, 20);
            lbl_Resena.TabIndex = 10;
            lbl_Resena.Text = "-Reseña:";
            // 
            // tbValoracionTecnica
            // 
            tbValoracionTecnica.Location = new Point(282, 140);
            tbValoracionTecnica.Margin = new Padding(3, 4, 3, 4);
            tbValoracionTecnica.Multiline = true;
            tbValoracionTecnica.Name = "tbValoracionTecnica";
            tbValoracionTecnica.Size = new Size(496, 52);
            tbValoracionTecnica.TabIndex = 93;
            // 
            // tbResena
            // 
            tbResena.Location = new Point(282, 246);
            tbResena.Margin = new Padding(3, 4, 3, 4);
            tbResena.Multiline = true;
            tbResena.Name = "tbResena";
            tbResena.Size = new Size(496, 52);
            tbResena.TabIndex = 94;
            // 
            // mCalendario
            // 
            mCalendario.Location = new Point(18, 91);
            mCalendario.Name = "mCalendario";
            mCalendario.TabIndex = 95;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFecha.Location = new Point(18, 34);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 20);
            lblFecha.TabIndex = 96;
            lblFecha.Text = "-Fecha:";
            // 
            // nudBelleza
            // 
            nudBelleza.Location = new Point(729, 30);
            nudBelleza.Margin = new Padding(3, 4, 3, 4);
            nudBelleza.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudBelleza.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBelleza.Name = "nudBelleza";
            nudBelleza.Size = new Size(49, 27);
            nudBelleza.TabIndex = 100;
            nudBelleza.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(655, 32);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 99;
            label1.Text = "-Belleza:";
            // 
            // nudInteres
            // 
            nudInteres.Location = new Point(584, 32);
            nudInteres.Margin = new Padding(3, 4, 3, 4);
            nudInteres.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudInteres.Name = "nudInteres";
            nudInteres.Size = new Size(46, 27);
            nudInteres.TabIndex = 98;
            nudInteres.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(453, 34);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 97;
            label2.Text = "-Interés cultural:";
            // 
            // CrearEditarValoraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(812, 411);
            Controls.Add(nudBelleza);
            Controls.Add(label1);
            Controls.Add(nudInteres);
            Controls.Add(label2);
            Controls.Add(lblFecha);
            Controls.Add(mCalendario);
            Controls.Add(tbResena);
            Controls.Add(tbValoracionTecnica);
            Controls.Add(lbl_Resena);
            Controls.Add(lbl_valoracionTec);
            Controls.Add(nud_Estrellas);
            Controls.Add(lbl_Estrellas);
            Controls.Add(nud_Dificultad);
            Controls.Add(lbl_dificultad);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarValoraciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearEditarValoraciones";
            Load += CrearEditarValoraciones_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Dificultad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Estrellas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBelleza).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInteres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_dificultad;
        private Label lbl_Fecha;
        private NumericUpDown nud_Dificultad;
        private Label lbl_Estrellas;
        private NumericUpDown nud_Estrellas;
        private Label lbl_valoracionTec;
        private Label lbl_Resena;
        private TextBox tbValoracionTecnica;
        private TextBox tbResena;
        private MonthCalendar mcCalendario;
        private MonthCalendar mCalendario;
        private Label lblFecha;
        private NumericUpDown nudBelleza;
        private Label label1;
        private NumericUpDown nudInteres;
        private Label label2;
    }
}