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
            txt_buscar_ruta = new TextBox();
            btn_buscar = new Button();
            flpRutas = new FlowLayoutPanel();
            btnAgregar = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // txt_buscar_ruta
            // 
            txt_buscar_ruta.Location = new Point(96, 52);
            txt_buscar_ruta.Margin = new Padding(5);
            txt_buscar_ruta.Name = "txt_buscar_ruta";
            txt_buscar_ruta.Size = new Size(539, 27);
            txt_buscar_ruta.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(696, 52);
            btn_buscar.Margin = new Padding(5);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(101, 35);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // flpRutas
            // 
            flpRutas.Location = new Point(96, 124);
            flpRutas.Margin = new Padding(3, 4, 3, 4);
            flpRutas.Name = "flpRutas";
            flpRutas.Size = new Size(701, 399);
            flpRutas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(549, 577);
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
            btnLogout.Location = new Point(270, 578);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // RutasLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 692);
            Controls.Add(btnLogout);
            Controls.Add(btnAgregar);
            Controls.Add(flpRutas);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar_ruta);
            Margin = new Padding(5);
            Name = "RutasLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rutas";
            FormClosing += RutasLista_FormClosing;
            Load += Rutas_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscar_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private FlowLayoutPanel flpRutas;
        private UserControls.UCRutaLista ucRutaLista1;
        private Button btnAgregar;
        private Button btnLogout;
    }
}