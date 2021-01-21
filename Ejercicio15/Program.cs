using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sigue = true;
            int primerNumero, segundoNumero;
            char operando;
            char aceptaContinuar;

            do
            {

                 Console.WriteLine("Calculadora\n\n\n");
                Console.WriteLine("A continuacion, debera ingresar dos numeros" +
                                    " y un operando..");
                Console.ReadKey();
                Console.WriteLine("En caso de que los numeros sean invalidos, se utilizara el cero por defecto.");
                Console.ReadKey(); 

                Console.Write("Primer numero:");
                int.TryParse(Console.ReadLine(), out primerNumero); //los metodos TryParse siempre asignan un valor por defecto 
                                                                    //si la operacion no se completa con exito
                                                                    //en este caso al tratarse de un int, asigna 0 a la variable primerNumero
                Console.Write("Segundo numero:");
                int.TryParse(Console.ReadLine(), out segundoNumero);

                Console.WriteLine("Ingrese el operando (/ - + *)");

                char.TryParse(Console.ReadLine(), out operando);

                Console.WriteLine("El resultado de la operacion es " + Calculadora.Calcular(primerNumero, segundoNumero, operando));



                Console.WriteLine("Continuar? s/n");
                char.TryParse(Console.ReadLine(), out aceptaContinuar);

                if (!(aceptaContinuar == 's' || aceptaContinuar == 'S'))
                    sigue = false;

                Console.Clear();
            } while (sigue);
        }
    }
}
