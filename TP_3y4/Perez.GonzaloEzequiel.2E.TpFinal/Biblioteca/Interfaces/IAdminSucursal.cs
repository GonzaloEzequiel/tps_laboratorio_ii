using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IAdminSucursal
    {
        public float GetRecaudacion();

        public Empleado ContratarEmpleado();

        public float LiquidarSueldo(Empleado e);

        public float LiquidarSueldos();
    }
}
