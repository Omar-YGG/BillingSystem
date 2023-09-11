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
    public partial class FrmEditarClientes : MaterialForm
    {
        public FrmEditarClientes()
        {
            InitializeComponent();
        }

        public int IdCliente { get; set; }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void LlenarCliente()
        {
            if (IdCliente == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "NUEVO CLIENTE";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR CLIENTE";

                //actualizar el registro actual con el id pasado
                String sentencia = $"SELECT * FROM TBLCLIENTES WHERE IdCliente ='{IdCliente}'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                //llenar campos a editar con los datos originales
                foreach (DataRow row in dt.Rows)
                {
                    TxtNombre.Text = row[1].ToString();
                    TxtDocumento.Text = row[2].ToString();
                    TxtDireccion.Text = row[3].ToString();
                    TxtTelefono.Text = row[4].ToString();
                    TxtEmail.Text = row[5].ToString();
                }
            }
        }

        private void FrmEditarClientes_Load(object sender, EventArgs e)
        {
            LlenarCliente();
        }




        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"EXEC [actualizar_Cliente] {IdCliente},'{TxtNombre.Text}',{TxtDocumento.Text} ,'{TxtDireccion.Text}','{TxtTelefono.Text}', '{TxtEmail.Text}','Javier','{DateTime.Now.ToShortDateString()}'";
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
            if (TxtNombre.Text == string.Empty)
            {
                MensajeError.SetError(TxtNombre, " debe ingresar el nombre del Cliente");
                TxtNombre.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtNombre, ""); }
            if (TxtDocumento.Text == "")
            {
                MensajeError.SetError(TxtDocumento, " debe ingresar el documento");
                TxtDocumento.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtDocumento, ""); }
            if (!esNumerico(TxtDocumento.Text))
            {
                MensajeError.SetError(TxtDocumento, " El Documento debe ser numerico");
                TxtDocumento.Focus();
                return false;
            }
            MensajeError.SetError(TxtDocumento, "");
            return errorCampos;
        }

        //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
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
