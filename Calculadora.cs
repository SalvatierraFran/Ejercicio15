using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio15
{
    class Calculadora
    {
        public static void Calcular(double numUno, double numDos, string operacion)
        {
            double resultado;

            if (operacion == "+")
            {
                resultado = numUno + numDos;
                mostrar(resultado);
            }
            else if (operacion == "-")
            {
                resultado = numUno - numDos;
                mostrar(resultado);
            }
            else if (operacion == "*")
            {
                resultado = numUno * numDos;
                mostrar(resultado);
            }
            else
            {
                if(Validar(numDos)==true)
                {
                    resultado = numUno / numDos;
                    mostrar(resultado);
                }
            }
        }

        private static bool Validar(double SegundoNumero)
        {
            bool rdo = false;
            
            if (SegundoNumero != 0)
            {
                rdo = true;
            }

            return rdo;
        }

        public static void mostrar(double Final)
        {
            Console.Write("\nEl resultado es: " + Final);
        }
    }
}
