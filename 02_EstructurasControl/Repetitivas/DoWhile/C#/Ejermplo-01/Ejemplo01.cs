using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Validación de entrada de usuario: Este ejemplo pide al usuario que ingrese un número 
            y continúa pidiéndolo hasta que se ingrese un valor positivo
             */
            int numero;

            do
            {
                Console.WriteLine("Por favor, ingrese un número positivo:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Entrada no válida. El número debe ser positivo.");
                }
            } while (numero <= 0);
            Console.WriteLine($"Gracias! Ha ingresado el número positivo: {numero}");
            
            Console.ReadKey();
        }
    }
}
