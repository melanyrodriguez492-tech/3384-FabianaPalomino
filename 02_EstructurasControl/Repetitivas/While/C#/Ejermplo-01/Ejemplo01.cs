using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.While_tarearepositorio3384
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simula la descarga de un archivo, mostrando el progreso hasta que se complete.
            int progreso = 0;
            Console.WriteLine("Descargando archivo...");
            while (progreso < 100)
            {
                progreso += 10; // Incrementa el progreso en 10%
                if (progreso > 100) progreso = 100; // Asegura que no exceda 100%
                Console.WriteLine($"Progreso: {progreso}%");
                System.Threading.Thread.Sleep(500); // Simula tiempo de descarga
            }
            Console.Write("Descarga completa.");
            Console.ReadLine();
        }
    }
}
