using System;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Indique el numero de ventas: ");
            int ventas1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ventas1; i++)
            {
                Console.WriteLine("Introduzca el numero de ventas: ");
                int ventas2 = Convert.ToInt32(Console.ReadLine());
                suma = suma + ventas2;
            }
            Console.WriteLine("El numero de ventas total ha sido: {0}",suma);
        }
    }
}
