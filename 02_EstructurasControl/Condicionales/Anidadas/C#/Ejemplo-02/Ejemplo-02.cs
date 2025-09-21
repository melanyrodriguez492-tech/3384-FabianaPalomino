using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Condicional_anidada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             En un supermercado, se realizan descuentos por las compras a partir de unas bolitas de colores:
            Verde 20%, amarilla 25%, negra del 30%; la blanca no aplica ningún descuento.
            Leer el importe de la compra y el color de la bolita e imprimir lo que debe pagar dicho cliente.
             */

            //Entrada de datos
            double monto_compra, monto_pagar;
            byte color_bolita;
            Console.WriteLine("Ingrese el monto total de la compra:");
            monto_compra = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el color de la bolita (1-Verde, 2-Amarilla, 3-Negra, 4-Blanca):");
            color_bolita = byte.Parse(Console.ReadLine());
            //Proceso
            if (color_bolita == 1) //Bolita verde
            {
                monto_pagar = monto_compra - (monto_compra * 0.20);
                Console.WriteLine("El monto a pagar con el descuento de la bolita verde es: $" + monto_pagar);
            }
            else
            {
                if (color_bolita == 2) //Bolita amarilla
                {
                    monto_pagar = monto_compra - (monto_compra * 0.25);
                    Console.WriteLine("El monto a pagar con el descuento de la bolita amarilla es: $" + monto_pagar);
                }
                else
                {
                    if (color_bolita == 3) //Bolita negra
                    {
                        monto_pagar = monto_compra - (monto_compra * 0.30);
                        Console.WriteLine("El monto a pagar con el descuento de la bolita negra es: $" + monto_pagar);
                    }
                    else
                    {
                        if (color_bolita == 4) //Bolita blanca
                        {
                            monto_pagar = monto_compra;
                            Console.WriteLine("El monto a pagar sin descuento de la bolita blanca es: $" + monto_pagar);
                        }
                        else
                        {
                            Console.WriteLine("Color de bolita no válido.");
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}

