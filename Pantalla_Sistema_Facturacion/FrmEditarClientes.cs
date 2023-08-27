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
    public partial class FrmEditarClientes : MaterialForm
    {
        public FrmEditarClientes()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarClientes_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White; 
                LblTitulo.Text = "NUEVO CLIENTE";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR CLIENTE";
                TxtIdCliente.Text = IdCliente.ToString();
                TxtNombre.Text = "nombre 1 apellido";
                TxtDocumento.Text = "7546434";
                TxtDireccion.Text = "calle donde vive el cliente";
                TxtTelefono.Text = "323412432";
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
