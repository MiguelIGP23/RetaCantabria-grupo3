namespace Forms
{
    partial class ActividadLista
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
            flpActividad = new FlowLayoutPanel();
            ucActividaLista1 = new UserControls.UCActividaLista();
            btnVolver = new Button();
            btnCrear = new Button();
            flpActividad.SuspendLayout();
            SuspendLayout();
            // 
            // flpActividad
            // 
            flpActividad.Controls.Add(ucActividaLista1);
            flpActividad.Location = new Point(64, 57);
            flpActividad.Margin = new Padding(3, 4, 3, 4);
            flpActividad.Name = "flpActividad";
            flpActividad.Size = new Size(774, 351);
            flpActividad.TabIndex = 0;
            // 
            // ucActividaLista1
            // 
            ucActividaLista1.Actividad = null;
            ucActividaLista1.Location = new Point(3, 5);
            ucActividaLista1.Margin = new Padding(3, 5, 3, 5);
            ucActividaLista1.Name = "ucActividaLista1";
            ucActividaLista1.Size = new Size(758, 133);
            ucActividaLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(263, 443);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 31);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(494, 443);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 31);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // ActividadLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 516);
            Controls.Add(btnCrear);
            Controls.Add(btnVolver);
            Controls.Add(flpActividad);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActividadLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ActividadLista";
            Load += ActividadLista_Load;
            flpActividad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpActividad;
        private Button btnVolver;
        private UserControls.UCActividaLista ucActividaLista1;
        private Button btnCrear;
    }
}