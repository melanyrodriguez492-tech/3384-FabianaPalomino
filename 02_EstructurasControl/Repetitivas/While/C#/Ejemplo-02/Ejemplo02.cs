using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Procesamiento de un cajero automático: Mantiene un bucle que permite al
            //usuario realizar múltiples transacciones hasta que decida salir.
            bool continuar = true;
            Console.WriteLine("Bienvenido al cajero automático.");
            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Depositar dinero");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Su saldo es de $1000.");
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad a retirar:");
                        string retiro = Console.ReadLine();
                        Console.WriteLine($"Ha retirado ${retiro}.");
                        break;
                    case "3":
                        Console.WriteLine("Ingrese la cantidad a depositar:");
                        string deposito = Console.ReadLine();
                        Console.WriteLine($"Ha depositado ${deposito}.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("¿Desea realizar otra transacción? (s/n)");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() != "s")
                {
                    continuar = false;
                    Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta luego!");
                }

                Console.ReadKey();

            }
        }
    }
}
