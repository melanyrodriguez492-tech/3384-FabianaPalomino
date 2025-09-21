using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Condicional_doble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se desea escribir un algoritmo que pida la temperatura actual en grados Celsius. 
             * El programa debe verificar si la temperatura es mayor a 25 °C.
Si la condición se cumple, el algoritmo debe enviar el mensaje: "¡Es un día de helado! 🍦".
Si la condición no se cumple, debe enviar el mensaje: "Mejor prepara un café caliente. ☕*/

            Console.WriteLine("Ingrese la temperatura actual en grados Celsius:");
            int temperatura = int.Parse(Console.ReadLine());

            if (temperatura > 25)
            {
                Console.WriteLine("¡Es un día de helado! ");
            }
            else
            {
                Console.WriteLine("Mejor prepara un café caliente.");
            }
            Console.ReadKey();

        }
    }
}
