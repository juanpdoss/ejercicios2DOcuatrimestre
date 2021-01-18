using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";

            int numeroDelUsuario;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
         

            } while (!int.TryParse(Console.ReadLine(), out numeroDelUsuario)); //itera hasta que el metodo TryParse retorne true

            //muestro el cuadrado del numero.
            Console.WriteLine("El cuadrado del numero ingresado es {0}.", Math.Pow(numeroDelUsuario, 2));

            //muestro el cubo del numero ingresado concatenando.
            Console.WriteLine("El cubo del numero ingresado es " + Math.Pow(numeroDelUsuario,3));




            Console.ReadKey();        
        
        }
    }
}
