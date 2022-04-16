using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Operando
    {
        private double numero;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Operando y setea su atributo "numero" en cero.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Operando y setea su atributo "numero" mediante el parametro double recibido.
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Operando y setea su atributo "numero" mediante el parametro string recibido.
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
           this.Numero = strNumero;
        }

        /// <summary>
        /// Setea el atributo "numero" del Operando
        /// </summary>
        public string Numero { set { this.numero = ValidarOperando(value); } }

        /// <summary>
        /// Valida que la cadena recibida sea un número, si no lo es lo convierte a "0"
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>Retorna la conversion de la cadena a número, o 0 si el ingreso es incorrecto</returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno;

            if (!double.TryParse(strNumero, out retorno))
                retorno = 0;

            return retorno;
        }

        /// <summary>
        /// Verifica si numero ingresado por string es o no es binario
        /// </summary>
        /// <param name="binario">string numero a validar</param>
        /// <returns>
        /// true si el valor ingresado es binario, false si no lo es
        /// </returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = true;

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Verifica si una cadena recibida es un número binario y lo convierte a decimal.
        /// </summary>
        /// <param name="binario">Cadena recibida a convertir</param>
        /// <returns>El numero decimal convertido en formato cadena, o el mensaje "Valor inválido" si la cadena recibida no es un numero binario</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            double auxDouble = 0;

            if (EsBinario(binario))
            {
                // Investigando hallé que este método posee una sobrecarga(n°19/19) la cual permite pasar un string a entero especificando la base
                //
                // int Covert.ToInt32(string? vale, int fromBase)
                // "Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer."
                //
                // La implementaría de la siguiente forma:
                // return (Convert.ToInt32(binario, 2)).ToString();
                //
                // Sin embargo opté por usar la siguiente forma que deduje, siguiendo los pasos lógicos de la operación, aunque admito no tiene el mejor aspecto!!
                for (int index = (binario.Length - 1); index >= 0; index--)
                {
                    auxDouble += int.Parse(binario[index].ToString()) * Math.Pow(2, ((binario.Length - 1) - index));
                }

                retorno = auxDouble.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";

            double auxNumero = 0;

            int[] auxInts = new int[50];


            if (numero != null)
            {
                auxNumero = double.Parse(numero);
                int i = 0;

                do
                {
                    auxInts[i] = (int)(auxNumero % 2);
                    auxNumero /= 2;
                    i++;

                } while ((int)auxNumero > 0);

                StringBuilder sb = new StringBuilder();

                for (int j = i - 1; j >= 0; j--)
                {
                    sb.Append(auxInts[j]);
                }

                retorno = sb.ToString();
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga de operador, permite sumar los atributos "numero" de dos Operandos
        /// </summary>
        /// <param name="n1">Primer Operando</param>
        /// <param name="n2">Segundo Operando</param>
        /// <returns>Retorna el resultado de la suma de los atributos "numero" de los Operandos</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador, permite restar los atributos "numero" de dos Operandos
        /// </summary>
        /// <param name="n1">Primer Operando</param>
        /// <param name="n2">Segundo Operando</param>
        /// <returns>Retorna el resultado de la resta de los atributos "numero" de los Operandos</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador, permite multiplicar los atributos "numero" de dos Operandos
        /// </summary>
        /// <param name="n1">Primer Operando</param>
        /// <param name="n2">Segundo Operando</param>
        /// <returns>Retorna el producto entre los atributos "numero" de los Operandos</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador, permite dividir los atributos "numero" de dos Operandos
        /// </summary>
        /// <param name="n1">Primer Operando, numerador</param>
        /// <param name="n2">Segundo Operando, denominador</param>
        /// <returns>Retorna el cociente entre los atributos "numero" de los Operandos</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
                return n1.numero / n2.numero;
            else
                return double.MinValue;
        }
    }
}
