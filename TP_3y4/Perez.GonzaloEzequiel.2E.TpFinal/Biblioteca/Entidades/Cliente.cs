using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        private List<Factura> facturas;
        private float billetera; //no puede ser negativa        

        public Cliente(List<Factura> facturas) : this(facturas[0].Beneficiario.GetHashCode(), facturas[0].Beneficiario.NombreCompleto, facturas[0].Beneficiario.Domicilio, facturas)
        {
            
        }

        public Cliente(int dni, string nombreCompleto, string domicilio, List<Factura> facturas)
        {
            Random random = new Random();

            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.domicilio = domicilio;
            this.facturas = facturas;
            this.billetera = random.Next(1000, 15000) + (float)(random.Next(1, 100) * Math.Pow(10, -2));
        }

        #region PROPIEDADES

        public override string NombreCompleto { get { return this.nombreCompleto; } }
        public List<Factura> Facturas { get { return this.facturas; } }
        public float Billetera 
        { 
            get { return this.billetera; }
            set { this.billetera = value; }
        }

        #endregion

        #region SOBRECARGA



        #endregion

        #region METODOS

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.ToString());
            foreach(Factura factura in this.facturas)
            {
                retorno.AppendLine("--------------------------------------------------");
                retorno.AppendLine(factura.ToString());
            }

            return retorno.ToString();
        }

        #endregion
    }
}
