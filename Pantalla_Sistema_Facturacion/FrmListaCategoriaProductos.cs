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
    public partial class FrmListaCategoriaProductos : Form
    {
        public FrmListaCategoriaProductos()
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
                DgCategorias.Rows.Add(i, $"descricion de categoria #{i}:jdfsghhrh");
            }
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarCategorias Categoria = new FrmEditarCategorias();
            Categoria.IdCategoria = 0;
            Categoria.ShowDialog();
        }

        private void DgCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgCategorias.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgCategorias.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgCategorias[0,posActual].Value.ToString()}");
            }
            if (DgCategorias.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgCategorias.CurrentRow.Index;
                FrmEditarCategorias Producto = new FrmEditarCategorias();
                Producto.IdCategoria = int.Parse(DgCategorias[0,posActual].Value.ToString());
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
