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
    public partial class FrmAuxGerencial : Form
    {
        private GestorGerencial gestorGerencial;
        private char modo;

        public FrmAuxGerencial(char modo)
        {
            InitializeComponent();
            gestorGerencial = new GestorGerencial();
            this.modo = modo;
        }

        private void FrmAuxGerencial_Load(object sender, EventArgs e)
        {
            switch(modo)
            {
                case ('C'):
                    this.lblSuperior.Text = "Sucursal";
                    //this.cmbSuperior.Items.AddRange(PagoFacil.Sucursales.ToString().ToArray());
                    this.lblInferior.Enabled = false;
                    this.cmbInferior.Enabled = false;
                    break;

                case ('P'):
                    this.lblSuperior.Text = "Sucursal";
                    //this.cmbSuperior.Items.AddRange(PagoFacil.Sucursales.ToString().ToArray());
                    this.lblInferior.Text = "Empleado a Promover";
                    //this.cmbInferior.Items.AddRange(empleados de la sucursal elegida arriba);
                    break;

                case ('T'):
                    this.lblSuperior.Text = "Empleado a Transferir";
                    //this.cmbSuperior.Items.AddRange(todos los empleados de todas las sucursales que no sean encargados);
                    this.lblInferior.Text = "Sucursal Destino";
                    //this.cmbSuperior.Items.AddRange(PagoFacil.Sucursales.ToString().ToArray());
                    break;

                case ('D'):
                    this.lblSuperior.Text = "Sucursal";
                    //this.cmbSuperior.Items.AddRange(PagoFacil.Sucursales.ToString().ToArray());
                    this.lblInferior.Text = "Empleado a Despedir";
                    //this.cmbInferior.Items.AddRange(empleados de la sucursal elegida arriba);
                    break;

                case ('A'):
                    this.lblSuperior.Text = "Localidad";
                    this.cmbSuperior.Enabled = false;
                    //crea un txtboxLocalidad location 14; 63 size 258; 23
                    this.lblInferior.Text = "Dirección";
                    this.cmbInferior.Enabled = false;
                    //crea un txtboxDireccion location 14; 118 size 258; 23
                    break;

                default:
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case ('C'):
                    if(gestorGerencial.ContratarEmpleado(Sucursal.GetSucursalById(this.cmbSuperior.SelectedIndex)) is not null)
                    {
                        MessageBox.Show("Se contrató un nuevo representante", "Contratación exitosa");
                    }
                    else
                    {
                        MessageBox.Show("No hay más cupo en la Sucursal", "Contratación cancelada");
                    }
                    break;

                case ('P'):
                    if(gestorGerencial.PromoverEmpleado(Sucursal.GetSucursalById(this.cmbSuperior.SelectedIndex).Staff[cmbInferior.SelectedIndex]) is not null)
                    {
                        MessageBox.Show("Se promivió al representante", "Promoción exitosa");
                    }
                    break;

                case ('T'):
                    break;

                case ('D'):
                    break;

                case ('A'):
                    break;

                default:
                    break;
            }
        }
    }
}
