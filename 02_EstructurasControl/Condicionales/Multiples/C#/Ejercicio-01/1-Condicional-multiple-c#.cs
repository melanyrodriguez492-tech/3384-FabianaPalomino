using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3384_FABIANAPALOMINO_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //# Ejemplo: Clasificar un número según su valor
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }
            Console.ReadKey();
        }
    }
}
