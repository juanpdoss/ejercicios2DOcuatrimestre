using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador aux1 = new Sumador();
            Sumador aux2 = new Sumador();            

            Console.WriteLine(aux1.Sumar(12, 34));
            Console.WriteLine(aux1.Sumar("conca", "teno"));
            Console.WriteLine((int)aux1);
            Console.WriteLine(aux1 + aux2);

            //Muestra false por consola, ya que no tienen la misma cantidad de sumas.
            Console.WriteLine(aux2 | aux1);

            

        }
    }
}
