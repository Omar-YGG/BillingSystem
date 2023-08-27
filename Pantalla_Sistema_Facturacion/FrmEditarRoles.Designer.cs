
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmEditarRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarRoles));
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.TxtRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new MaterialSkin.Controls.MaterialLabel();
            this.PnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(114, 29);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 19);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "NUEVOS DATOS";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtIdRol
            // 
            this.TxtIdRol.Depth = 0;
            this.TxtIdRol.Hint = "Codigo Rol";
            this.TxtIdRol.Location = new System.Drawing.Point(53, 102);
            this.TxtIdRol.MaxLength = 32767;
            this.TxtIdRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdRol.Name = "TxtIdRol";
            this.TxtIdRol.PasswordChar = '\0';
            this.TxtIdRol.SelectedText = "";
            this.TxtIdRol.SelectionLength = 0;
            this.TxtIdRol.SelectionStart = 0;
            this.TxtIdRol.Size = new System.Drawing.Size(81, 23);
            this.TxtIdRol.TabIndex = 1;
            this.TxtIdRol.TabStop = false;
            this.TxtIdRol.UseSystemPasswordChar = false;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.LblDescripcion);
            this.PnlDatos.Controls.Add(this.textBox1);
            this.PnlDatos.Controls.Add(this.TxtRol);
            this.PnlDatos.Location = new System.Drawing.Point(27, 131);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(312, 179);
            this.PnlDatos.TabIndex = 2;
            // 
            // TxtRol
            // 
            this.TxtRol.Depth = 0;
            this.TxtRol.Hint = "Nombre Rol";
            this.TxtRol.Location = new System.Drawing.Point(30, 22);
            this.TxtRol.MaxLength = 32767;
            this.TxtRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRol.Name = "TxtRol";
            this.TxtRol.PasswordChar = '\0';
            this.TxtRol.SelectedText = "";
            this.TxtRol.SelectionLength = 0;
            this.TxtRol.SelectionStart = 0;
            this.TxtRol.Size = new System.Drawing.Size(263, 23);
            this.TxtRol.TabIndex = 0;
            this.TxtRol.TabStop = false;
            this.TxtRol.UseSystemPasswordChar = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(31, 338);
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
            this.BtnSalir.Location = new System.Drawing.Point(272, 338);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 65);
            this.textBox1.TabIndex = 1;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Depth = 0;
            this.LblDescripcion.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDescripcion.Location = new System.Drawing.Point(26, 70);
            this.LblDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(254, 19);
            this.LblDescripcion.TabIndex = 2;
            this.LblDescripcion.Text = "DESCRIPCION DETALLADA DEL ROL";
            // 
            // FrmEditarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(368, 400);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.TxtIdRol);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditarRoles_Load);
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdRol;
        private System.Windows.Forms.Panel PnlDatos;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRol;
        private MaterialSkin.Controls.MaterialLabel LblDescripcion;
        private System.Windows.Forms.TextBox textBox1;
    }
}