
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmAyuda
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
            this.WbAyuda = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WbAyuda
            // 
            this.WbAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WbAyuda.Location = new System.Drawing.Point(0, 0);
            this.WbAyuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.WbAyuda.Name = "WbAyuda";
            this.WbAyuda.Size = new System.Drawing.Size(871, 496);
            this.WbAyuda.TabIndex = 0;
            this.WbAyuda.Url = new System.Uri("https://www.microsoft.com/es-co", System.UriKind.Absolute);
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 496);
            this.Controls.Add(this.WbAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAyuda";
            this.Text = "FrmAyuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WbAyuda;
    }
}