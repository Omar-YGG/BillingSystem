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
    public partial class FrmEditarRoles : MaterialForm
    {
        public FrmEditarRoles()
        {
            InitializeComponent();
        }

        public int IdRol { get; set; }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarRoles_Load(object sender, EventArgs e)
        {
            if (IdRol == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White; 
                LblTitulo.Text = "ROL NUEVO";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR ROL";
                TxtIdRol.Text = IdRol.ToString();
                TxtRol.Text = "nombre rol";
                
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
