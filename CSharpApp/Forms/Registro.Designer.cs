namespace CSharpApp
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_rep_password = new System.Windows.Forms.Label();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_rep_password = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.cmb_rol = new System.Windows.Forms.ComboBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(229, 60);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(229, 102);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_apellidos.TabIndex = 1;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(229, 155);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(229, 195);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(61, 13);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Contraseña";
            // 
            // lbl_rep_password
            // 
            this.lbl_rep_password.AutoSize = true;
            this.lbl_rep_password.Location = new System.Drawing.Point(229, 231);
            this.lbl_rep_password.Name = "lbl_rep_password";
            this.lbl_rep_password.Size = new System.Drawing.Size(107, 13);
            this.lbl_rep_password.TabIndex = 4;
            this.lbl_rep_password.Text = "Confirmar contraseña";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Location = new System.Drawing.Point(229, 278);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(23, 13);
            this.lbl_rol.TabIndex = 5;
            this.lbl_rol.Text = "Rol";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(428, 53);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_rep_password
            // 
            this.txt_rep_password.Location = new System.Drawing.Point(428, 229);
            this.txt_rep_password.Name = "txt_rep_password";
            this.txt_rep_password.Size = new System.Drawing.Size(121, 20);
            this.txt_rep_password.TabIndex = 8;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(428, 188);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(121, 20);
            this.txt_password.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(428, 148);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(121, 20);
            this.txt_email.TabIndex = 10;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(428, 99);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(121, 20);
            this.txt_apellido.TabIndex = 11;
            // 
            // cmb_rol
            // 
            this.cmb_rol.FormattingEnabled = true;
            this.cmb_rol.Location = new System.Drawing.Point(428, 275);
            this.cmb_rol.Name = "cmb_rol";
            this.cmb_rol.Size = new System.Drawing.Size(121, 21);
            this.cmb_rol.TabIndex = 12;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(232, 360);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 13;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(474, 360);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 14;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cmb_rol);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_rep_password);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_rol);
            this.Controls.Add(this.lbl_rep_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

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