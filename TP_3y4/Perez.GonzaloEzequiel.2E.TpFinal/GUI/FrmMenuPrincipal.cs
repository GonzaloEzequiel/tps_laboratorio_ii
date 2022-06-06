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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Text += $"PagoFacil - Modo {FrmLogin.empleadoLogueado.GetType().Name}";
            this.lblInfo.Text = $"{FrmLogin.empleadoLogueado.NombreCompleto} - {FrmLogin.empleadoLogueado.Sucursal.Localidad}, {FrmLogin.empleadoLogueado.Sucursal.Direccion}";

            if(FrmLogin.empleadoLogueado.GetType() == typeof(Encargado))
            {
                this.btnAdminSucursal.Enabled = true;
            }
            else if(FrmLogin.empleadoLogueado is Gerente)
            {
                this.lblColaClientes.Text = "Elija Sucursal";
                this.btnAtenderCliente.Enabled = false;
                this.cmbSucursal.Enabled = true;
                this.btnAdminSucursal.Enabled = true;
                this.btnAdminGerencial.Enabled = true;
            }
        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            FrmAtencionCliente frmAtencionCliente = new FrmAtencionCliente(FrmLogin.empleadoLogueado.Sucursal.ColaAtencion.Peek());
            frmAtencionCliente.MdiParent = this;
            frmAtencionCliente.Show();
        }

        private void btnAdminSucursal_Click(object sender, EventArgs e)
        {
            FrmAdminSucursal frmAdminSucursal;

            if (FrmLogin.empleadoLogueado is Gerente)
            {
                frmAdminSucursal = new FrmAdminSucursal(Sucursal.GetSucursalById(this.cmbSucursal.SelectedIndex));
            }
            else
            {
                frmAdminSucursal = new FrmAdminSucursal(FrmLogin.empleadoLogueado.Sucursal);
            }
             
            frmAdminSucursal.MdiParent = this;
            frmAdminSucursal.Show();
        }

        private void btnAdminGerencial_Click(object sender, EventArgs e)
        {
            FrmAdminGerencial frmAdminGerencial = new FrmAdminGerencial();
        }
    }
}
