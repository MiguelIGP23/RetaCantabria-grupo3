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
            btnVolver = new Button();
            ucActividaLista1 = new UserControls.UCActividaLista();
            flpActividad.SuspendLayout();
            SuspendLayout();
            // 
            // flpActividad
            // 
            flpActividad.Controls.Add(ucActividaLista1);
            flpActividad.Location = new Point(56, 43);
            flpActividad.Name = "flpActividad";
            flpActividad.Size = new Size(677, 263);
            flpActividad.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(348, 371);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ucActividaLista1
            // 
            ucActividaLista1.Actividad = null;
            ucActividaLista1.Location = new Point(3, 3);
            ucActividaLista1.Name = "ucActividaLista1";
            ucActividaLista1.Size = new Size(674, 95);
            ucActividaLista1.TabIndex = 0;
            // 
            // ActividadLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(flpActividad);
            Name = "ActividadLista";
            Text = "ActividadLista";
            flpActividad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpActividad;
        private Button btnVolver;
        private UserControls.UCActividaLista ucActividaLista1;
    }
}