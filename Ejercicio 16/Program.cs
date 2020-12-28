using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double IVA = 21;
            Console.WriteLine("Por favor, introduzca el precio del producto: ");

            precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El producto final con IVA es {0}", precio*IVA/100+precio);

        }
    }
}
