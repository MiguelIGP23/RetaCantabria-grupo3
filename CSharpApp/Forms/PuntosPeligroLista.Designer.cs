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
            flpPuntosPeligro.Location = new Point(40, 40);
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
            btnVolver.BackColor = Color.DarkSeaGreen;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Location = new Point(65, 400);
            btnVolver.Margin = new Padding(0);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(690, 40);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // PuntosPeligroLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 234, 193);
            ClientSize = new Size(802, 463);
            Controls.Add(btnVolver);
            Controls.Add(flpPuntosPeligro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PuntosPeligroLista";
            StartPosition = FormStartPosition.CenterScreen;
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