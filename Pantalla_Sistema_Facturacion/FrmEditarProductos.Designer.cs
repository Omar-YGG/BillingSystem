
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmEditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarProductos));
            this.LblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.TxtIdProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.LblDetallesProducto = new MaterialSkin.Controls.MaterialLabel();
            this.TxtDetallesProducto = new System.Windows.Forms.TextBox();
            this.TxtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblCategorias = new MaterialSkin.Controls.MaterialLabel();
            this.CbbCategorias = new System.Windows.Forms.ComboBox();
            this.TxtStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.LblTitulo.Location = new System.Drawing.Point(342, 35);
            this.LblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(120, 19);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "NUEVOS DATOS";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // TxtIdProducto
            // 
            this.TxtIdProducto.Depth = 0;
            this.TxtIdProducto.Hint = "ID";
            this.TxtIdProducto.Location = new System.Drawing.Point(53, 102);
            this.TxtIdProducto.MaxLength = 32767;
            this.TxtIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtIdProducto.Name = "TxtIdProducto";
            this.TxtIdProducto.PasswordChar = '\0';
            this.TxtIdProducto.SelectedText = "";
            this.TxtIdProducto.SelectionLength = 0;
            this.TxtIdProducto.SelectionStart = 0;
            this.TxtIdProducto.Size = new System.Drawing.Size(32, 23);
            this.TxtIdProducto.TabIndex = 1;
            this.TxtIdProducto.TabStop = false;
            this.TxtIdProducto.UseSystemPasswordChar = false;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.LblDetallesProducto);
            this.PnlDatos.Controls.Add(this.TxtDetallesProducto);
            this.PnlDatos.Controls.Add(this.TxtRutaImagen);
            this.PnlDatos.Controls.Add(this.LblCategorias);
            this.PnlDatos.Controls.Add(this.CbbCategorias);
            this.PnlDatos.Controls.Add(this.TxtStock);
            this.PnlDatos.Controls.Add(this.TxtPrecioVenta);
            this.PnlDatos.Controls.Add(this.TxtPrecioCompra);
            this.PnlDatos.Controls.Add(this.TxtCodReferencia);
            this.PnlDatos.Controls.Add(this.TxtProducto);
            this.PnlDatos.Location = new System.Drawing.Point(27, 131);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(705, 217);
            this.PnlDatos.TabIndex = 2;
            // 
            // LblDetallesProducto
            // 
            this.LblDetallesProducto.AutoSize = true;
            this.LblDetallesProducto.Depth = 0;
            this.LblDetallesProducto.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblDetallesProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDetallesProducto.Location = new System.Drawing.Point(420, 98);
            this.LblDetallesProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDetallesProducto.Name = "LblDetallesProducto";
            this.LblDetallesProducto.Size = new System.Drawing.Size(153, 19);
            this.LblDetallesProducto.TabIndex = 10;
            this.LblDetallesProducto.Text = "Detalles del Producto";
            // 
            // TxtDetallesProducto
            // 
            this.TxtDetallesProducto.Location = new System.Drawing.Point(424, 120);
            this.TxtDetallesProducto.Multiline = true;
            this.TxtDetallesProducto.Name = "TxtDetallesProducto";
            this.TxtDetallesProducto.Size = new System.Drawing.Size(256, 80);
            this.TxtDetallesProducto.TabIndex = 9;
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta Imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(424, 55);
            this.TxtRutaImagen.MaxLength = 32767;
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(256, 23);
            this.TxtRutaImagen.TabIndex = 8;
            this.TxtRutaImagen.TabStop = false;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Depth = 0;
            this.LblCategorias.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblCategorias.Location = new System.Drawing.Point(420, 18);
            this.LblCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(74, 19);
            this.LblCategorias.TabIndex = 7;
            this.LblCategorias.Text = "Categoria";
            // 
            // CbbCategorias
            // 
            this.CbbCategorias.AccessibleName = "";
            this.CbbCategorias.CausesValidation = false;
            this.CbbCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbbCategorias.FormattingEnabled = true;
            this.CbbCategorias.Location = new System.Drawing.Point(500, 16);
            this.CbbCategorias.Name = "CbbCategorias";
            this.CbbCategorias.Size = new System.Drawing.Size(180, 21);
            this.CbbCategorias.TabIndex = 5;
            this.CbbCategorias.Tag = "";
            // 
            // TxtStock
            // 
            this.TxtStock.Depth = 0;
            this.TxtStock.Hint = "Cantidad Stock";
            this.TxtStock.Location = new System.Drawing.Point(43, 177);
            this.TxtStock.MaxLength = 32767;
            this.TxtStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.PasswordChar = '\0';
            this.TxtStock.SelectedText = "";
            this.TxtStock.SelectionLength = 0;
            this.TxtStock.SelectionStart = 0;
            this.TxtStock.Size = new System.Drawing.Size(300, 23);
            this.TxtStock.TabIndex = 4;
            this.TxtStock.TabStop = false;
            this.TxtStock.UseSystemPasswordChar = false;
            this.TxtStock.Click += new System.EventHandler(this.materialSingleLineTextField5_Click);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio Venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(43, 137);
            this.TxtPrecioVenta.MaxLength = 32767;
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(300, 23);
            this.TxtPrecioVenta.TabIndex = 3;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Depth = 0;
            this.TxtPrecioCompra.Hint = "Precio Compra";
            this.TxtPrecioCompra.Location = new System.Drawing.Point(43, 94);
            this.TxtPrecioCompra.MaxLength = 32767;
            this.TxtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PasswordChar = '\0';
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.SelectionLength = 0;
            this.TxtPrecioCompra.SelectionStart = 0;
            this.TxtPrecioCompra.Size = new System.Drawing.Size(300, 23);
            this.TxtPrecioCompra.TabIndex = 2;
            this.TxtPrecioCompra.TabStop = false;
            this.TxtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtCodReferencia
            // 
            this.TxtCodReferencia.Depth = 0;
            this.TxtCodReferencia.Hint = "Codigo Referencia";
            this.TxtCodReferencia.Location = new System.Drawing.Point(43, 55);
            this.TxtCodReferencia.MaxLength = 32767;
            this.TxtCodReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodReferencia.Name = "TxtCodReferencia";
            this.TxtCodReferencia.PasswordChar = '\0';
            this.TxtCodReferencia.SelectedText = "";
            this.TxtCodReferencia.SelectionLength = 0;
            this.TxtCodReferencia.SelectionStart = 0;
            this.TxtCodReferencia.Size = new System.Drawing.Size(300, 23);
            this.TxtCodReferencia.TabIndex = 1;
            this.TxtCodReferencia.TabStop = false;
            this.TxtCodReferencia.UseSystemPasswordChar = false;
            // 
            // TxtProducto
            // 
            this.TxtProducto.Depth = 0;
            this.TxtProducto.Hint = "Producto";
            this.TxtProducto.Location = new System.Drawing.Point(43, 14);
            this.TxtProducto.MaxLength = 32767;
            this.TxtProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.PasswordChar = '\0';
            this.TxtProducto.SelectedText = "";
            this.TxtProducto.SelectionLength = 0;
            this.TxtProducto.SelectionStart = 0;
            this.TxtProducto.Size = new System.Drawing.Size(300, 23);
            this.TxtProducto.TabIndex = 0;
            this.TxtProducto.TabStop = false;
            this.TxtProducto.UseSystemPasswordChar = false;
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
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(765, 451);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.TxtIdProducto);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEditarProductos_Load);
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtIdProducto;
        private System.Windows.Forms.Panel PnlDatos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtProducto;
        private MaterialSkin.Controls.MaterialRaisedButton BtnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private MaterialSkin.Controls.MaterialLabel LblDetallesProducto;
        private System.Windows.Forms.TextBox TxtDetallesProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel LblCategorias;
        private System.Windows.Forms.ComboBox CbbCategorias;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}