
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmEditarCategorias
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarCategorias));
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.TxtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(196, 31);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 19);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "NUEVOS DATOS";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtIdCategoria
            // 
            this.TxtIdCategoria.Depth = 0;
            this.TxtIdCategoria.Hint = "Codigo";
            this.TxtIdCategoria.Location = new System.Drawing.Point(53, 102);
            this.TxtIdCategoria.MaxLength = 32767;
            this.TxtIdCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdCategoria.Name = "TxtIdCategoria";
            this.TxtIdCategoria.PasswordChar = '\0';
            this.TxtIdCategoria.SelectedText = "";
            this.TxtIdCategoria.SelectionLength = 0;
            this.TxtIdCategoria.SelectionStart = 0;
            this.TxtIdCategoria.Size = new System.Drawing.Size(60, 23);
            this.TxtIdCategoria.TabIndex = 1;
            this.TxtIdCategoria.TabStop = false;
            this.TxtIdCategoria.UseSystemPasswordChar = false;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.TxtCategoria);
            this.PnlDatos.Location = new System.Drawing.Point(27, 131);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(468, 155);
            this.PnlDatos.TabIndex = 2;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Depth = 0;
            this.TxtCategoria.Hint = "Nombre Categoria";
            this.TxtCategoria.Location = new System.Drawing.Point(26, 40);
            this.TxtCategoria.MaxLength = 32767;
            this.TxtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.PasswordChar = '\0';
            this.TxtCategoria.SelectedText = "";
            this.TxtCategoria.SelectionLength = 0;
            this.TxtCategoria.SelectionStart = 0;
            this.TxtCategoria.Size = new System.Drawing.Size(400, 23);
            this.TxtCategoria.TabIndex = 0;
            this.TxtCategoria.TabStop = false;
            this.TxtCategoria.UseSystemPasswordChar = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(53, 319);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 3;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(395, 319);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmEditarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(531, 400);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.TxtIdCategoria);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditarCategorias_Load);
            this.PnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdCategoria;
        private System.Windows.Forms.Panel PnlDatos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCategoria;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}