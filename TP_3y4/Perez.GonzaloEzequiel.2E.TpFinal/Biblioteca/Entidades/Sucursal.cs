using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sucursal
    {
        private int id;
        private static int maxId;

        private float caja;
        private string localidad;
        private string direccion;
        private List<Empleado> staff;
        private Queue<Cliente> colaAtencion;
        //private List<Factura> facturasCobradas;

        static Sucursal()
        {
            maxId = 1;
        }

        public Sucursal(string localidad, string direccion, List<Empleado> staff)
        {
            this.id = maxId;
            maxId++;

            this.caja = 0;
            this.localidad = localidad;
            this.direccion = direccion;
            this.staff = staff;

            this.colaAtencion = new Queue<Cliente>();
            //this.facturasCobradas = new List<Factura>();
        }

        public float Caja { get { return this.caja; } set { this.caja = value; } }
        public string Localidad { get { return this.localidad; } }
        public string Direccion { get { return this.direccion; } } 
        public List<Empleado> Staff { get { return this.Staff; } }
        public Queue<Cliente> ColaAtencion { get { return this.colaAtencion; } }
        //public List<Factura> FacturasCobradas { get { return this.facturasCobradas; } }

        #region SOBRECARGA

        /// <summary>
        /// Compara e indica si dos sucursales son la misma, teniendo en cuenta su direccion y localidad
        /// </summary>
        /// <param name="s1">Primer Sucursal</param>
        /// <param name="s2">Segunda Sucursal</param>
        /// <returns>True si ambas son la misma sucursal, False si no lo son</returns>
        public static bool operator ==(Sucursal s1, Sucursal s2)
        {
            return s1.localidad == s2.localidad && s1.direccion == s2.direccion;
        }

        /// <summary>
        /// Compara e indica si dos sucursales NO son la misma, teniendo en cuenta su direccion y localidad
        /// </summary>
        /// <param name="s1">Primer Sucursal</param>
        /// <param name="s2">Segunda Sucursal</param>
        /// <returns>False si ambas son la misma sucursal,True si no lo son</returns>
        public static bool operator !=(Sucursal s1, Sucursal s2)
        {
            return !(s1 == s2);
        }

        /// <summary>
        /// Indica si un Empleado pertenece al staff de una Sucursal
        /// </summary>
        /// <param name="s">Sucursal</param>
        /// <param name="e">Empleado</param>
        /// <returns>True si el Empleado pertenece a la Sucursal, False si no pertenece</returns>
        public static bool operator ==(Sucursal s, Empleado e)
        {
            foreach(Empleado empleado in s.staff)
            {
                if(empleado == e)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Indica si un Empleado NO pertenece al staff de una Sucursal
        /// </summary>
        /// <param name="s">Sucursal</param>
        /// <param name="e">Empleado</param>
        /// <returns>False si el Empleado pertenece a la Sucursal, True si no pertenece</returns>
        public static bool operator !=(Sucursal s, Empleado e)
        {
            return !(s == e);
        }

        /// <summary>
        /// Añande un empleado al staff de una Sucursal, siempre y cuando no forme parte de su staff desde antes y haya cupo
        /// </summary>
        /// <param name="s">Sucursal</param>
        /// <param name="e">Empleado</param>
        /// <returns>True si el Empleado se agregó a la Sucursal, False si no se agregó</returns>
        public static  bool operator +(Sucursal s, Empleado e)
        {
            if(s != e && s.Staff.Count < 6)
            {
                s.staff.Add(e);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Quita un empleado del staff de una Sucursal, siempre y cuando forme parte de su staff desde antes
        /// </summary>
        /// <param name="s">Sucursal</param>
        /// <param name="e">Empleado</param>
        /// <returns>True si el Empleado se quitó de la Sucursal, False si no se quitó</returns>
        public static bool operator -(Sucursal s, Empleado e)
        {
            if (s == e)
            {
                s.staff.Remove(e);
                return true;
            }

            return false;
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Busca una sucursal por su número de ID
        /// </summary>
        /// <param name="id">id a buscar</param>
        /// <returns>Sucursal encontrada</returns>
        /// <exception cref="SucursalException">se lanza si no se encontró ninguna sucursal con ese id</exception>
        public static Sucursal GetSucursalById(int id)
        {
            foreach(Sucursal sucursal in PagoFacil.Sucursales)
            {
                if(sucursal.GetHashCode() == id)
                {
                    return sucursal;
                }
            }

            throw new SucursalException("No se encontró la sucursal");
        }

        /// <summary>
        /// Compara esta Sucursal con el objeto
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>True si son el mismo objeto, False si no lo son</returns>
        public override bool Equals(object obj)
        {
            Sucursal sucursal = obj as Sucursal;
            return sucursal is not null && this == (Sucursal)obj;
        }

        /// <summary>
        /// Muestra el número de la sucursal
        /// </summary>
        /// <returns>número de la sucursal</returns>
        public override int GetHashCode()
        {
            return this.id;
        }

        /// <summary>
        /// COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR COMPLETAR 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "";
        }

        #endregion
    }
}
