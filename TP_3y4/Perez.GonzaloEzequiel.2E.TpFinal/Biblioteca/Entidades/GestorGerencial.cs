using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestorGerencial : IAdminSucursal, IAdminGerencial
    {
        Sucursal sucursalAGestionar;
        private static List<Persona> recursosHumanos;

        static GestorGerencial()
        {
            recursosHumanos = new List<Persona>();  //se debe leer desde un archivo de Persona(s) postulantes
        }

        public Sucursal SucursalAGestionar
        {
            get { return Sucursal.GetSucursalById(sucursalAGestionar.GetHashCode()); }
            set { this.sucursalAGestionar = value; }
        }
        public static List<Persona> RecursosHumanos { get { return recursosHumanos; } }

        #region METODOS

        //GestorGerencial implementa la interfaz IAdinSucursal de forma explícita
        #region IAdminSucursal

        /// <summary>
        /// Recauda la caja de una Sucursal
        /// </summary>
        /// <returns>el monto total recaudado</returns>
        float IAdminSucursal.GetRecaudacion()
        {
            float retorno = this.sucursalAGestionar.Caja;

            this.sucursalAGestionar.Caja = 0;
            PagoFacil.Recaudacion += retorno;

            return retorno;
        }

        /// <summary>
        /// Contrata una Persona elegida para la Sucursal
        /// </summary>
        /// <returns>el nuevo Empleado si se pudo contratar, null si no se pudo contratar (cupo)</returns>
        Empleado IAdminSucursal.ContratarEmpleado()
        {
            //Empleado nuevoEmpleado = new Empleado(ElegirPostulate());

            //if (this.SucursalAGestionar + nuevoEmpleado)
            //{
            //    nuevoEmpleado.Sucursal = this.SucursalAGestionar;
            //    return nuevoEmpleado;
            //}

            //return null;                        

            return ContratarEmpleado(this.sucursalAGestionar);
        }

        /// <summary>
        /// Liquida el sueldo de un Empleado con los valores en caja de la Sucursal
        /// </summary>
        /// <param name="e">Empleado a liquidar</param>
        /// <returns>el sueldo del Empleado</returns>
        float IAdminSucursal.LiquidarSueldo(Empleado e)
        {
            e.Sucursal.Caja -= e.Sueldo;
            e.cobrado = true;

            return e.Sueldo;
        }

        /// <summary>
        /// Liquida los sueldos de todos los Empleados de una Sucursal, puede dar saldo negativo
        /// </summary>
        /// <returns>la suma total de sueldos liquidados</returns>
        float IAdminSucursal.LiquidarSueldos()
        {
            float retorno = 0;

            foreach (Empleado empleado in this.sucursalAGestionar.Staff)
            {
                if(!empleado.Cobrado)
                {
                    retorno += ((IAdminSucursal)this).LiquidarSueldo(empleado);
                }                
            }

            return retorno;
        }

        #endregion

        //GestorGerencial implementa la interfaz IAdinGerencial de forma imlícita
        #region IAdminGerencial

        /// <summary>
        /// Recauda la caja de todas las sucursales de PagoFacil
        /// </summary>
        /// <returns>el monto total recaudado</returns>
        public float GetRecaudacion()
        {
            float retorno = 0;

            foreach(Sucursal sucursal in PagoFacil.Sucursales)
            {
                this.SucursalAGestionar = sucursal;
                retorno += ((IAdminSucursal)this).GetRecaudacion();
            }

            return retorno;
        }

        /// <summary>
        /// Contrata una Persona elegida, para una Sucursal elegida
        /// </summary>
        /// <param name="s">Sucursal elegida</param>
        /// <returns>el nuevo Empleado si se pudo contratar, null si no se pudo contratar (cupo)</returns>
        public Empleado ContratarEmpleado(Sucursal s)
        {
            Empleado nuevoEmpleado = new Empleado(ElegirPostulate());

            if (s + nuevoEmpleado)
            {
                nuevoEmpleado.Sucursal = s;
                return nuevoEmpleado;
            }

            return null;
        }

        /// <summary>
        /// Promueve un Empleado al cargo de Encargado, actualizando el staff
        /// </summary>
        /// <param name="e">Empleado a promover</param>
        /// <returns>nuevo Encargado</returns>
        public Encargado PromoverEmpleado(Empleado e)
        {
            Encargado empleadoPromovido = new Encargado(e);

            e.Sucursal.Staff.Remove(e);
            e.Sucursal.Staff.Add(empleadoPromovido);

            return empleadoPromovido;
        }

        /// <summary>
        /// Transifere un Empleado a una nueva Sucursal
        /// </summary>
        /// <param name="e">Empleado a transferir</param>
        /// <param name="s">nueva Sucursal elegida</param>
        public bool TransferirEmpleado(Empleado e, Sucursal s)
        {
            return e.Sucursal - e && s + e;
        }

        /// <summary>
        /// Liquida el sueldo de un Empleado y lo despide (con causa, o tal vez renunció)
        /// </summary>
        /// <param name="e"></param>
        /// <returns>True si lo despidió, False si hubo algun inconveniente (ese empleado no exista)</returns>
        public bool DespedirEmpleado(Empleado e)
        {
            ((IAdminSucursal)this).LiquidarSueldo(e);

            return e.Sucursal - e;            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float LiquidarSueldos()
        {
            float retorno = 0;

            foreach (Sucursal sucursal in PagoFacil.Sucursales)
            {
                this.SucursalAGestionar = sucursal;
                retorno += ((IAdminSucursal)this).LiquidarSueldos();
            }

            return retorno;
        }

        #endregion

        /// <summary>
        /// Elige una Persona postulante de la lista de recursosHumanos disponibles, para emplear, y la quita de la lista de recursosHumanos
        /// </summary>
        /// <returns>la Persona elegida</returns>
        public static Persona ElegirPostulate()
        {
            Random random = new Random();

            //Elige una persona de entre las primeras 10 entrevistadas (por sus aptitudes claramente)
            Persona persona = recursosHumanos[random.Next(0, 10)];

            recursosHumanos.Remove(persona);

            return persona;
        }

        #endregion










    }
}
