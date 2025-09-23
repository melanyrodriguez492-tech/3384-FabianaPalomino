using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Tablero de juego (ej. Tres en Raya): Un programa que simula el 
            tablero de un juego simple como el Tres en Raya, permitiendo mostrar el estado 
            actual del tablero.
             */
            char[,] tablero = new char[3, 3]
                {
                { 'X', 'O', 'X' },
                { ' ', 'X', ' ' },
                { 'O', ' ', 'O' }
            };
            Console.WriteLine("Estado actual del tablero de Tres en Raya:");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < tablero.GetLength(1) - 1)
                        Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < tablero.GetLength(0) - 1)
                    Console.WriteLine("---------");
            }
            Console.ReadKey();

        }
    }
}
