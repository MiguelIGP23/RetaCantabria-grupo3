namespace Forms
{
    partial class Registro
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
            lbl_nombre = new Label();
            lbl_apellidos = new Label();
            lbl_email = new Label();
            lbl_password = new Label();
            lbl_rep_password = new Label();
            lbl_rol = new Label();
            txt_nombre = new TextBox();
            txt_rep_password = new TextBox();
            txt_password = new TextBox();
            txt_email = new TextBox();
            txt_apellido = new TextBox();
            cmb_rol = new ComboBox();
            btn_registrar = new Button();
            btn_volver = new Button();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(305, 92);
            lbl_nombre.Margin = new Padding(4, 0, 4, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(64, 20);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.AutoSize = true;
            lbl_apellidos.Location = new Point(305, 157);
            lbl_apellidos.Margin = new Padding(4, 0, 4, 0);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new Size(72, 20);
            lbl_apellidos.TabIndex = 1;
            lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(305, 238);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(305, 300);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(83, 20);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "Contraseña";
            // 
            // lbl_rep_password
            // 
            lbl_rep_password.AutoSize = true;
            lbl_rep_password.Location = new Point(305, 355);
            lbl_rep_password.Margin = new Padding(4, 0, 4, 0);
            lbl_rep_password.Name = "lbl_rep_password";
            lbl_rep_password.Size = new Size(151, 20);
            lbl_rep_password.TabIndex = 4;
            lbl_rep_password.Text = "Confirmar contraseña";
            // 
            // lbl_rol
            // 
            lbl_rol.AutoSize = true;
            lbl_rol.Location = new Point(305, 428);
            lbl_rol.Margin = new Padding(4, 0, 4, 0);
            lbl_rol.Name = "lbl_rol";
            lbl_rol.Size = new Size(31, 20);
            lbl_rol.TabIndex = 5;
            lbl_rol.Text = "Rol";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(571, 82);
            txt_nombre.Margin = new Padding(4, 5, 4, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(160, 27);
            txt_nombre.TabIndex = 6;
            // 
            // txt_rep_password
            // 
            txt_rep_password.Location = new Point(571, 352);
            txt_rep_password.Margin = new Padding(4, 5, 4, 5);
            txt_rep_password.Name = "txt_rep_password";
            txt_rep_password.Size = new Size(160, 27);
            txt_rep_password.TabIndex = 8;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(571, 289);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(160, 27);
            txt_password.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(571, 228);
            txt_email.Margin = new Padding(4, 5, 4, 5);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(160, 27);
            txt_email.TabIndex = 10;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(571, 152);
            txt_apellido.Margin = new Padding(4, 5, 4, 5);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(160, 27);
            txt_apellido.TabIndex = 11;
            // 
            // cmb_rol
            // 
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Location = new Point(571, 423);
            cmb_rol.Margin = new Padding(4, 5, 4, 5);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(160, 28);
            cmb_rol.TabIndex = 12;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(309, 554);
            btn_registrar.Margin = new Padding(4, 5, 4, 5);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(100, 35);
            btn_registrar.TabIndex = 13;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(632, 554);
            btn_volver.Margin = new Padding(4, 5, 4, 5);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(100, 35);
            btn_volver.TabIndex = 14;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(btn_volver);
            Controls.Add(btn_registrar);
            Controls.Add(cmb_rol);
            Controls.Add(txt_apellido);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_rep_password);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_rol);
            Controls.Add(lbl_rep_password);
            Controls.Add(lbl_password);
            Controls.Add(lbl_email);
            Controls.Add(lbl_apellidos);
            Controls.Add(lbl_nombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_rep_password;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rep_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.ComboBox cmb_rol;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_volver;
    }
}