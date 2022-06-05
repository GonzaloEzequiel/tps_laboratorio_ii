using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Encargado : Empleado, IAdminSucursal
    {
        protected float bono;

        public Encargado(Empleado empleado) : this(empleado.GetHashCode(), empleado.NombreCompleto, empleado.Domicilio) { }

        public Encargado(int dni, string nombreCompleto, string domicilio) : base(dni, nombreCompleto, domicilio)
        {
            this.bono = 0.25f;
        }

        #region PROPIEDADES

        public override string NombreCompleto
        {
            get { return this.nombreCompleto + " [Encargado]"; }
        }

        public override float Sueldo { get { return base.Sueldo * this.bono; } }

        public float Bono
        {
            get { return this.bono; }
            set { this.bono = value; }
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Recauda el valor total en la caja de la Sucursal
        /// </summary>
        /// <returns>la suma del monto total recaudado</returns>
        public float GetRecaudacion()
        {
            float retorno = this.Sucursal.Caja;

            this.Sucursal.Caja = 0;
            PagoFacil.Recaudacion += retorno;

            return retorno;
        }

        /// <summary>
        /// Contrata una Persona elegida para esta Sucursal
        /// </summary>
        /// <returns>el nuevo Empleado si se pudo contratar, null si no se pudo contratar (cupo)</returns>
        public Empleado ContratarEmpleado()
        {
            Empleado nuevoEmpleado = new Empleado(GestorGerencial.ElegirPostulate());

            if (this.Sucursal + nuevoEmpleado)
            {
                nuevoEmpleado.Sucursal = this.Sucursal;
                return nuevoEmpleado;
            }

            return null;
        }

        /// <summary>
        /// Liquida el sueldo de un Empleado con los valores en caja de la Sucursal
        /// </summary>
        /// <param name="e">Empleado a liquidar</param>
        /// <returns>el sueldo del Empleado</returns>
        /// <exception cref="SucursalException">se lanza si el Empleado no perteneces a la Sucursal del Encargado (jurisdiccion)</exception>
        public float LiquidarSueldo(Empleado e)
        {
            if(e.Sucursal == this.Sucursal)
            {
                this.Sucursal.Caja -= e.Sueldo;
                e.cobrado = true;

                return e.Sueldo;
            }
            else
            {
                throw new SucursalException("El empleado no pertenece a esta Sucursal");
            }
        }

        /// <summary>
        /// Liquida los sueldos de todos los Empleados de una Sucursal, puede dar saldo negativo
        /// </summary>
        /// <returns>la suma total de sueldos liquidados</returns>
        public float LiquidarSueldos()
        {
            float retorno = 0;

            foreach(Empleado empleado in this.Sucursal.Staff)
            {
                retorno += this.LiquidarSueldo(empleado);
            }

            return retorno;
        }

        /// <summary>
        /// Muestra todos los datos del Encargado
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.ToString());
            retorno.Append($"Bono: {this.Bono}");

            return retorno.ToString();
        }

        #endregion
    }
}
