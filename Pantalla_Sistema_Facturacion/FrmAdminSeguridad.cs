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
    public partial class FrmAdminSeguridad : Form
    {
        public FrmAdminSeguridad()
        {
            InitializeComponent();
        }

        Acceso_datos Acceso = new Acceso_datos();

        private void LlenarCboEmpleados()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.CargarTabla("TBLEMPLEADO", "");
            CboEmpleados.DataSource = dt;
            CboEmpleados.DisplayMember = "strNombre";
            CboEmpleados.ValueMember = "IdEmpleado";
            Acceso.CerrarrBd();
        }


        private Boolean validar()
        {
            Boolean errorCampos = true;
            if (TxtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(TxtUsuario, "debe ingresar un valor de Usuario");
                TxtUsuario.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtUsuario, ""); }
            if (TxtClave.Text == "")
            {
                MensajeError.SetError(TxtClave, "Debe ingresar un valor de cédula");
                TxtClave.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(TxtClave, ""); }
            return errorCampos;
        }

        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
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

        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    String sentencia = $"EXEC actualizar_Seguridad '{Convert.ToInt32(CboEmpleados.SelectedValue)}','{TxtUsuario.Text}','{TxtClave.Text}','{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")}','Javier'";
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

        // función que permite eliminar los datos de ingreso de un usuario
        public void Eliminar()
        {
            Acceso_datos Acceso = new Acceso_datos();
            string sentencia = $"EXEC Eliminar_Seguridad '{ Convert.ToInt32(CboEmpleados.SelectedValue)}'";
            MessageBox.Show(Acceso.EjecutarComando(sentencia));
            TxtUsuario.Text = "";
            TxtClave.Text = "";
        }

        // función que permite consultar los datos de ingreso de un usuario
        public void Consultar()
        {
            DataTable dt = new DataTable();
            string sentencia = "SELECT StrUsuario,StrClave FROM TBLSEGURIDAD WHERE IdEmpleado=" + CboEmpleados.SelectedValue.ToString();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.EjecutarComandoDatos(sentencia);
            if (dt.Rows.Count > 0)
            {
                TxtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                TxtClave.Text = dt.Rows[0]["StrClave"].ToString();
            }
            else
            {
                MessageBox.Show("El usuario no dispone de datos de ingreso");
                TxtUsuario.Text = "";
                TxtClave.Text = "";
            }
        }


        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminSeguridad_Load(object sender, EventArgs e)
        {
            LlenarCboEmpleados();
        }

        //btn actualizar datos q se ingresa
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //verificamos si desea cerrar la ventana
            DialogResult Rta;
            Rta = MessageBox.Show("Desea salir de la edición ?", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Rta == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void LblAdminClientes_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnNuevo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
