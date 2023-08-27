using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pantalla_Sistema_Facturacion
{
    public partial class FrmPrincipal : MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form FormHijo)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(FormHijo);
            FormHijo.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmListaCategoriaProductos Categorias = new FrmListaCategoriaProductos();
            AbrirForm(Categorias);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmListaClientes ListaClientes = new FrmListaClientes();
            AbrirForm(ListaClientes);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin FrmLogearse = new FrmLogin();
            FrmLogearse.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void WbrAyuda_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmListaProductos ListaProductos = new FrmListaProductos();
            AbrirForm(ListaProductos);
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            FrmListaFacturas Factura = new FrmListaFacturas();
            AbrirForm(Factura);
        }

        private void BtnInformes_Click(object sender, EventArgs e)
        {
            FrmInformes Informes = new FrmInformes();
            AbrirForm(Informes);
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmListaEmpleados Empleados =new FrmListaEmpleados();
            AbrirForm(Empleados);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            FrmListaRoles Rol = new FrmListaRoles();
            AbrirForm(Rol);
        }

        private void BtnSeguridad_Click(object sender, EventArgs e)
        {
            FrmAdminSeguridad Cuentas = new FrmAdminSeguridad();
            AbrirForm(Cuentas);
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda Ayuda = new FrmAyuda();
            AbrirForm(Ayuda);
        }

        private void BtnAcercaD_Click(object sender, EventArgs e)
        {
            FrmAcercaDe AcercaDe = new FrmAcercaDe();
            AbrirForm(AcercaDe);
        }
    }
}
