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
    public partial class FrmEditarCategorias : MaterialForm
    {
        public FrmEditarCategorias()
        {
            InitializeComponent();
        }

        public int IdCategoria { get; set; }
        DataTable dt = new DataTable();
        Acceso_datos Acceso = new Acceso_datos();

        private void materialSingleLineTextField5_Click(object sender, EventArgs e)
        {

        }

        private void LlenarCategoria()
        {
            if (IdCategoria == 0)
            {//REGISTRO D NUEVO CLIENTE
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "NUEVA CATEGORIA";
            }
            else
            {//ACTUALLIZACION D UN CLIENTE VIEJO/ID PASADO
                LblTitulo.ForeColor = Color.White;
                LblTitulo.Text = "MODIFICAR CATEGORIA";

                //actualizar el registro actual con el id pasado
                String sentencia = $"SELECT * FROM TBLCATEGORIA_PROD WHERE IdCategoria ='{IdCategoria}'";
                dt = Acceso.EjecutarComandoDatos(sentencia);

                //llenar campos a editar con los datos originales
                foreach (DataRow row in dt.Rows)
                {
                    TxtCategoria.Text = row[1].ToString();
                }
            }
        }


        private void FrmEditarCategorias_Load(object sender, EventArgs e)
        {
            LlenarCategoria();
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
                    String sentencia = $"EXEC [actualizar_CategoriaProd] {IdCategoria},'{TxtCategoria.Text}','{DateTime.Now.ToShortDateString()}', 'Javier'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }

        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (TxtCategoria.Text == String.Empty)
            {
                MensajeError.SetError(TxtCategoria, " debe ingresar el nombre de Categoria");
                TxtCategoria.Focus();
                errorCampos = false;
            }
            else MensajeError.SetError(TxtCategoria, ""); 
            
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
