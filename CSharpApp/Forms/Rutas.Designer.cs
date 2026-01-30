namespace CSharpApp
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
            this.dgv_rutas = new System.Windows.Forms.DataGridView();
            this.txt_buscar_ruta = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_detalles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rutas
            // 
            this.dgv_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rutas.Location = new System.Drawing.Point(69, 94);
            this.dgv_rutas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_rutas.Name = "dgv_rutas";
            this.dgv_rutas.RowHeadersWidth = 51;
            this.dgv_rutas.Size = new System.Drawing.Size(903, 322);
            this.dgv_rutas.TabIndex = 0;
            // 
            // txt_buscar_ruta
            // 
            this.txt_buscar_ruta.Location = new System.Drawing.Point(96, 42);
            this.txt_buscar_ruta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscar_ruta.Name = "txt_buscar_ruta";
            this.txt_buscar_ruta.Size = new System.Drawing.Size(539, 22);
            this.txt_buscar_ruta.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(696, 42);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(100, 28);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(696, 444);
            this.btn_borrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(100, 28);
            this.btn_borrar.TabIndex = 3;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_detalles
            // 
            this.btn_detalles.Location = new System.Drawing.Point(124, 444);
            this.btn_detalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(100, 28);
            this.btn_detalles.TabIndex = 4;
            this.btn_detalles.Text = "Ver Detalles";
            this.btn_detalles.UseVisualStyleBackColor = true;
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar_ruta);
            this.Controls.Add(this.dgv_rutas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rutas";
            this.Text = "Rutas";
            this.Load += new System.EventHandler(this.Rutas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rutas;
        private System.Windows.Forms.TextBox txt_buscar_ruta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_detalles;
    }
}