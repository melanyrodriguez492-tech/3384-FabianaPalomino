using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elaborar un programa condicional simple que pregunte si esta lloviendo y depende a la respuesta recomiende llevar un paragaguas
            Console.WriteLine("Esta lloviendo si/no");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                Console.WriteLine("No olvides llevar paraguas");
            }
            Console.ReadKey();

        }
    }
}
