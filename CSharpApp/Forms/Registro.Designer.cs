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
            txt_nombre = new TextBox();
            txt_rep_password = new TextBox();
            txt_password = new TextBox();
            txt_email = new TextBox();
            txt_apellido = new TextBox();
            btn_guardar = new Button();
            btn_volver = new Button();
            btEliminar = new Button();
            ckPassword = new CheckBox();
            cbRol = new ComboBox();
            lblRol = new Label();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_nombre.Location = new Point(42, 44);
            lbl_nombre.Margin = new Padding(4, 0, 4, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(77, 20);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "-Nombre:";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.AutoSize = true;
            lbl_apellidos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_apellidos.Location = new Point(42, 109);
            lbl_apellidos.Margin = new Padding(4, 0, 4, 0);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new Size(84, 20);
            lbl_apellidos.TabIndex = 1;
            lbl_apellidos.Text = "-Apellidos:";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_email.Location = new Point(42, 172);
            lbl_email.Margin = new Padding(4, 0, 4, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(57, 20);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "-Email:";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_password.Location = new Point(42, 276);
            lbl_password.Margin = new Padding(4, 0, 4, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(98, 20);
            lbl_password.TabIndex = 3;
            lbl_password.Text = "-Contraseña:";
            // 
            // lbl_rep_password
            // 
            lbl_rep_password.AutoSize = true;
            lbl_rep_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_rep_password.Location = new Point(42, 335);
            lbl_rep_password.Margin = new Padding(4, 0, 4, 0);
            lbl_rep_password.Name = "lbl_rep_password";
            lbl_rep_password.Size = new Size(171, 20);
            lbl_rep_password.TabIndex = 4;
            lbl_rep_password.Text = "-Confirmar contraseña:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(209, 41);
            txt_nombre.Margin = new Padding(4, 5, 4, 5);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(285, 27);
            txt_nombre.TabIndex = 6;
            // 
            // txt_rep_password
            // 
            txt_rep_password.Location = new Point(221, 332);
            txt_rep_password.Margin = new Padding(4, 5, 4, 5);
            txt_rep_password.Name = "txt_rep_password";
            txt_rep_password.Size = new Size(273, 27);
            txt_rep_password.TabIndex = 8;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(221, 273);
            txt_password.Margin = new Padding(4, 5, 4, 5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(273, 27);
            txt_password.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(209, 169);
            txt_email.Margin = new Padding(4, 5, 4, 5);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(285, 27);
            txt_email.TabIndex = 10;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(209, 106);
            txt_apellido.Margin = new Padding(4, 5, 4, 5);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(285, 27);
            txt_apellido.TabIndex = 11;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(314, 409);
            btn_guardar.Margin = new Padding(4, 5, 4, 5);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(100, 35);
            btn_guardar.TabIndex = 13;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(42, 409);
            btn_volver.Margin = new Padding(4, 5, 4, 5);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(100, 35);
            btn_volver.TabIndex = 14;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(176, 409);
            btEliminar.Margin = new Padding(4, 5, 4, 5);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(100, 35);
            btEliminar.TabIndex = 15;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // ckPassword
            // 
            ckPassword.AutoSize = true;
            ckPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ckPassword.Location = new Point(42, 227);
            ckPassword.Name = "ckPassword";
            ckPassword.Size = new Size(184, 24);
            ckPassword.TabIndex = 16;
            ckPassword.Text = "¿Cambiar contraseña?";
            ckPassword.UseVisualStyleBackColor = true;
            ckPassword.CheckedChanged += ckPassword_CheckedChanged;
            // 
            // cbRol
            // 
            cbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(314, 223);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(180, 28);
            cbRol.TabIndex = 17;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRol.Location = new Point(267, 228);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(42, 20);
            lblRol.TabIndex = 18;
            lblRol.Text = "-Rol:";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 518);
            Controls.Add(lblRol);
            Controls.Add(cbRol);
            Controls.Add(ckPassword);
            Controls.Add(btEliminar);
            Controls.Add(btn_volver);
            Controls.Add(btn_guardar);
            Controls.Add(txt_apellido);
            Controls.Add(txt_email);
            Controls.Add(txt_password);
            Controls.Add(txt_rep_password);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_rep_password);
            Controls.Add(lbl_password);
            Controls.Add(lbl_email);
            Controls.Add(lbl_apellidos);
            Controls.Add(lbl_nombre);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registro";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_rep_password;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_rep_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_volver;
        private Button btEliminar;
        private CheckBox ckPassword;
        private ComboBox cbRol;
        private Label lblRol;
    }
}