using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pantalla_Sistema_Facturacion
{
    public partial class FrmListaCategoriaProductos : Form
    {
        public FrmListaCategoriaProductos()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();  //Se crea el objeto datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos();  //Se crea el objeto d clase acceso_datos

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (TxtBuscarCategoria.Text != "")
            {
                DgCategorias.Rows.Clear();
                String sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE strDescripcion LIKE '%{TxtBuscarCategoria.Text}%'"; //sentencia para consultar por nombre
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    DgCategorias.Rows.Add(row[0], row[1]);
                }
                TxtBuscarCategoria.Text = "";
            }
            else LlenarGrid();
        }

        public void LlenarGrid()
        {
            DgCategorias.Rows.Clear();

            String sentencia = $"SELECT IdCategoria, StrDescripcion FROM TBLCATEGORIA_PROD"; //sentencia para traer la info d la tblclientes
            dt = Acceso.EjecutarComandoDatos(sentencia); //invocacion metodo ejecutar... para ejecutar la sentencia anterior

            foreach (DataRow row in dt.Rows)
            {
                DgCategorias.Rows.Add(row[0], row[1]);
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

            //boton eliminar
            if (DgCategorias.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgCategorias.CurrentRow.Index;

                //mensaje d confirmacion d borrado
                if (MessageBox.Show($"¿Seguro de Borrar Categoria: {DgCategorias[1, posActual].Value.ToString()}?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //invocacion del procedimiento almacenado de eliminar cliente y se pasa como parametro el IdCliente
                    int IdCategoria = Convert.ToInt32(DgCategorias[0, posActual].Value.ToString()); //se lee el IDCliente a borrar del grid
                    String sentencia = $"EXEC Eliminar_CategoriaProducto '{IdCategoria}'";
                    String Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                }
            }

            //bton editar
            if (DgCategorias.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgCategorias.CurrentRow.Index;
                FrmEditarCategorias Categoria = new FrmEditarCategorias();

                // se pasan los parametros a editar del grid al frmeditarcliente
                Categoria.IdCategoria = int.Parse(DgCategorias[0, posActual].Value.ToString());
                Categoria.ShowDialog();
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
