using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Inventario de almacén por pasillo y estante: 
            Un programa que usa una matriz para representar la
            cantidad de productos en un almacén, organizados por pasillo (filas) y
            estante (columnas).
             */
            int[,] inventario = new int[3, 4]
                {
                { 10, 5, 8, 12 },
                { 7, 14, 6, 9 },
                { 20, 15, 10, 5 }
                    };
            Console.WriteLine("Inventario del almacén (Pasillos x Estantes):");
            for (int i = 0; i < inventario.GetLength(0); i++)
            {
                for (int j = 0; j < inventario.GetLength(1); j++)
                {
                    Console.Write(inventario[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
