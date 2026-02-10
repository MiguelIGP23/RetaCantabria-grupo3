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
            btn_volver.Location = new Point(96, 234);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(75, 23);
            btn_volver.TabIndex = 0;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(232, 234);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(75, 23);
            btn_borrar.TabIndex = 1;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            btn_editar.Location = new Point(354, 234);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(75, 23);
            btn_editar.TabIndex = 2;
            btn_editar.Text = "Editar";
            btn_editar.UseVisualStyleBackColor = true;
            // 
            // ucValoracionCompleto1
            // 
            ucValoracionCompleto1.Location = new Point(12, 12);
            ucValoracionCompleto1.Name = "ucValoracionCompleto1";
            ucValoracionCompleto1.Size = new Size(514, 189);
            ucValoracionCompleto1.TabIndex = 3;
            ucValoracionCompleto1.valoracion = null;
            // 
            // ValoracionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 290);
            Controls.Add(ucValoracionCompleto1);
            Controls.Add(btn_editar);
            Controls.Add(btn_borrar);
            Controls.Add(btn_volver);
            Name = "ValoracionDetalle";
            Text = "ValoracionDetalle";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_volver;
        private Button btn_borrar;
        private Button btn_editar;
        private UserControls.UCValoracionCompleto ucValoracionCompleto1;
    }
}