namespace Forms
{
    partial class CrearEditarCalendario
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
            mcCalendario = new MonthCalendar();
            dtpHora = new DateTimePicker();
            tbInformacion = new TextBox();
            btnVolver = new Button();
            lblInformacion = new Label();
            btnGuardar = new Button();
            label3 = new Label();
            label4 = new Label();
            cbRutas = new ComboBox();
            SuspendLayout();
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(49, 51);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 0;
            // 
            // dtpHora
            // 
            dtpHora.Location = new Point(139, 287);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(103, 27);
            dtpHora.TabIndex = 1;
            // 
            // tbInformacion
            // 
            tbInformacion.Location = new Point(311, 175);
            tbInformacion.Multiline = true;
            tbInformacion.Name = "tbInformacion";
            tbInformacion.Size = new Size(335, 73);
            tbInformacion.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(344, 288);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(105, 29);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Cancelar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInformacion.Location = new Point(311, 141);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(105, 20);
            lblInformacion.TabIndex = 6;
            lblInformacion.Text = "-Información:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(509, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(80, 292);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "-Hora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(311, 51);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 9;
            label4.Text = "-Ruta:";
            // 
            // cbRutas
            // 
            cbRutas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRutas.FormattingEnabled = true;
            cbRutas.Location = new Point(311, 89);
            cbRutas.Name = "cbRutas";
            cbRutas.Size = new Size(335, 28);
            cbRutas.TabIndex = 10;
            // 
            // CrearEditarCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 360);
            Controls.Add(cbRutas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(lblInformacion);
            Controls.Add(btnVolver);
            Controls.Add(tbInformacion);
            Controls.Add(dtpHora);
            Controls.Add(mcCalendario);
            Name = "CrearEditarCalendario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CrearEditarCalendario";
            Load += CrearEditarCalendario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar mcCalendario;
        private DateTimePicker dtpHora;
        private TextBox tbInformacion;
        private Label label1;
        private Button btnVolver;
        private Label label2;
        private Label lblInformacion;
        private Button btnGuardar;
        private Label label3;
        private Label label4;
        private ComboBox cbRutas;
    }
}