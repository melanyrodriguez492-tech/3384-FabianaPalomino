using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recorre la cadena de atrás hacia adelante para invertirla.
            Console.WriteLine("Ingrese una cadena de texto para invertirla:");
            string cadena = Console.ReadLine();
            string cadena_invertida = "";
            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadena_invertida += cadena[i];
            }
            Console.WriteLine("La cadena invertida es: " + cadena_invertida);
            Console.ReadKey();

        }
    }
}
