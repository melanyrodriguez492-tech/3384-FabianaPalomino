using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Juego de adivinanza simple: 
            El bucle se repite hasta que el usuario adivina el número secreto,
            garantizando al menos un intento.
             */
            int numeroSecreto = 7; // Número que el usuario debe adivinar
            int intento;
            do
            {
                Console.WriteLine("Adivina el número secreto (entre 1 y 10):");
                intento = Convert.ToInt32(Console.ReadLine());
                if (intento != numeroSecreto)
                {
                    Console.WriteLine("Número incorrecto. Inténtalo de nuevo.");
                }
            } while (intento != numeroSecreto);
            Console.WriteLine("¡Felicidades! Has adivinado el número secreto.");
            Console.ReadKey();

        }
    }
}
