using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_Doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Programa condiconal doble para evaluar si una persona tiene licencia de conducir y depende a eso decirle si puede o no manejar
            Console.WriteLine("¿Tienes licencia de conducir? (si/no):");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                Console.WriteLine("Puedes manejar.");
            }
            else
            {
                Console.WriteLine("No puedes manejar.");
            }
            Console.ReadKey();
        }
    }
}
