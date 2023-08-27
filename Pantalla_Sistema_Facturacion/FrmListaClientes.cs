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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
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
                DgClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2", $"{i*12345}", $"{i*54321}");
            }
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarClientes Clente = new FrmEditarClientes();
            Clente.IdCliente = 0;
            Clente.ShowDialog();
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgClientes.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgClientes.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgClientes[0,posActual].Value.ToString()}");
            }
            if (DgClientes.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgClientes.CurrentRow.Index;
                FrmEditarClientes Cliente = new FrmEditarClientes();
                Cliente.IdCliente = int.Parse(DgClientes[0,posActual].Value.ToString());
                Cliente.ShowDialog();
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
