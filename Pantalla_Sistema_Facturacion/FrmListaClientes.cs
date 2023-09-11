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

        DataTable dt = new DataTable();  //Se crea el objeto datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos();  //Se crea el objeto d clase acceso_datos

        private void LlenarGrid()
        {
            DgClientes.Rows.Clear();

            String sentencia = $"SELECT IdCliente, StrNombre, NumDocumento, StrTelefono FROM TBLCLIENTES"; //sentencia para traer la info d la tblclientes
            dt = Acceso.EjecutarComandoDatos(sentencia); //invocacion metodo ejecutar... para ejecutar la sentencia anterior

            foreach (DataRow row in dt.Rows)
            {
                DgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            //for (int i=1; i<10; i++)
            //{
            //    DgClientes.Rows.Add(i, $"Nombre {i} Apellido1 Apellido2", $"{i*12345}", $"{i*54321}");
            //}
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (TxtBuscarCliente.Text != "")
            {
                DgClientes.Rows.Clear();
                String sentencia = $"SELECT * FROM TBLCLIENTES WHERE strNombre LIKE '%{TxtBuscarCliente.Text}%'"; //sentencia para consultar por nombreuser
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    DgClientes.Rows.Add(row[0], row[1], row[2], row[3]);
                }
                TxtBuscarCliente.Text = "";
            }
            else LlenarGrid();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEditarClientes Cliente = new FrmEditarClientes();
            Cliente.IdCliente = 0;
            Cliente.ShowDialog();
            LlenarGrid();
        }

        private void DgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posActual = 0;

            //boton eliminar
            if (DgClientes.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgClientes.CurrentRow.Index;

                //mensaje d confirmacion d borrado
                if (MessageBox.Show($"¿Seguro de Borrar Cliente: {DgClientes[1,posActual].Value.ToString()}?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //invocacion del procedimiento almacenado de eliminar cliente y se pasa como parametro el IdCliente
                    int IdCliente = Convert.ToInt32(DgClientes[0,posActual].Value.ToString()); //se lee el IDCliente a borrar del grid
                    String sentencia = $"EXEC Eliminar_cliente '{IdCliente}'";
                    String Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                }
            }

            //bton editar
            if (DgClientes.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgClientes.CurrentRow.Index;
                FrmEditarClientes Cliente = new FrmEditarClientes();

                // se pasan los parametros a editar del grid al frmeditarcliente
                Cliente.IdCliente = int.Parse(DgClientes[0,posActual].Value.ToString());
                Cliente.ShowDialog();
            }
            LlenarGrid();
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
