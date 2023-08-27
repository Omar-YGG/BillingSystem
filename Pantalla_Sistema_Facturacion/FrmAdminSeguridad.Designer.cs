
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmAdminSeguridad
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
            this.LblAdminCuentasSistema = new MaterialSkin.Controls.MaterialLabel();
            this.TxtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.CbbEmpleados = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblAdminCuentasSistema
            // 
            this.LblAdminCuentasSistema.AutoSize = true;
            this.LblAdminCuentasSistema.Depth = 0;
            this.LblAdminCuentasSistema.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdminCuentasSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdminCuentasSistema.Location = new System.Drawing.Point(261, 19);
            this.LblAdminCuentasSistema.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdminCuentasSistema.Name = "LblAdminCuentasSistema";
            this.LblAdminCuentasSistema.Size = new System.Drawing.Size(320, 19);
            this.LblAdminCuentasSistema.TabIndex = 0;
            this.LblAdminCuentasSistema.Text = "ADMINISTRADOR DE CUENTAS DEL SISTEMA";
            this.LblAdminCuentasSistema.Click += new System.EventHandler(this.LblAdminClientes_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Depth = 0;
            this.TxtUsuario.Hint = "Usuario";
            this.TxtUsuario.Location = new System.Drawing.Point(253, 116);
            this.TxtUsuario.MaxLength = 32767;
            this.TxtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.PasswordChar = '\0';
            this.TxtUsuario.SelectedText = "";
            this.TxtUsuario.SelectionLength = 0;
            this.TxtUsuario.SelectionStart = 0;
            this.TxtUsuario.Size = new System.Drawing.Size(256, 23);
            this.TxtUsuario.TabIndex = 1;
            this.TxtUsuario.TabStop = false;
            this.TxtUsuario.UseSystemPasswordChar = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(293, 198);
            this.BtnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Primary = true;
            this.BtnActualizar.Size = new System.Drawing.Size(103, 36);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(533, 198);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR  ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtClave
            // 
            this.TxtClave.Depth = 0;
            this.TxtClave.Hint = "Clave";
            this.TxtClave.Location = new System.Drawing.Point(253, 157);
            this.TxtClave.MaxLength = 32767;
            this.TxtClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '\0';
            this.TxtClave.SelectedText = "";
            this.TxtClave.SelectionLength = 0;
            this.TxtClave.SelectionStart = 0;
            this.TxtClave.Size = new System.Drawing.Size(256, 23);
            this.TxtClave.TabIndex = 6;
            this.TxtClave.TabStop = false;
            this.TxtClave.UseSystemPasswordChar = false;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Depth = 0;
            this.LblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEmpleado.Location = new System.Drawing.Point(249, 76);
            this.LblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.LblEmpleado.TabIndex = 7;
            this.LblEmpleado.Text = "Empleado";
            // 
            // CbbEmpleados
            // 
            this.CbbEmpleados.FormattingEnabled = true;
            this.CbbEmpleados.Location = new System.Drawing.Point(343, 74);
            this.CbbEmpleados.Name = "CbbEmpleados";
            this.CbbEmpleados.Size = new System.Drawing.Size(248, 21);
            this.CbbEmpleados.TabIndex = 8;
            // 
            // FrmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(730, 381);
            this.Controls.Add(this.CbbEmpleados);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblAdminCuentasSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmAdminSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAdminCuentasSistema;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtClave;
        private MaterialSkin.Controls.MaterialLabel LblEmpleado;
        private System.Windows.Forms.ComboBox CbbEmpleados;
    }
}