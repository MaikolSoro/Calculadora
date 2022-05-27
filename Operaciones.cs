using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operaciones
    {

        double POT = 1.0 / 3.0;


       

        /// <summary>
        /// Suma dos numeros
        /// </summary>
        /// <param name="n1" name="n2"></param>
        /// <returns>resultado de la suma numero entero</returns>
        internal int Sumar(int n1, int n2)
        {

            return n1 + n2;
        }
        public int registraSuma(int n1, int n2)
        {
            int result = n1 + n2;
         //   DB().Registrar(Ruta(NodePadre(), n1, n2);
            return result;

        }
        /// <summary>
        /// Resta dos numeros
        /// </summary>
        /// <param name="n1" name="n2"></param>
        /// <returns>resultado de la resta, numero entero</returns>
        internal int Restar(int n1, int n2)
        {
            return n1 - n2;
        }

        /// <summary>
        /// multiplica dos numeros
        /// </summary>
        /// <param name="n1" name="n2"></param>
        /// <returns>resultado de la multiplación, numero entero</returns>
        internal int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        /// <summary>
        /// Divide dos numeros
        /// </summary>
        /// <param name="n1" name="n2">param>
        /// <returns>resultado de la division, numero entero</returns>
        internal int Dividir(int n1, int n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            return n1 / n2;
        }

        /// <summary>
        /// Calcula la potencia de un numero
        /// </summary>
        /// <param name="n1" name="n2">param>
        /// <returns>resultado de la potencia de un numero elevado al cuadrado</returns>
        internal double Potencia(double n1, double n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            return Math.Pow(n1, n2);
        }

        /// <summary>
        /// Calcula la raiz cuadrada de un numero
        /// 
        /// </summary>
        /// <param name="n1" name="n2">param>
        /// <returns>resultado de la raiz cuadrada al un numero</returns>
        internal double RaizCuadrada(double n1)
        {
            if (n1 == 0)
            {
                return 0;
            }
            return Math.Round(Math.Sqrt(n1),2);
        }

        /// <summary>
        /// Calcula la raiz cubica de un numero
        /// 
        /// </summary>
        /// <param name="n1" name="n2">param>
        /// <returns>resultado de la raiz cubica al un numero</returns>
        internal double RaizCubica(double n1)
        {
            if (n1 == 0)
            {
                return 0;
            }
            return Math.Round(Math.Pow(n1, (POT)), 2);
        }

    }
}
