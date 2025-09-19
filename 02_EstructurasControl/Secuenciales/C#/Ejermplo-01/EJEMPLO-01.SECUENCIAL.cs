using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_SECUENCIAL_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un algoritmo que permita convertir de grados Celsius a grados Fahrenheit, se indicar la cantidad de grados en Celsius
            Console.WriteLine("Ingrese la cantidad de grados en Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("La cantidad de grados en Fahrenheit es: " + fahrenheit);
            Console.ReadKey();
        }
    }
}
