using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    /*
     * Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
    multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
    operación que desea realizar (pulsando el caracter +, -, * ó /).
    El usuario decidirá cuándo finalizar el programa.
    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
    a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
    operación matemática. El método devolverá el resultado de la operación.
    b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
    utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
    TRUE si el número es distinto de CERO.*/

    public class Calculadora
    {
        /// <summary>
        /// Calcula el valor de la operacion requerida por el parametro "operando" y lo retorna.
        /// </summary>
        /// <param name="primerNumero"></param>
        /// <param name="segundoNumero"></param>
        /// <param name="operando"></param>
        /// <returns></returns>
        public static float Calcular(int primerNumero, int segundoNumero, char operando)
        {
            float resultado = 0;

            switch (operando)
            {
                case '/':
                        
                      if(Calculadora.Validar(segundoNumero)) //El casteo es necesario para que la parte decimal no se pierda
                        resultado =(float)primerNumero / segundoNumero;                     

                    break;

                case '*':
                    resultado = primerNumero * segundoNumero;
                    break;

                case '-':
                    resultado = primerNumero - segundoNumero;
                    break;

                default:  //por default, sumo.
                    resultado = primerNumero + segundoNumero;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Retorna true cuando el numero recibido como parametro es distinto de cero, false caso contrario.
        /// </summary>
        /// <param name="segundoNumero"></param>
        /// <returns></returns>
        private static bool Validar(int segundoNumero)
        {
            bool paramEsDistintoDeCero = false;

            if (segundoNumero != 0)
                paramEsDistintoDeCero = true;

            return paramEsDistintoDeCero;
        }

    }
}
