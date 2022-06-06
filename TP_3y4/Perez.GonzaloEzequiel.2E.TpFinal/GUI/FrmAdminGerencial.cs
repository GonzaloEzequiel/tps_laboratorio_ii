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
    public partial class FrmAdminGerencial : Form
    {
        private GestorGerencial gestorGerencial;

        public FrmAdminGerencial()
        {
            InitializeComponent();
            gestorGerencial = new GestorGerencial();
        }

        private void btnContratarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAuxGerencial frmAuxGerencial = new FrmAuxGerencial('C');
            frmAuxGerencial.ShowDialog();
        }

        private void btnPromoverEmpleado_Click(object sender, EventArgs e)
        {
            FrmAuxGerencial frmAuxGerencial = new FrmAuxGerencial('P');
            frmAuxGerencial.ShowDialog();
        }

        private void btnTransferirEmpleado_Click(object sender, EventArgs e)
        {
            FrmAuxGerencial frmAuxGerencial = new FrmAuxGerencial('T');
            frmAuxGerencial.ShowDialog();
        }

        private void btnDespedirEmpleado_Click(object sender, EventArgs e)
        {
            FrmAuxGerencial frmAuxGerencial = new FrmAuxGerencial('D');
            frmAuxGerencial.ShowDialog();
        }

        private void btnAbrirNuevaSucursal_Click(object sender, EventArgs e)
        {
            FrmAuxGerencial frmAuxGerencial = new FrmAuxGerencial('A');
            frmAuxGerencial.ShowDialog();
        }

        private void btnRecaudar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea realizar la recaudacion de todas las sucursales?", "RECAUDACIÓN TOTAL", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                gestorGerencial.GetRecaudacion();
            }
        }

        private void btnLiquidarSueldos_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea liquidar el sueldo de todos los empleados?", "LIQUIDACIÓN TOTAL", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                gestorGerencial.LiquidarSueldos();
            }
        }        
    }
}
