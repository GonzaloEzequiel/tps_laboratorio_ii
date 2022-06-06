using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Factura
    {
        private int numero;
        private string empresaProveedora;
        private float monto;
        private DateTime fechaVencimiento;
        private Persona beneficiario;
        private bool pagada;

        public Factura(int numero, string empresaProveedora, float monto, DateTime fechaVencimiento, Persona beneficiario)
        {
            this.numero = numero;
            this.empresaProveedora = empresaProveedora;
            this.monto = monto;
            this.fechaVencimiento = fechaVencimiento;
            this.beneficiario = beneficiario;

            this.pagada = false;
        }

        #region PROPIEDADES

        public int Numero { get { return this.numero; } }
        public string EmpresaProveedora { get { return this.empresaProveedora; } }
        public float Monto { get { return this.monto; } }
        public DateTime FechaVencimiento { get { return this.fechaVencimiento; } }
        public Persona Beneficiario { get { return this.beneficiario; } }
        public bool Pagada 
        { 
            get { return this.pagada; }
            set { this.pagada = value; }
        }

        #endregion

        /// <summary>
        /// Muestra un detalle de la Factura
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        //public static string ImprimirFactura(Factura factura)
        //{
        //    StringBuilder retorno = new StringBuilder();

        //    retorno.AppendLine(" __________________________________________ ");
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendFormat("|  {0,20}        Factura número: {1,10}  |", factura.EmpresaProveedora, factura.Numero);
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendFormat("|   Total a Pagar: ${0,10}       |", factura.Monto);
        //    retorno.AppendFormat("|   Vencimiento: {0,XX/XX}       |", factura.FechaVencimiento);
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendFormat("|  {0, 20}               |", factura.Beneficiario.NombreCompleto);
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendLine("|  Servicios del mes en curso x1 u         |");
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendLine("|                  || ||||| ||| ||||||| |  |");
        //    retorno.AppendLine("|                  || ||||| ||| ||||||| |  |");
        //    retorno.AppendLine("|                                          |");
        //    retorno.AppendLine("|__________________________________________|");

        //    return retorno.ToString();
        //}

        /// <summary>
        /// Muestra todos los datos de una Factura
        /// </summary>
        /// <returns>string con los datos</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            //retorno.AppendFormat("Empresa: {0,20} | Factura número: {1,10}", this.EmpresaProveedora, this.Numero);
            retorno.AppendFormat("Fecha de vencimiento: {0, XX/XX} | Monto a pagar: ${1,10}", this.FechaVencimiento, this.Monto);

            if(!this.Pagada)
            {
                retorno.Append("NO ");
            }
            retorno.Append("PAGADA");

            return retorno.ToString();
        }
    }
}
