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
    public partial class FrmEditarCategorias : MaterialForm
    {
        public FrmEditarCategorias()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarCategorias_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White; 
                LblTitulo.Text = "CATEGORIA NUEVA";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR CATEGORIA";
                TxtIdCategoria.Text = IdCategoria.ToString();
                TxtCategoria.Text = "nombre categoria";
                
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
