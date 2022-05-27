using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Calculadora
{
    internal class Program
    {
        // Crea el archivo con la suma de los numeros
        static void crear(int n1, int n2, int res) {
         StreamWriter escribir = new StreamWriter(@"C:\\Calculadora\\Suma.txt", true);
            try
            {
                escribir.WriteLine(n1 + " + "+ n2 + "=" + res);
          
            }
            catch(Exception e)
            {
                Console.WriteLine(e + "PASO ALGO");
            }
            escribir.Close();
      }
    static void Main(string[] args)

        {
            string menu = "\nMenu Calculadora \n" +
               "1. Sumar\n" +
               "2. Restar\n" +
               "3. Multiplicar\n" +
               "4. Dividir\n" +
               "5. Potencia\n" +
               "6. RaizCuadrada\n" +
               "7. RaizCubica\n" +
               "8. Salir\n" +
               "Seleccione una opción: ";

            bool salir = false;
            Operaciones ope = new Operaciones();

            while (!salir)
            {
                Console.Clear();
                Console.Write(menu);
                int op = Int32.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Write("Numero 1: ");
                        int numero1 = int.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");

                        int numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        int res = ope.Sumar(numero1, numero2);
                        Console.WriteLine("{0}+{1}={2}", numero1, numero2, res);

                        crear(numero1, numero2, res);
                        break;
                    case 2:
                        Console.Write("Numero 1: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");

                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        res = ope.Restar(numero1, numero2);
                        Console.WriteLine("{0}-{1}={2}", numero1, numero2, res);
                        break;
                    case 3:
                        Console.Write("Numero 1: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");

                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        res = ope.Multiplicar(numero1, numero2);
                        Console.WriteLine("{0}*{1}={2}", numero1, numero2, res);
                        break;
                    case 4:
                        Console.Write("Numero 1: ");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");

                        numero2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        res = ope.Dividir(numero1, numero2);
                        Console.WriteLine("{0}/{1}={2}", numero1, numero2, res);
                        break;
                    case 5:

                        Console.Write("Numero 1: ");
                        double num1 = Double.Parse(Console.ReadLine());

                        Console.Write("Numero 2: ");

                        double num2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine();

                        double result = ope.Potencia(num1, num2);
                        Console.WriteLine("{0}/{1}={2}", num1, num2, result);
                        break;
                    case 6:
                        Console.Write("Numero 1: ");
                        num1 = Double.Parse(Console.ReadLine());

                        result = ope.RaizCuadrada(num1);
                        Console.WriteLine("{0} = {1}", num1, result);
                        break;

                    case 7:
                        Console.Write("Numero 1: ");
                        num1 = Double.Parse(Console.ReadLine());

                        result = ope.RaizCubica(num1);
                        Console.WriteLine("{0} = {1}", num1, result);
                        break;

                    case 8:
                        Console.WriteLine("Salir");
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción Inválida");
                        break;
                }

                Console.ReadKey();
            }
        }


    }

}







