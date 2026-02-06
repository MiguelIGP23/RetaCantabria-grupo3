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
            btnNuevo = new Button();
            flpPuntosPeligro.SuspendLayout();
            SuspendLayout();
            // 
            // flpPuntosPeligro
            // 
            flpPuntosPeligro.AutoScroll = true;
            flpPuntosPeligro.Controls.Add(ucPuntoPeligroLista1);
            flpPuntosPeligro.Location = new Point(36, 31);
            flpPuntosPeligro.Margin = new Padding(3, 2, 3, 2);
            flpPuntosPeligro.Name = "flpPuntosPeligro";
            flpPuntosPeligro.Size = new Size(635, 243);
            flpPuntosPeligro.TabIndex = 0;
            // 
            // ucPuntoPeligroLista1
            // 
            ucPuntoPeligroLista1.Location = new Point(3, 3);
            ucPuntoPeligroLista1.Name = "ucPuntoPeligroLista1";
            ucPuntoPeligroLista1.PuntoPeligro = null;
            ucPuntoPeligroLista1.Size = new Size(620, 75);
            ucPuntoPeligroLista1.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(120, 294);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(323, 293);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 23);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo punto";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // PuntosPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnNuevo);
            Controls.Add(btnVolver);
            Controls.Add(flpPuntosPeligro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PuntosPeligroLista";
            Text = "PuntosPeligroLista";
            Load += PuntosPeligroLista_Load;
            flpPuntosPeligro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpPuntosPeligro;
        private UserControls.UCPuntoPeligroLista ucPuntoPeligroLista1;
        private Button btnVolver;
        private Button btnNuevo;
    }
}