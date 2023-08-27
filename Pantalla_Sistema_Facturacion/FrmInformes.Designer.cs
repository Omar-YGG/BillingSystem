
namespace Pantalla_Sistema_Facturacion
{
    partial class FrmInformes
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
            this.LblInformes = new MaterialSkin.Controls.MaterialLabel();
            this.BtnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.BtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.LblSelecInforme = new MaterialSkin.Controls.MaterialLabel();
            this.CbbListaInforme = new System.Windows.Forms.ComboBox();
            this.CbbOrdenFacturas = new System.Windows.Forms.ComboBox();
            this.LblOrdenFact = new MaterialSkin.Controls.MaterialLabel();
            this.LblFchInicio = new MaterialSkin.Controls.MaterialLabel();
            this.LblFchFinal = new MaterialSkin.Controls.MaterialLabel();
            this.DtpInicio = new System.Windows.Forms.DateTimePicker();
            this.DtpFiinal = new System.Windows.Forms.DateTimePicker();
            this.RbtnEnPantalla = new System.Windows.Forms.RadioButton();
            this.RbtnPdf = new System.Windows.Forms.RadioButton();
            this.RbtnExcel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblInformes
            // 
            this.LblInformes.AutoSize = true;
            this.LblInformes.Depth = 0;
            this.LblInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblInformes.Location = new System.Drawing.Point(303, 20);
            this.LblInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblInformes.Name = "LblInformes";
            this.LblInformes.Size = new System.Drawing.Size(324, 19);
            this.LblInformes.TabIndex = 0;
            this.LblInformes.Text = "GENERADOR DE INFORMES DE FACTURACION";
            this.LblInformes.Click += new System.EventHandler(this.LblAdminClientes_Click);
            // 
            // BtnGenerarInforme
            // 
            this.BtnGenerarInforme.AutoSize = true;
            this.BtnGenerarInforme.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnGenerarInforme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarInforme.Depth = 0;
            this.BtnGenerarInforme.Icon = null;
            this.BtnGenerarInforme.Location = new System.Drawing.Point(307, 270);
            this.BtnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnGenerarInforme.Name = "BtnGenerarInforme";
            this.BtnGenerarInforme.Primary = true;
            this.BtnGenerarInforme.Size = new System.Drawing.Size(144, 36);
            this.BtnGenerarInforme.TabIndex = 4;
            this.BtnGenerarInforme.Text = "GENERAR INFORME";
            this.BtnGenerarInforme.UseVisualStyleBackColor = true;
            this.BtnGenerarInforme.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.AutoSize = true;
            this.BtnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Depth = 0;
            this.BtnSalir.Icon = null;
            this.BtnSalir.Location = new System.Drawing.Point(463, 270);
            this.BtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Primary = true;
            this.BtnSalir.Size = new System.Drawing.Size(58, 36);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR  ";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "CLIENTE";
            this.cliente.Name = "cliente";
            this.cliente.Width = 300;
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
            // LblSelecInforme
            // 
            this.LblSelecInforme.AutoSize = true;
            this.LblSelecInforme.Depth = 0;
            this.LblSelecInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblSelecInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblSelecInforme.Location = new System.Drawing.Point(139, 114);
            this.LblSelecInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblSelecInforme.Name = "LblSelecInforme";
            this.LblSelecInforme.Size = new System.Drawing.Size(144, 19);
            this.LblSelecInforme.TabIndex = 6;
            this.LblSelecInforme.Text = "Seleccionar Informe";
            // 
            // CbbListaInforme
            // 
            this.CbbListaInforme.FormattingEnabled = true;
            this.CbbListaInforme.Location = new System.Drawing.Point(289, 114);
            this.CbbListaInforme.Name = "CbbListaInforme";
            this.CbbListaInforme.Size = new System.Drawing.Size(274, 21);
            this.CbbListaInforme.TabIndex = 7;
            // 
            // CbbOrdenFacturas
            // 
            this.CbbOrdenFacturas.FormattingEnabled = true;
            this.CbbOrdenFacturas.Location = new System.Drawing.Point(687, 114);
            this.CbbOrdenFacturas.Name = "CbbOrdenFacturas";
            this.CbbOrdenFacturas.Size = new System.Drawing.Size(203, 21);
            this.CbbOrdenFacturas.TabIndex = 9;
            // 
            // LblOrdenFact
            // 
            this.LblOrdenFact.AutoSize = true;
            this.LblOrdenFact.Depth = 0;
            this.LblOrdenFact.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblOrdenFact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblOrdenFact.Location = new System.Drawing.Point(594, 114);
            this.LblOrdenFact.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblOrdenFact.Name = "LblOrdenFact";
            this.LblOrdenFact.Size = new System.Drawing.Size(87, 19);
            this.LblOrdenFact.TabIndex = 8;
            this.LblOrdenFact.Text = "Ordenar por";
            // 
            // LblFchInicio
            // 
            this.LblFchInicio.AutoSize = true;
            this.LblFchInicio.Depth = 0;
            this.LblFchInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFchInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFchInicio.Location = new System.Drawing.Point(193, 160);
            this.LblFchInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFchInicio.Name = "LblFchInicio";
            this.LblFchInicio.Size = new System.Drawing.Size(90, 19);
            this.LblFchInicio.TabIndex = 10;
            this.LblFchInicio.Text = "Fecha Inicio";
            // 
            // LblFchFinal
            // 
            this.LblFchFinal.AutoSize = true;
            this.LblFchFinal.Depth = 0;
            this.LblFchFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.LblFchFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblFchFinal.Location = new System.Drawing.Point(436, 160);
            this.LblFchFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblFchFinal.Name = "LblFchFinal";
            this.LblFchFinal.Size = new System.Drawing.Size(85, 19);
            this.LblFchFinal.TabIndex = 11;
            this.LblFchFinal.Text = "Fecha Final";
            // 
            // DtpInicio
            // 
            this.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpInicio.Location = new System.Drawing.Point(289, 160);
            this.DtpInicio.Name = "DtpInicio";
            this.DtpInicio.Size = new System.Drawing.Size(97, 20);
            this.DtpInicio.TabIndex = 12;
            // 
            // DtpFiinal
            // 
            this.DtpFiinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFiinal.Location = new System.Drawing.Point(530, 160);
            this.DtpFiinal.Name = "DtpFiinal";
            this.DtpFiinal.Size = new System.Drawing.Size(97, 20);
            this.DtpFiinal.TabIndex = 13;
            // 
            // RbtnEnPantalla
            // 
            this.RbtnEnPantalla.AutoSize = true;
            this.RbtnEnPantalla.Location = new System.Drawing.Point(319, 219);
            this.RbtnEnPantalla.Name = "RbtnEnPantalla";
            this.RbtnEnPantalla.Size = new System.Drawing.Size(79, 17);
            this.RbtnEnPantalla.TabIndex = 14;
            this.RbtnEnPantalla.TabStop = true;
            this.RbtnEnPantalla.Text = "En Pantalla";
            this.RbtnEnPantalla.UseVisualStyleBackColor = true;
            // 
            // RbtnPdf
            // 
            this.RbtnPdf.AutoSize = true;
            this.RbtnPdf.Location = new System.Drawing.Point(422, 219);
            this.RbtnPdf.Name = "RbtnPdf";
            this.RbtnPdf.Size = new System.Drawing.Size(46, 17);
            this.RbtnPdf.TabIndex = 15;
            this.RbtnPdf.TabStop = true;
            this.RbtnPdf.Text = "PDF";
            this.RbtnPdf.UseVisualStyleBackColor = true;
            // 
            // RbtnExcel
            // 
            this.RbtnExcel.AutoSize = true;
            this.RbtnExcel.Location = new System.Drawing.Point(496, 219);
            this.RbtnExcel.Name = "RbtnExcel";
            this.RbtnExcel.Size = new System.Drawing.Size(51, 17);
            this.RbtnExcel.TabIndex = 16;
            this.RbtnExcel.TabStop = true;
            this.RbtnExcel.Text = "Excel";
            this.RbtnExcel.UseVisualStyleBackColor = true;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(988, 427);
            this.Controls.Add(this.RbtnExcel);
            this.Controls.Add(this.RbtnPdf);
            this.Controls.Add(this.RbtnEnPantalla);
            this.Controls.Add(this.DtpFiinal);
            this.Controls.Add(this.DtpInicio);
            this.Controls.Add(this.LblFchFinal);
            this.Controls.Add(this.LblFchInicio);
            this.Controls.Add(this.CbbOrdenFacturas);
            this.Controls.Add(this.LblOrdenFact);
            this.Controls.Add(this.CbbListaInforme);
            this.Controls.Add(this.LblSelecInforme);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGenerarInforme);
            this.Controls.Add(this.LblInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaClientes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel LblInformes;
        private MaterialSkin.Controls.MaterialRaisedButton BtnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewButtonColumn BtnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn BtnBorrar;
        private MaterialSkin.Controls.MaterialLabel LblSelecInforme;
        private System.Windows.Forms.ComboBox CbbListaInforme;
        private System.Windows.Forms.ComboBox CbbOrdenFacturas;
        private MaterialSkin.Controls.MaterialLabel LblOrdenFact;
        private MaterialSkin.Controls.MaterialLabel LblFchInicio;
        private MaterialSkin.Controls.MaterialLabel LblFchFinal;
        private System.Windows.Forms.DateTimePicker DtpInicio;
        private System.Windows.Forms.DateTimePicker DtpFiinal;
        private System.Windows.Forms.RadioButton RbtnEnPantalla;
        private System.Windows.Forms.RadioButton RbtnPdf;
        private System.Windows.Forms.RadioButton RbtnExcel;
    }
}