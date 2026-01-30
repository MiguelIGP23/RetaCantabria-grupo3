namespace Forms
{
    partial class Rutas
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
            dgv_rutas = new DataGridView();
            txt_buscar_ruta = new TextBox();
            btn_buscar = new Button();
            btn_borrar = new Button();
            btn_detalles = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_rutas).BeginInit();
            SuspendLayout();
            // 
            // dgv_rutas
            // 
            dgv_rutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rutas.Location = new Point(69, 118);
            dgv_rutas.Margin = new Padding(4, 5, 4, 5);
            dgv_rutas.Name = "dgv_rutas";
            dgv_rutas.RowHeadersWidth = 51;
            dgv_rutas.Size = new Size(903, 402);
            dgv_rutas.TabIndex = 0;
            // 
            // txt_buscar_ruta
            // 
            txt_buscar_ruta.Location = new Point(96, 52);
            txt_buscar_ruta.Margin = new Padding(4, 5, 4, 5);
            txt_buscar_ruta.Name = "txt_buscar_ruta";
            txt_buscar_ruta.Size = new Size(539, 27);
            txt_buscar_ruta.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.Location = new Point(696, 52);
            btn_buscar.Margin = new Padding(4, 5, 4, 5);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(100, 35);
            btn_buscar.TabIndex = 2;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(696, 555);
            btn_borrar.Margin = new Padding(4, 5, 4, 5);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(100, 35);
            btn_borrar.TabIndex = 3;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_detalles
            // 
            btn_detalles.Location = new Point(124, 555);
            btn_detalles.Margin = new Padding(4, 5, 4, 5);
            btn_detalles.Name = "btn_detalles";
            btn_detalles.Size = new Size(100, 35);
            btn_detalles.TabIndex = 4;
            btn_detalles.Text = "Ver Detalles";
            btn_detalles.UseVisualStyleBackColor = true;
            // 
            // Rutas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(btn_detalles);
            Controls.Add(btn_borrar);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar_ruta);
            Controls.Add(dgv_rutas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Rutas";
            Text = "Rutas";
            Load += Rutas_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_rutas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rutas;
        private System.Windows.Forms.TextBox txt_buscar_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_detalles;
    }
}