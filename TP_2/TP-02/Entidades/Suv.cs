using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }


        //ESTE METODO NO TIENE NECESIDAD DE IMPLEMENTACION EN ESTA CLASE
        //
        //public override sealed string Mostrar()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine("SUV");
        //    sb.AppendLine(base);
        //    sb.AppendLine("TAMAÑO : {0}", this.Tamanio);
        //    sb.AppendLine("");
        //    sb.AppendLine("---------------------");

        //    return sb;
        //}
    }
}
