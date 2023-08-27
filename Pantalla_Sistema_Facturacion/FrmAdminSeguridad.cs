using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Sistema_Facturacion
{
    public partial class FrmAdminSeguridad : Form
    {
        public FrmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }


        private void FrmAdminSeguridad_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Actualizados");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblAdminClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
