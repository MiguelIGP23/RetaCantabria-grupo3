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
            btn_Borrar = new Button();
            btn_Editar = new Button();
            btn_Volver = new Button();
            SuspendLayout();
            // 
            // btn_Borrar
            // 
            btn_Borrar.Location = new Point(361, 273);
            btn_Borrar.Name = "btn_Borrar";
            btn_Borrar.Size = new Size(75, 23);
            btn_Borrar.TabIndex = 0;
            btn_Borrar.Text = "Borrar";
            btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(221, 273);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 1;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(100, 273);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(75, 23);
            btn_Volver.TabIndex = 2;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            // 
            // ValoracionDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 332);
            Controls.Add(btn_Volver);
            Controls.Add(btn_Editar);
            Controls.Add(btn_Borrar);
            Name = "ValoracionDetalle";
            Text = "ValoracionDetalle";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Borrar;
        private Button btn_Editar;
        private Button btn_Volver;
    }
}