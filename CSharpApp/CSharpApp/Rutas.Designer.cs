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
            this.dgv_rutas.Location = new System.Drawing.Point(52, 76);
            this.dgv_rutas.Name = "dgv_rutas";
            this.dgv_rutas.Size = new System.Drawing.Size(677, 262);
            this.dgv_rutas.TabIndex = 0;
            // 
            // txt_buscar_ruta
            // 
            this.txt_buscar_ruta.Location = new System.Drawing.Point(72, 34);
            this.txt_buscar_ruta.Name = "txt_buscar_ruta";
            this.txt_buscar_ruta.Size = new System.Drawing.Size(405, 20);
            this.txt_buscar_ruta.TabIndex = 1;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(522, 34);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(522, 361);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 3;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_detalles
            // 
            this.btn_detalles.Location = new System.Drawing.Point(93, 361);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(75, 23);
            this.btn_detalles.TabIndex = 4;
            this.btn_detalles.Text = "Ver Detalles";
            this.btn_detalles.UseVisualStyleBackColor = true;
            // 
            // Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_detalles);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar_ruta);
            this.Controls.Add(this.dgv_rutas);
            this.Name = "Rutas";
            this.Text = "Rutas";
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