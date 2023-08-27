
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmListaProductos
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
            this.LblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.TxtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdminProductos
            // 
            this.LblAdminProductos.AutoSize = true;
            this.LblAdminProductos.Depth = 0;
            this.LblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdminProductos.Location = new System.Drawing.Point(401, 21);
            this.LblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdminProductos.Name = "LblAdminProductos";
            this.LblAdminProductos.Size = new System.Drawing.Size(240, 19);
            this.LblAdminProductos.TabIndex = 0;
            this.LblAdminProductos.Text = "ADMINISTRADOR DE PRODUCTOS";
            this.LblAdminProductos.Click += new System.EventHandler(this.LblAdminClientes_Click);
            // 
            // TxtBuscarProducto
            // 
            this.TxtBuscarProducto.Depth = 0;
            this.TxtBuscarProducto.Hint = "Buscar Producto";
            this.TxtBuscarProducto.Location = new System.Drawing.Point(219, 80);
            this.TxtBuscarProducto.MaxLength = 32767;
            this.TxtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarProducto.Name = "TxtBuscarProducto";
            this.TxtBuscarProducto.PasswordChar = '\0';
            this.TxtBuscarProducto.SelectedText = "";
            this.TxtBuscarProducto.SelectionLength = 0;
            this.TxtBuscarProducto.SelectionStart = 0;
            this.TxtBuscarProducto.Size = new System.Drawing.Size(351, 23);
            this.TxtBuscarProducto.TabIndex = 1;
            this.TxtBuscarProducto.TabStop = false;
            this.TxtBuscarProducto.UseSystemPasswordChar = false;
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
            this.BtnSalir.Location = new System.Drawing.Point(903, 518);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR  ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DgProductos
            // 
            this.DgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.categoria,
            this.precio,
            this.stock,
            this.BtnEditar,
            this.BtnBorrar});
            this.DgProductos.Location = new System.Drawing.Point(119, 132);
            this.DgProductos.Name = "DgProductos";
            this.DgProductos.Size = new System.Drawing.Size(842, 349);
            this.DgProductos.TabIndex = 6;
            this.DgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductos_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // producto
            // 
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.Width = 300;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.Width = 150;
            // 
            // precio
            // 
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            // 
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.Name = "stock";
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
            // FrmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(988, 606);
            this.Controls.Add(this.DgProductos);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarProducto);
            this.Controls.Add(this.LblAdminProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAdminProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridView DgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
    }
}