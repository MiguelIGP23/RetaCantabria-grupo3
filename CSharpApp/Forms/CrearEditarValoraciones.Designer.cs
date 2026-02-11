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
            dateTimePicker1 = new DateTimePicker();
            lbl_Fecha = new Label();
            nud_Dificultad = new NumericUpDown();
            lbl_Estrellas = new Label();
            nud_Estrellas = new NumericUpDown();
            lbl_valoracionTec = new Label();
            lbl_Resena = new Label();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nud_Dificultad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Estrellas).BeginInit();
            SuspendLayout();
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Location = new Point(135, 324);
            btn_Aceptar.Margin = new Padding(3, 4, 3, 4);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(86, 31);
            btn_Aceptar.TabIndex = 0;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Location = new Point(341, 324);
            btn_Cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(86, 31);
            btn_Cancelar.TabIndex = 1;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lbl_dificultad
            // 
            lbl_dificultad.AutoSize = true;
            lbl_dificultad.Location = new Point(57, 55);
            lbl_dificultad.Name = "lbl_dificultad";
            lbl_dificultad.Size = new Size(83, 20);
            lbl_dificultad.TabIndex = 2;
            lbl_dificultad.Text = "-Dificultad:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(135, 127);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.Location = new Point(57, 127);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(56, 20);
            lbl_Fecha.TabIndex = 4;
            lbl_Fecha.Text = "-Fecha:";
            // 
            // nud_Dificultad
            // 
            nud_Dificultad.Location = new Point(166, 52);
            nud_Dificultad.Margin = new Padding(3, 4, 3, 4);
            nud_Dificultad.Name = "nud_Dificultad";
            nud_Dificultad.Size = new Size(61, 27);
            nud_Dificultad.TabIndex = 5;
            // 
            // lbl_Estrellas
            // 
            lbl_Estrellas.AutoSize = true;
            lbl_Estrellas.Location = new Point(57, 205);
            lbl_Estrellas.Name = "lbl_Estrellas";
            lbl_Estrellas.Size = new Size(72, 20);
            lbl_Estrellas.TabIndex = 6;
            lbl_Estrellas.Text = "-Estrellas:";
            // 
            // nud_Estrellas
            // 
            nud_Estrellas.Location = new Point(135, 205);
            nud_Estrellas.Margin = new Padding(3, 4, 3, 4);
            nud_Estrellas.Name = "nud_Estrellas";
            nud_Estrellas.Size = new Size(61, 27);
            nud_Estrellas.TabIndex = 7;
            // 
            // lbl_valoracionTec
            // 
            lbl_valoracionTec.AutoSize = true;
            lbl_valoracionTec.Location = new Point(431, 63);
            lbl_valoracionTec.Name = "lbl_valoracionTec";
            lbl_valoracionTec.Size = new Size(137, 20);
            lbl_valoracionTec.TabIndex = 8;
            lbl_valoracionTec.Text = "-ValoracionTecnica:";
            // 
            // lbl_Resena
            // 
            lbl_Resena.AutoSize = true;
            lbl_Resena.Location = new Point(431, 169);
            lbl_Resena.Name = "lbl_Resena";
            lbl_Resena.Size = new Size(65, 20);
            lbl_Resena.TabIndex = 10;
            lbl_Resena.Text = "-Resena:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(411, 104);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(278, 52);
            txtNombre.TabIndex = 93;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(411, 205);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 52);
            textBox1.TabIndex = 94;
            // 
            // CrearEditarValoraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 381);
            Controls.Add(textBox1);
            Controls.Add(txtNombre);
            Controls.Add(lbl_Resena);
            Controls.Add(lbl_valoracionTec);
            Controls.Add(nud_Estrellas);
            Controls.Add(lbl_Estrellas);
            Controls.Add(nud_Dificultad);
            Controls.Add(lbl_Fecha);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_dificultad);
            Controls.Add(btn_Cancelar);
            Controls.Add(btn_Aceptar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearEditarValoraciones";
            Text = "CrearEditarValoraciones";
            ((System.ComponentModel.ISupportInitialize)nud_Dificultad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Estrellas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private Label lbl_dificultad;
        private DateTimePicker dateTimePicker1;
        private Label lbl_Fecha;
        private NumericUpDown nud_Dificultad;
        private Label lbl_Estrellas;
        private NumericUpDown nud_Estrellas;
        private Label lbl_valoracionTec;
        private Label lbl_Resena;
        private TextBox txtNombre;
        private TextBox textBox1;
    }
}