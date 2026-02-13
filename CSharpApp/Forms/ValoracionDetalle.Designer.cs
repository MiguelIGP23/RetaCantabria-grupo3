namespace Forms
{
    partial class ValoracionDetalle
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
            btn_volver = new Button();
            btn_borrar = new Button();
            btn_editar = new Button();
            ucValoracionCompleto1 = new UserControls.UCValoracionCompleto();
            SuspendLayout();
            // 
            // btn_volver
            // 
            btn_volver.BackColor = Color.DarkSeaGreen;
            btn_volver.FlatAppearance.BorderSize = 0;
            btn_volver.FlatStyle = FlatStyle.Flat;
            btn_volver.Location = new Point(39, 290);
            btn_volver.Margin = new Padding(0);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(269, 40);
            btn_volver.TabIndex = 0;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = false;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.BackColor = Color.DarkSeaGreen;
            btn_borrar.FlatAppearance.BorderSize = 0;
            btn_borrar.FlatStyle = FlatStyle.Flat;
            btn_borrar.Location = new Point(39, 330);
            btn_borrar.Margin = new Padding(0);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(541, 40);
            btn_borrar.TabIndex = 1;
            btn_borrar.Text = "Eliminar";
            btn_borrar.UseVisualStyleBackColor = false;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = Color.DarkSeaGreen;
            btn_editar.FlatAppearance.BorderSize = 0;
            btn_editar.FlatStyle = FlatStyle.Flat;
            btn_editar.Location = new Point(308, 290);
            btn_editar.Margin = new Padding(0);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(272, 40);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // ucValoracionCompleto1
            // 
            ucValoracionCompleto1.Location = new Point(14, 16);
            ucValoracionCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucValoracionCompleto1.Name = "ucValoracionCompleto1";
            ucValoracionCompleto1.Size = new Size(587, 252);
            ucValoracionCompleto1.TabIndex = 3;
            ucValoracionCompleto1.valoracion = null;
            // 
            // ValoracionDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(641, 390);
            Controls.Add(ucValoracionCompleto1);
            Controls.Add(btn_editar);
            Controls.Add(btn_borrar);
            Controls.Add(btn_volver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ValoracionDetalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ValoracionDetalle";
            Load += ValoracionDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_volver;
        private Button btn_borrar;
        private Button btn_editar;
        private UserControls.UCValoracionCompleto ucValoracionCompleto1;
    }
}