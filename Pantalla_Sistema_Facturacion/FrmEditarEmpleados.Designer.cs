
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmEditarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarEmpleados));
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.DtpFchRetiro = new System.Windows.Forms.DateTimePicker();
            this.LblFchRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.DtpFchIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.LblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.LblRoles = new MaterialSkin.Controls.MaterialLabel();
            this.CbbCategorias = new System.Windows.Forms.ComboBox();
            this.TxtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.LblTitulo.Location = new System.Drawing.Point(303, 34);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 19);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "NUEVOS DATOS";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtIdEmpleado
            // 
            this.TxtIdEmpleado.Depth = 0;
            this.TxtIdEmpleado.Hint = "ID";
            this.TxtIdEmpleado.Location = new System.Drawing.Point(53, 102);
            this.TxtIdEmpleado.MaxLength = 32767;
            this.TxtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdEmpleado.Name = "TxtIdEmpleado";
            this.TxtIdEmpleado.PasswordChar = '\0';
            this.TxtIdEmpleado.SelectedText = "";
            this.TxtIdEmpleado.SelectionLength = 0;
            this.TxtIdEmpleado.SelectionStart = 0;
            this.TxtIdEmpleado.Size = new System.Drawing.Size(32, 23);
            this.TxtIdEmpleado.TabIndex = 1;
            this.TxtIdEmpleado.TabStop = false;
            this.TxtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.DtpFchRetiro);
            this.PnlDatos.Controls.Add(this.LblFchRetiro);
            this.PnlDatos.Controls.Add(this.DtpFchIngreso);
            this.PnlDatos.Controls.Add(this.materialLabel1);
            this.PnlDatos.Controls.Add(this.LblDatosAdicionales);
            this.PnlDatos.Controls.Add(this.TxtDatosAdicionales);
            this.PnlDatos.Controls.Add(this.LblRoles);
            this.PnlDatos.Controls.Add(this.CbbCategorias);
            this.PnlDatos.Controls.Add(this.TxtEmail);
            this.PnlDatos.Controls.Add(this.TxtTelefono);
            this.PnlDatos.Controls.Add(this.TxtDireccion);
            this.PnlDatos.Controls.Add(this.TxtDocumento);
            this.PnlDatos.Controls.Add(this.TxtNombre);
            this.PnlDatos.Location = new System.Drawing.Point(27, 131);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(705, 241);
            this.PnlDatos.TabIndex = 2;
            // 
            // DtpFchRetiro
            // 
            this.DtpFchRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFchRetiro.Location = new System.Drawing.Point(501, 98);
            this.DtpFchRetiro.Name = "DtpFchRetiro";
            this.DtpFchRetiro.Size = new System.Drawing.Size(79, 20);
            this.DtpFchRetiro.TabIndex = 14;
            // 
            // LblFchRetiro
            // 
            this.LblFchRetiro.AutoSize = true;
            this.LblFchRetiro.Depth = 0;
            this.LblFchRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFchRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFchRetiro.Location = new System.Drawing.Point(392, 98);
            this.LblFchRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFchRetiro.Name = "LblFchRetiro";
            this.LblFchRetiro.Size = new System.Drawing.Size(93, 19);
            this.LblFchRetiro.TabIndex = 13;
            this.LblFchRetiro.Text = "Fecha Retiro";
            // 
            // DtpFchIngreso
            // 
            this.DtpFchIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFchIngreso.Location = new System.Drawing.Point(501, 59);
            this.DtpFchIngreso.Name = "DtpFchIngreso";
            this.DtpFchIngreso.Size = new System.Drawing.Size(79, 20);
            this.DtpFchIngreso.TabIndex = 12;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(392, 59);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(103, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Fecha Ingreso";
            // 
            // LblDatosAdicionales
            // 
            this.LblDatosAdicionales.AutoSize = true;
            this.LblDatosAdicionales.Depth = 0;
            this.LblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDatosAdicionales.Location = new System.Drawing.Point(392, 137);
            this.LblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDatosAdicionales.Name = "LblDatosAdicionales";
            this.LblDatosAdicionales.Size = new System.Drawing.Size(132, 19);
            this.LblDatosAdicionales.TabIndex = 10;
            this.LblDatosAdicionales.Text = "Datos Adicionales";
            // 
            // TxtDatosAdicionales
            // 
            this.TxtDatosAdicionales.Location = new System.Drawing.Point(396, 159);
            this.TxtDatosAdicionales.Multiline = true;
            this.TxtDatosAdicionales.Name = "TxtDatosAdicionales";
            this.TxtDatosAdicionales.Size = new System.Drawing.Size(294, 63);
            this.TxtDatosAdicionales.TabIndex = 9;
            // 
            // LblRoles
            // 
            this.LblRoles.AutoSize = true;
            this.LblRoles.Depth = 0;
            this.LblRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblRoles.Location = new System.Drawing.Point(392, 18);
            this.LblRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblRoles.Name = "LblRoles";
            this.LblRoles.Size = new System.Drawing.Size(102, 19);
            this.LblRoles.TabIndex = 7;
            this.LblRoles.Text = "Rol Empleado";
            // 
            // CbbCategorias
            // 
            this.CbbCategorias.AccessibleName = "";
            this.CbbCategorias.CausesValidation = false;
            this.CbbCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbbCategorias.FormattingEnabled = true;
            this.CbbCategorias.Location = new System.Drawing.Point(500, 16);
            this.CbbCategorias.Name = "CbbCategorias";
            this.CbbCategorias.Size = new System.Drawing.Size(190, 21);
            this.CbbCategorias.TabIndex = 5;
            this.CbbCategorias.Tag = "";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Depth = 0;
            this.TxtEmail.Hint = "Email";
            this.TxtEmail.Location = new System.Drawing.Point(43, 177);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.Size = new System.Drawing.Size(300, 23);
            this.TxtEmail.TabIndex = 4;
            this.TxtEmail.TabStop = false;
            this.TxtEmail.UseSystemPasswordChar = false;
            this.TxtEmail.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Depth = 0;
            this.TxtTelefono.Hint = "Telefono";
            this.TxtTelefono.Location = new System.Drawing.Point(43, 137);
            this.TxtTelefono.MaxLength = 32767;
            this.TxtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PasswordChar = '\0';
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.SelectionLength = 0;
            this.TxtTelefono.SelectionStart = 0;
            this.TxtTelefono.Size = new System.Drawing.Size(300, 23);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.TabStop = false;
            this.TxtTelefono.UseSystemPasswordChar = false;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Depth = 0;
            this.TxtDireccion.Hint = "Direccion";
            this.TxtDireccion.Location = new System.Drawing.Point(43, 94);
            this.TxtDireccion.MaxLength = 32767;
            this.TxtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.PasswordChar = '\0';
            this.TxtDireccion.SelectedText = "";
            this.TxtDireccion.SelectionLength = 0;
            this.TxtDireccion.SelectionStart = 0;
            this.TxtDireccion.Size = new System.Drawing.Size(300, 23);
            this.TxtDireccion.TabIndex = 2;
            this.TxtDireccion.TabStop = false;
            this.TxtDireccion.UseSystemPasswordChar = false;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Depth = 0;
            this.TxtDocumento.Hint = "Documento";
            this.TxtDocumento.Location = new System.Drawing.Point(43, 55);
            this.TxtDocumento.MaxLength = 32767;
            this.TxtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.PasswordChar = '\0';
            this.TxtDocumento.SelectedText = "";
            this.TxtDocumento.SelectionLength = 0;
            this.TxtDocumento.SelectionStart = 0;
            this.TxtDocumento.Size = new System.Drawing.Size(300, 23);
            this.TxtDocumento.TabIndex = 1;
            this.TxtDocumento.TabStop = false;
            this.TxtDocumento.UseSystemPasswordChar = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Depth = 0;
            this.TxtNombre.Hint = "Nombre";
            this.TxtNombre.Location = new System.Drawing.Point(43, 14);
            this.TxtNombre.MaxLength = 32767;
            this.TxtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.PasswordChar = '\0';
            this.TxtNombre.SelectedText = "";
            this.TxtNombre.SelectionLength = 0;
            this.TxtNombre.SelectionStart = 0;
            this.TxtNombre.Size = new System.Drawing.Size(300, 23);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.UseSystemPasswordChar = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(53, 378);
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
            this.BtnSalir.Location = new System.Drawing.Point(674, 378);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmEditarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(761, 451);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.TxtIdEmpleado);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditarEmpleados_Load);
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdEmpleado;
        private System.Windows.Forms.Panel PnlDatos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombre;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialLabel LblDatosAdicionales;
        private System.Windows.Forms.TextBox TxtDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel LblRoles;
        private System.Windows.Forms.ComboBox CbbCategorias;
        private System.Windows.Forms.DateTimePicker DtpFchRetiro;
        private MaterialSkin.Controls.MaterialLabel LblFchRetiro;
        private System.Windows.Forms.DateTimePicker DtpFchIngreso;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}