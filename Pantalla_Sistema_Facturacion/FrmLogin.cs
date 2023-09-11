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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {

            String Respuesta = "";

            if (TxtUser.Text != "" && TxtPassword.Text != String.Empty)
            {
                Acceso_datos Acceso = new Acceso_datos();
                Respuesta = Acceso.ValidarUsuario(TxtUser.Text, TxtPassword.Text);

                if (Respuesta != "")
                {
                    MessageBox.Show($"Bienvenido {Respuesta}");
                    FrmPrincipal frmppal = new FrmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO O CLAVE NO ENCONTRADOS");
                    TxtUser.Text = "";
                    TxtUser.Focus();
                    TxtPassword.Text = "";
                }
            }
            else MessageBox.Show("Debes Ingresar un Usuario y una Contraseña");


            //String Respuesta = "";
            //if (TxtUser.Text != "" && TxtUser.Text != String.Empty && TxtPassword.Text != "")
            //{
            //    if (TxtUser.Text == "admin" && TxtPassword.Text == "1234")
            //        Respuesta = "Administrador pro";

            //    if (Respuesta != "")
            //    {
            //        MessageBox.Show($"Bienvenido queridisimo {Respuesta}");
            //        FrmPrincipal FrmPrin = new FrmPrincipal();
            //        this.Hide();
            //        FrmPrin.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuuario y/o Clave incorrectos");
            //        TxtUser.Text = "";
            //        TxtPassword.Text = "";
            //        TxtUser.Focus();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Debes ingresar un usuario y una clave");
            //    TxtUser.Text = "";
            //    TxtPassword.Text = "";
            //    TxtUser.Focus();
            //}
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
