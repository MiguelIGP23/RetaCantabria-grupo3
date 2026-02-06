namespace Forms
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_usuario = new Label();
            lbl_password = new Label();
            txt_usuario = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_verRutas = new Button();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(99, 50);
            lbl_usuario.Margin = new Padding(4, 0, 4, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(47, 15);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(99, 111);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(67, 15);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(208, 46);
            txt_usuario.Margin = new Padding(4, 4, 4, 4);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(161, 23);
            txt_usuario.TabIndex = 2;
            txt_usuario.Text = "miguel@gmail.com";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(208, 107);
            txt_password.Margin = new Padding(4, 4, 4, 4);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(161, 23);
            txt_password.TabIndex = 3;
            txt_password.Text = "1234";
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(122, 193);
            btn_login.Margin = new Padding(4, 4, 4, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(88, 26);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_verRutas
            // 
            btn_verRutas.Location = new Point(256, 193);
            btn_verRutas.Margin = new Padding(4, 4, 4, 4);
            btn_verRutas.Name = "btn_verRutas";
            btn_verRutas.Size = new Size(88, 26);
            btn_verRutas.TabIndex = 5;
            btn_verRutas.Text = "Ver rutas";
            btn_verRutas.UseVisualStyleBackColor = true;
            btn_verRutas.Click += btn_registro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 262);
            Controls.Add(btn_verRutas);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_verRutas;
    }
}

