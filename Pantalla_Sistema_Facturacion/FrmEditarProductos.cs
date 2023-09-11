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
    public partial class FrmEditarProductos : MaterialForm
    {
        public FrmEditarProductos()
        {
            InitializeComponent();
        }

        public int IdProducto { get; set; }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();


        private void LlenarCboProductos()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.CargarTabla("TBLCATEGORIA_PROD", "");
            CbbCategorias.DataSource = dt;
            CbbCategorias.DisplayMember = "StrDescripcion";
            CbbCategorias.ValueMember = "IdCategoria";
            Acceso.CerrarrBd();
        }

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void LlenarProducto()
        {
            if (IdProducto == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "NUEVO PRODUCTO";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR PRODUCTO";

                //actualizar el registro actual con el id pasado
                String sentencia = $"SELECT * FROM TBLPRODUCTO WHERE IdProducto ='{IdProducto}'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                //llenar campos a editar con los datos originales
                foreach (DataRow row in dt.Rows)
                {
                    TxtProducto.Text = row[1].ToString();
                    TxtCodReferencia.Text = row[2].ToString();
                    TxtPrecioCompra.Text = row[3].ToString();
                    TxtPrecioVenta.Text = row[4].ToString();
                    CbbCategorias.SelectedValue = row[5].ToString();
                    TxtDetallesProducto.Text = row[6].ToString();
                    TxtRutaImagen.Text = row[7].ToString();
                    TxtStock.Text = row[8].ToString();
                }
            }
        }


        private void FrmEditarProductos_Load(object sender, EventArgs e)
        {
            LlenarProducto();
            LlenarCboProductos();
        }


        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de producto en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    String sentencia = $"EXEC [actualizar_Producto] {IdProducto},'{TxtProducto.Text}',{TxtCodReferencia.Text} ,'{TxtPrecioCompra.Text}','{TxtPrecioVenta.Text}', '{Convert.ToInt32(CbbCategorias.SelectedValue)}', '{TxtDetallesProducto.Text}', '{TxtRutaImagen.Text}','{TxtStock.Text}', '{DateTime.Now.ToShortDateString()}', 'Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (TxtProducto.Text == String.Empty)
            {
                MensajeError.SetError(TxtProducto, " debe ingresar el nombre del Producto");
                TxtProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtProducto, ""); }
            if (TxtCodReferencia.Text == "")
            {
                MensajeError.SetError(TxtCodReferencia, " debe ingresar la referencia");
                TxtCodReferencia.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtCodReferencia, ""); }
            if (!esNumerico(TxtCodReferencia.Text))
            {
                MensajeError.SetError(TxtCodReferencia, " la referencia debe ser numerico");
                TxtCodReferencia.Focus();
                return false;
            }
            MensajeError.SetError(TxtCodReferencia, "");
            return errorCampos;
        }

        //función para validar si un valor dado es numerico
        private bool esNumerico(String num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
