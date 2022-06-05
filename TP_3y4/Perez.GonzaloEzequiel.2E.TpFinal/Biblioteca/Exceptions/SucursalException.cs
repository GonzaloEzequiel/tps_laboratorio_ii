using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SucursalException : Exception
    {
        private string clase;
        private string metodo;

        public SucursalException() : base() { }
        public SucursalException(string mensaje) : base(mensaje) { }
        public SucursalException(string mensaje, Exception inner) : base(mensaje, inner) { }

        public SucursalException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public string Clase { get { return this.clase; } }
        public string Metodo { get { return this.metodo; } }

    }
}
