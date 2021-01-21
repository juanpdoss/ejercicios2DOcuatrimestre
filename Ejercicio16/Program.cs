using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno primerAlumno = new Alumno("uzumaki", 3434, "naruto");
            Alumno segundoAlumno = new Alumno("uchiha", 3465, "sasuke");
            Alumno tercerAlumno = new Alumno("uchiha", 3111, "shisui");

            primerAlumno.Estudiar(6, 5);
            segundoAlumno.Estudiar(2, 2); //deberia mostrar alumno desaprobado por consola.
            tercerAlumno.Estudiar(4, 4);

            primerAlumno.CalcularFinal();
            segundoAlumno.CalcularFinal();
            tercerAlumno.CalcularFinal();

            Console.WriteLine(primerAlumno.Mostrar());
            Console.WriteLine(segundoAlumno.Mostrar());
            Console.WriteLine(tercerAlumno.Mostrar());

            Console.ReadKey();

        }
    }
}
