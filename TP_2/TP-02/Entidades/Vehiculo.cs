using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        protected EMarca marca;
        protected string chasis;
        protected ConsoleColor color;

        protected Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get; }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(this.GetType().Name.ToUpper());
            retorno.AppendLine((string)this);
            retorno.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            retorno.AppendLine();
            retorno.AppendLine("---------------------");

            return retorno.ToString();
        }

        /// <summary>
        /// "Castea a string" todos los detos de un vehiculo
        /// </summary>
        /// <param name="p">string Retorna el resultado del sb segun chasis, marca, color, (separacion) de un vehiculo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\r\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\r\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Primer Vehículo</param>
        /// <param name="v2">Segundo Vehículo</param>
        /// <returns>True si los dos Vehículos son iguales, false si no lo son</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.chasis == v2.chasis;
        }

        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">Primer Vehículo</param>
        /// <param name="v2">Segundo Vehículo</param>
        /// <returns>True si los dos Vehículos son distintos, false si son iguales</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
    }
}
