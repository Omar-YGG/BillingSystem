
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmEditarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarFacturas));
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.LblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.LblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.CbbestadoFactura = new System.Windows.Forms.ComboBox();
            this.TxtTotalIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CbbClientes = new System.Windows.Forms.ComboBox();
            this.LblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.LblEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.CbbEmpleados = new System.Windows.Forms.ComboBox();
            this.TxtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.BtnBorrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblDetallesfactura = new MaterialSkin.Controls.MaterialLabel();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Depth = 0;
            this.LblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblTitulo.Location = new System.Drawing.Point(342, 35);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 19);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "NUEVOS DATOS";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtIdFactura
            // 
            this.TxtIdFactura.Depth = 0;
            this.TxtIdFactura.Hint = "Numero Factura";
            this.TxtIdFactura.Location = new System.Drawing.Point(53, 102);
            this.TxtIdFactura.MaxLength = 32767;
            this.TxtIdFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdFactura.Name = "TxtIdFactura";
            this.TxtIdFactura.PasswordChar = '\0';
            this.TxtIdFactura.SelectedText = "";
            this.TxtIdFactura.SelectionLength = 0;
            this.TxtIdFactura.SelectionStart = 0;
            this.TxtIdFactura.Size = new System.Drawing.Size(118, 23);
            this.TxtIdFactura.TabIndex = 1;
            this.TxtIdFactura.TabStop = false;
            this.TxtIdFactura.UseSystemPasswordChar = false;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.DtpFechaRegistro);
            this.PnlDatos.Controls.Add(this.TxtTotalFactura);
            this.PnlDatos.Controls.Add(this.LblEmpleados);
            this.PnlDatos.Controls.Add(this.CbbEmpleados);
            this.PnlDatos.Controls.Add(this.LblCliente);
            this.PnlDatos.Controls.Add(this.CbbClientes);
            this.PnlDatos.Controls.Add(this.LblDetallesProducto);
            this.PnlDatos.Controls.Add(this.LblEstadoFactura);
            this.PnlDatos.Controls.Add(this.CbbestadoFactura);
            this.PnlDatos.Controls.Add(this.TxtTotalIVA);
            this.PnlDatos.Controls.Add(this.TxtDescuento);
            this.PnlDatos.Location = new System.Drawing.Point(27, 131);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(647, 217);
            this.PnlDatos.TabIndex = 2;
            // 
            // LblDetallesProducto
            // 
            this.LblDetallesProducto.AutoSize = true;
            this.LblDetallesProducto.Depth = 0;
            this.LblDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDetallesProducto.Location = new System.Drawing.Point(481, 17);
            this.LblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDetallesProducto.Name = "LblDetallesProducto";
            this.LblDetallesProducto.Size = new System.Drawing.Size(153, 19);
            this.LblDetallesProducto.TabIndex = 10;
            this.LblDetallesProducto.Text = "Detalles del Producto";
            // 
            // LblEstadoFactura
            // 
            this.LblEstadoFactura.AutoSize = true;
            this.LblEstadoFactura.Depth = 0;
            this.LblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEstadoFactura.Location = new System.Drawing.Point(481, 78);
            this.LblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEstadoFactura.Name = "LblEstadoFactura";
            this.LblEstadoFactura.Size = new System.Drawing.Size(110, 19);
            this.LblEstadoFactura.TabIndex = 7;
            this.LblEstadoFactura.Text = "Estado Factura";
            // 
            // CbbestadoFactura
            // 
            this.CbbestadoFactura.AccessibleName = "";
            this.CbbestadoFactura.CausesValidation = false;
            this.CbbestadoFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbbestadoFactura.FormattingEnabled = true;
            this.CbbestadoFactura.Location = new System.Drawing.Point(485, 100);
            this.CbbestadoFactura.Name = "CbbestadoFactura";
            this.CbbestadoFactura.Size = new System.Drawing.Size(124, 21);
            this.CbbestadoFactura.TabIndex = 5;
            this.CbbestadoFactura.Tag = "";
            // 
            // TxtTotalIVA
            // 
            this.TxtTotalIVA.Depth = 0;
            this.TxtTotalIVA.Hint = "Total IVA";
            this.TxtTotalIVA.Location = new System.Drawing.Point(26, 134);
            this.TxtTotalIVA.MaxLength = 32767;
            this.TxtTotalIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotalIVA.Name = "TxtTotalIVA";
            this.TxtTotalIVA.PasswordChar = '\0';
            this.TxtTotalIVA.SelectedText = "";
            this.TxtTotalIVA.SelectionLength = 0;
            this.TxtTotalIVA.SelectionStart = 0;
            this.TxtTotalIVA.Size = new System.Drawing.Size(300, 23);
            this.TxtTotalIVA.TabIndex = 4;
            this.TxtTotalIVA.TabStop = false;
            this.TxtTotalIVA.UseSystemPasswordChar = false;
            this.TxtTotalIVA.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Depth = 0;
            this.TxtDescuento.Hint = "Descuento";
            this.TxtDescuento.Location = new System.Drawing.Point(26, 94);
            this.TxtDescuento.MaxLength = 32767;
            this.TxtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.PasswordChar = '\0';
            this.TxtDescuento.SelectedText = "";
            this.TxtDescuento.SelectionLength = 0;
            this.TxtDescuento.SelectionStart = 0;
            this.TxtDescuento.Size = new System.Drawing.Size(300, 23);
            this.TxtDescuento.TabIndex = 3;
            this.TxtDescuento.TabStop = false;
            this.TxtDescuento.UseSystemPasswordChar = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSize = true;
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.Depth = 0;
            this.BtnActualizar.Icon = null;
            this.BtnActualizar.Location = new System.Drawing.Point(689, 131);
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
            this.BtnSalir.Location = new System.Drawing.Point(689, 222);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CbbClientes
            // 
            this.CbbClientes.FormattingEnabled = true;
            this.CbbClientes.Location = new System.Drawing.Point(104, 18);
            this.CbbClientes.Name = "CbbClientes";
            this.CbbClientes.Size = new System.Drawing.Size(331, 21);
            this.CbbClientes.TabIndex = 11;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Depth = 0;
            this.LblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCliente.Location = new System.Drawing.Point(22, 18);
            this.LblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(56, 19);
            this.LblCliente.TabIndex = 12;
            this.LblCliente.Text = "Cliente";
            // 
            // LblEmpleados
            // 
            this.LblEmpleados.AutoSize = true;
            this.LblEmpleados.Depth = 0;
            this.LblEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblEmpleados.Location = new System.Drawing.Point(22, 55);
            this.LblEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblEmpleados.Name = "LblEmpleados";
            this.LblEmpleados.Size = new System.Drawing.Size(76, 19);
            this.LblEmpleados.TabIndex = 14;
            this.LblEmpleados.Text = "Empleado";
            // 
            // CbbEmpleados
            // 
            this.CbbEmpleados.FormattingEnabled = true;
            this.CbbEmpleados.Location = new System.Drawing.Point(104, 55);
            this.CbbEmpleados.Name = "CbbEmpleados";
            this.CbbEmpleados.Size = new System.Drawing.Size(331, 21);
            this.CbbEmpleados.TabIndex = 13;
            // 
            // TxtTotalFactura
            // 
            this.TxtTotalFactura.Depth = 0;
            this.TxtTotalFactura.Hint = "Total Factura";
            this.TxtTotalFactura.Location = new System.Drawing.Point(26, 177);
            this.TxtTotalFactura.MaxLength = 32767;
            this.TxtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtTotalFactura.Name = "TxtTotalFactura";
            this.TxtTotalFactura.PasswordChar = '\0';
            this.TxtTotalFactura.SelectedText = "";
            this.TxtTotalFactura.SelectionLength = 0;
            this.TxtTotalFactura.SelectionStart = 0;
            this.TxtTotalFactura.Size = new System.Drawing.Size(300, 23);
            this.TxtTotalFactura.TabIndex = 15;
            this.TxtTotalFactura.TabStop = false;
            this.TxtTotalFactura.UseSystemPasswordChar = false;
            // 
            // DtpFechaRegistro
            // 
            this.DtpFechaRegistro.CustomFormat = "";
            this.DtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaRegistro.Location = new System.Drawing.Point(485, 39);
            this.DtpFechaRegistro.Name = "DtpFechaRegistro";
            this.DtpFechaRegistro.Size = new System.Drawing.Size(102, 20);
            this.DtpFechaRegistro.TabIndex = 16;
            this.DtpFechaRegistro.Value = new System.DateTime(2023, 8, 21, 12, 31, 42, 0);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.AutoSize = true;
            this.BtnBorrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnBorrar.Depth = 0;
            this.BtnBorrar.Icon = null;
            this.BtnBorrar.Location = new System.Drawing.Point(689, 178);
            this.BtnBorrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Primary = true;
            this.BtnBorrar.Size = new System.Drawing.Size(83, 36);
            this.BtnBorrar.TabIndex = 5;
            this.BtnBorrar.Text = "Eliminar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblDetallesfactura);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(27, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 170);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.cantidad,
            this.valor,
            this.total,
            this.editar,
            this.borrar});
            this.dataGridView1.Location = new System.Drawing.Point(63, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 118);
            this.dataGridView1.TabIndex = 0;
            // 
            // LblDetallesfactura
            // 
            this.LblDetallesfactura.AutoSize = true;
            this.LblDetallesfactura.Depth = 0;
            this.LblDetallesfactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDetallesfactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDetallesfactura.Location = new System.Drawing.Point(22, 0);
            this.LblDetallesfactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDetallesfactura.Name = "LblDetallesfactura";
            this.LblDetallesfactura.Size = new System.Drawing.Size(142, 19);
            this.LblDetallesfactura.TabIndex = 1;
            this.LblDetallesfactura.Text = "DETALLE FACTURA";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // producto
            // 
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            // 
            // valor
            // 
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            // 
            // total
            // 
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            // 
            // editar
            // 
            this.editar.HeaderText = "EDITAR";
            this.editar.Name = "editar";
            this.editar.Width = 80;
            // 
            // borrar
            // 
            this.borrar.HeaderText = "BORRAR";
            this.borrar.Name = "borrar";
            this.borrar.Width = 80;
            // 
            // FrmEditarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(824, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.TxtIdFactura);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditarFacturas_Load);
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdFactura;
        private System.Windows.Forms.Panel PnlDatos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotalIVA;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtDescuento;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialLabel LblDetallesProducto;
        private MaterialSkin.Controls.MaterialLabel LblEstadoFactura;
        private System.Windows.Forms.ComboBox CbbestadoFactura;
        private MaterialSkin.Controls.MaterialLabel LblEmpleados;
        private System.Windows.Forms.ComboBox CbbEmpleados;
        private MaterialSkin.Controls.MaterialLabel LblCliente;
        private System.Windows.Forms.ComboBox CbbClientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtTotalFactura;
        private System.Windows.Forms.DateTimePicker DtpFechaRegistro;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBorrar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel LblDetallesfactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrar;
    }
}