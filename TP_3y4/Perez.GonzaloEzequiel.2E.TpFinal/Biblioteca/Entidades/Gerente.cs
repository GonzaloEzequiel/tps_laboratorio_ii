using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gerente : Encargado
    {
        public Gerente(Empleado empleado) : base(empleado)
        {
        }
    }
}
