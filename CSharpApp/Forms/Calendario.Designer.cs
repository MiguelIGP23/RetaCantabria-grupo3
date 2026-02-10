namespace Forms
{
    partial class Calendario
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
            flpRutas = new FlowLayoutPanel();
            btnVolver = new Button();
            btnNueva = new Button();
            lbFecha = new Label();
            SuspendLayout();
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(44, 40);
            mcCalendario.MaxSelectionCount = 1;
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 0;
            mcCalendario.DateChanged += mcCalendario_DateChanged;
            // 
            // flpRutas
            // 
            flpRutas.AutoScroll = true;
            flpRutas.Location = new Point(323, 40);
            flpRutas.Name = "flpRutas";
            flpRutas.Size = new Size(690, 338);
            flpRutas.TabIndex = 1;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(44, 349);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(170, 349);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(94, 29);
            btnNueva.TabIndex = 3;
            btnNueva.Text = "Nueva";
            btnNueva.UseVisualStyleBackColor = true;
            // 
            // lbFecha
            // 
            lbFecha.Location = new Point(44, 285);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(220, 25);
            lbFecha.TabIndex = 4;
            lbFecha.Text = "txtFecha";
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 420);
            Controls.Add(lbFecha);
            Controls.Add(btnNueva);
            Controls.Add(btnVolver);
            Controls.Add(flpRutas);
            Controls.Add(mcCalendario);
            Name = "Calendario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calendario";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcCalendario;
        private FlowLayoutPanel flpRutas;
        private Button btnVolver;
        private Button btnNueva;
        private Label lbFecha;
    }
}