using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer numero: ");
            double PrimerNumero = double.Parse(Console.ReadLine());

            Console.Write("\nIngrese segundo numero: ");
            double SegundoNumero = double.Parse(Console.ReadLine());

            Console.Write("\nIngrese operacion + - * /: ");
            string Ope = Console.ReadLine();

            while (Ope != "+" && Ope != "-" && Ope != "*" && Ope != "/")
            {
                Console.Write("\nError. Reingrese: ");
                Ope = Console.ReadLine();
            }

            Calculadora.Calcular(PrimerNumero, SegundoNumero, Ope);

            Console.ReadKey();
        }
    }
}
