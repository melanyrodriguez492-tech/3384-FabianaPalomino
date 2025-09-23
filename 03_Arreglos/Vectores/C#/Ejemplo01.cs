using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Registro de ventas diarias: Un programa que usa un vector para registrar 
            las ventas de 7 días y luego calcula el total y el promedio.
             */
            double[] ventasDiarias = new double[7];
            double totalVentas = 0;
            for (int i = 0; i < ventasDiarias.Length; i++)
            {
                Console.WriteLine($"Ingrese las ventas del día {i + 1}:");
                ventasDiarias[i] = Convert.ToDouble(Console.ReadLine());
                totalVentas += ventasDiarias[i];
            }
            double promedioVentas = totalVentas / ventasDiarias.Length;
            Console.WriteLine($"Total de ventas de la semana: ${totalVentas}");
            Console.WriteLine($"Promedio diario de ventas: ${promedioVentas}");
            Console.ReadKey();
        }
    }
}
