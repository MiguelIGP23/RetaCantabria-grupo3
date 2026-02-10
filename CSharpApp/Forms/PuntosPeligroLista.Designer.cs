namespace Forms
{
    partial class PuntosPeligroLista
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
            flpPuntosPeligro = new FlowLayoutPanel();
            ucPuntoPeligroLista1 = new UserControls.UCPuntoPeligroLista();
            btnVolver = new Button();
            flpPuntosPeligro.SuspendLayout();
            SuspendLayout();
            // 
            // flpPuntosPeligro
            // 
            flpPuntosPeligro.AutoScroll = true;
            flpPuntosPeligro.Controls.Add(ucPuntoPeligroLista1);
            flpPuntosPeligro.Location = new Point(41, 41);
            flpPuntosPeligro.Name = "flpPuntosPeligro";
            flpPuntosPeligro.Size = new Size(726, 324);
            flpPuntosPeligro.TabIndex = 0;
            // 
            // ucPuntoPeligroLista1
            // 
            ucPuntoPeligroLista1.Location = new Point(3, 4);
            ucPuntoPeligroLista1.Margin = new Padding(3, 4, 3, 4);
            ucPuntoPeligroLista1.Name = "ucPuntoPeligroLista1";
            ucPuntoPeligroLista1.PuntoPeligro = null;
            ucPuntoPeligroLista1.Size = new Size(709, 100);
            ucPuntoPeligroLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(312, 388);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // PuntosPeligroLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(btnVolver);
            Controls.Add(flpPuntosPeligro);
            Name = "PuntosPeligroLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PuntosPeligroLista";
            Load += PuntosPeligroLista_Load;
            flpPuntosPeligro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpPuntosPeligro;
        private UserControls.UCPuntoPeligroLista ucPuntoPeligroLista1;
        private Button btnVolver;
    }
}