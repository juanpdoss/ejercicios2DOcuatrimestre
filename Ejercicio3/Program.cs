using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";

            int cantidadIteraciones;
            int contadorDivisores = 0;

            do
            {
                Console.WriteLine("Ingrese un numero.");
                Console.WriteLine("a continuacion, vera los numeros primos existentes entre el 1 y el numero ingresado.");

            } while (!int.TryParse(Console.ReadLine(),out cantidadIteraciones));


            for (int i = 1; i <=cantidadIteraciones; i++) //utilizo un for ya que se de antemano cuantas veces tengo que iterar.
            {
                for (int j = 1; j <= i; j++) //el for anidado divide a la variable I por cada numero que haya desde el 1 hasta el.
                {
                    if (i % j == 0)
                        contadorDivisores++;
                }


                if (contadorDivisores == 2) //si un numero solo tiene 2 divisores, es primo. 
                    Console.WriteLine("{0} es primo.", i);

                contadorDivisores = 0; //reinicio el contador.


            }
           





            Console.ReadKey();
        }
    }
}
