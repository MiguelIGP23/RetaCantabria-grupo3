namespace Forms
{
    partial class ImagenesPeligroLista
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
            flpImagenes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpImagenes
            // 
            flpImagenes.AutoScroll = true;
            flpImagenes.Location = new Point(50, 55);
            flpImagenes.Name = "flpImagenes";
            flpImagenes.Size = new Size(700, 295);
            flpImagenes.TabIndex = 0;
            // 
            // ImagenesPeligroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpImagenes);
            Name = "ImagenesPeligroLista";
            Text = "ImagenesPeligroLista";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpImagenes;
    }
}