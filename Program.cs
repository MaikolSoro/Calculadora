using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {

        static void Main(string[] args)

        {
            string menu = "\nMenu Calculadora \n" +
               "1. Sumar\n" +
               "2. Restar\n" +
               "3. Multiplicar\n" +
               "4. Dividir\n" +
               "5. Salir\n" +
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




    
