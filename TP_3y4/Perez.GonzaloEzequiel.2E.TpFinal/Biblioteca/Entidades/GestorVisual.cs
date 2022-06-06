using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class GestorVisual<T, U>
        where T : class
        where U : class
    {
        ///// <summary>
        ///// Muestra los datos de una clase contenedora, y el detalle de una lista de elementos
        ///// </summary>
        ///// <param name="contenedor"></param>
        ///// <param name="lista"></param>
        ///// <returns></returns>
        public string Mostrar(T contenedor, List<U> listado)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(Mostrar(contenedor));
            retorno.AppendLine($"Lista de {listado.GetType().Name}");

            try
            {
                foreach (U item in listado)
                {
                    retorno.AppendLine("-----------------------------------------------------");
                    retorno.AppendLine(Mostrar(item));
                }
            }
            catch (NullReferenceException ex)
            {
                throw new NullReferenceException("Sin elementos en la lista", ex);
            }

            return retorno.ToString();
        }

        /// <summary>
        /// Muestra todos los datos de la Clase
        /// </summary>
        /// <param name="coso"></param>
        /// <returns></returns>
        public string Mostrar(T clase)
        {
            return clase.ToString();
        }

        public string Mostrar(U clase)
        {
            return clase.ToString();
        }
    }
}
