using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Condicional.Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             En una empresa los empleados deben trabajar como mínimo 6 horas diarias,
            si el empleado cumple esta condición se le pagan $400.00"
            mínimo 6 horas diarias= condición
            */
            //Entrada
            
            Console.WriteLine("Ingrese la cantidad de horas trabajadas en la semana:");
            byte horas_trabajadas=byte.Parse(Console.ReadLine());

            if (horas_trabajadas >= 6)
            {
                Console.WriteLine("El empleado cumplió con el mínimo de horas trabajadas, se le pagará $400.00");
            }
            else
            {
                Console.WriteLine("El empleado no cumplió con el mínimo de horas trabajadas, no se le pagará.");
            }
            Console.ReadKey();
        }
    }
}
