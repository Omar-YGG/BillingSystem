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
    public partial class FrmEditarFacturas : MaterialForm
    {
        public FrmEditarFacturas()
        {
            InitializeComponent();
        }

        public int IdFactura { get; set; }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarFacturas_Load(object sender, EventArgs e)
        {
            if (IdFactura == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White; 
                LblTitulo.Text = "NUEVA FACTURA";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR FACTURA";
                TxtIdFactura.Text = IdFactura.ToString();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos actualizados");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
