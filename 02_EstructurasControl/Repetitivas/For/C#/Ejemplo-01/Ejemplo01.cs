using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario un número y genera su tabla de multiplicar hasta 10.
            Console.WriteLine("Ingrese un número para generar su tabla de multiplicar:");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
            Console.ReadKey();
        }
    }
}
