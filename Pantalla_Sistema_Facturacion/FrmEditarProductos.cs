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
    public partial class FrmEditarProductos : MaterialForm
    {
        public FrmEditarProductos()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {
            if (IdProducto == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White; 
                LblTitulo.Text = "PRODUCTO";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR PRODUCTO";
                TxtIdProducto.Text = IdProducto.ToString();
                TxtProducto.Text = "nombre producto";
                TxtCodReferencia.Text = "7546434";
                TxtPrecioCompra.Text = "$ 500.000";
                TxtPrecioVenta.Text = "$ 1.000.000";
                TxtStock.Text = "200";
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
