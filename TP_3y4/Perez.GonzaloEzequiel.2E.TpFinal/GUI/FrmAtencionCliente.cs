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
    public partial class FrmAtencionCliente : Form
    {
        private GestorVisual<Cliente, Factura> gestor;
        private Cliente cliente;

        public FrmAtencionCliente(Cliente clienteParaAtender)
        {
            InitializeComponent();
            cliente = clienteParaAtender;
            gestor = new GestorVisual<Cliente, Factura>();
        }

        private void FrmAtencionCliente_Load(object sender, EventArgs e)
        {
            this.rtxtbClienteInfo.Text = gestor.Mostrar(cliente, cliente.Facturas);
        }

        private void btnCobrarFacturas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FrmLogin.empleadoLogueado.AtenderCliente(cliente), "Cobranza");
            this.Limpiar();
            if(cliente.Facturas.Count > 0)
            {
                this.rtxtbClienteInfo.Text = gestor.Mostrar(cliente, cliente.Facturas);
                this.lblMensaje.Text = "No se cobraron todas las facturas";
            }
            else
            {
                this.lblMensaje.Text = "Se cobraron todas las facturas";
            }                      
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpia el contenido del formulario
        /// </summary>
        private void Limpiar()
        {
            this.rtxtbClienteInfo.Text = null;
        }        
    }
}
