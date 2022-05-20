using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operaciones
    {

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1" name="n2">Tamaño del arreglo</param>
        /// <returns>resultado de la suma numero entero</returns>

        internal int Sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1" name="n2">Tamaño del arreglo</param>
        /// <returns>resultado de la resta, numero entero</returns>
        internal int Restar(int n1, int n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1" name="n2">Tamaño del arreglo</param>
        /// <returns>resultado de la multiplación, numero entero</returns>
        internal int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1" name="n2">Tamaño del arreglo</param>
        /// <returns>resultado de la division, numero entero</returns>
        internal int Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            return n1 / n2;
        }

    }
}
