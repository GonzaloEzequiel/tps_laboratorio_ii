using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color)
        {
        }
        
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        //ESTE METODO NO TIENE NECESIDAD DE IMPLEMENTACION EN ESTA CLASE
        //
        //private override sealed string Mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("CICLOMOTOR");
        //    sb.AppendLine(this.Mostrar());
        //    sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
        //    sb.AppendLine("");
        //    sb.AppendLine("---------------------");

        //    return sb;
        //}
    }
}
