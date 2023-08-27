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
    public partial class FrmListaFacturas : Form
    {
        public FrmListaFacturas()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        public void LlenarGrid()
        {
            String fechita = "/05/2023";
            for (int i=1; i<10; i++)
            {
                DgFacturas.Rows.Add($"{i}00{i}", $"Nombre Cliente {i}",$"{i.ToString()+fechita}", $"{i*12345}", "Pendiente");
            }
        }

        private void FrmListaFacturas_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarFacturas Factura = new FrmEditarFacturas();
            Factura.IdFactura = 0;
            Factura.ShowDialog();
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgFacturas.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgFacturas.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgFacturas[0,posActual].Value.ToString()}");
            }
            if (DgFacturas.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgFacturas.CurrentRow.Index;
                FrmEditarFacturas Factura = new FrmEditarFacturas();
                Factura.IdFactura = int.Parse(DgFacturas[0,posActual].Value.ToString());
                Factura.ShowDialog();
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
