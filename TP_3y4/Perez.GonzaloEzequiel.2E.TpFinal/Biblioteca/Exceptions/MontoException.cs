using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MontoException : Exception
    {
        private string clase;
        private string metodo;

        public MontoException() : base() { }
        public MontoException(string mensaje) : base(mensaje) { }
        public MontoException(string mensaje, Exception inner) : base(mensaje, inner) { }

        public MontoException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner)
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public string Clase { get { return clase; } }
        public string Metodo { get { return metodo; } }

    }
}
