using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJEMPLO_02_SECUENCIAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un algoritmo que permita visualizar en porcentaje la cantidad de alumnos de Ing. De Sistemas,
            //Administración de Empresas y Contabilidad
            //Total = sis + adm + cont
            //porSis = (sis / Total) * 100
            //porAdm = (adm / Total) * 100
            //porCont = (cont / Total) * 100

            Console.WriteLine("Ingrese la cantidad de alumnos de Ing. De Sistemas:");
            int sis = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de alumnos de Administración de Empresas:");
            int adm = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de alumnos de Contabilidad:");
            int cont = int.Parse(Console.ReadLine());
            int total = sis + adm + cont;
            double porSis = (double)sis / total * 100;
            double porAdm = (double)adm / total * 100;
            double porCont = (double)cont / total * 100;
            Console.WriteLine("El porcentaje de alumnos de Ing. De Sistemas es: " + porSis + "%");
            Console.WriteLine("El porcentaje de alumnos de Administración de Empresas es: " + porAdm + "%");
            Console.WriteLine("El porcentaje de alumnos de Contabilidad es: " + porCont + "%");
            Console.ReadKey();
        }
    }
}
