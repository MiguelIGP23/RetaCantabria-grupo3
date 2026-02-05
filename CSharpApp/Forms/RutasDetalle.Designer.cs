namespace Forms
{
    partial class RutasDetalle
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
            ucRutaCompleto1 = new UserControls.UCRutaCompleto();
            btnPuntosPeligro = new Button();
            btnPuntosInteres = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // ucRutaCompleto1
            // 
            ucRutaCompleto1.Location = new Point(14, 16);
            ucRutaCompleto1.Margin = new Padding(3, 5, 3, 5);
            ucRutaCompleto1.Name = "ucRutaCompleto1";
            ucRutaCompleto1.Ruta = null;
            ucRutaCompleto1.Size = new Size(800, 528);
            ucRutaCompleto1.TabIndex = 0;
            // 
            // btnPuntosPeligro
            // 
            btnPuntosPeligro.Location = new Point(320, 552);
            btnPuntosPeligro.Margin = new Padding(3, 4, 3, 4);
            btnPuntosPeligro.Name = "btnPuntosPeligro";
            btnPuntosPeligro.Size = new Size(149, 31);
            btnPuntosPeligro.TabIndex = 2;
            btnPuntosPeligro.Text = "Puntos de peligro";
            btnPuntosPeligro.UseVisualStyleBackColor = true;
            btnPuntosPeligro.Click += btnPuntosPeligro_Click;
            // 
            // btnPuntosInteres
            // 
            btnPuntosInteres.Location = new Point(552, 552);
            btnPuntosInteres.Margin = new Padding(3, 4, 3, 4);
            btnPuntosInteres.Name = "btnPuntosInteres";
            btnPuntosInteres.Size = new Size(149, 31);
            btnPuntosInteres.TabIndex = 3;
            btnPuntosInteres.Text = "Puntos de interés";
            btnPuntosInteres.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(100, 552);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(149, 31);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // RutasDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 625);
            Controls.Add(btnVolver);
            Controls.Add(btnPuntosInteres);
            Controls.Add(btnPuntosPeligro);
            Controls.Add(ucRutaCompleto1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RutasDetalle";
            Text = "RutasDetalle";
            Load += RutasDetalle_Load;
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCRutaCompleto ucRutaCompleto1;
        private Button btnPuntosPeligro;
        private Button btnPuntosInteres;
        private Button btnVolver;
    }
}