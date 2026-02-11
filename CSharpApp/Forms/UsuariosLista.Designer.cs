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
            flpUsuarios.Controls.Add(ucUsuarioLista1);
            flpUsuarios.Location = new Point(53, 32);
            flpUsuarios.Name = "flpUsuarios";
            flpUsuarios.Size = new Size(685, 291);
            flpUsuarios.TabIndex = 0;
            // 
            // ucUsuarioLista1
            // 
            ucUsuarioLista1.Location = new Point(3, 3);
            ucUsuarioLista1.Name = "ucUsuarioLista1";
            ucUsuarioLista1.Size = new Size(671, 63);
            ucUsuarioLista1.TabIndex = 0;
            ucUsuarioLista1.usuario = null;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(149, 388);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(472, 388);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // UsuariosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnCrear);
            Controls.Add(flpUsuarios);
            Name = "UsuariosLista";
            Text = "UsuariosLista";
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