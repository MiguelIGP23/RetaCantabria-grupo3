namespace Forms
{
    partial class Actividad
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
            btn_Nueva = new Button();
            flpActividad = new FlowLayoutPanel();
            ucActividaLista1 = new UserControls.UCActividaLista();
            btn_Editar = new Button();
            btn_Borrar = new Button();
            btn_Volver = new Button();
            flpActividad.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Nueva
            // 
            btn_Nueva.Location = new Point(256, 256);
            btn_Nueva.Name = "btn_Nueva";
            btn_Nueva.Size = new Size(75, 23);
            btn_Nueva.TabIndex = 1;
            btn_Nueva.Text = "Nuevo";
            btn_Nueva.UseVisualStyleBackColor = true;
            btn_Nueva.Click += btn_Nueva_Click;
            // 
            // flpActividad
            // 
            flpActividad.Controls.Add(ucActividaLista1);
            flpActividad.Location = new Point(43, 25);
            flpActividad.Name = "flpActividad";
            flpActividad.Size = new Size(409, 214);
            flpActividad.TabIndex = 2;
            // 
            // ucActividaLista1
            // 
            ucActividaLista1.Actividad = null;
            ucActividaLista1.Location = new Point(3, 3);
            ucActividaLista1.Name = "ucActividaLista1";
            ucActividaLista1.Size = new Size(400, 88);
            ucActividaLista1.TabIndex = 0;
            // 
            // btn_Editar
            // 
            btn_Editar.Location = new Point(43, 256);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(75, 23);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "Editar";
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Borrar
            // 
            btn_Borrar.Location = new Point(150, 256);
            btn_Borrar.Name = "btn_Borrar";
            btn_Borrar.Size = new Size(75, 23);
            btn_Borrar.TabIndex = 4;
            btn_Borrar.Text = "Borrar";
            btn_Borrar.UseVisualStyleBackColor = true;
            btn_Borrar.Click += btn_Borrar_Click;
            // 
            // btn_Volver
            // 
            btn_Volver.Location = new Point(377, 256);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(75, 23);
            btn_Volver.TabIndex = 5;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // Actividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 309);
            Controls.Add(btn_Volver);
            Controls.Add(btn_Borrar);
            Controls.Add(btn_Editar);
            Controls.Add(flpActividad);
            Controls.Add(btn_Nueva);
            Name = "Actividad";
            Text = "Actividad";
            Load += Actividad_Load;
            flpActividad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Nueva;
        private FlowLayoutPanel flpActividad;
        private Button btn_Editar;
        private Button btn_Borrar;
        private UserControls.UCActividaLista ucActividaLista1;
        private Button btn_Volver;
    }
}