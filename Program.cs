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
            string resp = "";

            do

            {
                Console.Clear();

                int numero1 = 0; //Aqui se almacenara el primer valor ingresado.

                int numero2 = 0; //Aqui se almacenara el segundo valor ingresado.

                int resultado = 0; //Aqui se almacenara el resultado de la operacion.



                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:\n");

                Console.WriteLine("+ para sumar\n");

                Console.WriteLine("- para restar\n");

                Console.WriteLine("* para multiplicar\n");

                Console.WriteLine("/ para dividir\n");

                Console.Write("\nEliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar

                resp = Console.ReadLine();

                string eleccion = Convert.ToString(resp);

                //Aqui se agregaran los mensajes para poder ingresar los datos.

                Console.WriteLine("\nIngrese sus dos numerosn");

                Console.Write("Numero 1: ");
                numero1 = int.Parse(Console.ReadLine());

                Console.Write("Numero 2: ");

                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (eleccion)
                {
                    case "+":

                        Console.WriteLine("El resultado de la suma es:");
                        resultado = numero1 + numero2;

                        Console.WriteLine("{0} + {1} = {2}", numero1, numero2, resultado);
                        break;

                    case "-":

                        Console.WriteLine("El resultado de la resta es:");

                        resultado = numero1 - numero2;

                        Console.WriteLine("{0} - {1} = {2}", numero1, numero2, resultado);

                        break;
                    case "*":

                        Console.WriteLine("El resultado de la multiplicacion es:");
                        resultado = numero1 * numero2;

                        Console.WriteLine("{0} * {1} = {2}", numero1, numero2, resultado);

                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es:");

                        resultado = numero1 / numero2;

                        Console.WriteLine("{0} / {1} = {2}", numero1, numero2, resultado);

                        break;

                }
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.

                resp = Console.ReadLine();

            }
            while (resp == "s" || resp == "s");

        }

    }
}


    
