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
    public partial class FrmAdminSucursal : Form
    {
        private GestorVisual<Sucursal, Empleado> gestor;
        private Sucursal sucursal;
        private Encargado encargado;

        public FrmAdminSucursal(Sucursal sucursalParaAdministrar)
        {
            InitializeComponent();
            gestor = new GestorVisual<Sucursal, Empleado>();
            encargado = (Encargado)FrmLogin.empleadoLogueado;

            sucursal = sucursalParaAdministrar;
            
        }

        private void FrmAdminSucursal_Load(object sender, EventArgs e)
        {
            this.rtxtbSucursaleInfo.Text = gestor.Mostrar(sucursal, sucursal.Staff);
            this.lblMensaje.Text = $"Valores en caja: ${sucursal.Caja}";
        }

        private void btnRecaudar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se recaudaron ${sucursal.Caja}", "Recaudación");
            this.lblMensaje.Text = $"Valores en caja: ${sucursal.Caja}";
        }        

        private void btnContratarEmpleado_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Contratar nuevo Empleado?", "Contratar Empleado", MessageBoxButtons.YesNo);
            if(respuesta == DialogResult.Yes)
            {
                if(encargado.ContratarEmpleado() is not null)
                {
                    MessageBox.Show("Se contrató un nuevo representante", "Contratación exitosa");
                    this.rtxtbSucursaleInfo.Text = gestor.Mostrar(sucursal, sucursal.Staff);
                }
                else
                {
                    MessageBox.Show("No hay más cupo en la Sucursal", "Contratación cancelada");
                }                
            }
        }

        private void btnLiquidarSueldos_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea liquidar los sueldos?", "Liqudar Sueldos", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                encargado.LiquidarSueldos();
                this.lblMensaje.Text = $"Valores en caja: ${sucursal.Caja}";
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
