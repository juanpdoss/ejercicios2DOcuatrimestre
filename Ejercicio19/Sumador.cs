using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    /// <summary>
    /// Clase publica sumador.
    /// </summary>
    public class Sumador
    {
        #region atributos

        private int cantidadDeSumas;

        #endregion

        #region constructores

        /// <summary>
        /// Establece el atributo "cantidadDeSumas" con el int recibido como parametro.
        /// </summary>
        /// <param name="cantidadSumas"></param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadDeSumas = cantidadSumas;
        }
        /// <summary>
        /// Establece el atributo "cantidadDeSumas" reutilizando el constructor que recibe parametros.
        /// </summary>
        public Sumador():this(0)
        {

        }




        #endregion

        #region metodos

        /// <summary>
        /// Suma ambos numeros recibidos como paramtros
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Retorna el valor de la suma realizada.-</returns>
        public long Sumar(long a,long b)
        {
            this.cantidadDeSumas++; //incremento cantidad de sumas

            return a + b; //retorno el resultado de la suma.
        }

        /// <summary>
        /// Sobrecarga del metodo "Sumar", en vez de recibir numeros, esta sobrecarga recibe dos strings como parametros.
        /// retorna una nueva cadena que contiene ambos strings recibidos como parametros concatenados.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a,string b)
        {
            this.cantidadDeSumas++;
            return a + b;

        }

        /// <summary>
        /// Conversion explicita que retorna el atributo cantidadDeSumas cuando a un objeto Sumador se lo castea a int
        /// Sumador aux=new Sumador();
        /// Ejemplo = Console.writeLine((int)aux);
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadDeSumas;
        }

        /// <summary>
        /// Sobrecarga que recibe dos objetos de tipo Sumador como parametros.
        /// Retorna el resultado de la suma de los atributos "cantidadDeSumas" de ambos.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long operator +(Sumador a,Sumador b)
        {
            return a.cantidadDeSumas + b.cantidadDeSumas;
        }

        /// <summary>
        /// Retorna true si ambos objetos Sumador tienen los mismos valores en el atributo "cantidadDeSumas".
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator |(Sumador a,Sumador b)
        {
            if (a.cantidadDeSumas == b.cantidadDeSumas)
                return true;
            else
                return false;
        }



        #endregion
    }
}
