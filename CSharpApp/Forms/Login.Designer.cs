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
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_usuario.Location = new Point(57, 51);
            lbl_usuario.Margin = new Padding(5, 0, 5, 0);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(63, 20);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_password.Location = new Point(57, 116);
            lbl_password.Margin = new Padding(5, 0, 5, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(88, 20);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(182, 45);
            txt_usuario.Margin = new Padding(5);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(183, 27);
            txt_usuario.TabIndex = 2;
            txt_usuario.Text = "admin@admin.com";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(182, 111);
            txt_password.Margin = new Padding(5);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(183, 27);
            txt_password.TabIndex = 3;
            txt_password.Text = "admin";
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSeaGreen;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Location = new Point(57, 227);
            btn_login.Margin = new Padding(0);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(308, 42);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_verRutas
            // 
            btn_verRutas.BackColor = Color.DarkSeaGreen;
            btn_verRutas.FlatAppearance.BorderSize = 0;
            btn_verRutas.FlatStyle = FlatStyle.Flat;
            btn_verRutas.Location = new Point(57, 269);
            btn_verRutas.Margin = new Padding(0);
            btn_verRutas.Name = "btn_verRutas";
            btn_verRutas.Size = new Size(155, 42);
            btn_verRutas.TabIndex = 5;
            btn_verRutas.Text = "Ver rutas";
            btn_verRutas.UseVisualStyleBackColor = false;
            btn_verRutas.Click += btn_verRutas_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.DarkSeaGreen;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Location = new Point(212, 269);
            btnRegistro.Margin = new Padding(0);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(153, 42);
            btnRegistro.TabIndex = 6;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(431, 350);
            Controls.Add(btnRegistro);
            Controls.Add(btn_verRutas);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_password);
            Controls.Add(lbl_usuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnRegistro;
    }
}

