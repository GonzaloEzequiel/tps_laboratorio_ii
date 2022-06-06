using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        public static Empleado empleadoLogueado;    

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = @"../../../Resources/PF.png";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.LogIn(txtUsuario.Text, txtContrasenia.Text, out empleadoLogueado))
                {
                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    this.Hide();
                    menu.ShowDialog();

                    if (menu.DialogResult == DialogResult.Yes)
                        this.Close();
                }
            }
            catch(UsuarioInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Limpiar();
            }
        }

        private void btnLogEmpleado_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Gonza";
            txtContrasenia.Text = "123";
        }

        private void btnLogEncargado_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Gonza";
            txtContrasenia.Text = "123";
        }

        private void btnLogGerente_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "Gonza";
            txtContrasenia.Text = "123";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region METODOS

        /// <summary>
        /// Valida el acceso a la aplicación confirmando si tanto el usuario como su contrase son correctas
        /// </summary>
        /// <param name="usuario">usuario ingresado</param>
        /// <param name="contrasenia">contraseña ingresada</param>
        /// <param name="empleadoLogueado">Empleado logueado</param>
        /// <returns>True si el LogIn fue correcto, False si no lo fue</returns>
        /// <exception cref="UsuarioInvalidoException">se lanza cuando falta algun dato de ingresos, o cuando son incorrectos</exception>
        private bool LogIn(string usuario, string contrasenia, out Empleado empleadoLogueado)
        {
            if(usuario != null && contrasenia != null)
            {
                foreach(Sucursal sucursal in PagoFacil.Sucursales)
                {
                    foreach(Empleado empleado in sucursal.Staff)
                    {
                        if(empleado.Usuario == usuario.Trim().ToLower() && empleado.Contrasenia == contrasenia.Trim().ToLower())
                        {
                            empleadoLogueado = empleado;
                            return true;
                        }
                    }
                }

                throw new UsuarioInvalidoException("Usuario o Contraseña incorrectos");
            }
            else
            {
                throw new UsuarioInvalidoException("Información de Log incompleta");
            }
        }

        /// <summary>
        /// Limpia el contenido del formulario
        /// </summary>
        private void Limpiar()
        {
            txtUsuario.Text = null;
            txtContrasenia.Text = null;
        }

        #endregion
        
    }
}
