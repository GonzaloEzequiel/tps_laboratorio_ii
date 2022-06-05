using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IAdminGerencial
    {
        public float GetRecaudacion();

        public Empleado ContratarEmpleado(Sucursal s);

        public Encargado PromoverEmpleado(Empleado e);

        public bool TransferirEmpleado(Empleado e, Sucursal s);

        public bool DespedirEmpleado(Empleado e);

        public float LiquidarSueldos();
    }
}
