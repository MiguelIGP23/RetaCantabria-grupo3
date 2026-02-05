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
            btn_borrar = new Button();
            btn_detalles = new Button();
            flpRutas = new FlowLayoutPanel();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // txt_buscar_ruta
            // 
            txt_buscar_ruta.Location = new Point(84, 39);
            txt_buscar_ruta.Margin = new Padding(4);
            txt_buscar_ruta.Name = "txt_buscar_ruta";
            txt_buscar_ruta.Size = new Size(472, 23);
            txt_buscar_ruta.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(609, 39);
            btn_buscar.Margin = new Padding(4);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(88, 26);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(595, 416);
            btn_borrar.Margin = new Padding(4);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(88, 26);
            btn_borrar.TabIndex = 3;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_detalles
            // 
            btn_detalles.Location = new Point(108, 416);
            btn_detalles.Margin = new Padding(4);
            btn_detalles.Name = "btn_detalles";
            btn_detalles.Size = new Size(88, 26);
            btn_detalles.TabIndex = 4;
            btn_detalles.Text = "Ver Detalles";
            btn_detalles.UseVisualStyleBackColor = true;
            // 
            // flpRutas
            // 
            flpRutas.Location = new Point(84, 93);
            flpRutas.Name = "flpRutas";
            flpRutas.Size = new Size(613, 299);
            flpRutas.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(339, 416);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // RutasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 519);
            Controls.Add(btnAgregar);
            Controls.Add(flpRutas);
            Controls.Add(btn_detalles);
            Controls.Add(btn_borrar);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar_ruta);
            Margin = new Padding(4);
            Name = "RutasLista";
            Text = "Rutas";
            Load += Rutas_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_buscar_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_detalles;
        private FlowLayoutPanel flpRutas;
        private UserControls.UCRutaLista ucRutaLista1;
        private Button btnAgregar;
    }
}