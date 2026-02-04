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
            ucRutaCompleto1.Location = new Point(12, 12);
            ucRutaCompleto1.Name = "ucRutaCompleto1";
            ucRutaCompleto1.Ruta = null;
            ucRutaCompleto1.Size = new Size(700, 396);
            ucRutaCompleto1.TabIndex = 0;
            // 
            // btnPuntosPeligro
            // 
            btnPuntosPeligro.Location = new Point(295, 414);
            btnPuntosPeligro.Name = "btnPuntosPeligro";
            btnPuntosPeligro.Size = new Size(130, 23);
            btnPuntosPeligro.TabIndex = 2;
            btnPuntosPeligro.Text = "Puntos de peligro";
            btnPuntosPeligro.UseVisualStyleBackColor = true;
            // 
            // btnPuntosInteres
            // 
            btnPuntosInteres.Location = new Point(495, 414);
            btnPuntosInteres.Name = "btnPuntosInteres";
            btnPuntosInteres.Size = new Size(130, 23);
            btnPuntosInteres.TabIndex = 3;
            btnPuntosInteres.Text = "Puntos de interés";
            btnPuntosInteres.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(101, 414);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // RutasDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 469);
            Controls.Add(btnVolver);
            Controls.Add(btnPuntosInteres);
            Controls.Add(btnPuntosPeligro);
            Controls.Add(ucRutaCompleto1);
            Name = "RutasDetalle";
            Text = "RutasDetalle";
            ResumeLayout(false);
        }

        #endregion

        private UserControls.UCRutaCompleto ucRutaCompleto1;
        private Button btnPuntosPeligro;
        private Button btnPuntosInteres;
        private Button btnVolver;
    }
}