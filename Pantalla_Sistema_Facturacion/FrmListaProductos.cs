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
    public partial class FrmListaProductos : Form
    {
        public FrmListaProductos()
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
                DgProductos.Rows.Add(i, $"Nombre Producto {i}",$"Categoria {i}", $"{i*12345}", $"{i*54321}");
            }
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarProductos Producto = new FrmEditarProductos();
            Producto.IdProducto = 0;
            Producto.ShowDialog();
        }

        private void DgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgProductos.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgProductos.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgProductos[0,posActual].Value.ToString()}");
            }
            if (DgProductos.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgProductos.CurrentRow.Index;
                FrmEditarProductos Producto = new FrmEditarProductos();
                Producto.IdProducto = int.Parse(DgProductos[0,posActual].Value.ToString());
                Producto.ShowDialog();
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
