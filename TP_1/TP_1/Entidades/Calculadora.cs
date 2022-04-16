namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Reliza las operaciones matemáticas
        /// </summary>
        /// <param name="num1">Operando objeto con valor numérico para operar (1er término o numerador en caso de division)</param>
        /// <param name="num2">Operando objeto con valor numérico para operar (2do término o denominador en caso de division)</param>
        /// <returns>
        /// El resultado matemático de la operación seleccionada
        /// </returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;
            operador = Calculadora.ValidarOperador(operador);

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;

                default:
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida operador como caracter de operación matemática
        /// </summary>
        /// <param name="operador">char operador matemático recibido a validar</param>
        /// <returns>
        /// Si el operador matemático es correcto lo retorna, caso contrario retornará '+'
        /// </returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
    }
}