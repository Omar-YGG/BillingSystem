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
    public partial class FrmListaRoles : Form
    {
        public FrmListaRoles()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        public void LlenarGrid()
        {
            for (int i=1; i<10; i++)
            {
                DgRoles.Rows.Add(i, $"descricion de rol #{i}:jdfsghhrh");
            }
        }

        private void FrmListaRoles_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarRoles Rol = new FrmEditarRoles();
            Rol.IdRol = 0;
            Rol.ShowDialog();
        }

        private void DgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgRoles.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgRoles.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgRoles[0,posActual].Value.ToString()}");
            }
            if (DgRoles.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgRoles.CurrentRow.Index;
                FrmEditarRoles Rol = new FrmEditarRoles();
                Rol.IdRol = int.Parse(DgRoles[0,posActual].Value.ToString());
                Rol.ShowDialog();
            }
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
