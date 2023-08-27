
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnValidar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 250);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(21, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(316, 27);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(117, 19);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "INICIAR SESION";
            this.LblTitulo.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUser.Depth = 0;
            this.TxtUser.Hint = "User";
            this.TxtUser.Location = new System.Drawing.Point(254, 78);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.SelectedText = "";
            this.TxtUser.SelectionLength = 0;
            this.TxtUser.SelectionStart = 0;
            this.TxtUser.Size = new System.Drawing.Size(226, 23);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.TabStop = false;
            this.TxtUser.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Hint = "Password";
            this.TxtPassword.Location = new System.Drawing.Point(254, 125);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '°';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(226, 23);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // BtnValidar
            // 
            this.BtnValidar.AutoSize = true;
            this.BtnValidar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.BtnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnValidar.Depth = 0;
            this.BtnValidar.Icon = null;
            this.BtnValidar.Location = new System.Drawing.Point(254, 191);
            this.BtnValidar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Primary = true;
            this.BtnValidar.Size = new System.Drawing.Size(77, 36);
            this.BtnValidar.TabIndex = 4;
            this.BtnValidar.Text = "VALIDAR";
            this.BtnValidar.UseVisualStyleBackColor = false;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AutoSize = true;
            this.BtnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.Depth = 0;
            this.BtnCancelar.Icon = null;
            this.BtnCancelar.Location = new System.Drawing.Point(389, 191);
            this.BtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Primary = true;
            this.BtnCancelar.Size = new System.Drawing.Size(91, 36);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(550, 250);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton BtnValidar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnCancelar;
    }
}

