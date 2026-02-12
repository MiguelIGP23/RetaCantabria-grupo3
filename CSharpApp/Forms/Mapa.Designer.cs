namespace Forms
{
    partial class Mapa
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
            wbMapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)wbMapa).BeginInit();
            SuspendLayout();
            // 
            // wbMapa
            // 
            wbMapa.AllowExternalDrop = true;
            wbMapa.CreationProperties = null;
            wbMapa.DefaultBackgroundColor = Color.White;
            wbMapa.Dock = DockStyle.Fill;
            wbMapa.Location = new Point(0, 0);
            wbMapa.Name = "wbMapa";
            wbMapa.Size = new Size(800, 450);
            wbMapa.TabIndex = 0;
            wbMapa.ZoomFactor = 1D;
            // 
            // Mapa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(wbMapa);
            Name = "Mapa";
            Text = "Mapa";
            Load += Mapa_Load;
            ((System.ComponentModel.ISupportInitialize)wbMapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wbMapa;
    }
}