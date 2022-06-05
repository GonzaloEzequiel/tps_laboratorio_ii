using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class FacturaVencidaException : Exception
    {
        private string clase;
        private string metodo;

        public FacturaVencidaException() : base() { }
        public FacturaVencidaException(string mensaje) : base(mensaje) { }
        public FacturaVencidaException(string mensaje, Exception inner) : base(mensaje, inner) { }

        public FacturaVencidaException(string mensaje, string clase, string metodo, Exception inner) : base(mensaje, inner) 
        {
            this.clase = clase;
            this.metodo = metodo;
        }

        public string Clase { get { return this.clase; } }
        public string Metodo { get { return this.metodo; } }

    }
}
