using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected int dni;
        protected string nombreCompleto;
        protected string domicilio;

        #region PROPIEDADES

        public abstract string NombreCompleto { get; }
        public string Domicilio { get { return this.domicilio; } }

        #endregion

        #region SOBRECARGA

        /// <summary>
        /// Compara si dos personas son la misma, según su número de dni
        /// </summary>
        /// <param name="p1">primera Persona</param>
        /// <param name="p2">segunda Persona</param>
        /// <returns>True si son la misma Persona, False si no lo son</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.dni == p2.dni;
        }

        /// <summary>
        /// Compara si dos personas NO son la misma, según su número de dni
        /// </summary>
        /// <param name="p1">primera Persona</param>
        /// <param name="p2">segunda Persona</param>
        /// <returns>False si son la misma Persona, True si no lo son</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region METODOS

        /// <summary>
        /// Compara esta Persona con el objeto
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>True si son el mismo objeto, False si no lo son</returns>
        public override bool Equals(object obj)
        {
            Persona persona = obj as Persona;
            return persona is not null && this == (Persona)obj;
        }

        /// <summary>
        /// Muestra el número de dni de la Persona
        /// </summary>
        /// <returns>El número de dni</returns>
        public override int GetHashCode()
        {
            return this.dni;
        }

        /// <summary>
        /// Muestra los datos de la Persona
        /// </summary>
        /// <returns>string con los datos de la Persona</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendFormat("Nombre: {0,50} | Dni: {1,10}", this.NombreCompleto, this.GetHashCode());
            retorno.AppendLine($"Domicilio: {this.Domicilio}");

            return retorno.ToString();
        }

        #endregion
    }
}
