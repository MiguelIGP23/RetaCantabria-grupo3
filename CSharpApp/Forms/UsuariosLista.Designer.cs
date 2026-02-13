namespace Forms
{
    partial class UsuariosLista
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
            flpUsuarios = new FlowLayoutPanel();
            ucUsuarioLista1 = new UserControls.UCUsuarioLista();
            btnCrear = new Button();
            btnVolver = new Button();
            flpUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // flpUsuarios
            // 
            flpUsuarios.AutoScroll = true;
            flpUsuarios.Controls.Add(ucUsuarioLista1);
            flpUsuarios.Location = new Point(40, 40);
            flpUsuarios.Margin = new Padding(3, 4, 3, 4);
            flpUsuarios.Name = "flpUsuarios";
            flpUsuarios.Size = new Size(600, 388);
            flpUsuarios.TabIndex = 0;
            // 
            // ucUsuarioLista1
            // 
            ucUsuarioLista1.Location = new Point(3, 5);
            ucUsuarioLista1.Margin = new Padding(3, 5, 3, 5);
            ucUsuarioLista1.Name = "ucUsuarioLista1";
            ucUsuarioLista1.Size = new Size(767, 84);
            ucUsuarioLista1.TabIndex = 0;
            ucUsuarioLista1.Usuario = null;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.DarkSeaGreen;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(341, 449);
            btnCrear.Margin = new Padding(0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(299, 40);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(40, 449);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(301, 40);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // UsuariosLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(680, 513);
            Controls.Add(btnVolver);
            Controls.Add(btnCrear);
            Controls.Add(flpUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuariosLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UsuariosLista";
            Load += UsuariosLista_Load;
            flpUsuarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpUsuarios;
        private Button btnCrear;
        private Button btnVolver;
        private UserControls.UCUsuarioLista ucUsuarioLista1;
    }
}