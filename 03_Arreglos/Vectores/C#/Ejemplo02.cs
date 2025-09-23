using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Gestión de tareas pendientes: 
            Un programa que permite al usuario agregar hasta 5 tareas a un vector y luego las lista
             */
            string[] tareas = new string[5];
            for (int i = 0; i < tareas.Length; i++)
            {
                Console.WriteLine($"Ingrese la tarea {i + 1} (o deje en blanco para terminar):");
                string entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    break; // Salir del bucle si la entrada está vacía
                }
                tareas[i] = entrada;
            }
            Console.WriteLine("Tareas pendientes:");
            foreach (string tarea in tareas)
            {
                if (!string.IsNullOrWhiteSpace(tarea))
                {
                    Console.WriteLine($"- {tarea}");
                }
            }
            Console.ReadKey();
        }
    }
}
