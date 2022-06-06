using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        private string usuario;
        private string contrasenia;

        private int legajo;
        private static int nextLegajo;

        public float sueldo;
        public bool cobrado;

        private int idSucursal;

        static Empleado()
        {
            nextLegajo = 1000;
        }

        public Empleado(Persona peronsa) : this(peronsa.GetHashCode(), peronsa.NombreCompleto, peronsa.Domicilio) { }

        public Empleado(int dni, string nombreCompleto, string domicilio)
        {
            this.legajo = nextLegajo;
            nextLegajo++;

            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.domicilio = domicilio;

            this.usuario = dni.ToString();
            this.contrasenia = "1234";

            this.cobrado = false;
            this.sueldo = PagoFacil.SueldoBasico;
        }

        #region PROPIEDADES

        public override string NombreCompleto
        {
            get { return this.nombreCompleto + " [Empleado]"; }
        }
        public int Legajo { get { return this.legajo; } }
        public virtual float Sueldo { get { return this.sueldo; } }
        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }
        public string Contrasenia
        {
            get { return this.contrasenia; }
            set { this.contrasenia = value; }
        }
        public bool Cobrado
        {
            get { return this.cobrado; }
            set { this.cobrado = value; }
        }
        public Sucursal Sucursal 
        { 
            get { return Sucursal.GetSucursalById(this.idSucursal); }  
            set { this.idSucursal = value.GetHashCode(); } 
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Atiende un Cliente (entre 5 y 10 segundos) intentando cobrar todas sus facturas, remueve el Cliente de la cola de atencion de la Sucursal
        /// </summary>
        /// <param name="cliente">Cliente a atender</param>
        /// <returns>llama al siguiente Cliente en la cola</returns>
        /// <exception cref="Exception"></exception>
        public string AtenderCliente(Cliente cliente)
        {
            System.Threading.Thread.Sleep(new Random().Next(5000, 10000));

            foreach(Factura factura in cliente.Facturas)
            {
                try
                {
                    if(!factura.Pagada && this.CobrarFactura(cliente.Billetera, factura))
                    {
                        cliente.Billetera -= factura.Monto;
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("No se pudieron cobrar todas las facturas", ex);
                }
                finally
                {
                    this.Sucursal.ColaAtencion.Dequeue();                    
                }
            }

            return "Gracias ¡El que sigue!";

        }

        /// <summary>
        /// Cobra una Factura si el dinero es suficiente, lo añanade a la caja de la respectiva Sucursal
        /// </summary>
        /// <param name="dinero">Dinero recibido</param>
        /// <param name="factura">Factura a cobrar</param>
        /// <returns>True si la Factura fue cobrada, False si no lo fue</returns>
        /// <exception cref="MontoException">se lanza cuando el dinero recibido es insuficiente para abonar la Factura</exception>
        /// <exception cref="FacturaVencidaException">se lanza cuando la fecha de vencimiento es superior a la actural</exception>
        private bool CobrarFactura(float dinero, Factura factura)
        {
            if(factura.FechaVencimiento >= DateTime.Now)
            {
                if(dinero >= factura.Monto)
                {
                    this.Sucursal.Caja += factura.Monto;
                    factura.Pagada = true;
                }
                else
                {
                    throw new MontoException("Dinero insuficiente");
                }
            }
            else
            {
                throw new FacturaVencidaException("La factura está vencida");
            }

            return factura.Pagada;
        }

        #endregion
    }
}
