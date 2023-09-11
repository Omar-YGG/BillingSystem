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

        DataTable dt = new DataTable();  //Se crea el objeto datatable para almacenar lo consultado
        Acceso_datos Acceso = new Acceso_datos();  //Se crea el objeto d clase acceso_datos

        //boton buscar producto por un nombre
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (TxtBuscarProducto.Text != "")
            {
                DgProductos.Rows.Clear();
                String sentencia = $"SELECT * FROM TBLPRODUCTO WHERE strNombre LIKE '%{TxtBuscarProducto.Text}%'"; //sentencia para consultar por nombre
                dt = Acceso.EjecutarComandoDatos(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    DgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                }
                TxtBuscarProducto.Text = "";
            }
            else LlenarGrid();
        }

        public void LlenarGrid()
        {
            DgProductos.Rows.Clear();

            String sentencia = $"SELECT IdProducto, StrNombre, IdCategoria, NumPrecioVenta, NumStock FROM TBLPRODUCTO"; //sentencia para traer la info d la tblclientes
            dt = Acceso.EjecutarComandoDatos(sentencia); //invocacion metodo ejecutar... para ejecutar la sentencia anterior

            foreach (DataRow row in dt.Rows)
            {
                DgProductos.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
            }

            //for (int i=1; i<10; i++)
            //{
            //    DgProductos.Rows.Add(i, $"Nombre Producto {i}",$"Categoria {i}", $"{i*12345}", $"{i*54321}");
            //}
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

            //boton eliminar
            if (DgProductos.Columns[e.ColumnIndex].Name == "BtnBorrar")
            {
                posActual = DgProductos.CurrentRow.Index;

                //mensaje d confirmacion d borrado
                if (MessageBox.Show($"¿Seguro de Borrar Producto: {DgProductos[1, posActual].Value.ToString()}?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //invocacion del procedimiento almacenado de eliminar cliente y se pasa como parametro el IdCliente
                    int IdProducto = Convert.ToInt32(DgProductos[0, posActual].Value.ToString()); //se lee el IDCliente a borrar del grid
                    String sentencia = $"EXEC Eliminar_producto '{IdProducto}'";
                    String Mensaje = Acceso.EjecutarComando(sentencia);
                    MessageBox.Show(Mensaje);
                }
            }

            //bton editar
            if (DgProductos.Columns[e.ColumnIndex].Name == "BtnEditar")
            {
                posActual = DgProductos.CurrentRow.Index;
                FrmEditarProductos Producto = new FrmEditarProductos();

                // se pasan los parametros a editar del grid al frmeditarcliente
                Producto.IdProducto = int.Parse(DgProductos[0, posActual].Value.ToString());
                Producto.ShowDialog();
            }
            LlenarGrid();


            //int posActual = 0;

            //if (DgProductos.Columns[e.ColumnIndex].Name == "BtnBorrar")
            //{
            //    posActual = DgProductos.CurrentRow.Index;
            //    if (MessageBox.Show("¿Seguro de Borrar?", "CONFIRMACON", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //        MessageBox.Show($"BORRANDO indice {e.RowIndex} ID {DgProductos[0,posActual].Value.ToString()}");
            //}
            //if (DgProductos.Columns[e.ColumnIndex].Name == "BtnEditar")
            //{
            //    posActual = DgProductos.CurrentRow.Index;
            //    FrmEditarProductos Producto = new FrmEditarProductos();
            //    Producto.IdProducto = int.Parse(DgProductos[0,posActual].Value.ToString());
            //    Producto.ShowDialog();
            //}
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
