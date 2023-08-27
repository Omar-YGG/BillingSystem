
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmListaCategoriaProductos
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
            this.TxtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DgCategorias = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAdminProductos
            // 
            this.LblAdminProductos.AutoSize = true;
            this.LblAdminProductos.Depth = 0;
            this.LblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAdminProductos.Location = new System.Drawing.Point(337, 22);
            this.LblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblAdminProductos.Name = "LblAdminProductos";
            this.LblAdminProductos.Size = new System.Drawing.Size(348, 19);
            this.LblAdminProductos.TabIndex = 0;
            this.LblAdminProductos.Text = "ADMINISTRADOR DE CATEGORIAS DE PRODUCTO";
            this.LblAdminProductos.Click += new System.EventHandler(this.LblAdminClientes_Click);
            // 
            // TxtBuscarCategoria
            // 
            this.TxtBuscarCategoria.Depth = 0;
            this.TxtBuscarCategoria.Hint = "Buscar Categoria";
            this.TxtBuscarCategoria.Location = new System.Drawing.Point(219, 80);
            this.TxtBuscarCategoria.MaxLength = 32767;
            this.TxtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtBuscarCategoria.Name = "TxtBuscarCategoria";
            this.TxtBuscarCategoria.PasswordChar = '\0';
            this.TxtBuscarCategoria.SelectedText = "";
            this.TxtBuscarCategoria.SelectionLength = 0;
            this.TxtBuscarCategoria.SelectionStart = 0;
            this.TxtBuscarCategoria.Size = new System.Drawing.Size(351, 23);
            this.TxtBuscarCategoria.TabIndex = 1;
            this.TxtBuscarCategoria.TabStop = false;
            this.TxtBuscarCategoria.UseSystemPasswordChar = false;
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
            this.BtnSalir.Location = new System.Drawing.Point(779, 511);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR  ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DgCategorias
            // 
            this.DgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.BtnEditar,
            this.BtnBorrar});
            this.DgCategorias.Location = new System.Drawing.Point(119, 132);
            this.DgCategorias.Name = "DgCategorias";
            this.DgCategorias.Size = new System.Drawing.Size(743, 349);
            this.DgCategorias.TabIndex = 6;
            this.DgCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCategorias_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION CATEGORIA";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 500;
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
            // FrmListaCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(988, 606);
            this.Controls.Add(this.DgCategorias);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtBuscarCategoria);
            this.Controls.Add(this.LblAdminProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListaCategoriaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblAdminProductos;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton BtnBuscar;
        private MaterialSkin.Controls.MaterialRaisedButton BtnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridView DgCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
    }
}