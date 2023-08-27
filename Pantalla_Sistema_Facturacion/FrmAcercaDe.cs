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
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            String Mensaje = "Sistema de Facturacion FachaPacha Premium 2023\nVersion 2.14.16\n2023 Pascual Bravo Corp. - OmarGG.\nTodos los derechos reservados.";
            Clipboard.SetText(Mensaje);
            MessageBox.Show("Copiado al portapapeles");
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
