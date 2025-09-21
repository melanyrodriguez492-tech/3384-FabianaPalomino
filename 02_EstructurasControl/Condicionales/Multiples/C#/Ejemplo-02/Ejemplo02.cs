using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CONDICIONAL__MÚLTIPLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Dado un número que varíe en el rango de 1 a 12, mostrar el nombre del mes 
            al que representa e indicar el número de días de éste
            Variables = numero_mes, nombre_mes, dias_mes
             */
            //ENTRADA 
            Console.WriteLine("Ingrese un número del 1 al 12 para saber el mes y la cantidad de días que tiene:");
            byte numero_mes = byte.Parse(Console.ReadLine());
            string nombre_mes;
            byte dias_mes;

            //PROCESO

            switch(numero_mes)
            {
                case 1:
                    nombre_mes = "Enero";
                    dias_mes = 31;
                    break;
                case 2:
                    nombre_mes = "Febrero";
                    dias_mes = 28;
                    break;
                case 3:
                    nombre_mes = "Marzo";
                    dias_mes = 31;
                    break;
                case 4:
                    nombre_mes = "Abril";
                    dias_mes = 30;
                    break;
                case 5:
                    nombre_mes = "Mayo";
                    dias_mes = 31;
                    break;
                case 6:
                    nombre_mes = "Junio";
                    dias_mes = 30;
                    break;
                case 7:
                    nombre_mes = "Julio";
                    dias_mes = 31;
                    break;
                case 8:
                    nombre_mes = "Agosto";
                    dias_mes = 31;
                    break;
                case 9:
                    nombre_mes = "Septiembre";
                    dias_mes = 30;
                    break;
                case 10:
                    nombre_mes = "Octubre";
                    dias_mes = 31;
                    break;
                case 11:
                    nombre_mes = "Noviembre";
                    dias_mes = 30;
                    break;
                case 12:
                    nombre_mes = "Diciembre";
                    dias_mes = 31;
                    break;
                default:
                    nombre_mes = "Número de mes no válido.";
                    dias_mes = 0; //Asignar un valor por defecto
                    break;
            }
            //SALIDA
            if (dias_mes != 0)
            {
                Console.WriteLine("El mes es: " + nombre_mes + " y tiene " + dias_mes + " días.");
            }
            else
            {
                Console.WriteLine(nombre_mes);
            }
        }
    }
}
