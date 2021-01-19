using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";

            int numerosPerfectosQueNecesito = 4;
            int contador = 1;
            int acumulador = 0;

            while (numerosPerfectosQueNecesito>0)
            {
                contador++;

                for (int i = 1; i < contador; i++)
                {
                    if (contador % i == 0) //si encuentro dvisores de la variable "contador", los acumulo.
                        acumulador += i;

                }

                if(acumulador == contador)
                {
                    Console.WriteLine("{0} es un numero perfecto.", contador);
                    numerosPerfectosQueNecesito--; //decremento la variable "numerosPerfectosQueNecesito".
                }

                acumulador = 0; //nuevamente, asigno cero al acumulador para prepararlo para la siguiente iteracion.

            }



            Console.ReadKey();
        }
    }
}
