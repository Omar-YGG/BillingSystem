
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmListaEmpleados
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
            this.LblAdminEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgEmpleados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdminEmpleados
            // 
            this.LblAdminEmpleados.AutoSize = true;
            this.LblAdminEmpleados.Depth = 0;
            this.LblAdminEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdminEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdminEmpleados.Location = new System.Drawing.Point(401, 21);
            this.LblAdminEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdminEmpleados.Name = "LblAdminEmpleados";
            this.LblAdminEmpleados.Size = new System.Drawing.Size(241, 19);
            this.LblAdminEmpleados.TabIndex = 0;
            this.LblAdminEmpleados.Text = "ADMINISTRADOR DE EMPLEADOS";
            this.LblAdminEmpleados.Click += new System.EventHandler(this.LblAdminClientes_Click);
            // 
            // TxtBuscarEmpleado
            // 
            this.TxtBuscarEmpleado.Depth = 0;
            this.TxtBuscarEmpleado.Hint = "Buscar Empleado";
            this.TxtBuscarEmpleado.Location = new System.Drawing.Point(219, 80);
            this.TxtBuscarEmpleado.MaxLength = 32767;
            this.TxtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarEmpleado.Name = "TxtBuscarEmpleado";
            this.TxtBuscarEmpleado.PasswordChar = '\0';
            this.TxtBuscarEmpleado.SelectedText = "";
            this.TxtBuscarEmpleado.SelectionLength = 0;
            this.TxtBuscarEmpleado.SelectionStart = 0;
            this.TxtBuscarEmpleado.Size = new System.Drawing.Size(351, 23);
            this.TxtBuscarEmpleado.TabIndex = 1;
            this.TxtBuscarEmpleado.TabStop = false;
            this.TxtBuscarEmpleado.UseSystemPasswordChar = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AutoSize = true;
            this.BtnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.Depth = 0;
            this.BtnBuscar.Icon = null;
            this.BtnBuscar.Location = new System.Drawing.Point(655, 67);
            this.BtnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Primary = true;
            this.BtnBuscar.Size = new System.Drawing.Size(74, 36);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "BUSCAR";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.AutoSize = true;
            this.BtnNuevo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Depth = 0;
            this.BtnNuevo.Icon = null;
            this.BtnNuevo.Location = new System.Drawing.Point(771, 67);
            this.BtnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Primary = true;
            this.BtnNuevo.Size = new System.Drawing.Size(66, 36);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(771, 517);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR  ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DgEmpleados
            // 
            this.DgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.empleado,
            this.documento,
            this.telefono,
            this.BtnEditar,
            this.BtnBorrar});
            this.DgEmpleados.Location = new System.Drawing.Point(118, 132);
            this.DgEmpleados.Name = "DgEmpleados";
            this.DgEmpleados.Size = new System.Drawing.Size(747, 349);
            this.DgEmpleados.TabIndex = 6;
            this.DgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgEmpleados_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // empleado
            // 
            this.empleado.HeaderText = "EMPLEADO";
            this.empleado.Name = "empleado";
            this.empleado.Width = 300;
            // 
            // documento
            // 
            this.documento.HeaderText = "DOCUMENTO";
            this.documento.Name = "documento";
            this.documento.Width = 150;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            // 
            // BtnEditar
            // 
            this.BtnEditar.HeaderText = "EDITAR";
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseColumnTextForButtonValue = true;
            this.BtnEditar.Width = 60;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.HeaderText = "BORRAR";
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Text = "BORRAR";
            this.BtnBorrar.UseColumnTextForButtonValue = true;
            this.BtnBorrar.Width = 60;
            // 
            // FrmListaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(988, 606);
            this.Controls.Add(this.DgEmpleados);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarEmpleado);
            this.Controls.Add(this.LblAdminEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAdminEmpleados;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridView DgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
    }
}