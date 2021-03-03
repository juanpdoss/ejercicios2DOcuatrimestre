using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        /*
         * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
           dos grupos de números, cuyas sumas son iguales.
           El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
           cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
           49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
           Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
           usuario ingrese por consola.
           Nota: Utilizar estructuras repetitivas y selectivas.

         * 
         * */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 5";
            int numeroIteraciones;
            int acumuladorNumerosAnteriores = 0;
            int acumuladorNumerosSiguientes = 0;
            do
            {
                Console.WriteLine("Ingrese un numero ... ");

            } while (!int.TryParse(Console.ReadLine(),out numeroIteraciones));

            if(numeroIteraciones < 2)
            {
                do
                {
                    Console.WriteLine("Error. El numero debe ser mayor a uno.");
                    int.TryParse(Console.ReadLine(), out numeroIteraciones);

                } while (numeroIteraciones < 2);
            }

            for (int i = 1; i <= numeroIteraciones; i++)
            {
                //Console.WriteLine("En esta iteracion la variable i vale " + i);

                for (int j=0 ; j < i ; j++)//empiezo en cero para tener el 1 en cuenta.             
                    acumuladorNumerosAnteriores += j;
                

                for (int k=i+1; k <= numeroIteraciones ; k++)
                {
                    acumuladorNumerosSiguientes += k;
                    if(acumuladorNumerosSiguientes == acumuladorNumerosAnteriores)
                    {
                      Console.WriteLine(i + " es un centro numerico!!");
                      
                    }

                }                 

                acumuladorNumerosSiguientes = 0;
                acumuladorNumerosAnteriores = 0;    //reseteo acumuladores
            }




            Console.ReadKey();
        }
    }
}
