using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prgograma condional anidado  para pedir la edad de una persona y verificar si es un adulto , adulto mayor o menor de edad
            
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad.");
            }
            else
            {
                if (edad >= 18 && edad < 65)
                {
                    Console.WriteLine("Eres un adulto.");
                }
                else
                {
                    Console.WriteLine("Eres un adulto mayor.");
                }
            }
            Console.ReadKey();
        }
    }
}
