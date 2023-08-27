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
    public partial class FrmListaEmpleados : Form
    {
        public FrmListaEmpleados()
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
                DgEmpleados.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2", $"{i*12345}", $"{i*54321}");
            }
        }

        private void FrmListaEmpleados_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarEmpleados Empleado = new FrmEditarEmpleados();
            Empleado.IdEmpleado = 0;
            Empleado.ShowDialog();
        }

        private void DgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            if (DgEmpleados.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgEmpleados.CurrentRow.Index;
                if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgEmpleados[0,posActual].Value.ToString()}");
            }
            if (DgEmpleados.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgEmpleados.CurrentRow.Index;
                FrmEditarEmpleados Empleado = new FrmEditarEmpleados();
                Empleado.IdEmpleado = int.Parse(DgEmpleados[0,posActual].Value.ToString());
                Empleado.ShowDialog();
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
