using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PagoFacil
    {
        private static GestorGerencial gestorGerencial;        
        private static List<Sucursal> sucursales;
        private static float recaudacion;
        private static float sueldoBasico;

        static PagoFacil()
        {
            sucursales = new List<Sucursal>();
            recaudacion = 0;
            sueldoBasico = 40000f; //esto se leera desde un archivo
        }
                
        public static List<Sucursal> Sucursales { get { return sucursales; } }
        public static float Recaudacion { get { return recaudacion; } set { recaudacion = value; } }
        public static float SueldoBasico { get { return sueldoBasico; } set { sueldoBasico = value; } }

        /// <summary>
        /// Abre una nueva Sucursal en una localidad y dirección brindadas, asigna el personal
        /// </summary>
        /// <param name="localidad">localidad de la nueva Sucursal</param>
        /// <param name="direccion">direccion de la nueva Sucursal</param>
        /// <returns>la nueva Sucursal</returns>
        /// <exception cref="SucursalException">se lanza si la Sucursal ya existe, o si no se asignó al menos 1 Encargado</exception>
        public static Sucursal AbrirSucursal(string localidad, string direccion)
        {
            Random random = new Random();
            Sucursal auxSucursal = new Sucursal(localidad, direccion, new List<Empleado>());

            //verifica que la sucursal no exista previamente
            foreach(Sucursal sucursal in sucursales)
            {
                if(sucursal == auxSucursal)
                {
                    throw new SucursalException("La sucursal ya existe");
                }
            }

            //agregar n Empleados a la sucursal
            for(int i=0; i < random.Next(0,6); i++)
            {
                gestorGerencial.ContratarEmpleado(auxSucursal);
            }
            //y le asigna al primero el rol de Encargado
            gestorGerencial.PromoverEmpleado(auxSucursal.Staff[0]);

            //verifica la existencia de personal y al menos un Encargado
            if(auxSucursal.Staff is not null && ExisteEncargado(auxSucursal))
            {
                sucursales.Add(auxSucursal);
            }
            else
            {
                throw new SucursalException("No se puede abrir una sucursal sin un Encargado");
            }

            return auxSucursal;
        }

        /// <summary>
        /// Liquida los sueldos de los Empleados, recauda el restante, y cierra la Sucursal (mucha suerte a los Empleados)
        /// </summary>
        /// <param name="sucursal">la Sucursal a cerrar</param>
        /// <returns>la recaudacion final por el cierre de la Sucursal</returns>
        /// <exception cref="SucursalException">se lanza si la Sucursal no se encontró</exception>
        public static float CerrarSucursal(Sucursal sucursal)
        {
            float retorno = 0;

            foreach(Sucursal suc in sucursales)
            {
                if (suc == sucursal)
                {
                    gestorGerencial.SucursalAGestionar = suc;
                    retorno -= ((IAdminSucursal)gestorGerencial).LiquidarSueldos();
                    retorno += ((IAdminSucursal)gestorGerencial).GetRecaudacion();
                    sucursales.Remove(suc);
                    
                }
                else
                {
                    throw new SucursalException("No se encontró la Sucursal");
                }
            }

            return retorno;
        }

        /// <summary>
        /// Indica la existencia de un Encargado en la Sucursal, requisito para poder abrir una sucurasal
        /// </summary>
        /// <returns>True si existe al menos un Encargado asignado a la sucursal</returns>
        private static bool ExisteEncargado(Sucursal s)
        {
            foreach (Empleado empleado in s.Staff)
            {
                if (empleado.GetType() == typeof(Encargado))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
