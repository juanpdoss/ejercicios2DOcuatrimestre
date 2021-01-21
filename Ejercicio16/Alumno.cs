using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        public string apellido; 
        public int legajo;
        public string nombre;

        /// <summary>
        /// Costructor, solo inicializa los atributos publicos.
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;

        }

        public void CalcularFinal()
        {
            Random notaRandom = new Random();
            this.notaFinal = -1;

            if (this.nota1 > 3 && this.nota2 > 3)
                this.notaFinal = notaRandom.Next(6, 10);

        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre del alumno: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Legajo numero: " + this.legajo);
            sb.AppendLine("Primer nota: " + this.nota1);
            sb.AppendLine("Segunda nota: " + this.nota2);

            if (notaFinal != -1)
                sb.AppendLine("Nota final: " + this.notaFinal);
            else
                sb.AppendLine("Alumno desaprobado :(.");


            return sb.ToString();
        }


    }
}
