
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.TbpMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.Principal = new System.Windows.Forms.TabPage();
            this.Tablas = new System.Windows.Forms.TabPage();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.Seguridad = new System.Windows.Forms.TabPage();
            this.Acerca = new System.Windows.Forms.TabPage();
            this.TabOpcionesMenu = new MaterialSkin.Controls.MaterialTabSelector();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnInformes = new System.Windows.Forms.Button();
            this.BtnFacturas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnSeguridad = new System.Windows.Forms.Button();
            this.BtnRoles = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnAcercaD = new System.Windows.Forms.Button();
            this.BtnAyuda = new System.Windows.Forms.Button();
            this.PnlPrincipal.SuspendLayout();
            this.PnlMenu.SuspendLayout();
            this.TbpMenu.SuspendLayout();
            this.Principal.SuspendLayout();
            this.Tablas.SuspendLayout();
            this.Facturacion.SuspendLayout();
            this.Seguridad.SuspendLayout();
            this.Acerca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Controls.Add(this.PnlContenedor);
            this.PnlPrincipal.Controls.Add(this.PnlMenu);
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 63);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(1201, 588);
            this.PnlPrincipal.TabIndex = 0;
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlContenedor.Location = new System.Drawing.Point(202, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(999, 588);
            this.PnlContenedor.TabIndex = 1;
            // 
            // PnlMenu
            // 
            this.PnlMenu.Controls.Add(this.TbpMenu);
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(200, 588);
            this.PnlMenu.TabIndex = 0;
            // 
            // TbpMenu
            // 
            this.TbpMenu.Controls.Add(this.Principal);
            this.TbpMenu.Controls.Add(this.Tablas);
            this.TbpMenu.Controls.Add(this.Facturacion);
            this.TbpMenu.Controls.Add(this.Seguridad);
            this.TbpMenu.Controls.Add(this.Acerca);
            this.TbpMenu.Depth = 0;
            this.TbpMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbpMenu.Location = new System.Drawing.Point(0, 0);
            this.TbpMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TbpMenu.Name = "TbpMenu";
            this.TbpMenu.SelectedIndex = 0;
            this.TbpMenu.Size = new System.Drawing.Size(200, 588);
            this.TbpMenu.TabIndex = 0;
            // 
            // Principal
            // 
            this.Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Principal.Controls.Add(this.BtnSalir);
            this.Principal.Controls.Add(this.pictureBox1);
            this.Principal.Location = new System.Drawing.Point(4, 22);
            this.Principal.Name = "Principal";
            this.Principal.Padding = new System.Windows.Forms.Padding(3);
            this.Principal.Size = new System.Drawing.Size(192, 562);
            this.Principal.TabIndex = 1;
            this.Principal.Text = "Principal";
            // 
            // Tablas
            // 
            this.Tablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Tablas.Controls.Add(this.pictureBox6);
            this.Tablas.Controls.Add(this.BtnCategorias);
            this.Tablas.Controls.Add(this.BtnProductos);
            this.Tablas.Controls.Add(this.BtnClientes);
            this.Tablas.Location = new System.Drawing.Point(4, 22);
            this.Tablas.Name = "Tablas";
            this.Tablas.Padding = new System.Windows.Forms.Padding(3);
            this.Tablas.Size = new System.Drawing.Size(192, 562);
            this.Tablas.TabIndex = 0;
            this.Tablas.Text = "Tablas";
            // 
            // Facturacion
            // 
            this.Facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Facturacion.Controls.Add(this.pictureBox2);
            this.Facturacion.Controls.Add(this.BtnInformes);
            this.Facturacion.Controls.Add(this.BtnFacturas);
            this.Facturacion.Location = new System.Drawing.Point(4, 22);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Size = new System.Drawing.Size(192, 562);
            this.Facturacion.TabIndex = 2;
            this.Facturacion.Text = "Facturacion";
            // 
            // Seguridad
            // 
            this.Seguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Seguridad.Controls.Add(this.pictureBox3);
            this.Seguridad.Controls.Add(this.BtnSeguridad);
            this.Seguridad.Controls.Add(this.BtnRoles);
            this.Seguridad.Controls.Add(this.BtnEmpleados);
            this.Seguridad.Location = new System.Drawing.Point(4, 22);
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(192, 562);
            this.Seguridad.TabIndex = 3;
            this.Seguridad.Text = "Seguridad";
            // 
            // Acerca
            // 
            this.Acerca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Acerca.Controls.Add(this.pictureBox4);
            this.Acerca.Controls.Add(this.BtnAcercaD);
            this.Acerca.Controls.Add(this.BtnAyuda);
            this.Acerca.Location = new System.Drawing.Point(4, 22);
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(192, 562);
            this.Acerca.TabIndex = 4;
            this.Acerca.Text = "Acerca";
            // 
            // TabOpcionesMenu
            // 
            this.TabOpcionesMenu.BaseTabControl = this.TbpMenu;
            this.TabOpcionesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TabOpcionesMenu.Depth = 0;
            this.TabOpcionesMenu.Location = new System.Drawing.Point(321, 34);
            this.TabOpcionesMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabOpcionesMenu.Name = "TabOpcionesMenu";
            this.TabOpcionesMenu.Size = new System.Drawing.Size(819, 23);
            this.TabOpcionesMenu.TabIndex = 1;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSalir.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.cerrar_sesion;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(-4, 114);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(200, 45);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.space;
            this.pictureBox1.Location = new System.Drawing.Point(50, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.space;
            this.pictureBox6.Location = new System.Drawing.Point(50, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(89, 75);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCategorias.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.categorizacion;
            this.BtnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategorias.Location = new System.Drawing.Point(-4, 231);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(200, 45);
            this.BtnCategorias.TabIndex = 4;
            this.BtnCategorias.Text = "Categorias";
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnProductos.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.carrito_de_compras__1_;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(-4, 180);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(200, 45);
            this.BtnProductos.TabIndex = 3;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClientes.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.distribuir;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(-4, 129);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(200, 45);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.space;
            this.pictureBox2.Location = new System.Drawing.Point(50, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // BtnInformes
            // 
            this.BtnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInformes.FlatAppearance.BorderSize = 0;
            this.BtnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnInformes.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.informe;
            this.BtnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInformes.Location = new System.Drawing.Point(-4, 166);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Size = new System.Drawing.Size(200, 45);
            this.BtnInformes.TabIndex = 5;
            this.BtnInformes.Text = "Informes";
            this.BtnInformes.UseVisualStyleBackColor = true;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // BtnFacturas
            // 
            this.BtnFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFacturas.FlatAppearance.BorderSize = 0;
            this.BtnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFacturas.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.factura;
            this.BtnFacturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturas.Location = new System.Drawing.Point(-4, 124);
            this.BtnFacturas.Name = "BtnFacturas";
            this.BtnFacturas.Size = new System.Drawing.Size(200, 45);
            this.BtnFacturas.TabIndex = 4;
            this.BtnFacturas.Text = "Facturas";
            this.BtnFacturas.UseVisualStyleBackColor = true;
            this.BtnFacturas.Click += new System.EventHandler(this.BtnFacturas_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.space;
            this.pictureBox3.Location = new System.Drawing.Point(50, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 75);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // BtnSeguridad
            // 
            this.BtnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeguridad.FlatAppearance.BorderSize = 0;
            this.BtnSeguridad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeguridad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSeguridad.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.escudo;
            this.BtnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeguridad.Location = new System.Drawing.Point(-4, 223);
            this.BtnSeguridad.Name = "BtnSeguridad";
            this.BtnSeguridad.Size = new System.Drawing.Size(200, 45);
            this.BtnSeguridad.TabIndex = 8;
            this.BtnSeguridad.Text = "Seguridad";
            this.BtnSeguridad.UseVisualStyleBackColor = true;
            this.BtnSeguridad.Click += new System.EventHandler(this.BtnSeguridad_Click);
            // 
            // BtnRoles
            // 
            this.BtnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRoles.FlatAppearance.BorderSize = 0;
            this.BtnRoles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRoles.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.roles;
            this.BtnRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRoles.Location = new System.Drawing.Point(-4, 172);
            this.BtnRoles.Name = "BtnRoles";
            this.BtnRoles.Size = new System.Drawing.Size(200, 45);
            this.BtnRoles.TabIndex = 7;
            this.BtnRoles.Text = "Roles";
            this.BtnRoles.UseVisualStyleBackColor = true;
            this.BtnRoles.Click += new System.EventHandler(this.BtnRoles_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpleados.FlatAppearance.BorderSize = 0;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEmpleados.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.trabajadores;
            this.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEmpleados.Location = new System.Drawing.Point(-4, 121);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(200, 45);
            this.BtnEmpleados.TabIndex = 6;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.space;
            this.pictureBox4.Location = new System.Drawing.Point(50, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(89, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // BtnAcercaD
            // 
            this.BtnAcercaD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcercaD.FlatAppearance.BorderSize = 0;
            this.BtnAcercaD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAcercaD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcercaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcercaD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAcercaD.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.boton_de_informacion;
            this.BtnAcercaD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcercaD.Location = new System.Drawing.Point(-4, 179);
            this.BtnAcercaD.Name = "BtnAcercaD";
            this.BtnAcercaD.Size = new System.Drawing.Size(200, 45);
            this.BtnAcercaD.TabIndex = 7;
            this.BtnAcercaD.Text = "Acerca De";
            this.BtnAcercaD.UseVisualStyleBackColor = true;
            this.BtnAcercaD.Click += new System.EventHandler(this.BtnAcercaD_Click);
            // 
            // BtnAyuda
            // 
            this.BtnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAyuda.FlatAppearance.BorderSize = 0;
            this.BtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyuda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAyuda.Image = global::Pantalla_Sistema_Facturacion.Properties.Resources.ayuda;
            this.BtnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAyuda.Location = new System.Drawing.Point(-4, 128);
            this.BtnAyuda.Name = "BtnAyuda";
            this.BtnAyuda.Size = new System.Drawing.Size(200, 45);
            this.BtnAyuda.TabIndex = 6;
            this.BtnAyuda.Text = "Ayuda";
            this.BtnAyuda.UseVisualStyleBackColor = true;
            this.BtnAyuda.Click += new System.EventHandler(this.BtnAyuda_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.TabOpcionesMenu);
            this.Controls.Add(this.PnlPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACION";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnlPrincipal.ResumeLayout(false);
            this.PnlMenu.ResumeLayout(false);
            this.TbpMenu.ResumeLayout(false);
            this.Principal.ResumeLayout(false);
            this.Tablas.ResumeLayout(false);
            this.Facturacion.ResumeLayout(false);
            this.Seguridad.ResumeLayout(false);
            this.Acerca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Panel PnlMenu;
        private MaterialSkin.Controls.MaterialTabControl TbpMenu;
        private System.Windows.Forms.TabPage Principal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage Tablas;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.TabPage Seguridad;
        private System.Windows.Forms.TabPage Acerca;
        private MaterialSkin.Controls.MaterialTabSelector TabOpcionesMenu;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnInformes;
        private System.Windows.Forms.Button BtnFacturas;
        private System.Windows.Forms.Button BtnSeguridad;
        private System.Windows.Forms.Button BtnRoles;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnAcercaD;
        private System.Windows.Forms.Button BtnAyuda;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}